namespace AgenciaSeguros.Vistas.Componentes
{
  partial class Polizas
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
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.estadoText = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.placaText = new System.Windows.Forms.MaskedTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.anioText = new System.Windows.Forms.MaskedTextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.fechaEmision = new System.Windows.Forms.DateTimePicker();
      this.fechaVencimiento = new System.Windows.Forms.DateTimePicker();
      this.marcaText = new System.Windows.Forms.TextBox();
      this.modeloText = new System.Windows.Forms.TextBox();
      this.colorAutoText = new System.Windows.Forms.TextBox();
      this.clienteCombobox = new System.Windows.Forms.ComboBox();
      this.tipoPolizaText = new System.Windows.Forms.TextBox();
      this.primaNum = new System.Windows.Forms.NumericUpDown();
      this.montoCoberturaNum = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.primaNum)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.montoCoberturaNum)).BeginInit();
      this.SuspendLayout();
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(561, 289);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(49, 20);
      this.label10.TabIndex = 68;
      this.label10.Text = "Prima";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(533, 391);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(148, 20);
      this.label9.TabIndex = 66;
      this.label9.Text = "Monto de cobertura";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(305, 390);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(144, 20);
      this.label8.TabIndex = 64;
      this.label8.Text = "Estado de la Póliza";
      // 
      // estadoText
      // 
      this.estadoText.Location = new System.Drawing.Point(309, 425);
      this.estadoText.MaxLength = 200;
      this.estadoText.Name = "estadoText";
      this.estadoText.Size = new System.Drawing.Size(187, 26);
      this.estadoText.TabIndex = 63;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(218, 289);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(107, 20);
      this.label7.TabIndex = 62;
      this.label7.Text = "Color del auto";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(91, 289);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(111, 20);
      this.label6.TabIndex = 60;
      this.label6.Text = "Placa del Auto";
      // 
      // placaText
      // 
      this.placaText.Location = new System.Drawing.Point(95, 333);
      this.placaText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.placaText.Mask = "AAAAAAA";
      this.placaText.Name = "placaText";
      this.placaText.Size = new System.Drawing.Size(102, 26);
      this.placaText.TabIndex = 59;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(582, 195);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(99, 20);
      this.label4.TabIndex = 58;
      this.label4.Text = "Año del auto";
      // 
      // anioText
      // 
      this.anioText.Location = new System.Drawing.Point(586, 235);
      this.anioText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.anioText.Mask = "0000";
      this.anioText.Name = "anioText";
      this.anioText.Size = new System.Drawing.Size(95, 26);
      this.anioText.TabIndex = 57;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(128, 582);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(245, 43);
      this.button2.TabIndex = 56;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(411, 582);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(245, 43);
      this.btnGuardar.TabIndex = 55;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(339, 195);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(122, 20);
      this.label5.TabIndex = 53;
      this.label5.Text = "Modelo del auto";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(91, 195);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 20);
      this.label3.TabIndex = 51;
      this.label3.Text = "Marca del auto";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(407, 109);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(146, 20);
      this.label2.TabIndex = 50;
      this.label2.Text = "Fecha Vencimiento";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(322, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 20);
      this.label1.TabIndex = 48;
      this.label1.Text = "Registrar póliza";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(356, 288);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(58, 20);
      this.label11.TabIndex = 69;
      this.label11.Text = "Cliente";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(91, 391);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(106, 20);
      this.label12.TabIndex = 70;
      this.label12.Text = "Tipo de póliza";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(91, 109);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(134, 20);
      this.label13.TabIndex = 71;
      this.label13.Text = "Fecha de emisión";
      // 
      // fechaEmision
      // 
      this.fechaEmision.CustomFormat = "dd/MM/yyyy";
      this.fechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.fechaEmision.Location = new System.Drawing.Point(95, 141);
      this.fechaEmision.MaxDate = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      this.fechaEmision.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
      this.fechaEmision.Name = "fechaEmision";
      this.fechaEmision.Size = new System.Drawing.Size(278, 26);
      this.fechaEmision.TabIndex = 72;
      this.fechaEmision.Value = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      // 
      // fechaVencimiento
      // 
      this.fechaVencimiento.CustomFormat = "dd/MM/yyyy";
      this.fechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.fechaVencimiento.Location = new System.Drawing.Point(411, 141);
      this.fechaVencimiento.MaxDate = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      this.fechaVencimiento.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
      this.fechaVencimiento.Name = "fechaVencimiento";
      this.fechaVencimiento.Size = new System.Drawing.Size(270, 26);
      this.fechaVencimiento.TabIndex = 73;
      this.fechaVencimiento.Value = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      // 
      // marcaText
      // 
      this.marcaText.Location = new System.Drawing.Point(95, 235);
      this.marcaText.MaxLength = 200;
      this.marcaText.Name = "marcaText";
      this.marcaText.Size = new System.Drawing.Size(197, 26);
      this.marcaText.TabIndex = 74;
      // 
      // modeloText
      // 
      this.modeloText.Location = new System.Drawing.Point(339, 235);
      this.modeloText.MaxLength = 200;
      this.modeloText.Name = "modeloText";
      this.modeloText.Size = new System.Drawing.Size(194, 26);
      this.modeloText.TabIndex = 75;
      // 
      // colorAutoText
      // 
      this.colorAutoText.Location = new System.Drawing.Point(222, 333);
      this.colorAutoText.MaxLength = 200;
      this.colorAutoText.Name = "colorAutoText";
      this.colorAutoText.Size = new System.Drawing.Size(103, 26);
      this.colorAutoText.TabIndex = 76;
      // 
      // clienteCombobox
      // 
      this.clienteCombobox.FormattingEnabled = true;
      this.clienteCombobox.Location = new System.Drawing.Point(360, 330);
      this.clienteCombobox.Name = "clienteCombobox";
      this.clienteCombobox.Size = new System.Drawing.Size(173, 28);
      this.clienteCombobox.TabIndex = 77;
      // 
      // tipoPolizaText
      // 
      this.tipoPolizaText.Location = new System.Drawing.Point(95, 426);
      this.tipoPolizaText.MaxLength = 200;
      this.tipoPolizaText.Name = "tipoPolizaText";
      this.tipoPolizaText.Size = new System.Drawing.Size(170, 26);
      this.tipoPolizaText.TabIndex = 78;
      // 
      // primaNum
      // 
      this.primaNum.DecimalPlaces = 2;
      this.primaNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.primaNum.Location = new System.Drawing.Point(565, 331);
      this.primaNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
      this.primaNum.Name = "primaNum";
      this.primaNum.Size = new System.Drawing.Size(116, 26);
      this.primaNum.TabIndex = 79;
      this.primaNum.ThousandsSeparator = true;
      // 
      // montoCoberturaNum
      // 
      this.montoCoberturaNum.DecimalPlaces = 2;
      this.montoCoberturaNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.montoCoberturaNum.Location = new System.Drawing.Point(537, 426);
      this.montoCoberturaNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
      this.montoCoberturaNum.Name = "montoCoberturaNum";
      this.montoCoberturaNum.Size = new System.Drawing.Size(144, 26);
      this.montoCoberturaNum.TabIndex = 80;
      this.montoCoberturaNum.ThousandsSeparator = true;
      // 
      // Polizas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(796, 697);
      this.Controls.Add(this.montoCoberturaNum);
      this.Controls.Add(this.primaNum);
      this.Controls.Add(this.tipoPolizaText);
      this.Controls.Add(this.clienteCombobox);
      this.Controls.Add(this.colorAutoText);
      this.Controls.Add(this.modeloText);
      this.Controls.Add(this.marcaText);
      this.Controls.Add(this.fechaVencimiento);
      this.Controls.Add(this.fechaEmision);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.estadoText);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.placaText);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.anioText);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Polizas";
      this.Text = "Polizas";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.primaNum)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.montoCoberturaNum)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox estadoText;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox placaText;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.MaskedTextBox anioText;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.DateTimePicker fechaEmision;
    private System.Windows.Forms.TextBox modeloText;
    private System.Windows.Forms.TextBox marcaText;
    private System.Windows.Forms.TextBox colorAutoText;
    private System.Windows.Forms.NumericUpDown primaNum;
    private System.Windows.Forms.TextBox tipoPolizaText;
    private System.Windows.Forms.ComboBox clienteCombobox;
    private System.Windows.Forms.NumericUpDown montoCoberturaNum;
    private System.Windows.Forms.DateTimePicker fechaVencimiento;
  }
}