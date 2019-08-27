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
    public partial class IgnoreCaseSearch : Form
    {
        SearchInGraph ParentForm;
        public IgnoreCaseSearch(SearchInGraph myForm)
        {
            InitializeComponent();
            this.ParentForm = myForm;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int lenght = Int32.Parse(textBox1.Text);
                int ignoreLink=0;
                int IgnoreNodeWithWeightGraterThan=0;

                    RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                      .Where(x => x.Checked).FirstOrDefault();
                    if (radioBtn != null)
                    {
                        switch (radioBtn.Name)
                        {
                            case "radioButton1":
                                ignoreLink = 1; //ignores one way links
                                break;
                            case "radioButton2":
                                ignoreLink = 2; //ignores two way links
                                break;
                            case "radioButton3":
                                ignoreLink = 0;//ignores none
                                break;
                            default: break;
                        }
                        IgnoreNodeWithWeightGraterThan=Int32.Parse(textBox1.Text);
                        SearchInGraph.startSearch(new BreadthFirstSearchWithIgnoreCase(MainForm.MyGraph,ignoreLink,IgnoreNodeWithWeightGraterThan), ParentForm.comboBox2.Text, ParentForm.comboBox3.Text);
                    }

            }
            catch (ArgumentNullException)
            {
                Interaction.MsgBox("all Fields should be filed!!!");
            }
            catch (OverflowException)
            {
                Interaction.MsgBox("values are too big");
            }
            catch (FormatException)
            {
                Interaction.MsgBox("all Fields should be filed!!!");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IgnoreCaseSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
