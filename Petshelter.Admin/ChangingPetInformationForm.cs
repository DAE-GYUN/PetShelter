using PetShelter.Data;
using PetShelter.Data.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshelter.Admin
{
    public partial class ChangingPetInformationForm : Form
    {
        public ChangingPetInformationForm()
        {
            InitializeComponent();
        }
        public ChangingPetInformationForm(int petID)
        {
            _petId = petID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            Pet pet = Dao.Pet.GetByPK(_petId);

            pictureEdit1.Image = ByteArrayToImage(pet.Picture);
            txeName.Text = pet.Name;
            txeAge.Text = pet.Age.ToString();
            txeFamily.Text = pet.Familly;
            cbbeGender.Text = pet.Gender;
            if(pet.HasVaccinated==true)
            {
                checkVaccinated.CheckState = CheckState.Checked;
            }
            if(pet.HasNeutralized==true)
            {
                checkNeutralized.CheckState = CheckState.Checked;
            }
            txeSpecies.Text = pet.Species;
            txeEtc.Text = pet.ETC;
            txeWeight.Text = pet.Weight.ToString();
            cbbeSize.Text = pet.Size;
        }

        public int _petId { get; set; }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
            openFileDialog1.Title = "이미지 열기";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pictureEdit1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("등록을 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            byte[] dstPicture = imageToByteArray(pictureEdit1.Image);
         
          

            if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Dao.Pet.Insert(pet);
                Close();
            }

        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image recImg = Image.FromStream(ms);
            return recImg;
        }
    }
}
