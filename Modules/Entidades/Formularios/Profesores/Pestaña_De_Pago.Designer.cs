namespace p_proyect.Modules.Entidades.Formularios.Profesores
{
        partial class Pestaña_De_Pago
        {
                /// <summary>
                /// Required designer variable.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                /// Clean up any resources being used.
                /// </summary>
                /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
                protected override void Dispose( bool disposing ) {
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
                private void InitializeComponent() {
                        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                        System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
                        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
                        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pestaña_De_Pago));
                        this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
                        this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
                        this.label_nombre = new Bunifu.UI.WinForms.BunifuLabel();
                        this.label_cantidad_estudiantes = new Bunifu.UI.WinForms.BunifuLabel();
                        this.label_Cursos_impartidos = new Bunifu.UI.WinForms.BunifuLabel();
                        this.label_Total_A_Pagar = new Bunifu.UI.WinForms.BunifuLabel();
                        this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
                        this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
                        ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
                        this.materialCard1.SuspendLayout();
                        this.SuspendLayout();
                        // 
                        // chart1
                        // 
                        chartArea3.Name = "ChartArea1";
                        this.chart1.ChartAreas.Add(chartArea3);
                        legend3.Name = "Legend1";
                        this.chart1.Legends.Add(legend3);
                        this.chart1.Location = new System.Drawing.Point(17, 392);
                        this.chart1.Name = "chart1";
                        this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
                        series3.ChartArea = "ChartArea1";
                        series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        series3.Legend = "Legend1";
                        series3.Name = "Series1";
                        this.chart1.Series.Add(series3);
                        this.chart1.Size = new System.Drawing.Size(506, 338);
                        this.chart1.TabIndex = 0;
                        this.chart1.Text = "chart1";
                        // 
                        // materialCard1
                        // 
                        this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                        this.materialCard1.Controls.Add(this.materialButton1);
                        this.materialCard1.Controls.Add(this.materialFloatingActionButton1);
                        this.materialCard1.Controls.Add(this.label_Total_A_Pagar);
                        this.materialCard1.Controls.Add(this.label_Cursos_impartidos);
                        this.materialCard1.Controls.Add(this.label_cantidad_estudiantes);
                        this.materialCard1.Controls.Add(this.label_nombre);
                        this.materialCard1.Depth = 0;
                        this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        this.materialCard1.Location = new System.Drawing.Point(17, 78);
                        this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
                        this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialCard1.Name = "materialCard1";
                        this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
                        this.materialCard1.Size = new System.Drawing.Size(506, 297);
                        this.materialCard1.TabIndex = 1;
                        // 
                        // label_nombre
                        // 
                        this.label_nombre.AllowParentOverrides = false;
                        this.label_nombre.AutoEllipsis = false;
                        this.label_nombre.AutoSize = false;
                        this.label_nombre.CursorType = null;
                        this.label_nombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
                        this.label_nombre.ForeColor = System.Drawing.Color.MediumTurquoise;
                        this.label_nombre.Location = new System.Drawing.Point(17, 17);
                        this.label_nombre.Name = "label_nombre";
                        this.label_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.label_nombre.Size = new System.Drawing.Size(260, 74);
                        this.label_nombre.TabIndex = 2;
                        this.label_nombre.Text = "bunifuLabel1";
                        this.label_nombre.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
                        this.label_nombre.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
                        // 
                        // label_cantidad_estudiantes
                        // 
                        this.label_cantidad_estudiantes.AllowParentOverrides = false;
                        this.label_cantidad_estudiantes.AutoEllipsis = false;
                        this.label_cantidad_estudiantes.AutoSize = false;
                        this.label_cantidad_estudiantes.CursorType = null;
                        this.label_cantidad_estudiantes.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
                        this.label_cantidad_estudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                        this.label_cantidad_estudiantes.Location = new System.Drawing.Point(17, 97);
                        this.label_cantidad_estudiantes.Name = "label_cantidad_estudiantes";
                        this.label_cantidad_estudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.label_cantidad_estudiantes.Size = new System.Drawing.Size(260, 66);
                        this.label_cantidad_estudiantes.TabIndex = 3;
                        this.label_cantidad_estudiantes.Text = "bunifuLabel1";
                        this.label_cantidad_estudiantes.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
                        this.label_cantidad_estudiantes.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
                        // 
                        // label_Cursos_impartidos
                        // 
                        this.label_Cursos_impartidos.AllowParentOverrides = false;
                        this.label_Cursos_impartidos.AutoEllipsis = false;
                        this.label_Cursos_impartidos.AutoSize = false;
                        this.label_Cursos_impartidos.CursorType = null;
                        this.label_Cursos_impartidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
                        this.label_Cursos_impartidos.ForeColor = System.Drawing.Color.LightSeaGreen;
                        this.label_Cursos_impartidos.Location = new System.Drawing.Point(17, 169);
                        this.label_Cursos_impartidos.Name = "label_Cursos_impartidos";
                        this.label_Cursos_impartidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.label_Cursos_impartidos.Size = new System.Drawing.Size(260, 45);
                        this.label_Cursos_impartidos.TabIndex = 4;
                        this.label_Cursos_impartidos.Text = "bunifuLabel1";
                        this.label_Cursos_impartidos.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
                        this.label_Cursos_impartidos.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
                        // 
                        // label_Total_A_Pagar
                        // 
                        this.label_Total_A_Pagar.AllowParentOverrides = false;
                        this.label_Total_A_Pagar.AutoEllipsis = false;
                        this.label_Total_A_Pagar.AutoSize = false;
                        this.label_Total_A_Pagar.CursorType = null;
                        this.label_Total_A_Pagar.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
                        this.label_Total_A_Pagar.ForeColor = System.Drawing.Color.DarkOrange;
                        this.label_Total_A_Pagar.Location = new System.Drawing.Point(17, 220);
                        this.label_Total_A_Pagar.Name = "label_Total_A_Pagar";
                        this.label_Total_A_Pagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
                        this.label_Total_A_Pagar.Size = new System.Drawing.Size(260, 60);
                        this.label_Total_A_Pagar.TabIndex = 5;
                        this.label_Total_A_Pagar.Text = "bunifuLabel1";
                        this.label_Total_A_Pagar.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
                        this.label_Total_A_Pagar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
                        // 
                        // materialFloatingActionButton1
                        // 
                        this.materialFloatingActionButton1.Depth = 0;
                        this.materialFloatingActionButton1.Icon = global::p_proyect.Properties.Resources.logotipo_de_whatsapp;
                        this.materialFloatingActionButton1.Location = new System.Drawing.Point(432, 65);
                        this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
                        this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
                        this.materialFloatingActionButton1.TabIndex = 33;
                        this.materialFloatingActionButton1.Text = "Escribir a whattsap";
                        this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
                        this.materialFloatingActionButton1.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
                        // 
                        // materialButton1
                        // 
                        this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                        this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                        this.materialButton1.Depth = 0;
                        this.materialButton1.HighEmphasis = true;
                        this.materialButton1.Icon = global::p_proyect.Properties.Resources.Descripcion1;
                        this.materialButton1.Location = new System.Drawing.Point(388, 20);
                        this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                        this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
                        this.materialButton1.Name = "materialButton1";
                        this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
                        this.materialButton1.Size = new System.Drawing.Size(100, 36);
                        this.materialButton1.TabIndex = 34;
                        this.materialButton1.Text = "recibo";
                        this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                        this.materialButton1.UseAccentColor = false;
                        this.materialButton1.UseVisualStyleBackColor = true;
                        // 
                        // Pestaña_De_Pago
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(540, 736);
                        this.Controls.Add(this.materialCard1);
                        this.Controls.Add(this.chart1);
                        this.Name = "Pestaña_De_Pago";
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                        this.Text = "Pestaña De Pago";
                        this.Load += new System.EventHandler(this.Pestaña_De_Pago_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
                        this.materialCard1.ResumeLayout(false);
                        this.materialCard1.PerformLayout();
                        this.ResumeLayout(false);

                }

                #endregion

                private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
                private MaterialSkin.Controls.MaterialCard materialCard1;
                private Bunifu.UI.WinForms.BunifuLabel label_cantidad_estudiantes;
                private Bunifu.UI.WinForms.BunifuLabel label_nombre;
                private Bunifu.UI.WinForms.BunifuLabel label_Cursos_impartidos;
                private Bunifu.UI.WinForms.BunifuLabel label_Total_A_Pagar;
                private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
                private MaterialSkin.Controls.MaterialButton materialButton1;
        }
}