
namespace Project.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxAbout_SAA = new System.Windows.Forms.GroupBox();
            this.labelAbout_SAA = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_SAA = new System.Windows.Forms.PictureBox();
            this.buttonOK_SAA = new System.Windows.Forms.Button();
            this.groupBoxAboutProg_SAA = new System.Windows.Forms.GroupBox();
            this.labelAboutProg_SAA = new System.Windows.Forms.Label();
            this.groupBoxAbout_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).BeginInit();
            this.groupBoxAboutProg_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAbout_SAA
            // 
            this.groupBoxAbout_SAA.BackColor = System.Drawing.Color.Ivory;
            this.groupBoxAbout_SAA.Controls.Add(this.labelAbout_SAA);
            this.groupBoxAbout_SAA.Controls.Add(this.pictureBoxAvatar_SAA);
            this.groupBoxAbout_SAA.Location = new System.Drawing.Point(5, 4);
            this.groupBoxAbout_SAA.Name = "groupBoxAbout_SAA";
            this.groupBoxAbout_SAA.Size = new System.Drawing.Size(473, 243);
            this.groupBoxAbout_SAA.TabIndex = 0;
            this.groupBoxAbout_SAA.TabStop = false;
            this.groupBoxAbout_SAA.Text = "О разработчике";
            // 
            // labelAbout_SAA
            // 
            this.labelAbout_SAA.AutoSize = true;
            this.labelAbout_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_SAA.Location = new System.Drawing.Point(168, 30);
            this.labelAbout_SAA.Name = "labelAbout_SAA";
            this.labelAbout_SAA.Size = new System.Drawing.Size(276, 64);
            this.labelAbout_SAA.TabIndex = 1;
            this.labelAbout_SAA.Text = "ФИО: Шелудков Алексей Андреевич\r\nГруппа: АСОиУб-23-1\r\n\r\n\r\n";
            // 
            // pictureBoxAvatar_SAA
            // 
            this.pictureBoxAvatar_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SAA.Image")));
            this.pictureBoxAvatar_SAA.Location = new System.Drawing.Point(7, 19);
            this.pictureBoxAvatar_SAA.Name = "pictureBoxAvatar_SAA";
            this.pictureBoxAvatar_SAA.Size = new System.Drawing.Size(155, 215);
            this.pictureBoxAvatar_SAA.TabIndex = 0;
            this.pictureBoxAvatar_SAA.TabStop = false;
            // 
            // buttonOK_SAA
            // 
            this.buttonOK_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOK_SAA.FlatAppearance.BorderSize = 10;
            this.buttonOK_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK_SAA.Location = new System.Drawing.Point(400, 419);
            this.buttonOK_SAA.Name = "buttonOK_SAA";
            this.buttonOK_SAA.Size = new System.Drawing.Size(78, 30);
            this.buttonOK_SAA.TabIndex = 1;
            this.buttonOK_SAA.Text = "Закрыть";
            this.buttonOK_SAA.UseVisualStyleBackColor = false;
            this.buttonOK_SAA.Click += new System.EventHandler(this.buttonOK_SAA_Click);
            // 
            // groupBoxAboutProg_SAA
            // 
            this.groupBoxAboutProg_SAA.Controls.Add(this.labelAboutProg_SAA);
            this.groupBoxAboutProg_SAA.Location = new System.Drawing.Point(5, 253);
            this.groupBoxAboutProg_SAA.Name = "groupBoxAboutProg_SAA";
            this.groupBoxAboutProg_SAA.Size = new System.Drawing.Size(472, 140);
            this.groupBoxAboutProg_SAA.TabIndex = 2;
            this.groupBoxAboutProg_SAA.TabStop = false;
            this.groupBoxAboutProg_SAA.Text = "О программе";
            // 
            // labelAboutProg_SAA
            // 
            this.labelAboutProg_SAA.AutoSize = true;
            this.labelAboutProg_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAboutProg_SAA.Location = new System.Drawing.Point(11, 12);
            this.labelAboutProg_SAA.Name = "labelAboutProg_SAA";
            this.labelAboutProg_SAA.Size = new System.Drawing.Size(433, 64);
            this.labelAboutProg_SAA.TabIndex = 0;
            this.labelAboutProg_SAA.Text = "Предметная область : Автомастерская\r\n\r\nВ программе реализовано: открытие файла, \r" +
    "\nредактирование и сохранение, поиск, вывод статистики.\r\n";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBoxAboutProg_SAA);
            this.Controls.Add(this.buttonOK_SAA);
            this.Controls.Add(this.groupBoxAbout_SAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormAbout";
            this.Text = "Сведения о программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.groupBoxAbout_SAA.ResumeLayout(false);
            this.groupBoxAbout_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SAA)).EndInit();
            this.groupBoxAboutProg_SAA.ResumeLayout(false);
            this.groupBoxAboutProg_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAbout_SAA;
        private System.Windows.Forms.Label labelAbout_SAA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SAA;
        private System.Windows.Forms.Button buttonOK_SAA;
        private System.Windows.Forms.GroupBox groupBoxAboutProg_SAA;
        private System.Windows.Forms.Label labelAboutProg_SAA;
    }
}