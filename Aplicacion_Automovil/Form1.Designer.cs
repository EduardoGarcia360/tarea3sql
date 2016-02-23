namespace Aplicacion_Automovil
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_vehiculo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_nuevovalor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combobox_campo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_matricula = new System.Windows.Forms.ComboBox();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venta_vehiculosDataSet = new Aplicacion_Automovil.venta_vehiculosDataSet();
            this.combobox_color = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richtextbox_descripcion = new System.Windows.Forms.RichTextBox();
            this.textbox_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.vehiculoTableAdapter = new Aplicacion_Automovil.venta_vehiculosDataSetTableAdapters.vehiculoTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_codcliente = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox_campocliente = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_nuevodato = new System.Windows.Forms.TextBox();
            this.venta_vehiculosDataSet1 = new Aplicacion_Automovil.venta_vehiculosDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Aplicacion_Automovil.venta_vehiculosDataSet1TableAdapters.clienteTableAdapter();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_vehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_vehiculosDataSet)).BeginInit();
            this.tab_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_vehiculosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_vehiculo);
            this.tabControl.Controls.Add(this.tab_clientes);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 424);
            this.tabControl.TabIndex = 0;
            // 
            // tab_vehiculo
            // 
            this.tab_vehiculo.Controls.Add(this.label18);
            this.tab_vehiculo.Controls.Add(this.label17);
            this.tab_vehiculo.Controls.Add(this.button1);
            this.tab_vehiculo.Controls.Add(this.label10);
            this.tab_vehiculo.Controls.Add(this.textbox_nuevovalor);
            this.tab_vehiculo.Controls.Add(this.label9);
            this.tab_vehiculo.Controls.Add(this.combobox_campo);
            this.tab_vehiculo.Controls.Add(this.label8);
            this.tab_vehiculo.Controls.Add(this.combobox_matricula);
            this.tab_vehiculo.Controls.Add(this.combobox_color);
            this.tab_vehiculo.Controls.Add(this.label7);
            this.tab_vehiculo.Controls.Add(this.richtextbox_descripcion);
            this.tab_vehiculo.Controls.Add(this.textbox_precio);
            this.tab_vehiculo.Controls.Add(this.label6);
            this.tab_vehiculo.Controls.Add(this.label5);
            this.tab_vehiculo.Controls.Add(this.textbox_modelo);
            this.tab_vehiculo.Controls.Add(this.label4);
            this.tab_vehiculo.Controls.Add(this.textbox_marca);
            this.tab_vehiculo.Controls.Add(this.label3);
            this.tab_vehiculo.Controls.Add(this.textbox_matricula);
            this.tab_vehiculo.Controls.Add(this.label2);
            this.tab_vehiculo.Controls.Add(this.label1);
            this.tab_vehiculo.Controls.Add(this.button_ingresar);
            this.tab_vehiculo.Location = new System.Drawing.Point(4, 22);
            this.tab_vehiculo.Name = "tab_vehiculo";
            this.tab_vehiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_vehiculo.Size = new System.Drawing.Size(760, 398);
            this.tab_vehiculo.TabIndex = 0;
            this.tab_vehiculo.Text = "Vehiculos";
            this.tab_vehiculo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(443, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nuevo Valor:";
            // 
            // textbox_nuevovalor
            // 
            this.textbox_nuevovalor.Location = new System.Drawing.Point(443, 107);
            this.textbox_nuevovalor.Name = "textbox_nuevovalor";
            this.textbox_nuevovalor.Size = new System.Drawing.Size(163, 20);
            this.textbox_nuevovalor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Campo:";
            // 
            // combobox_campo
            // 
            this.combobox_campo.FormattingEnabled = true;
            this.combobox_campo.Items.AddRange(new object[] {
            "marca",
            "modelo",
            "color",
            "precio"});
            this.combobox_campo.Location = new System.Drawing.Point(418, 70);
            this.combobox_campo.Name = "combobox_campo";
            this.combobox_campo.Size = new System.Drawing.Size(188, 21);
            this.combobox_campo.TabIndex = 17;
            this.combobox_campo.Text = "Seleccione Campo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Matricula:";
            // 
            // combobox_matricula
            // 
            this.combobox_matricula.DataSource = this.vehiculoBindingSource;
            this.combobox_matricula.DisplayMember = "matricula";
            this.combobox_matricula.FormattingEnabled = true;
            this.combobox_matricula.Location = new System.Drawing.Point(418, 41);
            this.combobox_matricula.Name = "combobox_matricula";
            this.combobox_matricula.Size = new System.Drawing.Size(188, 21);
            this.combobox_matricula.TabIndex = 15;
            this.combobox_matricula.ValueMember = "matricula";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.venta_vehiculosDataSet;
            // 
            // venta_vehiculosDataSet
            // 
            this.venta_vehiculosDataSet.DataSetName = "venta_vehiculosDataSet";
            this.venta_vehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combobox_color
            // 
            this.combobox_color.FormattingEnabled = true;
            this.combobox_color.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo",
            "Naranja",
            "Gris"});
            this.combobox_color.Location = new System.Drawing.Point(99, 119);
            this.combobox_color.Name = "combobox_color";
            this.combobox_color.Size = new System.Drawing.Size(184, 21);
            this.combobox_color.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripcion:";
            // 
            // richtextbox_descripcion
            // 
            this.richtextbox_descripcion.Location = new System.Drawing.Point(99, 172);
            this.richtextbox_descripcion.Name = "richtextbox_descripcion";
            this.richtextbox_descripcion.Size = new System.Drawing.Size(184, 67);
            this.richtextbox_descripcion.TabIndex = 12;
            this.richtextbox_descripcion.Text = "";
            // 
            // textbox_precio
            // 
            this.textbox_precio.Location = new System.Drawing.Point(99, 146);
            this.textbox_precio.Name = "textbox_precio";
            this.textbox_precio.Size = new System.Drawing.Size(184, 20);
            this.textbox_precio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textbox_modelo
            // 
            this.textbox_modelo.Location = new System.Drawing.Point(99, 94);
            this.textbox_modelo.Name = "textbox_modelo";
            this.textbox_modelo.Size = new System.Drawing.Size(184, 20);
            this.textbox_modelo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo:";
            // 
            // textbox_marca
            // 
            this.textbox_marca.Location = new System.Drawing.Point(99, 68);
            this.textbox_marca.Name = "textbox_marca";
            this.textbox_marca.Size = new System.Drawing.Size(184, 20);
            this.textbox_marca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // textbox_matricula
            // 
            this.textbox_matricula.Location = new System.Drawing.Point(99, 42);
            this.textbox_matricula.Name = "textbox_matricula";
            this.textbox_matricula.Size = new System.Drawing.Size(184, 20);
            this.textbox_matricula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matricula:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Registro";
            // 
            // button_ingresar
            // 
            this.button_ingresar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_ingresar.Location = new System.Drawing.Point(99, 245);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(184, 23);
            this.button_ingresar.TabIndex = 0;
            this.button_ingresar.Text = "Ingresar";
            this.button_ingresar.UseVisualStyleBackColor = true;
            this.button_ingresar.Click += new System.EventHandler(this.button_ingresar_Click);
            // 
            // tab_clientes
            // 
            this.tab_clientes.Controls.Add(this.btn_AgregarCliente);
            this.tab_clientes.Controls.Add(this.txt_nuevodato);
            this.tab_clientes.Controls.Add(this.label22);
            this.tab_clientes.Controls.Add(this.comboBox_campocliente);
            this.tab_clientes.Controls.Add(this.label21);
            this.tab_clientes.Controls.Add(this.comboBox_codcliente);
            this.tab_clientes.Controls.Add(this.label20);
            this.tab_clientes.Controls.Add(this.label19);
            this.tab_clientes.Controls.Add(this.txtTelefono);
            this.tab_clientes.Controls.Add(this.txtDireccion);
            this.tab_clientes.Controls.Add(this.txtApellido);
            this.tab_clientes.Controls.Add(this.txtNombre);
            this.tab_clientes.Controls.Add(this.txtNIT);
            this.tab_clientes.Controls.Add(this.label16);
            this.tab_clientes.Controls.Add(this.label15);
            this.tab_clientes.Controls.Add(this.label14);
            this.tab_clientes.Controls.Add(this.label13);
            this.tab_clientes.Controls.Add(this.label12);
            this.tab_clientes.Controls.Add(this.label11);
            this.tab_clientes.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clientes.Size = new System.Drawing.Size(760, 398);
            this.tab_clientes.TabIndex = 1;
            this.tab_clientes.Text = "Clientes";
            this.tab_clientes.UseVisualStyleBackColor = true;
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 398);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Concesionario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nuevo Registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "NIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Apellido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Dirección";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Teléfono";
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(94, 69);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(186, 20);
            this.txtNIT.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(94, 148);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(186, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(94, 180);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(186, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(94, 216);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(186, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(332, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 22;
            this.label17.Text = "Actualizar Datos";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(332, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "Eliminar Registro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(381, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(230, 26);
            this.label19.TabIndex = 11;
            this.label19.Text = "Actualizar Registro";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(386, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Codigo de Cliente";
            // 
            // comboBox_codcliente
            // 
            this.comboBox_codcliente.DataSource = this.clienteBindingSource;
            this.comboBox_codcliente.DisplayMember = "cod_cliente";
            this.comboBox_codcliente.FormattingEnabled = true;
            this.comboBox_codcliente.Location = new System.Drawing.Point(524, 69);
            this.comboBox_codcliente.Name = "comboBox_codcliente";
            this.comboBox_codcliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_codcliente.TabIndex = 13;
            this.comboBox_codcliente.ValueMember = "cod_cliente";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(386, 116);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Campo";
            // 
            // comboBox_campocliente
            // 
            this.comboBox_campocliente.FormattingEnabled = true;
            this.comboBox_campocliente.Location = new System.Drawing.Point(524, 116);
            this.comboBox_campocliente.Name = "comboBox_campocliente";
            this.comboBox_campocliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_campocliente.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(389, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Nuevo Dato";
            // 
            // txt_nuevodato
            // 
            this.txt_nuevodato.Location = new System.Drawing.Point(524, 170);
            this.txt_nuevodato.Name = "txt_nuevodato";
            this.txt_nuevodato.Size = new System.Drawing.Size(100, 20);
            this.txt_nuevodato.TabIndex = 17;
            // 
            // venta_vehiculosDataSet1
            // 
            this.venta_vehiculosDataSet1.DataSetName = "venta_vehiculosDataSet1";
            this.venta_vehiculosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.venta_vehiculosDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Location = new System.Drawing.Point(108, 286);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(101, 23);
            this.btn_AgregarCliente.TabIndex = 18;
            this.btn_AgregarCliente.Text = "Agregar";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 448);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "IPC2 Sección B";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_vehiculo.ResumeLayout(false);
            this.tab_vehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_vehiculosDataSet)).EndInit();
            this.tab_clientes.ResumeLayout(false);
            this.tab_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_vehiculosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_vehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ingresar;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_matricula;
        private System.Windows.Forms.ComboBox combobox_color;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richtextbox_descripcion;
        private System.Windows.Forms.TextBox textbox_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combobox_matricula;
        private venta_vehiculosDataSet venta_vehiculosDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private venta_vehiculosDataSetTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_nuevovalor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combobox_campo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_nuevodato;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox_campocliente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox_codcliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private venta_vehiculosDataSet1 venta_vehiculosDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private venta_vehiculosDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btn_AgregarCliente;
    }
}

