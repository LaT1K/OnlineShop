namespace OnlineShop {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всіТовариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.овочіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фруктиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.постачальникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.постачальникиToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всіТовариToolStripMenuItem,
            this.овочіToolStripMenuItem,
            this.фруктиToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.productsToolStripMenuItem.Text = "Продукти";
            // 
            // всіТовариToolStripMenuItem
            // 
            this.всіТовариToolStripMenuItem.Name = "всіТовариToolStripMenuItem";
            this.всіТовариToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.всіТовариToolStripMenuItem.Text = "Всі продукти";
            this.всіТовариToolStripMenuItem.Click += new System.EventHandler(this.всіТовариToolStripMenuItem_Click);
            // 
            // овочіToolStripMenuItem
            // 
            this.овочіToolStripMenuItem.Name = "овочіToolStripMenuItem";
            this.овочіToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.овочіToolStripMenuItem.Text = "Овочі";
            this.овочіToolStripMenuItem.Click += new System.EventHandler(this.овочіToolStripMenuItem_Click);
            // 
            // фруктиToolStripMenuItem
            // 
            this.фруктиToolStripMenuItem.Name = "фруктиToolStripMenuItem";
            this.фруктиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.фруктиToolStripMenuItem.Text = "Фрукти";
            this.фруктиToolStripMenuItem.Click += new System.EventHandler(this.фруктиToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.adminToolStripMenuItem.Text = "Адмін";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aboutToolStripMenuItem.Text = "Про програму";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // постачальникиToolStripMenuItem
            // 
            this.постачальникиToolStripMenuItem.Name = "постачальникиToolStripMenuItem";
            this.постачальникиToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.постачальникиToolStripMenuItem.Text = "Постачальники";
            this.постачальникиToolStripMenuItem.Click += new System.EventHandler(this.постачальникиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem всіТовариToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem овочіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фруктиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постачальникиToolStripMenuItem;
    }
}