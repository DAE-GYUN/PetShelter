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
using DevExpress.XtraEditors;
using PetShelter.Data;
using PetShelter.Data.Dao;

namespace Petshelter.Admin
{
    public partial class AddPetForm : DevExpress.XtraEditors.XtraForm
    {
        public AddPetForm()
        {
            InitializeComponent();
        }

        public AddPetForm(string family) : this()
        {
            _family = family;
        }

        public string _family { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            txeFamily.Text = _family;
        }

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
            Pet pet = new Pet()
            {
                Picture = dstPicture,
                Name = txeName.Text,
                Age = int.Parse(txeAge.Text),
                Familly = txeFamily.Text,
                Gender = cbbeGender.Text,
                HasVaccinated = checkVaccinated.Checked,
                HasAnimalRegistrated = checkAnimalRegistrated.Checked,
                HasNeutralized = checkNeutralized.Checked,
                Species = txeSpecies.Text,
                ETC = txeEtc.Text,
                Weight = int.Parse(txeWeight.Text)
            };

            Dao.Pet.Insert(pet);
        }

        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}