
namespace Zork.Builder
{
    partial class NeighborForm
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
            this.NeighborFormLabel = new System.Windows.Forms.Label();
            this.Neighbor_Dropdown = new System.Windows.Forms.ComboBox();
            this.NeighborForm_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NeighborFormLabel
            // 
            this.NeighborFormLabel.AutoSize = true;
            this.NeighborFormLabel.Location = new System.Drawing.Point(56, 9);
            this.NeighborFormLabel.Name = "NeighborFormLabel";
            this.NeighborFormLabel.Size = new System.Drawing.Size(147, 13);
            this.NeighborFormLabel.TabIndex = 0;
            this.NeighborFormLabel.Text = "Assign Neighbor For Direction";
            // 
            // Neighbor_Dropdown
            // 
            this.Neighbor_Dropdown.FormattingEnabled = true;
            this.Neighbor_Dropdown.Location = new System.Drawing.Point(71, 25);
            this.Neighbor_Dropdown.Name = "Neighbor_Dropdown";
            this.Neighbor_Dropdown.Size = new System.Drawing.Size(121, 21);
            this.Neighbor_Dropdown.TabIndex = 1;
            // 
            // NeighborForm_OK
            // 
            this.NeighborForm_OK.Location = new System.Drawing.Point(94, 52);
            this.NeighborForm_OK.Name = "NeighborForm_OK";
            this.NeighborForm_OK.Size = new System.Drawing.Size(75, 23);
            this.NeighborForm_OK.TabIndex = 2;
            this.NeighborForm_OK.Text = "OK";
            this.NeighborForm_OK.UseVisualStyleBackColor = true;
            this.NeighborForm_OK.Click += new System.EventHandler(this.NeighborForm_OK_Click);
            // 
            // NeighborForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 80);
            this.Controls.Add(this.NeighborForm_OK);
            this.Controls.Add(this.Neighbor_Dropdown);
            this.Controls.Add(this.NeighborFormLabel);
            this.Name = "NeighborForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NeighborForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NeighborFormLabel;
        private System.Windows.Forms.ComboBox Neighbor_Dropdown;
        private System.Windows.Forms.Button NeighborForm_OK;
    }
}