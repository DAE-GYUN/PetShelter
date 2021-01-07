using PetShelter.DetailForms;
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

        private void acDogList_Click(object sender, EventArgs e)
        {
            PetsImformationForm dogsForm = new PetsImformationForm("Dog");
            dogsForm.Text = "DogsForm";
            ShowChild(dogsForm);
        }

        private void acCatList_Click(object sender, EventArgs e)
        {
            PetsImformationForm catsForm = new PetsImformationForm("Cat");
            catsForm.Text = "고양이";
            ShowChild(catsForm);
        }

        private void acEtcList_Click(object sender, EventArgs e)
        {
            PetsImformationForm etcForm = new PetsImformationForm("Etc");
            etcForm.Text = "기타종";
            ShowChild(etcForm);
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            AdoptionProgressGuideForm guideForm = new AdoptionProgressGuideForm();
            guideForm.Text = "입양 절차 안내";
            ShowChild(guideForm);
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            DissoultionOfAdoptionRequestForm dissoultionOfAdoptionRequest = new DissoultionOfAdoptionRequestForm();

            dissoultionOfAdoptionRequest.Text = "파양 신청서 작성";
            ShowChild(dissoultionOfAdoptionRequest);
        }
    }
}
