namespace Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TLP_general = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BT_generarP = new System.Windows.Forms.Button();
            this.BT_partiJ = new System.Windows.Forms.Button();
            this.BT_infoEq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PA_principal = new System.Windows.Forms.Panel();
            this.TLP_general.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_general
            // 
            this.TLP_general.AutoSize = true;
            this.TLP_general.ColumnCount = 1;
            this.TLP_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_general.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TLP_general.Controls.Add(this.PA_principal, 0, 1);
            this.TLP_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_general.Location = new System.Drawing.Point(0, 0);
            this.TLP_general.Name = "TLP_general";
            this.TLP_general.RowCount = 2;
            this.TLP_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP_general.Size = new System.Drawing.Size(857, 532);
            this.TLP_general.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BT_generarP, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BT_partiJ, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BT_infoEq, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BT_generarP
            // 
            this.BT_generarP.BackColor = System.Drawing.SystemColors.Highlight;
            this.BT_generarP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_generarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_generarP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_generarP.Location = new System.Drawing.Point(3, 3);
            this.BT_generarP.Name = "BT_generarP";
            this.BT_generarP.Size = new System.Drawing.Size(75, 49);
            this.BT_generarP.TabIndex = 0;
            this.BT_generarP.Text = "Partidos";
            this.BT_generarP.UseVisualStyleBackColor = false;
            this.BT_generarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_partiJ
            // 
            this.BT_partiJ.BackColor = System.Drawing.SystemColors.Highlight;
            this.BT_partiJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_partiJ.Location = new System.Drawing.Point(84, 3);
            this.BT_partiJ.Name = "BT_partiJ";
            this.BT_partiJ.Size = new System.Drawing.Size(80, 49);
            this.BT_partiJ.TabIndex = 1;
            this.BT_partiJ.Text = "Partidos Jugados";
            this.BT_partiJ.UseVisualStyleBackColor = false;
            this.BT_partiJ.Click += new System.EventHandler(this.BT_partiJ_Click);
            // 
            // BT_infoEq
            // 
            this.BT_infoEq.BackColor = System.Drawing.SystemColors.Highlight;
            this.BT_infoEq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_infoEq.Location = new System.Drawing.Point(170, 3);
            this.BT_infoEq.Name = "BT_infoEq";
            this.BT_infoEq.Size = new System.Drawing.Size(80, 49);
            this.BT_infoEq.TabIndex = 2;
            this.BT_infoEq.Text = "Informacion Equipos";
            this.BT_infoEq.UseVisualStyleBackColor = false;
            this.BT_infoEq.Click += new System.EventHandler(this.BT_infoEq_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(256, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Jugadores con targetas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(354, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cerrar Programa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PA_principal
            // 
            this.PA_principal.AutoSize = true;
            this.PA_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PA_principal.Location = new System.Drawing.Point(3, 64);
            this.PA_principal.Name = "PA_principal";
            this.PA_principal.Size = new System.Drawing.Size(851, 465);
            this.PA_principal.TabIndex = 1;
            this.PA_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.PA_principal_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 532);
            this.ControlBox = false;
            this.Controls.Add(this.TLP_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.TLP_general.ResumeLayout(false);
            this.TLP_general.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_general;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BT_generarP;
        private System.Windows.Forms.Button BT_partiJ;
        private System.Windows.Forms.Button BT_infoEq;
        private System.Windows.Forms.Panel PA_principal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}