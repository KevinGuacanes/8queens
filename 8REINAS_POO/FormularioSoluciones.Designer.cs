namespace _8REINAS_POO
{
    partial class FormularioSoluciones
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
            this.lblSolucion2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSoluciones = new System.Windows.Forms.ComboBox();
            this.btnSolucionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSolucion2
            // 
            this.lblSolucion2.AutoSize = true;
            this.lblSolucion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolucion2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSolucion2.Location = new System.Drawing.Point(241, 9);
            this.lblSolucion2.Name = "lblSolucion2";
            this.lblSolucion2.Size = new System.Drawing.Size(175, 21);
            this.lblSolucion2.TabIndex = 1;
            this.lblSolucion2.Text = "MOSTRAR SOLUCIÓN ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 391);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbSoluciones
            // 
            this.cbSoluciones.FormattingEnabled = true;
            this.cbSoluciones.Location = new System.Drawing.Point(148, 77);
            this.cbSoluciones.Name = "cbSoluciones";
            this.cbSoluciones.Size = new System.Drawing.Size(343, 23);
            this.cbSoluciones.TabIndex = 5;
            this.cbSoluciones.SelectedIndexChanged += new System.EventHandler(this.cbSoluciones_SelectedIndexChanged);
            // 
            // btnSolucionar
            // 
            this.btnSolucionar.Location = new System.Drawing.Point(525, 77);
            this.btnSolucionar.Name = "btnSolucionar";
            this.btnSolucionar.Size = new System.Drawing.Size(75, 23);
            this.btnSolucionar.TabIndex = 6;
            this.btnSolucionar.Text = "RESOLVER";
            this.btnSolucionar.UseVisualStyleBackColor = true;
            this.btnSolucionar.Click += new System.EventHandler(this.btnSolucionar_Click);
            // 
            // FormularioSoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(666, 534);
            this.Controls.Add(this.btnSolucionar);
            this.Controls.Add(this.cbSoluciones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSolucion2);
            this.Name = "FormularioSoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioSoluciones";
            this.Load += new System.EventHandler(this.FormularioSoluciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblSolucion2;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbSoluciones;
        private Button btnSolucionar;
    }
}