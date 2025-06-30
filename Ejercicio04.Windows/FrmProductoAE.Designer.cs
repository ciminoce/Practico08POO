namespace Ejercicio04.Windows
{
    partial class FrmProductoAE
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
            ChkEsBiodegradable = new CheckBox();
            DtpFechaVencimiento = new DateTimePicker();
            lblFechaVto = new Label();
            ChkEsAlcoholica = new CheckBox();
            BtnCancelar = new Button();
            BtnOK = new Button();
            NudStock = new NumericUpDown();
            TxtNombre = new TextBox();
            label3 = new Label();
            TxtPrecioBase = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtCodigo = new TextBox();
            label2 = new Label();
            CboTipoProducto = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NudStock).BeginInit();
            SuspendLayout();
            // 
            // ChkEsBiodegradable
            // 
            ChkEsBiodegradable.AutoSize = true;
            ChkEsBiodegradable.Location = new Point(195, 202);
            ChkEsBiodegradable.Name = "ChkEsBiodegradable";
            ChkEsBiodegradable.Size = new Size(126, 19);
            ChkEsBiodegradable.TabIndex = 34;
            ChkEsBiodegradable.Text = "¿Es Biodegradable?";
            ChkEsBiodegradable.UseVisualStyleBackColor = true;
            // 
            // DtpFechaVencimiento
            // 
            DtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            DtpFechaVencimiento.Location = new Point(415, 202);
            DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            DtpFechaVencimiento.Size = new Size(122, 23);
            DtpFechaVencimiento.TabIndex = 33;
            // 
            // lblFechaVto
            // 
            lblFechaVto.AutoSize = true;
            lblFechaVto.Location = new Point(335, 203);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(62, 15);
            lblFechaVto.TabIndex = 32;
            lblFechaVto.Text = "Fecha Vto:";
            // 
            // ChkEsAlcoholica
            // 
            ChkEsAlcoholica.AutoSize = true;
            ChkEsAlcoholica.Location = new Point(77, 202);
            ChkEsAlcoholica.Name = "ChkEsAlcoholica";
            ChkEsAlcoholica.Size = new Size(106, 19);
            ChkEsAlcoholica.TabIndex = 31;
            ChkEsAlcoholica.Text = "¿Es Alcohólica?";
            ChkEsAlcoholica.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(441, 248);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 52);
            BtnCancelar.TabIndex = 29;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(64, 248);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 30;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            // 
            // NudStock
            // 
            NudStock.Location = new Point(334, 156);
            NudStock.Name = "NudStock";
            NudStock.Size = new Size(120, 23);
            NudStock.TabIndex = 28;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(162, 112);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(354, 23);
            TxtNombre.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 115);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 21;
            label3.Text = "Nombre:";
            // 
            // TxtPrecioBase
            // 
            TxtPrecioBase.Location = new Point(162, 152);
            TxtPrecioBase.Name = "TxtPrecioBase";
            TxtPrecioBase.Size = new Size(100, 23);
            TxtPrecioBase.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 155);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 22;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 155);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 23;
            label4.Text = "Precio Base:";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(162, 74);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 24;
            label2.Text = "Código:";
            // 
            // CboTipoProducto
            // 
            CboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoProducto.FormattingEnabled = true;
            CboTipoProducto.Location = new Point(164, 28);
            CboTipoProducto.Name = "CboTipoProducto";
            CboTipoProducto.Size = new Size(121, 23);
            CboTipoProducto.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 19;
            label1.Text = "Tipo de Producto:";
            // 
            // FrmProductoAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 325);
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
            Name = "FrmProductoAE";
            Text = "FrmProductoAE";
            ((System.ComponentModel.ISupportInitialize)NudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkEsBiodegradable;
        private DateTimePicker DtpFechaVencimiento;
        private Label lblFechaVto;
        private CheckBox ChkEsAlcoholica;
        private Button BtnCancelar;
        private Button BtnOK;
        private NumericUpDown NudStock;
        private TextBox TxtNombre;
        private Label label3;
        private TextBox TxtPrecioBase;
        private Label label5;
        private Label label4;
        private TextBox TxtCodigo;
        private Label label2;
        private ComboBox CboTipoProducto;
        private Label label1;
    }
}