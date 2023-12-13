
namespace Project.V1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpen_SAA = new System.Windows.Forms.Button();
            this.openFileDialog_SAA = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTabl_SAA = new System.Windows.Forms.DataGridView();
            this.buttonSave_SAA = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipHelp_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.panelBD_SAA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabl_SAA)).BeginInit();
            this.panelBD_SAA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen_SAA
            // 
            this.buttonOpen_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen_SAA.AutoEllipsis = true;
            this.buttonOpen_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpen_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpen_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SAA.Image")));
            this.buttonOpen_SAA.Location = new System.Drawing.Point(6, 19);
            this.buttonOpen_SAA.Name = "buttonOpen_SAA";
            this.buttonOpen_SAA.Size = new System.Drawing.Size(139, 64);
            this.buttonOpen_SAA.TabIndex = 1;
            this.buttonOpen_SAA.Text = "Открыть файл";
            this.buttonOpen_SAA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipHelp_SAA.SetToolTip(this.buttonOpen_SAA, "Нажмите, чтобы открыть файл ");
            this.buttonOpen_SAA.UseVisualStyleBackColor = false;
            this.buttonOpen_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // openFileDialog_SAA
            // 
            this.openFileDialog_SAA.FileName = "openFileDialog1";
            // 
            // dataGridViewTabl_SAA
            // 
            this.dataGridViewTabl_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTabl_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabl_SAA.ColumnHeadersVisible = false;
            this.dataGridViewTabl_SAA.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewTabl_SAA.Name = "dataGridViewTabl_SAA";
            this.dataGridViewTabl_SAA.RowHeadersVisible = false;
            this.dataGridViewTabl_SAA.RowHeadersWidth = 30;
            this.dataGridViewTabl_SAA.Size = new System.Drawing.Size(768, 283);
            this.dataGridViewTabl_SAA.TabIndex = 2;
            // 
            // buttonSave_SAA
            // 
            this.buttonSave_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSave_SAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SAA.Image")));
            this.buttonSave_SAA.Location = new System.Drawing.Point(584, 19);
            this.buttonSave_SAA.Name = "buttonSave_SAA";
            this.buttonSave_SAA.Size = new System.Drawing.Size(193, 64);
            this.buttonSave_SAA.TabIndex = 3;
            this.buttonSave_SAA.Text = "Сохранить изменения";
            this.buttonSave_SAA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipHelp_SAA.SetToolTip(this.buttonSave_SAA, "Нажмите, чтобы сохранить изменения ");
            this.buttonSave_SAA.UseVisualStyleBackColor = false;
            this.buttonSave_SAA.Click += new System.EventHandler(this.buttonSave_SAA_Click);
            // 
            // toolTipHelp_SAA
            // 
            this.toolTipHelp_SAA.IsBalloon = true;
            this.toolTipHelp_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelp_SAA.ToolTipTitle = "Подсказка";
            // 
            // panelBD_SAA
            // 
            this.panelBD_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBD_SAA.Controls.Add(this.dataGridViewTabl_SAA);
            this.panelBD_SAA.Location = new System.Drawing.Point(0, 6);
            this.panelBD_SAA.Name = "panelBD_SAA";
            this.panelBD_SAA.Size = new System.Drawing.Size(784, 308);
            this.panelBD_SAA.TabIndex = 4;
            this.panelBD_SAA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBD_SAA_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave_SAA);
            this.panel1.Controls.Add(this.buttonOpen_SAA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 91);
            this.panel1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBD_SAA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "Проект | Спринт 7 | Вариант 1 | Шелудков А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabl_SAA)).EndInit();
            this.panelBD_SAA.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpen_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SAA;
        private System.Windows.Forms.DataGridView dataGridViewTabl_SAA;
        private System.Windows.Forms.Button buttonSave_SAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTipHelp_SAA;
        private System.Windows.Forms.Panel panelBD_SAA;
        private System.Windows.Forms.Panel panel1;
    }
}

