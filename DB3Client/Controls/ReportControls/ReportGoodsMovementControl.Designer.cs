namespace DB3Client.Controls.ReportControls
{
    partial class ReportGoodsMovementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.mlGroupBox1 = new Common.Forms.Base.MLGroupBox();
            this.cbItemTypeDiagram = new Common.Forms.Base.MLCheckBox();
            this.cbItemTypesDiagram = new Common.Forms.Base.MLComboBox();
            this.btnGenerateDiagram = new Common.Forms.Base.MLButton();
            this.labelErrorDiagram = new Common.Forms.Base.MLErrorLabel();
            this.mlLabel5 = new Common.Forms.Base.MLLabel();
            this.mlLabel6 = new Common.Forms.Base.MLLabel();
            this.dtToDiagram = new MetroFramework.Controls.MetroDateTime();
            this.dtFromDiagram = new MetroFramework.Controls.MetroDateTime();
            this.mlLabel4 = new Common.Forms.Base.MLLabel();
            this.cbDiagramType = new Common.Forms.Base.MLComboBox();
            this.chartMovement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mlGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // mlGroupBox1
            // 
            this.mlGroupBox1.BackColor = System.Drawing.Color.White;
            this.mlGroupBox1.Controls.Add(this.cbItemTypeDiagram);
            this.mlGroupBox1.Controls.Add(this.cbItemTypesDiagram);
            this.mlGroupBox1.Controls.Add(this.btnGenerateDiagram);
            this.mlGroupBox1.Controls.Add(this.labelErrorDiagram);
            this.mlGroupBox1.Controls.Add(this.mlLabel5);
            this.mlGroupBox1.Controls.Add(this.mlLabel6);
            this.mlGroupBox1.Controls.Add(this.dtToDiagram);
            this.mlGroupBox1.Controls.Add(this.dtFromDiagram);
            this.mlGroupBox1.Controls.Add(this.mlLabel4);
            this.mlGroupBox1.Controls.Add(this.cbDiagramType);
            this.mlGroupBox1.Controls.Add(this.chartMovement);
            this.mlGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.mlGroupBox1.Name = "mlGroupBox1";
            this.mlGroupBox1.Size = new System.Drawing.Size(1088, 554);
            this.mlGroupBox1.TabIndex = 1;
            this.mlGroupBox1.TabStop = false;
            this.mlGroupBox1.Text = "report_for_goods_movement";
            // 
            // cbItemTypeDiagram
            // 
            this.cbItemTypeDiagram.AutoSize = true;
            this.cbItemTypeDiagram.Location = new System.Drawing.Point(315, 20);
            this.cbItemTypeDiagram.Name = "cbItemTypeDiagram";
            this.cbItemTypeDiagram.Size = new System.Drawing.Size(75, 15);
            this.cbItemTypeDiagram.TabIndex = 32;
            this.cbItemTypeDiagram.Text = "item_type";
            this.cbItemTypeDiagram.UseSelectable = true;
            this.cbItemTypeDiagram.CheckedChanged += new System.EventHandler(this.cbItemTypeDiagram_CheckedChanged);
            // 
            // cbItemTypesDiagram
            // 
            this.cbItemTypesDiagram.FormattingEnabled = true;
            this.cbItemTypesDiagram.ItemHeight = 23;
            this.cbItemTypesDiagram.Location = new System.Drawing.Point(315, 42);
            this.cbItemTypesDiagram.Name = "cbItemTypesDiagram";
            this.cbItemTypesDiagram.Size = new System.Drawing.Size(249, 29);
            this.cbItemTypesDiagram.TabIndex = 31;
            this.cbItemTypesDiagram.UseSelectable = true;
            // 
            // btnGenerateDiagram
            // 
            this.btnGenerateDiagram.Location = new System.Drawing.Point(463, 131);
            this.btnGenerateDiagram.Name = "btnGenerateDiagram";
            this.btnGenerateDiagram.Size = new System.Drawing.Size(101, 23);
            this.btnGenerateDiagram.TabIndex = 30;
            this.btnGenerateDiagram.Text = "generate";
            this.btnGenerateDiagram.UseSelectable = true;
            this.btnGenerateDiagram.Click += new System.EventHandler(this.btnGenerateDiagram_Click);
            // 
            // labelErrorDiagram
            // 
            this.labelErrorDiagram.AutoSize = true;
            this.labelErrorDiagram.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDiagram.Location = new System.Drawing.Point(3, 131);
            this.labelErrorDiagram.Name = "labelErrorDiagram";
            this.labelErrorDiagram.Size = new System.Drawing.Size(64, 13);
            this.labelErrorDiagram.TabIndex = 29;
            this.labelErrorDiagram.Text = "invalid_data";
            this.labelErrorDiagram.Visible = false;
            // 
            // mlLabel5
            // 
            this.mlLabel5.AutoSize = true;
            this.mlLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel5.Location = new System.Drawing.Point(315, 74);
            this.mlLabel5.Name = "mlLabel5";
            this.mlLabel5.Size = new System.Drawing.Size(55, 19);
            this.mlLabel5.TabIndex = 28;
            this.mlLabel5.Text = "to_date";
            // 
            // mlLabel6
            // 
            this.mlLabel6.AutoSize = true;
            this.mlLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel6.Location = new System.Drawing.Point(6, 74);
            this.mlLabel6.Name = "mlLabel6";
            this.mlLabel6.Size = new System.Drawing.Size(71, 19);
            this.mlLabel6.TabIndex = 27;
            this.mlLabel6.Text = "from_date";
            // 
            // dtToDiagram
            // 
            this.dtToDiagram.Location = new System.Drawing.Point(315, 96);
            this.dtToDiagram.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtToDiagram.Name = "dtToDiagram";
            this.dtToDiagram.Size = new System.Drawing.Size(249, 29);
            this.dtToDiagram.TabIndex = 26;
            // 
            // dtFromDiagram
            // 
            this.dtFromDiagram.Location = new System.Drawing.Point(5, 96);
            this.dtFromDiagram.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFromDiagram.Name = "dtFromDiagram";
            this.dtFromDiagram.Size = new System.Drawing.Size(250, 29);
            this.dtFromDiagram.TabIndex = 25;
            // 
            // mlLabel4
            // 
            this.mlLabel4.AutoSize = true;
            this.mlLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlLabel4.Location = new System.Drawing.Point(6, 16);
            this.mlLabel4.Name = "mlLabel4";
            this.mlLabel4.Size = new System.Drawing.Size(70, 19);
            this.mlLabel4.TabIndex = 24;
            this.mlLabel4.Text = "report_for";
            // 
            // cbDiagramType
            // 
            this.cbDiagramType.FormattingEnabled = true;
            this.cbDiagramType.ItemHeight = 23;
            this.cbDiagramType.Location = new System.Drawing.Point(5, 42);
            this.cbDiagramType.Name = "cbDiagramType";
            this.cbDiagramType.Size = new System.Drawing.Size(249, 29);
            this.cbDiagramType.TabIndex = 23;
            this.cbDiagramType.UseSelectable = true;
            // 
            // chartMovement
            // 
            this.chartMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartMovement.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMovement.Legends.Add(legend2);
            this.chartMovement.Location = new System.Drawing.Point(6, 160);
            this.chartMovement.Name = "chartMovement";
            this.chartMovement.Size = new System.Drawing.Size(1076, 388);
            this.chartMovement.TabIndex = 0;
            // 
            // ReportGoodsMovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlGroupBox1);
            this.Name = "ReportGoodsMovementControl";
            this.Size = new System.Drawing.Size(1088, 554);
            this.mlGroupBox1.ResumeLayout(false);
            this.mlGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovement;
        private Common.Forms.Base.MLGroupBox mlGroupBox1;
        private Common.Forms.Base.MLCheckBox cbItemTypeDiagram;
        private Common.Forms.Base.MLComboBox cbItemTypesDiagram;
        private Common.Forms.Base.MLButton btnGenerateDiagram;
        private Common.Forms.Base.MLErrorLabel labelErrorDiagram;
        private Common.Forms.Base.MLLabel mlLabel5;
        private Common.Forms.Base.MLLabel mlLabel6;
        private MetroFramework.Controls.MetroDateTime dtToDiagram;
        private MetroFramework.Controls.MetroDateTime dtFromDiagram;
        private Common.Forms.Base.MLLabel mlLabel4;
        private Common.Forms.Base.MLComboBox cbDiagramType;
    }
}
