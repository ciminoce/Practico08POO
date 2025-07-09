namespace Ejercicio04.Windows
{
    partial class FrmProductosAE
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
            label1 = new Label();
            CboTipoProducto = new ComboBox();
            label2 = new Label();
            TxtCodigo = new TextBox();
            label3 = new Label();
            TxtNombre = new TextBox();
            label4 = new Label();
            TxtPrecioBase = new TextBox();
            label5 = new Label();
            NudStock = new NumericUpDown();
            BtnCancelar = new Button();
            BtnOK = new Button();
            ChkEsAlcoholica = new CheckBox();
            DtpFechaVencimiento = new DateTimePicker();
            lblFechaVto = new Label();
            ChkEsBiodegradable = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)NudStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 36);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Producto:";
            // 
            // CboTipoProducto
            // 
            CboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoProducto.FormattingEnabled = true;
            CboTipoProducto.Location = new Point(162, 33);
            CboTipoProducto.Name = "CboTipoProducto";
            CboTipoProducto.Size = new Size(121, 23);
            CboTipoProducto.TabIndex = 1;
            CboTipoProducto.SelectedIndexChanged += CboTipoProducto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Código:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(160, 79);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 120);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(160, 117);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(354, 23);
            TxtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 160);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "Precio Base:";
            // 
            // TxtPrecioBase
            // 
            TxtPrecioBase.Location = new Point(160, 157);
            TxtPrecioBase.Name = "TxtPrecioBase";
            TxtPrecioBase.Size = new Size(100, 23);
            TxtPrecioBase.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 160);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Stock:";
            // 
            // NudStock
            // 
            NudStock.Location = new Point(332, 161);
            NudStock.Name = "NudStock";
            NudStock.Size = new Size(120, 23);
            NudStock.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(439, 253);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 52);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(62, 253);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 14;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // ChkEsAlcoholica
            // 
            ChkEsAlcoholica.AutoSize = true;
            ChkEsAlcoholica.Location = new Point(75, 207);
            ChkEsAlcoholica.Name = "ChkEsAlcoholica";
            ChkEsAlcoholica.Size = new Size(106, 19);
            ChkEsAlcoholica.TabIndex = 15;
            ChkEsAlcoholica.Text = "¿Es Alcohólica?";
            ChkEsAlcoholica.UseVisualStyleBackColor = true;
            // 
            // DtpFechaVencimiento
            // 
            DtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            DtpFechaVencimiento.Location = new Point(413, 207);
            DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            DtpFechaVencimiento.Size = new Size(122, 23);
            DtpFechaVencimiento.TabIndex = 17;
            // 
            // lblFechaVto
            // 
            lblFechaVto.AutoSize = true;
            lblFechaVto.Location = new Point(333, 208);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(62, 15);
            lblFechaVto.TabIndex = 16;
            lblFechaVto.Text = "Fecha Vto:";
            // 
            // ChkEsBiodegradable
            // 
            ChkEsBiodegradable.AutoSize = true;
            ChkEsBiodegradable.Location = new Point(193, 207);
            ChkEsBiodegradable.Name = "ChkEsBiodegradable";
            ChkEsBiodegradable.Size = new Size(126, 19);
            ChkEsBiodegradable.TabIndex = 18;
            ChkEsBiodegradable.Text = "¿Es Biodegradable?";
            ChkEsBiodegradable.UseVisualStyleBackColor = true;
            // 
            // FrmProductosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 324);
            Controls.Add(ChkEsBiodegradable);
            Controls.Add(DtpFechaVencimiento);
            Controls.Add(lblFechaVto);
            Controls.Add(ChkEsAlcoholica);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Controls.Add(NudStock);
            Controls.Add(TxtNombre);
            Controls.Add(label3);
            Controls.Add(TxtPrecioBase);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtCodigo);
            Controls.Add(label2);
            Controls.Add(CboTipoProducto);
            Controls.Add(label1);
            Name = "FrmProductosAE";
            Text = "FrmProductoAE";
            ((System.ComponentModel.ISupportInitialize)NudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CboTipoProducto;
        private Label label2;
        private TextBox TxtCodigo;
        private Label label3;
        private TextBox TxtNombre;
        private Label label4;
        private TextBox TxtPrecioBase;
        private Label label5;
        private NumericUpDown NudStock;
        private Button BtnCancelar;
        private Button BtnOK;
        private CheckBox ChkEsAlcoholica;
        private DateTimePicker DtpFechaVencimiento;
        private Label lblFechaVto;
        private CheckBox ChkEsBiodegradable;
    }
}