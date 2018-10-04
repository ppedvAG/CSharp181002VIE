namespace FormsKlickSpiel
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonKlickMich = new System.Windows.Forms.Button();
            this.labelNoCheat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // buttonKlickMich
            // 
            this.buttonKlickMich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.buttonKlickMich.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKlickMich.Location = new System.Drawing.Point(200, 200);
            this.buttonKlickMich.Name = "buttonKlickMich";
            this.buttonKlickMich.Size = new System.Drawing.Size(289, 56);
            this.buttonKlickMich.TabIndex = 0;
            this.buttonKlickMich.TabStop = false;
            this.buttonKlickMich.Text = "Klick mich !";
            this.buttonKlickMich.UseVisualStyleBackColor = false;
            this.buttonKlickMich.Click += new System.EventHandler(this.buttonKlickMich_Click);
            this.buttonKlickMich.MouseEnter += new System.EventHandler(this.buttonKlickMich_MouseEnter);
            // 
            // labelNoCheat
            // 
            this.labelNoCheat.AutoSize = true;
            this.labelNoCheat.Location = new System.Drawing.Point(649, 53);
            this.labelNoCheat.Name = "labelNoCheat";
            this.labelNoCheat.Size = new System.Drawing.Size(0, 17);
            this.labelNoCheat.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNoCheat);
            this.Controls.Add(this.buttonKlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Super tolle Klickspiel für die ganze Familie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Button buttonKlickMich;
        private System.Windows.Forms.Label labelNoCheat;
    }
}

