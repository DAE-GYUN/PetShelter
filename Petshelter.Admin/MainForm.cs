using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Petshelter.Admin
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChild(Form form)
        {
            var childform = MdiChildren.FirstOrDefault(x => x.Text == form.Text);

            if (childform == null)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                childform.Focus();
            }
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            AddPetForm addPetForm = new AddPetForm("Dog");
            addPetForm.Text = "Add Dog";
            ShowChild(addPetForm);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            AddPetForm addPetForm = new AddPetForm("Cat");
            addPetForm.Text = "Add Cat";
            ShowChild(addPetForm);
        }

        private void btnEtc_Click(object sender, EventArgs e)
        {
            AddPetForm addPetForm = new AddPetForm("Etc");
            addPetForm.Text = "Add Etc";
            ShowChild(addPetForm);
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            PetManagementForm petManagementForm = new PetManagementForm();
            petManagementForm.Text = "Pet";
            ShowChild(petManagementForm);
        }
    }
}
