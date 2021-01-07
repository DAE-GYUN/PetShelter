using DevExpress.XtraEditors;
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
        
        private void tileView2_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            TileView view = e.Item.View;

            Pet pet = view.GetFocusedRow() as Pet;

            if (pet == null)
                return;

            MessageBox.Show(pet.PetID.ToString());

            int petId = pet.PetID;

            ChangingPetInformationForm changingPetInformationForm = new ChangingPetInformationForm(petId);
            changingPetInformationForm.Show();
            

            //List<Pet> pets = Dao.Pet.GetAll();
            
            //foreach (var pet in pets)
            //{
            //    if (tileView2.Columns[2].Name == pet.PetID.ToString());
            //    MessageBox.Show(pet.PetID.ToString());
            //}
            //MessageBox.Show(tileView2.Columns[7].FieldName);
        }

    

        #region tileViewClicked event things for C# 3.0
        public event EventHandler<tileViewClickedEventArgs> tileViewClicked;

        protected virtual void OntileViewClicked(tileViewClickedEventArgs e)
        {
            if (tileViewClicked != null)
                tileViewClicked(this, e);
        }

        private tileViewClickedEventArgs OntileViewClicked(Pet pet)
        {
            tileViewClickedEventArgs args = new tileViewClickedEventArgs(pet);
            OntileViewClicked(args);

            return args;
        }

        private tileViewClickedEventArgs OntileViewClickedForOut()
        {
            tileViewClickedEventArgs args = new tileViewClickedEventArgs();
            OntileViewClicked(args);

            return args;
        }

        public class tileViewClickedEventArgs : EventArgs
        {
            public Pet Pet { get; set; }

            public tileViewClickedEventArgs()
            {
            }

            public tileViewClickedEventArgs(Pet pet)
            {
                Pet = pet;
            }
        }
        #endregion


        //private void tileView2_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        //{
        //    List<Pet> pets = Dao.Pet.GetAll();

        //    //foreach (var pet in pets)
        //    //{
        //    //    if(tileView2.Columns[3].Name)
        //    //    {
        //    //        MessageBox.Show(pet.Name);
        //    //    }
        //    ////}
        //    ///

        //    MessageBox.Show(e.Item.Text4);


        //}
    }
}
