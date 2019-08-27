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
    public partial class AddLink : Form
    {
        public AddLink()
        {
            InitializeComponent();
            
                comboBox1.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
                comboBox1.DisplayMember = "Key";
                comboBox1.ValueMember = "Value";

                comboBox2.DataSource = new BindingSource(MainForm.MyGraph.getMap(), null);
                comboBox2.DisplayMember = "Key";
                comboBox2.ValueMember = "Value";
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLink_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
            try
            {
                int lenght = Int32.Parse(textBox1.Text);
               
                if (lenght != 0 && lenght>0)
                {
                    RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                      .Where(x => x.Checked).FirstOrDefault();
                    if (radioBtn != null)
                    {
                        switch (radioBtn.Name)
                        {
                            case "radioButton1":
                                MainForm.MyGraph.addOneWayLink(comboBox1.Text, comboBox2.Text, float.Parse(textBox1.Text));
                                break;
                            case "radioButton2":
                                MainForm.MyGraph.addTwoWayLink(comboBox1.Text, comboBox2.Text, float.Parse(textBox1.Text));
                                break;
                            default: break;
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("lenght of the link must be a positive number");
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
                Interaction.MsgBox("An Error ocured while formating you're data");
            }
            this.Close();
        }
    }
}
