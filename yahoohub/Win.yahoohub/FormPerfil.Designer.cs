
namespace Win.yahoohub
{
    partial class FormPerfil
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombUsuarioLabel;
            System.Windows.Forms.Label tipoUsuarioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label puestoIdLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaTipoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaSeguridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioIdComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.puestoIdComboBox = new System.Windows.Forms.ComboBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.listaPuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contrasenaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombUsuarioLabel = new System.Windows.Forms.Label();
            tipoUsuarioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            puestoIdLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPuestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1295, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 45;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(36, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1231, 47);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "PERFIL DEL USUARIO";
            // 
            // listaTipoUsuariosBindingSource
            // 
            this.listaTipoUsuariosBindingSource.DataSource = typeof(BL.yahoohub.TipoUsuario);
            // 
            // listaSeguridadBindingSource
            // 
            this.listaSeguridadBindingSource.DataSource = typeof(BL.yahoohub.Usuario);
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.yahoohub.Empleado);
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(68, 252);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(125, 23);
            contrasenaLabel.TabIndex = 45;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Enabled = false;
            this.contrasenaTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTextBox.Location = new System.Drawing.Point(251, 249);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(299, 29);
            this.contrasenaTextBox.TabIndex = 46;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(155, 147);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(38, 23);
            idLabel.TabIndex = 49;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(251, 144);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(299, 29);
            this.idTextBox.TabIndex = 50;
            // 
            // nombUsuarioLabel
            // 
            nombUsuarioLabel.AutoSize = true;
            nombUsuarioLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombUsuarioLabel.Location = new System.Drawing.Point(103, 202);
            nombUsuarioLabel.Name = "nombUsuarioLabel";
            nombUsuarioLabel.Size = new System.Drawing.Size(90, 23);
            nombUsuarioLabel.TabIndex = 51;
            nombUsuarioLabel.Text = "Usuario:";
            // 
            // nombUsuarioTextBox
            // 
            this.nombUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "NombUsuario", true));
            this.nombUsuarioTextBox.Enabled = false;
            this.nombUsuarioTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombUsuarioTextBox.Location = new System.Drawing.Point(251, 196);
            this.nombUsuarioTextBox.Name = "nombUsuarioTextBox";
            this.nombUsuarioTextBox.Size = new System.Drawing.Size(299, 29);
            this.nombUsuarioTextBox.TabIndex = 52;
            // 
            // tipoUsuarioIdLabel
            // 
            tipoUsuarioIdLabel.AutoSize = true;
            tipoUsuarioIdLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioIdLabel.Location = new System.Drawing.Point(28, 320);
            tipoUsuarioIdLabel.Name = "tipoUsuarioIdLabel";
            tipoUsuarioIdLabel.Size = new System.Drawing.Size(167, 23);
            tipoUsuarioIdLabel.TabIndex = 53;
            tipoUsuarioIdLabel.Text = "Tipo de Usuario:";
            // 
            // tipoUsuarioIdComboBox
            // 
            this.tipoUsuarioIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaSeguridadBindingSource, "TipoUsuarioId", true));
            this.tipoUsuarioIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaSeguridadBindingSource, "TipoUsuarioId", true));
            this.tipoUsuarioIdComboBox.DataSource = this.listaTipoUsuariosBindingSource;
            this.tipoUsuarioIdComboBox.DisplayMember = "Descripcion";
            this.tipoUsuarioIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuarioIdComboBox.Enabled = false;
            this.tipoUsuarioIdComboBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuarioIdComboBox.FormattingEnabled = true;
            this.tipoUsuarioIdComboBox.Location = new System.Drawing.Point(251, 313);
            this.tipoUsuarioIdComboBox.Name = "tipoUsuarioIdComboBox";
            this.tipoUsuarioIdComboBox.Size = new System.Drawing.Size(299, 30);
            this.tipoUsuarioIdComboBox.TabIndex = 54;
            this.tipoUsuarioIdComboBox.ValueMember = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(contrasenaLabel);
            this.groupBox1.Controls.Add(this.tipoUsuarioIdComboBox);
            this.groupBox1.Controls.Add(this.contrasenaTextBox);
            this.groupBox1.Controls.Add(tipoUsuarioIdLabel);
            this.groupBox1.Controls.Add(this.nombUsuarioTextBox);
            this.groupBox1.Controls.Add(nombUsuarioLabel);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(36, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 645);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(telefonoLabel);
            this.groupBox2.Controls.Add(this.telefonoTextBox);
            this.groupBox2.Controls.Add(correoLabel);
            this.groupBox2.Controls.Add(this.correoTextBox);
            this.groupBox2.Controls.Add(puestoIdLabel);
            this.groupBox2.Controls.Add(this.puestoIdComboBox);
            this.groupBox2.Controls.Add(this.imagenPictureBox);
            this.groupBox2.Controls.Add(apellidoLabel);
            this.groupBox2.Controls.Add(this.apellidoTextBox);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Location = new System.Drawing.Point(669, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 645);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfil del Usuario";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(89, 277);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(93, 23);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(198, 274);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(307, 29);
            this.nombreTextBox.TabIndex = 1;
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(88, 320);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(95, 23);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Apellido", true));
            this.apellidoTextBox.Enabled = false;
            this.apellidoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(198, 317);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(307, 29);
            this.apellidoTextBox.TabIndex = 3;
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaEmpleadosBindingSource, "Imagen", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.imagenPictureBox.Location = new System.Drawing.Point(211, 35);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(245, 212);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 5;
            this.imagenPictureBox.TabStop = false;
            // 
            // puestoIdLabel
            // 
            puestoIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            puestoIdLabel.AutoSize = true;
            puestoIdLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puestoIdLabel.Location = new System.Drawing.Point(101, 368);
            puestoIdLabel.Name = "puestoIdLabel";
            puestoIdLabel.Size = new System.Drawing.Size(82, 23);
            puestoIdLabel.TabIndex = 5;
            puestoIdLabel.Text = "Puesto:";
            puestoIdLabel.Click += new System.EventHandler(this.puestoIdLabel_Click);
            // 
            // puestoIdComboBox
            // 
            this.puestoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "PuestoId", true));
            this.puestoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaEmpleadosBindingSource, "PuestoId", true));
            this.puestoIdComboBox.DataSource = this.listaPuestosBindingSource;
            this.puestoIdComboBox.DisplayMember = "Descripcion";
            this.puestoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puestoIdComboBox.Enabled = false;
            this.puestoIdComboBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puestoIdComboBox.FormattingEnabled = true;
            this.puestoIdComboBox.Location = new System.Drawing.Point(198, 362);
            this.puestoIdComboBox.Name = "puestoIdComboBox";
            this.puestoIdComboBox.Size = new System.Drawing.Size(307, 30);
            this.puestoIdComboBox.TabIndex = 6;
            this.puestoIdComboBox.ValueMember = "Id";
            // 
            // correoLabel
            // 
            correoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            correoLabel.Location = new System.Drawing.Point(102, 415);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(81, 23);
            correoLabel.TabIndex = 7;
            correoLabel.Text = "Correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Correo", true));
            this.correoTextBox.Enabled = false;
            this.correoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoTextBox.Location = new System.Drawing.Point(198, 412);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(307, 29);
            this.correoTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(83, 463);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(100, 23);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEmpleadosBindingSource, "Telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(198, 460);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(307, 29);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // listaPuestosBindingSource
            // 
            this.listaPuestosBindingSource.DataSource = typeof(BL.yahoohub.Puesto);
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPerfil";
            this.Text = "FormPerfil";
            this.Load += new System.EventHandler(this.FormPerfil_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaSeguridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPuestosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource listaTipoUsuariosBindingSource;
        private System.Windows.Forms.BindingSource listaSeguridadBindingSource;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombUsuarioTextBox;
        private System.Windows.Forms.ComboBox tipoUsuarioIdComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox puestoIdComboBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.BindingSource listaPuestosBindingSource;
    }
}