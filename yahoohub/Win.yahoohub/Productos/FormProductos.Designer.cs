
namespace Win.yahoohub
{
    partial class FormProductos
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tamaño_AnchoLabel;
            System.Windows.Forms.Label tamaño_LargoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label precioCuadradoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaProductosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaProductosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.tamaño_AnchoTextBox = new System.Windows.Forms.TextBox();
            this.tamaño_LargoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listaCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.precioCuadradoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaPrecioCuadradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tamaño_AnchoLabel = new System.Windows.Forms.Label();
            tamaño_LargoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            precioCuadradoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).BeginInit();
            this.listaProductosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrecioCuadradosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            activoLabel.Location = new System.Drawing.Point(147, 456);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(80, 24);
            activoLabel.TabIndex = 11;
            activoLabel.Text = "Activo:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(185, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(40, 24);
            idLabel.TabIndex = 17;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(128, 162);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(97, 24);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Nombre:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(148, 402);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(80, 24);
            precioLabel.TabIndex = 23;
            precioLabel.Text = "Precio:";
            // 
            // tamaño_AnchoLabel
            // 
            tamaño_AnchoLabel.AutoSize = true;
            tamaño_AnchoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tamaño_AnchoLabel.Location = new System.Drawing.Point(61, 303);
            tamaño_AnchoLabel.Name = "tamaño_AnchoLabel";
            tamaño_AnchoLabel.Size = new System.Drawing.Size(166, 24);
            tamaño_AnchoLabel.TabIndex = 27;
            tamaño_AnchoLabel.Text = "Tamaño Ancho:";
            // 
            // tamaño_LargoLabel
            // 
            tamaño_LargoLabel.AutoSize = true;
            tamaño_LargoLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tamaño_LargoLabel.Location = new System.Drawing.Point(67, 351);
            tamaño_LargoLabel.Name = "tamaño_LargoLabel";
            tamaño_LargoLabel.Size = new System.Drawing.Size(160, 24);
            tamaño_LargoLabel.TabIndex = 29;
            tamaño_LargoLabel.Text = "Tamaño Largo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(183, 417);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(125, 25);
            descripcionLabel.TabIndex = 30;
            descripcionLabel.Text = "Descripción";
            descripcionLabel.Click += new System.EventHandler(this.descripcionLabel_Click);
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaIdLabel.Location = new System.Drawing.Point(111, 206);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(114, 24);
            categoriaIdLabel.TabIndex = 34;
            categoriaIdLabel.Text = "Categoria:";
            // 
            // precioCuadradoIdLabel
            // 
            precioCuadradoIdLabel.AutoSize = true;
            precioCuadradoIdLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioCuadradoIdLabel.Location = new System.Drawing.Point(12, 261);
            precioCuadradoIdLabel.Name = "precioCuadradoIdLabel";
            precioCuadradoIdLabel.Size = new System.Drawing.Size(215, 24);
            precioCuadradoIdLabel.TabIndex = 35;
            precioCuadradoIdLabel.Text = "Precio de la Medida:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg,png | *.jpg; *.png";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listaProductosBindingNavigator
            // 
            this.listaProductosBindingNavigator.AddNewItem = null;
            this.listaProductosBindingNavigator.BindingSource = this.listaProductosBindingSource;
            this.listaProductosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductosBindingNavigator.DeleteItem = null;
            this.listaProductosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaProductosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaProductosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaProductosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProductosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductosBindingNavigator.Name = "listaProductosBindingNavigator";
            this.listaProductosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductosBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.listaProductosBindingNavigator.TabIndex = 11;
            this.listaProductosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaProductosBindingSource
            // 
            this.listaProductosBindingSource.DataSource = typeof(BL.yahoohub.Producto);
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // listaProductosBindingNavigatorSaveItem
            // 
            this.listaProductosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProductosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProductosBindingNavigatorSaveItem.Image")));
            this.listaProductosBindingNavigatorSaveItem.Name = "listaProductosBindingNavigatorSaveItem";
            this.listaProductosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.listaProductosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaProductosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductosBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click_1);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource, "Activo", true));
            this.activoCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheckBox.Location = new System.Drawing.Point(261, 457);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 12;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Id", true));
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(261, 109);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(145, 32);
            this.IdTextBox.TabIndex = 18;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ImagenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaProductosBindingSource, "Imagen", true));
            this.ImagenPictureBox.Location = new System.Drawing.Point(82, 75);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(320, 266);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 20;
            this.ImagenPictureBox.TabStop = false;
            this.ImagenPictureBox.Click += new System.EventHandler(this.ImagenPictureBox_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(261, 154);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(389, 32);
            this.nombreTextBox.TabIndex = 22;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Precio", true));
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(261, 400);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(389, 32);
            this.precioTextBox.TabIndex = 24;
            // 
            // tamaño_AnchoTextBox
            // 
            this.tamaño_AnchoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Tamaño_Ancho", true));
            this.tamaño_AnchoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamaño_AnchoTextBox.Location = new System.Drawing.Point(261, 298);
            this.tamaño_AnchoTextBox.Name = "tamaño_AnchoTextBox";
            this.tamaño_AnchoTextBox.Size = new System.Drawing.Size(389, 32);
            this.tamaño_AnchoTextBox.TabIndex = 28;
            // 
            // tamaño_LargoTextBox
            // 
            this.tamaño_LargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Tamaño_Largo", true));
            this.tamaño_LargoTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamaño_LargoTextBox.Location = new System.Drawing.Point(261, 347);
            this.tamaño_LargoTextBox.Name = "tamaño_LargoTextBox";
            this.tamaño_LargoTextBox.Size = new System.Drawing.Size(389, 32);
            this.tamaño_LargoTextBox.TabIndex = 30;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(22, 448);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(441, 181);
            this.descripcionTextBox.TabIndex = 31;
            this.descripcionTextBox.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1263, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 32;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 61);
            this.button1.TabIndex = 33;
            this.button1.Text = "Elegir Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 61);
            this.button2.TabIndex = 34;
            this.button2.Text = "Remover Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listaCategoriasBindingSource
            // 
            this.listaCategoriasBindingSource.DataSource = typeof(BL.yahoohub.Categoria);
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaProductosBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataSource = this.listaCategoriasBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(261, 203);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(389, 32);
            this.categoriaIdComboBox.TabIndex = 35;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // precioCuadradoIdComboBox
            // 
            this.precioCuadradoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaProductosBindingSource, "PrecioCuadradoId", true));
            this.precioCuadradoIdComboBox.DataSource = this.listaPrecioCuadradosBindingSource;
            this.precioCuadradoIdComboBox.DisplayMember = "Valor";
            this.precioCuadradoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.precioCuadradoIdComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCuadradoIdComboBox.FormattingEnabled = true;
            this.precioCuadradoIdComboBox.Location = new System.Drawing.Point(261, 253);
            this.precioCuadradoIdComboBox.Name = "precioCuadradoIdComboBox";
            this.precioCuadradoIdComboBox.Size = new System.Drawing.Size(389, 32);
            this.precioCuadradoIdComboBox.TabIndex = 36;
            this.precioCuadradoIdComboBox.ValueMember = "Id";
            // 
            // listaPrecioCuadradosBindingSource
            // 
            this.listaPrecioCuadradosBindingSource.DataSource = typeof(BL.yahoohub.PrecioCuadrado);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.ImagenPictureBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Location = new System.Drawing.Point(759, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 668);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(this.tamaño_LargoTextBox);
            this.groupBox2.Controls.Add(precioCuadradoIdLabel);
            this.groupBox2.Controls.Add(tamaño_LargoLabel);
            this.groupBox2.Controls.Add(this.precioCuadradoIdComboBox);
            this.groupBox2.Controls.Add(this.tamaño_AnchoTextBox);
            this.groupBox2.Controls.Add(categoriaIdLabel);
            this.groupBox2.Controls.Add(tamaño_AnchoLabel);
            this.groupBox2.Controls.Add(this.categoriaIdComboBox);
            this.groupBox2.Controls.Add(this.precioTextBox);
            this.groupBox2.Controls.Add(precioLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(activoLabel);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.activoCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 668);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(501, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 58);
            this.button3.TabIndex = 35;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "REGISTRO DE PRODUCTOS";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 763);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listaProductosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingNavigator)).EndInit();
            this.listaProductosBindingNavigator.ResumeLayout(false);
            this.listaProductosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPrecioCuadradosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaProductosBindingSource;
        private System.Windows.Forms.BindingNavigator listaProductosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaProductosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox tamaño_AnchoTextBox;
        private System.Windows.Forms.TextBox tamaño_LargoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.ComboBox precioCuadradoIdComboBox;
        private System.Windows.Forms.BindingSource listaPrecioCuadradosBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}