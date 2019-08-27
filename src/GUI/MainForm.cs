using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using Draw.src.GUI;
using Draw.src.Model;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
    
    public partial class MainForm : Form
    {
        bool flag = false;
        Stopwatch s = new Stopwatch(); //stopwach, i use it for counting time to figure out to select or deselect a figure
        PointF Spoint = new Point(100, 100); //start point for drawing a figure or selection
        PointF Fpoint = new Point(100, 100);//end point of drawing figure of selection
        bool flagSelect = false; //drawing mode flag atribute ,used for drawing when figure type is selected
        String ShapeType = null; //String variable wich i use for geting the drawing figure type 
        public Shape sel = null; //Selection atribute ,i use it for cheking if figure conteins selection



        public static Graph MyGraph = new Graph();




        public static DialogProcessor dialogProcessor = new DialogProcessor();

        
        public MainForm()
        {
            
            InitializeComponent();
           
        }

        
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }



        
        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            

            if (pickUpSpeedButton.Checked) //Selection button
            {
                sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {
                    if (dialogProcessor.Selection.Contains(sel))
                    {
                        s.Start();
                        flag = false;
                    }   
                    else
                    {
                        dialogProcessor.Selection.Add(sel);
                        flag = true;
                    }
                        
                        statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                        dialogProcessor.IsDragging = true;
                        dialogProcessor.LastLocation = e.Location;
                        viewPort.Invalidate();
                }
                if(sel==null) //noting is selected
                {
                    Spoint.X=e.X ;
                    Spoint.Y = e.Y;
                    flagSelect = true;
                    ShapeType = "selection";

                }
            }
            
           
            if (DrawLineButton.Checked) //draw line button
            {
                Spoint.X = e.X;
                Spoint.Y = e.Y;
                flagSelect = true;
            }


        }

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
			}
           
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            s.Stop();
            dialogProcessor.IsDragging = false;
            if (s.ElapsedMilliseconds < 100 && flag==false)//Removes Selection when item is selected & clict under 100 mili sek
            {
                dialogProcessor.Selection.Remove(sel);
            }
            if(s.ElapsedMilliseconds < 1000 && flagSelect ==true)
            {
                Fpoint.X = e.X;
                Fpoint.Y = e.Y;
                switch (ShapeType)
                {
                    case null: break;
                        case "ractangle":
                        dialogProcessor.AddRectangle(Spoint, Fpoint);
                        flagSelect = false;
                        break;
                    case "elipse":
                        dialogProcessor.AddElipse(Spoint, Fpoint);
                        flagSelect = false;
                        break;
                    case "selection":
                        dialogProcessor.AddSelection(Spoint, Fpoint);
                        flagSelect = false;
                        break;
                    case "traiangle":
                     //   dialogProcessor.AddTriangle(Spoint, Fpoint);
                        flagSelect = false;
                        break;
                        


                    default:break;
                }
            }
            s.Reset();
            viewPort.Invalidate();

        }
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
           
            ShapeType = "ractangle";
            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
            viewPort.Invalidate();
        }
        private void toolStripButton1_Click(object sender, EventArgs e) 
        {
            
            ShapeType = "elipse";
            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";
            viewPort.Invalidate();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            dialogProcessor.SetColor(colorDialog1.Color);
            viewPort.Invalidate();
        }

        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {
           
        }

       

        private void viewPort_Load(object sender, EventArgs e)
        {

        }

       

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (MyGraph.HaveMoreThanOneNode())
            {
                AddLink pop = new AddLink();
                pop.Show();

                statusBar.Items[0].Text = "Последно действие: Добавяне на връзка между графове";
                viewPort.Invalidate();

            }
            else
            {
                Interaction.MsgBox("You need to have more than one node to make links");
            }
            
        }

       
        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
           
            if (dialogProcessor.Selection.Count==0)
            {
                MessageBox.Show("Първо селектирай примитив");
            }
            if (dialogProcessor.Selection.Count >= 2)
            {
                MessageBox.Show("Не можеш да именуваш повече от 1 примитив едновременно, моля селектирай само 1 ");
            }
            if (dialogProcessor.Selection.Count == 1)
            {

                string ShapeName=Interaction.InputBox("моля въведете име:","задаване на име","моята фигурка",-1,-1);
                dialogProcessor.SetShapeName(ShapeName);
                statusBar.Items[0].Text = "Последно действие: Задаване име на Примитив";
            }
            viewPort.Invalidate();

        }

        private void DeleteShapeButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteShape();
            statusBar.Items[0].Text = "Последно действие: изтриване на обект/и";
            viewPort.Invalidate();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.CoppyShape();
            statusBar.Items[0].Text = "Последно действие: копиране на обект/и";
            viewPort.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BrushSelectComboBox.SelectedIndex)
            {
                case 0:
                    dialogProcessor.ChangeMyPen(Color.Black,1.0F);
                    break;
                case 1:
                    dialogProcessor.ChangeMyPen(Color.Black, 2.0F);
                    break;
                case 2:
                    dialogProcessor.ChangeMyPen(Color.Black, 3.0F);
                    break;
                case 3:
                    dialogProcessor.ChangeMyPen(Color.Black, 4.0F);
                    break;
                case 4:
                    dialogProcessor.ChangeMyPen(Color.Black, 5.0F);
                    break;
                default:
                    goto case 0;

            }
            viewPort.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
           
            DrawLineButton.CheckOnClick = true;
            // BrushSelectComboBox.Select();
        }

        private void speedMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Double a = OpacityBar.Value*(244/10);
            Console.Out.WriteLine("My Opociti value "+OpacityBar.Value);
            dialogProcessor.ChangeMyOpacity(a);
            viewPort.Invalidate();
        }

        private void SetColorByNameButton_Click(object sender, EventArgs e)
        {
            String myColor = Interaction.InputBox("моля въведете цвят:", "задаване на цвят", "blue", -1, -1);
            dialogProcessor.ChengeMyColorByName(myColor);
            statusBar.Items[0].Text = "Последно действие: Задаване цвят на Примитив";
            viewPort.Invalidate();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            string angle = Interaction.InputBox("моля въведете ъгъл на завъртане:", "задаване на ъгъл на завъртане", "30", -1, -1);
            dialogProcessor.ChengeMyAngle(float.Parse(angle)); 
            statusBar.Items[0].Text = "Последно действие: Завъртане на Примитив";
            viewPort.Invalidate();
        }

       

        

        private void addNameToShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                MessageBox.Show("Първо селектирай примитив");
            }
            if (dialogProcessor.Selection.Count >= 2)
            {
                MessageBox.Show("Не можеш да именуваш повече от 1 примитив едновременно, моля селектирай само 1 ");
            }
            if (dialogProcessor.Selection.Count == 1)
            {

                string ShapeName = Interaction.InputBox("моля въведете име:", "задаване на име", "моята фигурка", -1, -1);
                dialogProcessor.SetShapeName(ShapeName);
                statusBar.Items[0].Text = "Последно действие: Задаване име на Примитив";
            }
            viewPort.Invalidate();
        }

        private void addColorByNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String myColor = Interaction.InputBox("моля въведете цвят:", "задаване на цвят", "blue", -1, -1);
            dialogProcessor.ChengeMyColorByName(myColor);
            statusBar.Items[0].Text = "Последно действие: Задаване цвят на Примитив";
            viewPort.Invalidate();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();
            viewPort.Invalidate();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeselectAll();
            viewPort.Invalidate();
        }

        private void copySelectedShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.CoppyShape();
            statusBar.Items[0].Text = "Последно действие: копиране на обект/и";
            viewPort.Invalidate();
        }

        private void deleteSelectedShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteShape();
            statusBar.Items[0].Text = "Последно действие: изтриване на обект/и";
            viewPort.Invalidate();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rotateSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string angle = Interaction.InputBox("моля въведете ъгъл на завъртане:", "задаване на ъгъл на завъртане", "30", -1, -1);
            dialogProcessor.ChengeMyAngle(float.Parse(angle));
            statusBar.Items[0].Text = "Последно действие: Завъртане на Примитив";
            viewPort.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)  ///working one
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "DefaultOutputName.gpd";

            save.Filter = "Text File | *.gpd";

            if (save.ShowDialog() == DialogResult.OK)

            {
                Graph.SerializeMyMap(save.FileName);
            }
        }
       

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            open.Filter = "All Files (*.*)|*.*gpd";
            open.FilterIndex = 2;

            open.Multiselect = true;
            

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Graph.Deserialize(open.FileName);
                    viewPort.Invalidate();

                }
                catch(Exception )
                {
                  
                }
            }    
        }

        private void addNodeButton_Click(object sender, EventArgs e)
        {

            AddNode pop1 = new AddNode();
            pop1.Show();
        }

        private void searchInGraphButton_Click(object sender, EventArgs e)
        {
            

            if (MyGraph.HaveMoreThanOneNode())
            {
                SearchInGraph pop3 = new SearchInGraph();
                pop3.Show();

                statusBar.Items[0].Text = "Последно действие: Търсене в графа.";
                viewPort.Invalidate();

            }
            else
            {
                Interaction.MsgBox("You need to have atleast 2 nods to search in you'r graff");
            }
        }
    }
}
