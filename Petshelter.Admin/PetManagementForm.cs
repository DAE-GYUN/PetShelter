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


namespace Petshelter.Admin
{
    public partial class PetManagementForm : Form
    {
        public PetManagementForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
            bdsPet.DataSource = Dao.Pet.GetAll();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tileView2_ItemDoubleClick(object sender, TileViewItemClickEventArgs e)
        {
            TileView view = e.Item.View;

            Pet pet = view.GetFocusedRow() as Pet;

            if (pet == null)
                return;

            MessageBox.Show(pet.PetID.ToString());

            int petId = pet.PetID;

            ChangingPetInformationForm changingPetInformationForm = new ChangingPetInformationForm(petId);
            changingPetInformationForm.Show();
        }
    }
}
