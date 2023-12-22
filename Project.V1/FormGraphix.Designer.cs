
namespace Project.V1
{
    partial class FormGraphix
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCost_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCost_SAA = new System.Windows.Forms.GroupBox();
            this.chartMec_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCloseGraph_SAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCost_SAA)).BeginInit();
            this.groupBoxCost_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMec_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCost_SAA
            // 
            this.chartCost_SAA.BorderlineColor = System.Drawing.Color.Ivory;
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea3.Name = "ChartArea1";
            this.chartCost_SAA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartCost_SAA.Legends.Add(legend3);
            this.chartCost_SAA.Location = new System.Drawing.Point(7, 19);
            this.chartCost_SAA.Name = "chartCost_SAA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.Name = "Series1";
            this.chartCost_SAA.Series.Add(series3);
            this.chartCost_SAA.Size = new System.Drawing.Size(744, 273);
            this.chartCost_SAA.TabIndex = 0;
            this.chartCost_SAA.Text = "chart1";
            // 
            // groupBoxCost_SAA
            // 
            this.groupBoxCost_SAA.Controls.Add(this.chartMec_SAA);
            this.groupBoxCost_SAA.Controls.Add(this.chartCost_SAA);
            this.groupBoxCost_SAA.Location = new System.Drawing.Point(5, 7);
            this.groupBoxCost_SAA.Name = "groupBoxCost_SAA";
            this.groupBoxCost_SAA.Size = new System.Drawing.Size(757, 620);
            this.groupBoxCost_SAA.TabIndex = 1;
            this.groupBoxCost_SAA.TabStop = false;
            this.groupBoxCost_SAA.Text = "Графики";
            // 
            // chartMec_SAA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartMec_SAA.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartMec_SAA.Legends.Add(legend4);
            this.chartMec_SAA.Location = new System.Drawing.Point(7, 312);
            this.chartMec_SAA.Name = "chartMec_SAA";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartMec_SAA.Series.Add(series4);
            this.chartMec_SAA.Size = new System.Drawing.Size(743, 295);
            this.chartMec_SAA.TabIndex = 1;
            this.chartMec_SAA.Text = "chart1";
            // 
            // buttonCloseGraph_SAA
            // 
            this.buttonCloseGraph_SAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCloseGraph_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseGraph_SAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseGraph_SAA.Location = new System.Drawing.Point(303, 634);
            this.buttonCloseGraph_SAA.Name = "buttonCloseGraph_SAA";
            this.buttonCloseGraph_SAA.Size = new System.Drawing.Size(193, 35);
            this.buttonCloseGraph_SAA.TabIndex = 2;
            this.buttonCloseGraph_SAA.Text = "Закрыть";
            this.buttonCloseGraph_SAA.UseVisualStyleBackColor = false;
            this.buttonCloseGraph_SAA.Click += new System.EventHandler(this.buttonCloseGraph_SAA_Click);
            // 
            // FormGraphix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(771, 681);
            this.Controls.Add(this.buttonCloseGraph_SAA);
            this.Controls.Add(this.groupBoxCost_SAA);
            this.MinimumSize = new System.Drawing.Size(787, 678);
            this.Name = "FormGraphix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.FormGraphix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCost_SAA)).EndInit();
            this.groupBoxCost_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMec_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCost_SAA;
        private System.Windows.Forms.GroupBox groupBoxCost_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMec_SAA;
        private System.Windows.Forms.Button buttonCloseGraph_SAA;
    }
}