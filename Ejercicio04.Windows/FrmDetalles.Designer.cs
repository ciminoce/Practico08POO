namespace Ejercicio04.Windows
{
    partial class FrmDetalles
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
            lblFechaVto = new Label();
            ChkEsAlcoholica = new CheckBox();
            BtnOK = new Button();
            TxtNombre = new TextBox();
            label3 = new Label();
            TxtFechaVto = new TextBox();
            TxtStock = new TextBox();
            TxtPrecioBase = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtTipoProducto = new TextBox();
            TxtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ChkEsBiodegradable
            // 
            ChkEsBiodegradable.AutoSize = true;
            ChkEsBiodegradable.Location = new Point(67, 211);
            ChkEsBiodegradable.Name = "ChkEsBiodegradable";
            ChkEsBiodegradable.Size = new Size(126, 19);
            ChkEsBiodegradable.TabIndex = 50;
            ChkEsBiodegradable.Text = "¿Es Biodegradable?";
            ChkEsBiodegradable.UseVisualStyleBackColor = true;
            // 
            // lblFechaVto
            // 
            lblFechaVto.AutoSize = true;
            lblFechaVto.Location = new Point(453, 151);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(62, 15);
            lblFechaVto.TabIndex = 49;
            lblFechaVto.Text = "Fecha Vto:";
            // 
            // ChkEsAlcoholica
            // 
            ChkEsAlcoholica.AutoSize = true;
            ChkEsAlcoholica.Location = new Point(67, 186);
            ChkEsAlcoholica.Name = "ChkEsAlcoholica";
            ChkEsAlcoholica.Size = new Size(106, 19);
            ChkEsAlcoholica.TabIndex = 48;
            ChkEsAlcoholica.Text = "¿Es Alcohólica?";
            ChkEsAlcoholica.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(261, 259);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 47;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(141, 107);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.ReadOnly = true;
            TxtNombre.Size = new Size(354, 23);
            TxtNombre.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 110);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 36;
            label3.Text = "Nombre:";
            // 
            // TxtFechaVto
            // 
            TxtFechaVto.Location = new Point(531, 148);
            TxtFechaVto.Name = "TxtFechaVto";
            TxtFechaVto.ReadOnly = true;
            TxtFechaVto.Size = new Size(100, 23);
            TxtFechaVto.TabIndex = 41;
            // 
            // TxtStock
            // 
            TxtStock.Location = new Point(317, 147);
            TxtStock.Name = "TxtStock";
            TxtStock.ReadOnly = true;
            TxtStock.Size = new Size(100, 23);
            TxtStock.TabIndex = 42;
            // 
            // TxtPrecioBase
            // 
            TxtPrecioBase.Location = new Point(141, 147);
            TxtPrecioBase.Name = "TxtPrecioBase";
            TxtPrecioBase.ReadOnly = true;
            TxtPrecioBase.Size = new Size(100, 23);
            TxtPrecioBase.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 150);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 37;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 150);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 38;
            label4.Text = "Precio Base:";
            // 
            // TxtTipoProducto
            // 
            TxtTipoProducto.Location = new Point(141, 23);
            TxtTipoProducto.Name = "TxtTipoProducto";
            TxtTipoProducto.ReadOnly = true;
            TxtTipoProducto.Size = new Size(231, 23);
            TxtTipoProducto.TabIndex = 44;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(141, 69);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.ReadOnly = true;
            TxtCodigo.Size = new Size(100, 23);
            TxtCodigo.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 39;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 35;
            label1.Text = "Tipo de Producto:";
            // 
            // FrmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 335);
            Controls.Add(ChkEsBiodegradable);
            Controls.Add(lblFechaVto);
            Controls.Add(ChkEsAlcoholica);
            Controls.Add(BtnOK);
            Controls.Add(TxtNombre);
            Controls.Add(label3);
            Controls.Add(TxtFechaVto);
            Controls.Add(TxtStock);
            Controls.Add(TxtPrecioBase);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtTipoProducto);
            Controls.Add(TxtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDetalles";
            Text = "FrmDetalles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkEsBiodegradable;
        private Label lblFechaVto;
        private CheckBox ChkEsAlcoholica;
        private Button BtnOK;
        private TextBox TxtNombre;
        private Label label3;
        private TextBox TxtFechaVto;
        private TextBox TxtStock;
        private TextBox TxtPrecioBase;
        private Label label5;
        private Label label4;
        private TextBox TxtTipoProducto;
        private TextBox TxtCodigo;
        private Label label2;
        private Label label1;
    }
}