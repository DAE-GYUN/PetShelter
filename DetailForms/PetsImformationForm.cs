using DevExpress.XtraGrid.Views.Tile;
using PetShelter.Data;
using PetShelter.Data.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            TileView view = e.Item.View;

            Pet pet = view.GetFocusedRow() as Pet;
            // as :  캐스팅 하는건데 대신에 얘가 값이 안맞으면 null을 반환해줘 맞으면 캐스팅 해줘 대신에 값타입은 안돼용
            if (pet == null)
                return;

            pictureEdit1.Image = pet.Picture;
            
            
        }
        
    }
}
