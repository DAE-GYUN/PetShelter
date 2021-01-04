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
        }

        public string _family { get; set; }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            if(_family == "Dog")
            {
                petBindingSource.DataSource = Dao.Pet.GetPetList("Dog");
            }
            else if(_family == "Cat")
            {
                petBindingSource.DataSource = Dao.Pet.GetPetList("Cat");
            }
            else if(_family == "Etc")
                petBindingSource.DataSource = Dao.Pet.GetPetList("Etc");


        }

    }
}
