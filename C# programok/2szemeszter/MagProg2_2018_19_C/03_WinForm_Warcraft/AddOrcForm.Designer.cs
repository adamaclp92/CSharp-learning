namespace _03_WinForm_Warcraft
{
    partial class AddOrcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHealth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDamage = new System.Windows.Forms.NumericUpDown();
            this.cbCouncilor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(105, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(435, 26);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Health";
            // 
            // nudHealth
            // 
            this.nudHealth.Location = new System.Drawing.Point(105, 59);
            this.nudHealth.Name = "nudHealth";
            this.nudHealth.Size = new System.Drawing.Size(120, 26);
            this.nudHealth.TabIndex = 3;
            this.nudHealth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Damage";
            // 
            // nudDamage
            // 
            this.nudDamage.Location = new System.Drawing.Point(105, 97);
            this.nudDamage.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudDamage.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(120, 26);
            this.nudDamage.TabIndex = 5;
            this.nudDamage.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cbCouncilor
            // 
            this.cbCouncilor.AutoSize = true;
            this.cbCouncilor.Location = new System.Drawing.Point(105, 146);
            this.cbCouncilor.Name = "cbCouncilor";
            this.cbCouncilor.Size = new System.Drawing.Size(15, 14);
            this.cbCouncilor.TabIndex = 6;
            this.cbCouncilor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Councilor";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(516, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(20, 176);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(54, 20);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Image";
            // 
            // tbImage
            // 
            this.tbImage.Enabled = false;
            this.tbImage.Location = new System.Drawing.Point(105, 176);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(348, 26);
            this.tbImage.TabIndex = 10;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(459, 173);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(81, 29);
            this.btnOpenImage.TabIndex = 11;
            this.btnOpenImage.Text = "Open";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // AddOrcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 269);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCouncilor);
            this.Controls.Add(this.nudDamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOrcForm";
            this.Text = "Add new orc";
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDamage;
        private System.Windows.Forms.CheckBox cbCouncilor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Button btnOpenImage;
    }
}