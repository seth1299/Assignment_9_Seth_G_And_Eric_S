
namespace Zork.Builder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
            System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label ExitMessageLabel;
            System.Windows.Forms.Label InvalidCommandMessageTextBox;
            this.Builder_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.OpenFileDialog();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.roomsTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Neighbor_Label = new System.Windows.Forms.Label();
            this.Room_Desc_Box = new System.Windows.Forms.MaskedTextBox();
            this.Room_Name_Box = new System.Windows.Forms.MaskedTextBox();
            this.Starting_Location_Checkbox = new System.Windows.Forms.CheckBox();
            this.Room_Description_Label = new System.Windows.Forms.Label();
            this.Room_Name_Label = new System.Windows.Forms.Label();
            this.Build_File_Button = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.GroupBox();
            this.Room_Scroll = new System.Windows.Forms.VScrollBar();
            this.World_Rooms = new System.Windows.Forms.ListBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.South_Box = new System.Windows.Forms.Button();
            this.West_box = new System.Windows.Forms.Button();
            this.East_Box = new System.Windows.Forms.Button();
            this.North_Box = new System.Windows.Forms.Button();
            this.miscTabPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExitMessageTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            ExitMessageLabel = new System.Windows.Forms.Label();
            InvalidCommandMessageTextBox = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.roomsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Rooms.SuspendLayout();
            this.miscTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Builder_Menu,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.quitToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Builder_Menu
            // 
            this.Builder_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newToolStripMenuItem,
            openToolStripMenuItem,
            saveToolStripMenuItem1,
            saveAsToolStripMenuItem});
            this.Builder_Menu.Name = "Builder_Menu";
            this.Builder_Menu.Size = new System.Drawing.Size(37, 20);
            this.Builder_Menu.Text = "File";
            this.Builder_Menu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            saveToolStripMenuItem1.Text = "&Save";
            saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            saveAsToolStripMenuItem.Text = "Save &As...";
            saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // FileOpen
            // 
            this.FileOpen.FileName = "openFileDialog1";
            this.FileOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = typeof(Zork.Player);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.roomsTabPage);
            this.tabControl1.Controls.Add(this.miscTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // roomsTabPage
            // 
            this.roomsTabPage.Controls.Add(this.pictureBox1);
            this.roomsTabPage.Controls.Add(this.Neighbor_Label);
            this.roomsTabPage.Controls.Add(this.Room_Desc_Box);
            this.roomsTabPage.Controls.Add(this.Room_Name_Box);
            this.roomsTabPage.Controls.Add(this.Starting_Location_Checkbox);
            this.roomsTabPage.Controls.Add(this.Room_Description_Label);
            this.roomsTabPage.Controls.Add(this.Room_Name_Label);
            this.roomsTabPage.Controls.Add(this.Build_File_Button);
            this.roomsTabPage.Controls.Add(this.Rooms);
            this.roomsTabPage.Controls.Add(this.South_Box);
            this.roomsTabPage.Controls.Add(this.West_box);
            this.roomsTabPage.Controls.Add(this.East_Box);
            this.roomsTabPage.Controls.Add(this.North_Box);
            this.roomsTabPage.Location = new System.Drawing.Point(4, 24);
            this.roomsTabPage.Name = "roomsTabPage";
            this.roomsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTabPage.Size = new System.Drawing.Size(792, 467);
            this.roomsTabPage.TabIndex = 0;
            this.roomsTabPage.Text = "Rooms";
            this.roomsTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 93);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Neighbor_Label
            // 
            this.Neighbor_Label.AutoSize = true;
            this.Neighbor_Label.Location = new System.Drawing.Point(637, 366);
            this.Neighbor_Label.Name = "Neighbor_Label";
            this.Neighbor_Label.Size = new System.Drawing.Size(55, 15);
            this.Neighbor_Label.TabIndex = 28;
            this.Neighbor_Label.Text = "Neighbors";
            // 
            // Room_Desc_Box
            // 
            this.Room_Desc_Box.Location = new System.Drawing.Point(205, 137);
            this.Room_Desc_Box.Name = "Room_Desc_Box";
            this.Room_Desc_Box.Size = new System.Drawing.Size(449, 20);
            this.Room_Desc_Box.TabIndex = 27;
            // 
            // Room_Name_Box
            // 
            this.Room_Name_Box.Location = new System.Drawing.Point(202, 38);
            this.Room_Name_Box.Name = "Room_Name_Box";
            this.Room_Name_Box.Size = new System.Drawing.Size(452, 20);
            this.Room_Name_Box.TabIndex = 26;
            // 
            // Starting_Location_Checkbox
            // 
            this.Starting_Location_Checkbox.AutoSize = true;
            this.Starting_Location_Checkbox.Location = new System.Drawing.Point(208, 291);
            this.Starting_Location_Checkbox.Name = "Starting_Location_Checkbox";
            this.Starting_Location_Checkbox.Size = new System.Drawing.Size(122, 19);
            this.Starting_Location_Checkbox.TabIndex = 25;
            this.Starting_Location_Checkbox.Text = "Is Starting Location?";
            this.Starting_Location_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Room_Description_Label
            // 
            this.Room_Description_Label.AutoSize = true;
            this.Room_Description_Label.Location = new System.Drawing.Point(202, 119);
            this.Room_Description_Label.Name = "Room_Description_Label";
            this.Room_Description_Label.Size = new System.Drawing.Size(94, 15);
            this.Room_Description_Label.TabIndex = 24;
            this.Room_Description_Label.Text = "Room Description:";
            // 
            // Room_Name_Label
            // 
            this.Room_Name_Label.AutoSize = true;
            this.Room_Name_Label.Location = new System.Drawing.Point(202, 20);
            this.Room_Name_Label.Name = "Room_Name_Label";
            this.Room_Name_Label.Size = new System.Drawing.Size(67, 15);
            this.Room_Name_Label.TabIndex = 23;
            this.Room_Name_Label.Text = "Room Name:";
            // 
            // Build_File_Button
            // 
            this.Build_File_Button.Location = new System.Drawing.Point(205, 437);
            this.Build_File_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Build_File_Button.Name = "Build_File_Button";
            this.Build_File_Button.Size = new System.Drawing.Size(105, 26);
            this.Build_File_Button.TabIndex = 22;
            this.Build_File_Button.Text = "Build Zork File";
            this.Build_File_Button.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.Room_Scroll);
            this.Rooms.Controls.Add(this.World_Rooms);
            this.Rooms.Controls.Add(this.Remove);
            this.Rooms.Controls.Add(this.Add);
            this.Rooms.Location = new System.Drawing.Point(0, 4);
            this.Rooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rooms.Size = new System.Drawing.Size(200, 474);
            this.Rooms.TabIndex = 21;
            this.Rooms.TabStop = false;
            this.Rooms.Text = "Rooms";
            // 
            // Room_Scroll
            // 
            this.Room_Scroll.Location = new System.Drawing.Point(179, 22);
            this.Room_Scroll.Name = "Room_Scroll";
            this.Room_Scroll.Size = new System.Drawing.Size(15, 394);
            this.Room_Scroll.TabIndex = 7;
            // 
            // World_Rooms
            // 
            this.World_Rooms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.playersBindingSource, "Location.Name", true));
            this.World_Rooms.DataSource = this.playersBindingSource;
            this.World_Rooms.DisplayMember = "LocationName";
            this.World_Rooms.FormattingEnabled = true;
            this.World_Rooms.ItemHeight = 15;
            this.World_Rooms.Location = new System.Drawing.Point(6, 22);
            this.World_Rooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.World_Rooms.Name = "World_Rooms";
            this.World_Rooms.Size = new System.Drawing.Size(188, 394);
            this.World_Rooms.TabIndex = 6;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(112, 433);
            this.Remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(61, 26);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(19, 433);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 26);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // South_Box
            // 
            this.South_Box.Location = new System.Drawing.Point(627, 400);
            this.South_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.South_Box.Name = "South_Box";
            this.South_Box.Size = new System.Drawing.Size(74, 64);
            this.South_Box.TabIndex = 20;
            this.South_Box.Text = "South";
            this.South_Box.UseVisualStyleBackColor = true;
            // 
            // West_box
            // 
            this.West_box.Location = new System.Drawing.Point(543, 341);
            this.West_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.West_box.Name = "West_box";
            this.West_box.Size = new System.Drawing.Size(74, 64);
            this.West_box.TabIndex = 19;
            this.West_box.Text = "West";
            this.West_box.UseVisualStyleBackColor = true;
            // 
            // East_Box
            // 
            this.East_Box.Location = new System.Drawing.Point(710, 341);
            this.East_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.East_Box.Name = "East_Box";
            this.East_Box.Size = new System.Drawing.Size(74, 64);
            this.East_Box.TabIndex = 18;
            this.East_Box.Text = "East";
            this.East_Box.UseVisualStyleBackColor = true;
            // 
            // North_Box
            // 
            this.North_Box.Location = new System.Drawing.Point(627, 282);
            this.North_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.North_Box.Name = "North_Box";
            this.North_Box.Size = new System.Drawing.Size(74, 64);
            this.North_Box.TabIndex = 17;
            this.North_Box.Text = "North";
            this.North_Box.UseVisualStyleBackColor = true;
            // 
            // miscTabPage
            // 
            this.miscTabPage.Controls.Add(this.textBox2);
            this.miscTabPage.Controls.Add(InvalidCommandMessageTextBox);
            this.miscTabPage.Controls.Add(this.ExitMessageTextBox);
            this.miscTabPage.Controls.Add(ExitMessageLabel);
            this.miscTabPage.Controls.Add(this.textBox1);
            this.miscTabPage.Controls.Add(welcomeMessageLabel);
            this.miscTabPage.Location = new System.Drawing.Point(4, 24);
            this.miscTabPage.Name = "miscTabPage";
            this.miscTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.miscTabPage.Size = new System.Drawing.Size(792, 467);
            this.miscTabPage.TabIndex = 1;
            this.miscTabPage.Text = "Misc";
            this.miscTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(4, 7);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(91, 15);
            welcomeMessageLabel.TabIndex = 0;
            welcomeMessageLabel.Text = "Welcome Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ExitMessageTextBox
            // 
            this.ExitMessageTextBox.Location = new System.Drawing.Point(9, 68);
            this.ExitMessageTextBox.Name = "ExitMessageTextBox";
            this.ExitMessageTextBox.Size = new System.Drawing.Size(126, 20);
            this.ExitMessageTextBox.TabIndex = 3;
            // 
            // ExitMessageLabel
            // 
            ExitMessageLabel.AutoSize = true;
            ExitMessageLabel.Location = new System.Drawing.Point(6, 49);
            ExitMessageLabel.Name = "ExitMessageLabel";
            ExitMessageLabel.Size = new System.Drawing.Size(66, 15);
            ExitMessageLabel.TabIndex = 2;
            ExitMessageLabel.Text = "Exit Message";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 5;
            // 
            // InvalidCommandMessageTextBox
            // 
            InvalidCommandMessageTextBox.AutoSize = true;
            InvalidCommandMessageTextBox.Location = new System.Drawing.Point(4, 91);
            InvalidCommandMessageTextBox.Name = "InvalidCommandMessageTextBox";
            InvalidCommandMessageTextBox.Size = new System.Drawing.Size(131, 15);
            InvalidCommandMessageTextBox.TabIndex = 4;
            InvalidCommandMessageTextBox.Text = "Invalid Command Message";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.roomsTabPage.ResumeLayout(false);
            this.roomsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Rooms.ResumeLayout(false);
            this.miscTabPage.ResumeLayout(false);
            this.miscTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog FileOpen;
        private System.Windows.Forms.ToolStripMenuItem Builder_Menu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage roomsTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Neighbor_Label;
        private System.Windows.Forms.MaskedTextBox Room_Desc_Box;
        private System.Windows.Forms.MaskedTextBox Room_Name_Box;
        private System.Windows.Forms.CheckBox Starting_Location_Checkbox;
        private System.Windows.Forms.Label Room_Description_Label;
        private System.Windows.Forms.Label Room_Name_Label;
        private System.Windows.Forms.Button Build_File_Button;
        private System.Windows.Forms.GroupBox Rooms;
        private System.Windows.Forms.VScrollBar Room_Scroll;
        private System.Windows.Forms.ListBox World_Rooms;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button South_Box;
        private System.Windows.Forms.Button West_box;
        private System.Windows.Forms.Button East_Box;
        private System.Windows.Forms.Button North_Box;
        private System.Windows.Forms.TabPage miscTabPage;
        private System.Windows.Forms.TextBox ExitMessageTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

