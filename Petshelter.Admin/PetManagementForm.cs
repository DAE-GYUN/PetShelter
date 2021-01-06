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
    }
}
