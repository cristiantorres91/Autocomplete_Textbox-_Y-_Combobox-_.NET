using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autocomplete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargar los datos para el autocomplete del textbox
            textBox1.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cargo los datos que tendra el combobox
            comboBox1.DataSource = AutoCompleClass.Datos();
            comboBox1.DisplayMember = "pais";
            comboBox1.ValueMember = "id";

            // cargo la lista de items para el autocomplete dle combobox
            comboBox1.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
