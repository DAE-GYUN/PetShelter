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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
       
        }

        private void ShowChild(Form form)
        {
            form.MdiParent = this;
            form.Show();
            //var childform = MdiChildren.FirstOrDefault(x => x.GetType() == form.GetType());

            //if (childform == null)
            //{
            //    form.MdiParent = this;
            //    form.Show();
            //}
            //else
            //{
            //    childform.Focus();
            //}
        }

        private void acDogList_Click(object sender, EventArgs e)
        {
            ShowChild(new PetsImformationForm("Dog"));
        }

        private void acCatList_Click(object sender, EventArgs e)
        {
            ShowChild(new PetsImformationForm("Cat"));
        }

        private void acEtcList_Click(object sender, EventArgs e)
        {
            ShowChild(new PetsImformationForm("Etc"));
        }
    }
}
