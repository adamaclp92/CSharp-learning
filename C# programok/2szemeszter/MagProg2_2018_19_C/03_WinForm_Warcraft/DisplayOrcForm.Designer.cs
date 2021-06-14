namespace _03_WinForm_Warcraft
{
    partial class DisplayOrcForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameData = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblHealthData = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDeadData = new System.Windows.Forms.Label();
            this.lblDead = new System.Windows.Forms.Label();
            this.lblDamageData = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblCouncilorData = new System.Windows.Forms.Label();
            this.lblCouncilor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblNameData
            // 
            this.lblNameData.AutoSize = true;
            this.lblNameData.Location = new System.Drawing.Point(94, 9);
            this.lblNameData.Name = "lblNameData";
            this.lblNameData.Size = new System.Drawing.Size(51, 20);
            this.lblNameData.TabIndex = 1;
            this.lblNameData.Text = "label2";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(366, 9);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(225, 181);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 2;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblHealthData
            // 
            this.lblHealthData.AutoSize = true;
            this.lblHealthData.Location = new System.Drawing.Point(94, 39);
            this.lblHealthData.Name = "lblHealthData";
            this.lblHealthData.Size = new System.Drawing.Size(51, 20);
            this.lblHealthData.TabIndex = 4;
            this.lblHealthData.Text = "label2";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(12, 39);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 20);
            this.lblHealth.TabIndex = 3;
            this.lblHealth.Text = "Health";
            // 
            // lblDeadData
            // 
            this.lblDeadData.AutoSize = true;
            this.lblDeadData.Location = new System.Drawing.Point(94, 69);
            this.lblDeadData.Name = "lblDeadData";
            this.lblDeadData.Size = new System.Drawing.Size(51, 20);
            this.lblDeadData.TabIndex = 6;
            this.lblDeadData.Text = "label2";
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Location = new System.Drawing.Point(12, 69);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(48, 20);
            this.lblDead.TabIndex = 5;
            this.lblDead.Text = "Dead";
            // 
            // lblDamageData
            // 
            this.lblDamageData.AutoSize = true;
            this.lblDamageData.Location = new System.Drawing.Point(94, 98);
            this.lblDamageData.Name = "lblDamageData";
            this.lblDamageData.Size = new System.Drawing.Size(51, 20);
            this.lblDamageData.TabIndex = 8;
            this.lblDamageData.Text = "label2";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(12, 98);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(70, 20);
            this.lblDamage.TabIndex = 7;
            this.lblDamage.Text = "Damage";
            // 
            // lblCouncilorData
            // 
            this.lblCouncilorData.AutoSize = true;
            this.lblCouncilorData.Location = new System.Drawing.Point(94, 127);
            this.lblCouncilorData.Name = "lblCouncilorData";
            this.lblCouncilorData.Size = new System.Drawing.Size(51, 20);
            this.lblCouncilorData.TabIndex = 10;
            this.lblCouncilorData.Text = "label2";
            // 
            // lblCouncilor
            // 
            this.lblCouncilor.AutoSize = true;
            this.lblCouncilor.Location = new System.Drawing.Point(12, 127);
            this.lblCouncilor.Name = "lblCouncilor";
            this.lblCouncilor.Size = new System.Drawing.Size(75, 20);
            this.lblCouncilor.TabIndex = 9;
            this.lblCouncilor.Text = "Councilor";
            // 
            // DisplayOrcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 202);
            this.Controls.Add(this.lblCouncilorData);
            this.Controls.Add(this.lblCouncilor);
            this.Controls.Add(this.lblDamageData);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblDeadData);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.lblHealthData);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.lblNameData);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayOrcForm";
            this.Text = "DisplayOrcForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameData;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label lblHealthData;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblDeadData;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Label lblDamageData;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblCouncilorData;
        private System.Windows.Forms.Label lblCouncilor;
    }
}