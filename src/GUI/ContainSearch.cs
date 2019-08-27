using Draw.src.SearchAlgorithms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw.src.GUI
{
    
    public partial class ContainSearch : Form
    {
        SearchInGraph ParentForm;
        public ContainSearch(SearchInGraph myForm)
        {
            this.ParentForm = myForm;
            InitializeComponent();

            comboBox1.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            comboBox2.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchInGraph.startSearch(new BreadthFirstSearchWithContainSearch(MainForm.MyGraph, comboBox1.Text, comboBox2.Text), ParentForm.comboBox2.Text, ParentForm.comboBox3.Text);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
