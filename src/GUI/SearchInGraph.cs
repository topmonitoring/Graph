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
    public partial class SearchInGraph : Form
    {
        public SearchInGraph()
        {
            InitializeComponent();
            comboBox2.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";

            comboBox3.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
            comboBox3.DisplayMember = "Key";
            comboBox3.ValueMember = "Value";

            comboBox1.Items.Add("GreedyByLenght");
            comboBox1.Items.Add("BreadthFirstSearch");
            comboBox1.Items.Add("BreadthFirstSearchWithIgnoreCase");
            comboBox1.Items.Add("BreadthFirstSearchWithContainSearch");
            comboBox1.SelectedIndex = 0;
            
        }

        private void SearchInGraph_Load(object sender, EventArgs e)
        {

        }

        public static void startSearch(SearchAlg alg, String startName, String endName)
        {
            if (alg.search(startName, endName))
            {

            }
            else
            {
                Interaction.MsgBox("HAVE NOT A PATH");
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "BreadthFirstSearch":
                    startSearch(new BreadthFirstSearch(MainForm.MyGraph), comboBox2.Text, comboBox3.Text);
                    break;
                case "GreedyByLenght":
                    startSearch(new GreedyByLenght(MainForm.MyGraph), comboBox2.Text, comboBox3.Text);
                    break;
                case "BreadthFirstSearchWithIgnoreCase":
                    IgnoreCaseSearch form = new IgnoreCaseSearch(this);
                    form.ShowDialog();
                    break;
                case "BreadthFirstSearchWithContainSearch":
                    ContainSearch form2 = new ContainSearch(this);
                    form2.ShowDialog();
                        break;
                default:
                    break;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
