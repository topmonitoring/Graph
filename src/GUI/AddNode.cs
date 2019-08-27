using Draw.src.Model;
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
    public partial class AddNode : Form
    {
        

        public AddNode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                int xCoord = Int32.Parse(textBox1.Text);
                int yCoord = Int32.Parse(textBox2.Text);
                String weight = textBox3.Text.ToString();
                if (Int32.Parse(weight)!=0)
                {
                    MainForm.MyGraph.addNode(xCoord, yCoord, weight);
                }
                this.Close();

            }
                    catch (ArgumentNullException)
                    {
                        Interaction.MsgBox("all Fields should be Numbers!!!");
                    }
                    catch (OverflowException)
                    {
                        Interaction.MsgBox("values are too big");
                    }
                    catch (FormatException)
                    {
                        Interaction.MsgBox("An Error ocured while formating you're data");
                    }
         }

        
    }
}
