namespace _03_WinForm_Warcraft
{
    partial class MainWindow
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
            this.dgvOrcs = new System.Windows.Forms.DataGridView();
            this.btnAddOrc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrcs
            // 
            this.dgvOrcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcs.Location = new System.Drawing.Point(20, 20);
            this.dgvOrcs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrcs.Name = "dgvOrcs";
            this.dgvOrcs.Size = new System.Drawing.Size(629, 342);
            this.dgvOrcs.TabIndex = 0;
            this.dgvOrcs.DoubleClick += new System.EventHandler(this.dgvOrcs_DoubleClick);
            // 
            // btnAddOrc
            // 
            this.btnAddOrc.Location = new System.Drawing.Point(657, 20);
            this.btnAddOrc.Name = "btnAddOrc";
            this.btnAddOrc.Size = new System.Drawing.Size(125, 37);
            this.btnAddOrc.TabIndex = 1;
            this.btnAddOrc.Text = "Add new orc";
            this.btnAddOrc.UseVisualStyleBackColor = true;
            this.btnAddOrc.Click += new System.EventHandler(this.btnAddOrc_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 377);
            this.Controls.Add(this.btnAddOrc);
            this.Controls.Add(this.dgvOrcs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Warcraft character manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrcs;
        private System.Windows.Forms.Button btnAddOrc;


    }
}

