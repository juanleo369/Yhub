
namespace Win.yahoohub
{
    partial class FormSalida
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label fechaSalidaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label materialIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label precioUnitLabel;
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            this.listaMaterialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaMaterialesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaInventariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaMaterialesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.empleadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.fechaSalidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.materialIdComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.precioUnitTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            cantidadLabel = new System.Windows.Forms.Label();
            empleadoIdLabel = new System.Windows.Forms.Label();
            fechaSalidaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            materialIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            precioUnitLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaterialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaterialesBindingNavigator)).BeginInit();
            this.listaMaterialesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaInventariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(94, 159);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(107, 24);
            cantidadLabel.TabIndex = 1;
            cantidadLabel.Text = "Cantidad:";
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadoIdLabel.Location = new System.Drawing.Point(76, 210);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(126, 24);
            empleadoIdLabel.TabIndex = 3;
            empleadoIdLabel.Text = "Empleados:";
            // 
            // fechaSalidaLabel
            // 
            fechaSalidaLabel.AutoSize = true;
            fechaSalidaLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaSalidaLabel.Location = new System.Drawing.Point(61, 258);
            fechaSalidaLabel.Name = "fechaSalidaLabel";
            fechaSalidaLabel.Size = new System.Drawing.Size(145, 24);
            fechaSalidaLabel.TabIndex = 5;
            fechaSalidaLabel.Text = "Fecha Salida:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(154, 65);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 24);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // materialIdLabel
            // 
            materialIdLabel.AutoSize = true;
            materialIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            materialIdLabel.Location = new System.Drawing.Point(81, 112);
            materialIdLabel.Name = "materialIdLabel";
            materialIdLabel.Size = new System.Drawing.Size(122, 24);
            materialIdLabel.TabIndex = 9;
            materialIdLabel.Text = "Materiales:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(53, 150);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(135, 24);
            descripcionLabel.TabIndex = 39;
            descripcionLabel.Text = "Descripción:";
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel2.Location = new System.Drawing.Point(143, 56);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(40, 24);
            idLabel2.TabIndex = 41;
            idLabel2.Text = "Id:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(89, 103);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(97, 24);
            nombreLabel1.TabIndex = 43;
            nombreLabel1.Text = "Nombre:";
            // 
            // precioUnitLabel
            // 
            precioUnitLabel.AutoSize = true;
            precioUnitLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioUnitLabel.Location = new System.Drawing.Point(61, 196);
            precioUnitLabel.Name = "precioUnitLabel";
            precioUnitLabel.Size = new System.Drawing.Size(128, 24);
            precioUnitLabel.TabIndex = 45;
            precioUnitLabel.Text = "Precio Unit:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(117, 245);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(73, 24);
            stockLabel.TabIndex = 47;
            stockLabel.Text = "Stock:";
            // 
            // listaMaterialesBindingSource
            // 
            this.listaMaterialesBindingSource.DataSource = typeof(BL.yahoohub.Material);
            // 
            // listaMaterialesBindingNavigator
            // 
            this.listaMaterialesBindingNavigator.AddNewItem = null;
            this.listaMaterialesBindingNavigator.BindingSource = this.listaInventariosBindingSource;
            this.listaMaterialesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaMaterialesBindingNavigator.DeleteItem = null;
            this.listaMaterialesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaMaterialesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaMaterialesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaMaterialesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaMaterialesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaMaterialesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaMaterialesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaMaterialesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaMaterialesBindingNavigator.Name = "listaMaterialesBindingNavigator";
            this.listaMaterialesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaMaterialesBindingNavigator.Size = new System.Drawing.Size(1319, 27);
            this.listaMaterialesBindingNavigator.TabIndex = 0;
            this.listaMaterialesBindingNavigator.Text = "bindingNavigator1";
            this.listaMaterialesBindingNavigator.RefreshItems += new System.EventHandler(this.listaMaterialesBindingNavigator_RefreshItems);
            // 
            // listaInventariosBindingSource
            // 
            this.listaInventariosBindingSource.DataSource = typeof(BL.yahoohub.Inventario);
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
            this.bindingNavigatorSeparator.Visible = false;
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
            // 
            // listaMaterialesBindingNavigatorSaveItem
            // 
            this.listaMaterialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaMaterialesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaMaterialesBindingNavigatorSaveItem.Image")));
            this.listaMaterialesBindingNavigatorSaveItem.Name = "listaMaterialesBindingNavigatorSaveItem";
            this.listaMaterialesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaMaterialesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaMaterialesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaMaterialesBindingNavigatorSaveItem_Click);
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
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.yahoohub.Empleado);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaInventariosBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(231, 156);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(372, 32);
            this.cantidadTextBox.TabIndex = 2;
            // 
            // empleadoIdComboBox
            // 
            this.empleadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaInventariosBindingSource, "EmpleadoId", true));
            this.empleadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaInventariosBindingSource, "EmpleadoId", true));
            this.empleadoIdComboBox.DataSource = this.listaEmpleadosBindingSource;
            this.empleadoIdComboBox.DisplayMember = "Nombre";
            this.empleadoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empleadoIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdComboBox.FormattingEnabled = true;
            this.empleadoIdComboBox.Location = new System.Drawing.Point(231, 204);
            this.empleadoIdComboBox.Name = "empleadoIdComboBox";
            this.empleadoIdComboBox.Size = new System.Drawing.Size(372, 32);
            this.empleadoIdComboBox.TabIndex = 4;
            this.empleadoIdComboBox.ValueMember = "Id";
            // 
            // fechaSalidaDateTimePicker
            // 
            this.fechaSalidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaInventariosBindingSource, "FechaSalida", true));
            this.fechaSalidaDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaSalidaDateTimePicker.Location = new System.Drawing.Point(231, 254);
            this.fechaSalidaDateTimePicker.Name = "fechaSalidaDateTimePicker";
            this.fechaSalidaDateTimePicker.Size = new System.Drawing.Size(372, 32);
            this.fechaSalidaDateTimePicker.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaInventariosBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(231, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(372, 32);
            this.idTextBox.TabIndex = 8;
            // 
            // materialIdComboBox
            // 
            this.materialIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaInventariosBindingSource, "MaterialId", true));
            this.materialIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaInventariosBindingSource, "MaterialId", true));
            this.materialIdComboBox.DataSource = this.listaMaterialesBindingSource;
            this.materialIdComboBox.DisplayMember = "Descripcion";
            this.materialIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialIdComboBox.FormattingEnabled = true;
            this.materialIdComboBox.Location = new System.Drawing.Point(231, 109);
            this.materialIdComboBox.Name = "materialIdComboBox";
            this.materialIdComboBox.Size = new System.Drawing.Size(372, 32);
            this.materialIdComboBox.TabIndex = 10;
            this.materialIdComboBox.ValueMember = "Id";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaterialesBindingSource, "Descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(213, 147);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(233, 32);
            this.descripcionTextBox.TabIndex = 40;
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaterialesBindingSource, "Id", true));
            this.idTextBox2.Enabled = false;
            this.idTextBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox2.Location = new System.Drawing.Point(213, 53);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(233, 32);
            this.idTextBox2.TabIndex = 42;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaterialesBindingSource, "Nombre", true));
            this.nombreTextBox1.Enabled = false;
            this.nombreTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox1.Location = new System.Drawing.Point(213, 100);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(233, 32);
            this.nombreTextBox1.TabIndex = 44;
            // 
            // precioUnitTextBox
            // 
            this.precioUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaterialesBindingSource, "PrecioUnit", true));
            this.precioUnitTextBox.Enabled = false;
            this.precioUnitTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioUnitTextBox.Location = new System.Drawing.Point(213, 193);
            this.precioUnitTextBox.Name = "precioUnitTextBox";
            this.precioUnitTextBox.Size = new System.Drawing.Size(233, 32);
            this.precioUnitTextBox.TabIndex = 46;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMaterialesBindingSource, "Stock", true));
            this.stockTextBox.Enabled = false;
            this.stockTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(213, 242);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(233, 32);
            this.stockTextBox.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.materialIdComboBox);
            this.groupBox1.Controls.Add(materialIdLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.fechaSalidaDateTimePicker);
            this.groupBox1.Controls.Add(fechaSalidaLabel);
            this.groupBox1.Controls.Add(this.empleadoIdComboBox);
            this.groupBox1.Controls.Add(empleadoIdLabel);
            this.groupBox1.Controls.Add(this.cantidadTextBox);
            this.groupBox1.Controls.Add(cantidadLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 505);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de la Salida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 71);
            this.button2.TabIndex = 12;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 71);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1248, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 51;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(11, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE SALIDAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(idLabel2);
            this.groupBox2.Controls.Add(this.stockTextBox);
            this.groupBox2.Controls.Add(stockLabel);
            this.groupBox2.Controls.Add(this.precioUnitTextBox);
            this.groupBox2.Controls.Add(descripcionLabel);
            this.groupBox2.Controls.Add(precioUnitLabel);
            this.groupBox2.Controls.Add(this.descripcionTextBox);
            this.groupBox2.Controls.Add(this.nombreTextBox1);
            this.groupBox2.Controls.Add(nombreLabel1);
            this.groupBox2.Controls.Add(this.idTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(719, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 496);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Material";
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaMaterialesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalida";
            this.Text = "FormSalida";
            this.Load += new System.EventHandler(this.FormSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaMaterialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMaterialesBindingNavigator)).EndInit();
            this.listaMaterialesBindingNavigator.ResumeLayout(false);
            this.listaMaterialesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaInventariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaMaterialesBindingSource;
        private System.Windows.Forms.BindingNavigator listaMaterialesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaMaterialesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.BindingSource listaInventariosBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox empleadoIdComboBox;
        private System.Windows.Forms.DateTimePicker fechaSalidaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox materialIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox precioUnitTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}