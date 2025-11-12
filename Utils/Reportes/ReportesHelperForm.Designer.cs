namespace p_proyect.Utils.Reportes
{
    partial class ReportesHelperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesHelperForm));
            this.ListadoParaReportesShow = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.FechaDeInicioDelReporte = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.FechaDeFinalizacionDelReporte = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoParaReportesShow)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoParaReportesShow
            // 
            this.ListadoParaReportesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoParaReportesShow.Location = new System.Drawing.Point(36, 129);
            this.ListadoParaReportesShow.Name = "ListadoParaReportesShow";
            this.ListadoParaReportesShow.Size = new System.Drawing.Size(903, 437);
            this.ListadoParaReportesShow.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(33, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(199, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Informacion Para El Reporte";
            // 
            // FechaDeInicioDelReporte
            // 
            this.FechaDeInicioDelReporte.BackColor = System.Drawing.Color.Transparent;
            this.FechaDeInicioDelReporte.BorderColor = System.Drawing.Color.Silver;
            this.FechaDeInicioDelReporte.BorderRadius = 1;
            this.FechaDeInicioDelReporte.Color = System.Drawing.Color.Silver;
            this.FechaDeInicioDelReporte.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.FechaDeInicioDelReporte.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.FechaDeInicioDelReporte.DisabledColor = System.Drawing.Color.Gray;
            this.FechaDeInicioDelReporte.DisplayWeekNumbers = false;
            this.FechaDeInicioDelReporte.DPHeight = 0;
            this.FechaDeInicioDelReporte.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FechaDeInicioDelReporte.FillDatePicker = false;
            this.FechaDeInicioDelReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FechaDeInicioDelReporte.ForeColor = System.Drawing.Color.Black;
            this.FechaDeInicioDelReporte.Icon = ((System.Drawing.Image)(resources.GetObject("FechaDeInicioDelReporte.Icon")));
            this.FechaDeInicioDelReporte.IconColor = System.Drawing.Color.Gray;
            this.FechaDeInicioDelReporte.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.FechaDeInicioDelReporte.LeftTextMargin = 5;
            this.FechaDeInicioDelReporte.Location = new System.Drawing.Point(36, 613);
            this.FechaDeInicioDelReporte.MinimumSize = new System.Drawing.Size(4, 32);
            this.FechaDeInicioDelReporte.Name = "FechaDeInicioDelReporte";
            this.FechaDeInicioDelReporte.Size = new System.Drawing.Size(280, 32);
            this.FechaDeInicioDelReporte.TabIndex = 2;
            this.FechaDeInicioDelReporte.Value = new System.DateTime(2025, 11, 11, 0, 0, 0, 0);
            this.FechaDeInicioDelReporte.ValueChanged += new System.EventHandler(this.FechaDeInicioDelReporte_ValueChanged);
            // 
            // FechaDeFinalizacionDelReporte
            // 
            this.FechaDeFinalizacionDelReporte.BackColor = System.Drawing.Color.Transparent;
            this.FechaDeFinalizacionDelReporte.BorderColor = System.Drawing.Color.Silver;
            this.FechaDeFinalizacionDelReporte.BorderRadius = 1;
            this.FechaDeFinalizacionDelReporte.Color = System.Drawing.Color.Silver;
            this.FechaDeFinalizacionDelReporte.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.FechaDeFinalizacionDelReporte.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.FechaDeFinalizacionDelReporte.DisabledColor = System.Drawing.Color.Gray;
            this.FechaDeFinalizacionDelReporte.DisplayWeekNumbers = false;
            this.FechaDeFinalizacionDelReporte.DPHeight = 0;
            this.FechaDeFinalizacionDelReporte.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FechaDeFinalizacionDelReporte.FillDatePicker = false;
            this.FechaDeFinalizacionDelReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FechaDeFinalizacionDelReporte.ForeColor = System.Drawing.Color.Black;
            this.FechaDeFinalizacionDelReporte.Icon = ((System.Drawing.Image)(resources.GetObject("FechaDeFinalizacionDelReporte.Icon")));
            this.FechaDeFinalizacionDelReporte.IconColor = System.Drawing.Color.Gray;
            this.FechaDeFinalizacionDelReporte.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.FechaDeFinalizacionDelReporte.LeftTextMargin = 5;
            this.FechaDeFinalizacionDelReporte.Location = new System.Drawing.Point(322, 613);
            this.FechaDeFinalizacionDelReporte.MinimumSize = new System.Drawing.Size(4, 32);
            this.FechaDeFinalizacionDelReporte.Name = "FechaDeFinalizacionDelReporte";
            this.FechaDeFinalizacionDelReporte.Size = new System.Drawing.Size(297, 32);
            this.FechaDeFinalizacionDelReporte.TabIndex = 3;
            this.FechaDeFinalizacionDelReporte.Value = new System.DateTime(2025, 11, 11, 0, 0, 0, 0);
            this.FechaDeFinalizacionDelReporte.ValueChanged += new System.EventHandler(this.FechaDeFinalizacionDelReporte_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(33, 581);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(185, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Fecha de inicio del reporte";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(260, 582);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(230, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Fecha de finalizacion del reporte";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(36, 654);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(235, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Generar a partir de fechas";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(279, 654);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(340, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "Generar Reporte de todos los registros";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(627, 654);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(242, 36);
            this.materialButton3.TabIndex = 9;
            this.materialButton3.Text = "Cargar todos los registros";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // ReportesHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 735);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.FechaDeFinalizacionDelReporte);
            this.Controls.Add(this.FechaDeInicioDelReporte);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ListadoParaReportesShow);
            this.Name = "ReportesHelperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.ReportesHelperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoParaReportesShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoParaReportesShow;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.UI.WinForms.BunifuDatePicker FechaDeInicioDelReporte;
        private Bunifu.UI.WinForms.BunifuDatePicker FechaDeFinalizacionDelReporte;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}