
namespace Win.yahoohub
{
    partial class FormPlanillas
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pagoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanillas));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPlanillasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPlanillasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaPlanillasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPlanillasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pagoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empleadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            descripcionLabel = new System.Windows.Forms.Label();
            empleadoIdLabel = new System.Windows.Forms.Label();
            fechaPagoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            pagoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasBindingNavigator)).BeginInit();
            this.listaPlanillasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(391, 139);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(135, 24);
            descripcionLabel.TabIndex = 49;
            descripcionLabel.Text = "Descripción:";
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadoIdLabel.Location = new System.Drawing.Point(396, 59);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(126, 24);
            empleadoIdLabel.TabIndex = 50;
            empleadoIdLabel.Text = "Empleados:";
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaPagoLabel.Location = new System.Drawing.Point(392, 181);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(133, 24);
            fechaPagoLabel.TabIndex = 51;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(481, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 24);
            idLabel.TabIndex = 52;
            idLabel.Text = "Id:";
            // 
            // pagoLabel
            // 
            pagoLabel.AutoSize = true;
            pagoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagoLabel.Location = new System.Drawing.Point(456, 98);
            pagoLabel.Name = "pagoLabel";
            pagoLabel.Size = new System.Drawing.Size(67, 24);
            pagoLabel.TabIndex = 53;
            pagoLabel.Text = "Pago:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(23, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE PLANILLA";
            // 
            // listaPlanillasBindingSource
            // 
            this.listaPlanillasBindingSource.DataSource = typeof(BL.yahoohub.Planilla);
            // 
            // listaPlanillasBindingNavigator
            // 
            this.listaPlanillasBindingNavigator.AddNewItem = null;
            this.listaPlanillasBindingNavigator.BindingSource = this.listaPlanillasBindingSource;
            this.listaPlanillasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaPlanillasBindingNavigator.DeleteItem = null;
            this.listaPlanillasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaPlanillasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaPlanillasBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaPlanillasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaPlanillasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaPlanillasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaPlanillasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaPlanillasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaPlanillasBindingNavigator.Name = "listaPlanillasBindingNavigator";
            this.listaPlanillasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaPlanillasBindingNavigator.Size = new System.Drawing.Size(1346, 27);
            this.listaPlanillasBindingNavigator.TabIndex = 49;
            this.listaPlanillasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaPlanillasBindingNavigatorSaveItem
            // 
            this.listaPlanillasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaPlanillasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaPlanillasBindingNavigatorSaveItem.Image")));
            this.listaPlanillasBindingNavigatorSaveItem.Name = "listaPlanillasBindingNavigatorSaveItem";
            this.listaPlanillasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaPlanillasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaPlanillasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaPlanillasBindingNavigatorSaveItem_Click);
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
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.yahoohub.Empleado);
            // 
            // listaPlanillasDataGridView
            // 
            this.listaPlanillasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listaPlanillasDataGridView.AutoGenerateColumns = false;
            this.listaPlanillasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPlanillasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.listaPlanillasDataGridView.DataSource = this.listaPlanillasBindingSource;
            this.listaPlanillasDataGridView.Location = new System.Drawing.Point(22, 230);
            this.listaPlanillasDataGridView.Name = "listaPlanillasDataGridView";
            this.listaPlanillasDataGridView.RowHeadersWidth = 51;
            this.listaPlanillasDataGridView.RowTemplate.Height = 24;
            this.listaPlanillasDataGridView.Size = new System.Drawing.Size(1178, 289);
            this.listaPlanillasDataGridView.TabIndex = 49;
            this.listaPlanillasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaPlanillasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpleadoId";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmpleadoId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaPago";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaPago";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pago";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pago";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(pagoLabel);
            this.groupBox1.Controls.Add(this.pagoTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(fechaPagoLabel);
            this.groupBox1.Controls.Add(this.fechaPagoDateTimePicker);
            this.groupBox1.Controls.Add(empleadoIdLabel);
            this.groupBox1.Controls.Add(this.empleadoIdComboBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(this.listaPlanillasDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1231, 541);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pagoTextBox
            // 
            this.pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPlanillasBindingSource, "Pago", true));
            this.pagoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTextBox.Location = new System.Drawing.Point(540, 95);
            this.pagoTextBox.Name = "pagoTextBox";
            this.pagoTextBox.Size = new System.Drawing.Size(373, 32);
            this.pagoTextBox.TabIndex = 54;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPlanillasBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(540, 16);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(373, 32);
            this.idTextBox.TabIndex = 53;
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaPlanillasBindingSource, "FechaPago", true));
            this.fechaPagoDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(540, 176);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(373, 32);
            this.fechaPagoDateTimePicker.TabIndex = 52;
            // 
            // empleadoIdComboBox
            // 
            this.empleadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaPlanillasBindingSource, "EmpleadoId", true));
            this.empleadoIdComboBox.DataSource = this.listaEmpleadosBindingSource;
            this.empleadoIdComboBox.DisplayMember = "Nombre";
            this.empleadoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empleadoIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdComboBox.FormattingEnabled = true;
            this.empleadoIdComboBox.Location = new System.Drawing.Point(540, 56);
            this.empleadoIdComboBox.Name = "empleadoIdComboBox";
            this.empleadoIdComboBox.Size = new System.Drawing.Size(373, 32);
            this.empleadoIdComboBox.TabIndex = 51;
            this.empleadoIdComboBox.ValueMember = "Id";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPlanillasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(540, 136);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(373, 32);
            this.descripcionTextBox.TabIndex = 50;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1275, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 51;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 722);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaPlanillasBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlanillas";
            this.Text = "FormPlanillas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasBindingNavigator)).EndInit();
            this.listaPlanillasBindingNavigator.ResumeLayout(false);
            this.listaPlanillasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPlanillasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource listaPlanillasBindingSource;
        private System.Windows.Forms.BindingNavigator listaPlanillasBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listaPlanillasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.DataGridView listaPlanillasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pagoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.ComboBox empleadoIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button button7;
    }
}