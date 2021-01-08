using DevExpress.XtraGrid.Views.Tile;
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

namespace PetShelter
{
    public partial class PetsImformationForm : Form
    {
        public PetsImformationForm()
        {
            InitializeComponent();
        }

        public PetsImformationForm(string family) : this()
        {
            _family = family;

            gcPetInformation.Text = $"{_family} Information";
        }

        public string _family { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            //if(_family == "Dog")
            //    petBindingSource.DataSource = Dao.Pet.GetPetList("Dog");

            //else if(_family == "Cat")
            //    petBindingSource.DataSource = Dao.Pet.GetPetList("Cat");

            //else if(_family == "Etc")
            //    petBindingSource.DataSource = Dao.Pet.GetPetList("Etc");

            petBindingSource.DataSource = Dao.Pet.GetPetList(_family);
        }

        private void tileView1_ItemDoubleClick(object sender, TileViewItemClickEventArgs e)
        {
            //  tileview에 있는 데이터를 가져온다.
            TileView view = e.Item.View;
            Pet pet = view.GetFocusedRow() as Pet;
            // as :  캐스팅 하는건데 대신에 얘가 값이 안맞으면 null을 반환해줘 맞으면 캐스팅 해줘 대신에 값타입은 안돼용
            if (pet == null)
                return;


            // 클릭히먄 옆에 디테일에 데이터 이동
            pictureEdit1.Image = ByteArrayToImage(pet.Picture);
            txeName.Text = pet.Name;
            txeSpecies.Text = pet.Species;
            txeAge.Text = pet.Age.ToString();
            cbbeGender.Text = pet.Gender;
            txbSize.Text = pet.Size;
            txbWeight.Text = pet.Weight.ToString();
            txbEtc.Text = pet.ETC;

            if (pet.HasNeutralized == true)
                cbHasNeutralized.CheckState = CheckState.Checked;
            else
                cbHasNeutralized.CheckState = CheckState.Unchecked;


            if (pet.HasVaccinated == true)
                cbHasVaccinated.CheckState = CheckState.Checked;
            else
                cbHasVaccinated.CheckState = CheckState.Unchecked;


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
