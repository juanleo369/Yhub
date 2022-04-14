
namespace Win.yahoohub
{
    partial class FormEmpleados
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label deparmentoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label metodoIdLabel;
            System.Windows.Forms.Label puestoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.puestoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaMetodoPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.deparmentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.listaEmpleadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaEmpleadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            deparmentoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            metodoIdLabel = new System.Windows.Forms.Label();
            puestoIdLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetodoPagosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingNavigator)).BeginInit();
            this.listaEmpleadosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(134, 132);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(99, 24);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Apellido:";
            apellidoLabel.Click += new System.EventHandler(this.apellidoLabel_Click);
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(149, 287);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(87, 24);
            ciudadLabel.TabIndex = 4;
            ciudadLabel.Text = "Ciudad:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(152, 326);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(84, 24);
            correoLabel.TabIndex = 6;
            correoLabel.Text = "Correo:";
            // 
            // deparmentoLabel
            // 
            deparmentoLabel.AutoSize = true;
            deparmentoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deparmentoLabel.Location = new System.Drawing.Point(94, 365);
            deparmentoLabel.Name = "deparmentoLabel";
            deparmentoLabel.Size = new System.Drawing.Size(142, 24);
            deparmentoLabel.TabIndex = 8;
            deparmentoLabel.Text = "Deparmento:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(228, 379);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(105, 24);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "Dirección";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(159, 485);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(77, 24);
            fechaLabel.TabIndex = 12;
            fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(190, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 24);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(135, 95);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(97, 24);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rTNLabel.Location = new System.Drawing.Point(45, 170);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(189, 24);
            rTNLabel.TabIndex = 24;
            rTNLabel.Text = "RTN/IDENTIDAD:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salarioLabel.Location = new System.Drawing.Point(147, 206);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(87, 24);
            salarioLabel.TabIndex = 26;
            salarioLabel.Text = "Salario:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(131, 249);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(104, 24);
            telefonoLabel.TabIndex = 28;
            telefonoLabel.Text = "Teléfono:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(156, 531);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(80, 24);
            activoLabel.TabIndex = 29;
            activoLabel.Text = "Activo:";
            // 
            // metodoIdLabel
            // 
            metodoIdLabel.AutoSize = true;
            metodoIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            metodoIdLabel.Location = new System.Drawing.Point(57, 407);
            metodoIdLabel.Name = "metodoIdLabel";
            metodoIdLabel.Size = new System.Drawing.Size(179, 24);
            metodoIdLabel.TabIndex = 30;
            metodoIdLabel.Text = "Método de Pago:";
            // 
            // puestoIdLabel
            // 
            puestoIdLabel.AutoSize = true;
            puestoIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puestoIdLabel.Location = new System.Drawing.Point(150, 443);
            puestoIdLabel.Name = "puestoIdLabel";
            puestoIdLabel.Size = new System.Drawing.Size(85, 24);
            puestoIdLabel.TabIndex = 31;
            puestoIdLabel.Text = "Puesto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(31, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE EMPLEADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(puestoIdLabel);
            this.groupBox1.Controls.Add(this.puestoIdComboBox);
            this.groupBox1.Controls.Add(metodoIdLabel);
            this.groupBox1.Controls.Add(this.metodoIdComboBox);
            this.groupBox1.Controls.Add(activoLabel);
            this.groupBox1.Controls.Add(this.activoCheckBox1);
            this.groupBox1.Controls.Add(apellidoLabel);
            this.groupBox1.Controls.Add(this.apellidoTextBox);
            this.groupBox1.Controls.Add(ciudadLabel);
            this.groupBox1.Controls.Add(this.ciudadTextBox);
            this.groupBox1.Controls.Add(correoLabel);
            this.groupBox1.Controls.Add(this.correoTextBox);
            this.groupBox1.Controls.Add(deparmentoLabel);
            this.groupBox1.Controls.Add(this.deparmentoTextBox);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(rTNLabel);
            this.groupBox1.Controls.Add(this.rTNTextBox);
            this.groupBox1.Controls.Add(salarioLabel);
            this.groupBox1.Controls.Add(this.salarioTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 691);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // puestoIdComboBox
            // 
            this.puestoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "PuestoId", true));
            this.puestoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaEmpleadosBindingSource, "PuestoId", true));
            this.puestoIdComboBox.DataSource = this.listaPuestosBindingSource;
            this.puestoIdComboBox.DisplayMember = "Descripcion";
            this.puestoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puestoIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puestoIdComboBox.FormattingEnabled = true;
            this.puestoIdComboBox.Location = new System.Drawing.Point(255, 439);
            this.puestoIdComboBox.Name = "puestoIdComboBox";
            this.puestoIdComboBox.Size = new System.Drawing.Size(372, 32);
            this.puestoIdComboBox.TabIndex = 32;
            this.puestoIdComboBox.ValueMember = "Id";
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.yahoohub.Empleado);
            // 
            // listaPuestosBindingSource
            // 
            this.listaPuestosBindingSource.DataSource = typeof(BL.yahoohub.Puesto);
            // 
            // metodoIdComboBox
            // 
            this.metodoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "MetodoId", true));
            this.metodoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaEmpleadosBindingSource, "MetodoId", true));
            this.metodoIdComboBox.DataSource = this.listaMetodoPagosBindingSource;
            this.metodoIdComboBox.DisplayMember = "Descripcion";
            this.metodoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metodoIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoIdComboBox.FormattingEnabled = true;
            this.metodoIdComboBox.Location = new System.Drawing.Point(255, 399);
            this.metodoIdComboBox.Name = "metodoIdComboBox";
            this.metodoIdComboBox.Size = new System.Drawing.Size(372, 32);
            this.metodoIdComboBox.TabIndex = 31;
            this.metodoIdComboBox.ValueMember = "Id";
            // 
            // listaMetodoPagosBindingSource
            // 
            this.listaMetodoPagosBindingSource.DataSource = typeof(BL.yahoohub.MetodoPago);
            // 
            // activoCheckBox1
            // 
            this.activoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaEmpleadosBindingSource, "Activo", true));
            this.activoCheckBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox1.Location = new System.Drawing.Point(255, 528);
            this.activoCheckBox1.Name = "activoCheckBox1";
            this.activoCheckBox1.Size = new System.Drawing.Size(241, 24);
            this.activoCheckBox1.TabIndex = 30;
            this.activoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(255, 129);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(372, 32);
            this.apellidoTextBox.TabIndex = 3;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Ciudad", true));
            this.ciudadTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.Location = new System.Drawing.Point(255, 279);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(372, 32);
            this.ciudadTextBox.TabIndex = 5;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(255, 318);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(372, 32);
            this.correoTextBox.TabIndex = 7;
            // 
            // deparmentoTextBox
            // 
            this.deparmentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Deparmento", true));
            this.deparmentoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deparmentoTextBox.Location = new System.Drawing.Point(255, 357);
            this.deparmentoTextBox.Name = "deparmentoTextBox";
            this.deparmentoTextBox.Size = new System.Drawing.Size(372, 32);
            this.deparmentoTextBox.TabIndex = 9;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaEmpleadosBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(255, 479);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(372, 32);
            this.fechaDateTimePicker.TabIndex = 13;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(255, 55);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(372, 32);
            this.idTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(255, 92);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(372, 32);
            this.nombreTextBox.TabIndex = 21;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "RTN", true));
            this.rTNTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTNTextBox.Location = new System.Drawing.Point(255, 167);
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(372, 32);
            this.rTNTextBox.TabIndex = 25;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Salario", true));
            this.salarioTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioTextBox.Location = new System.Drawing.Point(255, 203);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(372, 32);
            this.salarioTextBox.TabIndex = 27;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(255, 241);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(372, 32);
            this.telefonoTextBox.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.ImagenPictureBox);
            this.groupBox2.Controls.Add(this.direccionTextBox);
            this.groupBox2.Controls.Add(direccionLabel);
            this.groupBox2.Location = new System.Drawing.Point(744, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 691);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Empleados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 61);
            this.button1.TabIndex = 48;
            this.button1.Text = "Elegir Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(283, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 61);
            this.button2.TabIndex = 49;
            this.button2.Text = "Remover Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ImagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaEmpleadosBindingSource, "Imagen", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ImagenPictureBox.Location = new System.Drawing.Point(136, 43);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(283, 244);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 17;
            this.ImagenPictureBox.TabStop = false;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(113, 414);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(337, 151);
            this.direccionTextBox.TabIndex = 11;
            // 
            // listaEmpleadosBindingNavigator
            // 
            this.listaEmpleadosBindingNavigator.AddNewItem = null;
            this.listaEmpleadosBindingNavigator.BindingSource = this.listaEmpleadosBindingSource;
            this.listaEmpleadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEmpleadosBindingNavigator.DeleteItem = null;
            this.listaEmpleadosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaEmpleadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaEmpleadosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaEmpleadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEmpleadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEmpleadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEmpleadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEmpleadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEmpleadosBindingNavigator.Name = "listaEmpleadosBindingNavigator";
            this.listaEmpleadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEmpleadosBindingNavigator.Size = new System.Drawing.Size(1343, 27);
            this.listaEmpleadosBindingNavigator.TabIndex = 45;
            this.listaEmpleadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Visible = false;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaEmpleadosBindingNavigatorSaveItem
            // 
            this.listaEmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEmpleadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEmpleadosBindingNavigatorSaveItem.Image")));
            this.listaEmpleadosBindingNavigatorSaveItem.Name = "listaEmpleadosBindingNavigatorSaveItem";
            this.listaEmpleadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaEmpleadosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaEmpleadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaEmpleadosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1272, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 46;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 816);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listaEmpleadosBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetodoPagosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingNavigator)).EndInit();
            this.listaEmpleadosBindingNavigator.ResumeLayout(false);
            this.listaEmpleadosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.BindingNavigator listaEmpleadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaEmpleadosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox deparmentoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox rTNTextBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.BindingSource listaMetodoPagosBindingSource;
        private System.Windows.Forms.BindingSource listaPuestosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox activoCheckBox1;
        private System.Windows.Forms.ComboBox puestoIdComboBox;
        private System.Windows.Forms.ComboBox metodoIdComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
    }
}