
namespace Win.yahoohub
{
    partial class FormUsuarios
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
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombUsuarioLabel;
            System.Windows.Forms.Label tipoUsuarioIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaSeguridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaSeguridadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaSeguridadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaSeguridadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.empleadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaTipoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contrasenaLabel = new System.Windows.Forms.Label();
            empleadoIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombUsuarioLabel = new System.Windows.Forms.Label();
            tipoUsuarioIdLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).BeginInit();
            this.listaSeguridadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(434, 170);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(113, 21);
            contrasenaLabel.TabIndex = 43;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadoIdLabel.Location = new System.Drawing.Point(447, 205);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(100, 21);
            empleadoIdLabel.TabIndex = 45;
            empleadoIdLabel.Text = "Empleado:";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(510, 100);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 21);
            idLabel.TabIndex = 47;
            idLabel.Text = "Id:";
            // 
            // nombUsuarioLabel
            // 
            nombUsuarioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            nombUsuarioLabel.AutoSize = true;
            nombUsuarioLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombUsuarioLabel.Location = new System.Drawing.Point(464, 135);
            nombUsuarioLabel.Name = "nombUsuarioLabel";
            nombUsuarioLabel.Size = new System.Drawing.Size(82, 21);
            nombUsuarioLabel.TabIndex = 49;
            nombUsuarioLabel.Text = "Usuario:";
            // 
            // tipoUsuarioIdLabel
            // 
            tipoUsuarioIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            tipoUsuarioIdLabel.AutoSize = true;
            tipoUsuarioIdLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioIdLabel.Location = new System.Drawing.Point(424, 243);
            tipoUsuarioIdLabel.Name = "tipoUsuarioIdLabel";
            tipoUsuarioIdLabel.Size = new System.Drawing.Size(124, 21);
            tipoUsuarioIdLabel.TabIndex = 51;
            tipoUsuarioIdLabel.Text = "Tipo Usuario:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE USUARIO";
            // 
            // listaSeguridadBindingSource
            // 
            this.listaSeguridadBindingSource.DataSource = typeof(BL.yahoohub.Usuario);
            // 
            // listaSeguridadBindingNavigator
            // 
            this.listaSeguridadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaSeguridadBindingNavigator.BindingSource = this.listaSeguridadBindingSource;
            this.listaSeguridadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaSeguridadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaSeguridadBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaSeguridadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaSeguridadBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaSeguridadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaSeguridadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaSeguridadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaSeguridadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaSeguridadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaSeguridadBindingNavigator.Name = "listaSeguridadBindingNavigator";
            this.listaSeguridadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaSeguridadBindingNavigator.Size = new System.Drawing.Size(1323, 27);
            this.listaSeguridadBindingNavigator.TabIndex = 42;
            this.listaSeguridadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listaSeguridadBindingNavigatorSaveItem
            // 
            this.listaSeguridadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaSeguridadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaSeguridadBindingNavigatorSaveItem.Image")));
            this.listaSeguridadBindingNavigatorSaveItem.Name = "listaSeguridadBindingNavigatorSaveItem";
            this.listaSeguridadBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaSeguridadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaSeguridadBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaSeguridadBindingNavigatorSaveItem_Click);
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
            // listaSeguridadDataGridView
            // 
            this.listaSeguridadDataGridView.AllowUserToAddRows = false;
            this.listaSeguridadDataGridView.AllowUserToDeleteRows = false;
            this.listaSeguridadDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listaSeguridadDataGridView.AutoGenerateColumns = false;
            this.listaSeguridadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSeguridadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.listaSeguridadDataGridView.DataSource = this.listaSeguridadBindingSource;
            this.listaSeguridadDataGridView.Location = new System.Drawing.Point(18, 303);
            this.listaSeguridadDataGridView.Name = "listaSeguridadDataGridView";
            this.listaSeguridadDataGridView.ReadOnly = true;
            this.listaSeguridadDataGridView.RowHeadersWidth = 51;
            this.listaSeguridadDataGridView.RowTemplate.Height = 24;
            this.listaSeguridadDataGridView.Size = new System.Drawing.Size(1218, 320);
            this.listaSeguridadDataGridView.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombUsuario";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contrasena";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contrasena";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoUsuarioId";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoUsuarioId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TipoUsuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "TipoUsuario";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmpleadoId";
            this.dataGridViewTextBoxColumn6.HeaderText = "EmpleadoId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1252, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 43;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTextBox.Location = new System.Drawing.Point(559, 167);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(331, 28);
            this.contrasenaTextBox.TabIndex = 44;
            // 
            // empleadoIdComboBox
            // 
            this.empleadoIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.empleadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaSeguridadBindingSource, "EmpleadoId", true));
            this.empleadoIdComboBox.DataSource = this.listaEmpleadosBindingSource;
            this.empleadoIdComboBox.DisplayMember = "Nombre";
            this.empleadoIdComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdComboBox.FormattingEnabled = true;
            this.empleadoIdComboBox.Location = new System.Drawing.Point(559, 202);
            this.empleadoIdComboBox.Name = "empleadoIdComboBox";
            this.empleadoIdComboBox.Size = new System.Drawing.Size(331, 29);
            this.empleadoIdComboBox.TabIndex = 46;
            this.empleadoIdComboBox.ValueMember = "Id";
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.yahoohub.Empleado);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(559, 97);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(331, 28);
            this.idTextBox.TabIndex = 48;
            // 
            // nombUsuarioTextBox
            // 
            this.nombUsuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nombUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "NombUsuario", true));
            this.nombUsuarioTextBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombUsuarioTextBox.Location = new System.Drawing.Point(559, 132);
            this.nombUsuarioTextBox.Name = "nombUsuarioTextBox";
            this.nombUsuarioTextBox.Size = new System.Drawing.Size(331, 28);
            this.nombUsuarioTextBox.TabIndex = 50;
            // 
            // tipoUsuarioIdComboBox
            // 
            this.tipoUsuarioIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tipoUsuarioIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "TipoUsuarioId", true));
            this.tipoUsuarioIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaSeguridadBindingSource, "TipoUsuarioId", true));
            this.tipoUsuarioIdComboBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuarioIdComboBox.FormattingEnabled = true;
            this.tipoUsuarioIdComboBox.Location = new System.Drawing.Point(559, 240);
            this.tipoUsuarioIdComboBox.Name = "tipoUsuarioIdComboBox";
            this.tipoUsuarioIdComboBox.Size = new System.Drawing.Size(331, 29);
            this.tipoUsuarioIdComboBox.TabIndex = 52;
            // 
            // listaTipoUsuariosBindingSource
            // 
            this.listaTipoUsuariosBindingSource.DataSource = typeof(BL.yahoohub.TipoUsuario);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 666);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombUsuarioLabel);
            this.Controls.Add(this.nombUsuarioTextBox);
            this.Controls.Add(tipoUsuarioIdLabel);
            this.Controls.Add(this.tipoUsuarioIdComboBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listaSeguridadDataGridView);
            this.Controls.Add(this.listaSeguridadBindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingNavigator)).EndInit();
            this.listaSeguridadBindingNavigator.ResumeLayout(false);
            this.listaSeguridadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource listaSeguridadBindingSource;
        private System.Windows.Forms.BindingNavigator listaSeguridadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaSeguridadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView listaSeguridadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.ComboBox empleadoIdComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombUsuarioTextBox;
        private System.Windows.Forms.ComboBox tipoUsuarioIdComboBox;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.BindingSource listaTipoUsuariosBindingSource;
    }
}