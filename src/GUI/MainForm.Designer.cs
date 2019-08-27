namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRandomRecrangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRandomElipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNameToShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColorByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRandomTraiangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.addNodeButton = new System.Windows.Forms.ToolStripButton();
            this.DrawLineButton = new System.Windows.Forms.ToolStripButton();
            this.searchInGraphButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteShapeButton = new System.Windows.Forms.ToolStripButton();
            this.ChangeColorButton = new System.Windows.Forms.ToolStripButton();
            this.SetNameToShapeButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.SetColorByNameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BrushSelectComboBox = new System.Windows.Forms.ComboBox();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(711, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRandomRecrangleToolStripMenuItem,
            this.addRandomElipseToolStripMenuItem,
            this.addNameToShapeToolStripMenuItem,
            this.addColorByNameToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.addRandomTraiangleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addRandomRecrangleToolStripMenuItem
            // 
            this.addRandomRecrangleToolStripMenuItem.Name = "addRandomRecrangleToolStripMenuItem";
            this.addRandomRecrangleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addRandomRecrangleToolStripMenuItem.Text = "Add Random Recrangle";
            // 
            // addRandomElipseToolStripMenuItem
            // 
            this.addRandomElipseToolStripMenuItem.Name = "addRandomElipseToolStripMenuItem";
            this.addRandomElipseToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            // 
            // addNameToShapeToolStripMenuItem
            // 
            this.addNameToShapeToolStripMenuItem.Name = "addNameToShapeToolStripMenuItem";
            this.addNameToShapeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNameToShapeToolStripMenuItem.Text = "Add Name to Shape";
            this.addNameToShapeToolStripMenuItem.Click += new System.EventHandler(this.addNameToShapeToolStripMenuItem_Click);
            // 
            // addColorByNameToolStripMenuItem
            // 
            this.addColorByNameToolStripMenuItem.Name = "addColorByNameToolStripMenuItem";
            this.addColorByNameToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addColorByNameToolStripMenuItem.Text = "Add Color by name";
            this.addColorByNameToolStripMenuItem.Click += new System.EventHandler(this.addColorByNameToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect all";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // addRandomTraiangleToolStripMenuItem
            // 
            this.addRandomTraiangleToolStripMenuItem.Name = "addRandomTraiangleToolStripMenuItem";
            this.addRandomTraiangleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedShapeToolStripMenuItem,
            this.deleteSelectedShapeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copySelectedShapeToolStripMenuItem
            // 
            this.copySelectedShapeToolStripMenuItem.Name = "copySelectedShapeToolStripMenuItem";
            this.copySelectedShapeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.copySelectedShapeToolStripMenuItem.Text = "Copy Selected Shape";
            this.copySelectedShapeToolStripMenuItem.Click += new System.EventHandler(this.copySelectedShapeToolStripMenuItem_Click);
            // 
            // deleteSelectedShapeToolStripMenuItem
            // 
            this.deleteSelectedShapeToolStripMenuItem.Name = "deleteSelectedShapeToolStripMenuItem";
            this.deleteSelectedShapeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteSelectedShapeToolStripMenuItem.Text = "Delete Selected Shape";
            this.deleteSelectedShapeToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedShapeToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateSelectedToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // rotateSelectedToolStripMenuItem
            // 
            this.rotateSelectedToolStripMenuItem.Name = "rotateSelectedToolStripMenuItem";
            this.rotateSelectedToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.rotateSelectedToolStripMenuItem.Text = "Rotate Selected";
            this.rotateSelectedToolStripMenuItem.Click += new System.EventHandler(this.rotateSelectedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 437);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(711, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.addNodeButton,
            this.DrawLineButton,
            this.searchInGraphButton,
            this.DeleteShapeButton,
            this.ChangeColorButton,
            this.SetNameToShapeButton,
            this.CopyButton,
            this.SetColorByNameButton,
            this.toolStripButton1});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(711, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // addNodeButton
            // 
            this.addNodeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNodeButton.Image = ((System.Drawing.Image)(resources.GetObject("addNodeButton.Image")));
            this.addNodeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(23, 22);
            this.addNodeButton.Text = "toolStripButton2";
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // DrawLineButton
            // 
            this.DrawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawLineButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineButton.Image")));
            this.DrawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawLineButton.Name = "DrawLineButton";
            this.DrawLineButton.Size = new System.Drawing.Size(23, 22);
            this.DrawLineButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // searchInGraphButton
            // 
            this.searchInGraphButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchInGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("searchInGraphButton.Image")));
            this.searchInGraphButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchInGraphButton.Name = "searchInGraphButton";
            this.searchInGraphButton.Size = new System.Drawing.Size(23, 22);
            this.searchInGraphButton.Text = "searchInGraphButton";
            this.searchInGraphButton.Click += new System.EventHandler(this.searchInGraphButton_Click);
            // 
            // DeleteShapeButton
            // 
            this.DeleteShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteShapeButton.Image")));
            this.DeleteShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteShapeButton.Name = "DeleteShapeButton";
            this.DeleteShapeButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteShapeButton.Text = "toolStripButton1";
            this.DeleteShapeButton.Click += new System.EventHandler(this.DeleteShapeButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeColorButton.Image")));
            this.ChangeColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(23, 22);
            this.ChangeColorButton.Text = "toolStripButton1";
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // SetNameToShapeButton
            // 
            this.SetNameToShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SetNameToShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("SetNameToShapeButton.Image")));
            this.SetNameToShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetNameToShapeButton.Name = "SetNameToShapeButton";
            this.SetNameToShapeButton.Size = new System.Drawing.Size(23, 22);
            this.SetNameToShapeButton.Text = "toolStripButton1";
            this.SetNameToShapeButton.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 22);
            this.CopyButton.Text = "toolStripButton1";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SetColorByNameButton
            // 
            this.SetColorByNameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SetColorByNameButton.Image = ((System.Drawing.Image)(resources.GetObject("SetColorByNameButton.Image")));
            this.SetColorByNameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetColorByNameButton.Name = "SetColorByNameButton";
            this.SetColorByNameButton.Size = new System.Drawing.Size(23, 22);
            this.SetColorByNameButton.Text = "toolStripButton1";
            this.SetColorByNameButton.Click += new System.EventHandler(this.SetColorByNameButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "RotationButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_3);
            // 
            // BrushSelectComboBox
            // 
            this.BrushSelectComboBox.FormattingEnabled = true;
            this.BrushSelectComboBox.Items.AddRange(new object[] {
            "Tiny pen",
            "Small pen",
            "Medium pen",
            "Large pen",
            "Very Large pen"});
            this.BrushSelectComboBox.Location = new System.Drawing.Point(568, 4);
            this.BrushSelectComboBox.Name = "BrushSelectComboBox";
            this.BrushSelectComboBox.Size = new System.Drawing.Size(131, 21);
            this.BrushSelectComboBox.TabIndex = 5;
            this.BrushSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OpacityBar
            // 
            this.OpacityBar.Location = new System.Drawing.Point(443, 4);
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(119, 45);
            this.OpacityBar.TabIndex = 6;
            this.OpacityBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(711, 388);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 459);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.BrushSelectComboBox);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton ChangeColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton DrawLineButton;
        private System.Windows.Forms.ToolStripButton SetNameToShapeButton;
        private System.Windows.Forms.ToolStripButton DeleteShapeButton;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ComboBox BrushSelectComboBox;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.ToolStripButton SetColorByNameButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem addRandomRecrangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRandomElipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNameToShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColorByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem addRandomTraiangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton addNodeButton;
        private System.Windows.Forms.ToolStripButton searchInGraphButton;
    }
}
