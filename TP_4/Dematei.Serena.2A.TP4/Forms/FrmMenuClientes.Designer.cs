
namespace Forms
{
    partial class FrmMenuClientes
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
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.btn_EliminarCliente = new System.Windows.Forms.Button();
            this.btn_ActualizarLista = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ModificarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.btn_Serializar = new System.Windows.Forms.Button();
            this.listBox_Clientes = new System.Windows.Forms.ListBox();
            this.btn_CambiarColores = new System.Windows.Forms.Button();
            this.btn_CantidadClientes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CargarCliente.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarCliente.Location = new System.Drawing.Point(42, 76);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(382, 45);
            this.btn_CargarCliente.TabIndex = 0;
            this.btn_CargarCliente.Text = "Cargar nuevo cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = false;
            this.btn_CargarCliente.Click += new System.EventHandler(this.btn_CargarCliente_Click);
            // 
            // btn_EliminarCliente
            // 
            this.btn_EliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_EliminarCliente.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarCliente.Location = new System.Drawing.Point(42, 143);
            this.btn_EliminarCliente.Name = "btn_EliminarCliente";
            this.btn_EliminarCliente.Size = new System.Drawing.Size(382, 44);
            this.btn_EliminarCliente.TabIndex = 1;
            this.btn_EliminarCliente.Text = "Eliminar cliente";
            this.btn_EliminarCliente.UseVisualStyleBackColor = false;
            this.btn_EliminarCliente.Click += new System.EventHandler(this.btn_EliminarCliente_Click);
            // 
            // btn_ActualizarLista
            // 
            this.btn_ActualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ActualizarLista.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ActualizarLista.Location = new System.Drawing.Point(131, 525);
            this.btn_ActualizarLista.Name = "btn_ActualizarLista";
            this.btn_ActualizarLista.Size = new System.Drawing.Size(211, 64);
            this.btn_ActualizarLista.TabIndex = 2;
            this.btn_ActualizarLista.Text = "Actualizar lista";
            this.btn_ActualizarLista.UseVisualStyleBackColor = false;
            this.btn_ActualizarLista.Click += new System.EventHandler(this.btn_ActualizarLista_Click);
            // 
            // btn_ModificarCliente
            // 
            this.btn_ModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ModificarCliente.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModificarCliente.Location = new System.Drawing.Point(42, 209);
            this.btn_ModificarCliente.Name = "btn_ModificarCliente";
            this.btn_ModificarCliente.Size = new System.Drawing.Size(382, 44);
            this.btn_ModificarCliente.TabIndex = 9;
            this.btn_ModificarCliente.Text = "Modificar cliente";
            this.btn_ModificarCliente.UseVisualStyleBackColor = false;
            this.btn_ModificarCliente.Click += new System.EventHandler(this.btn_ModificarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1035, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefono";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(693, 45);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(66, 20);
            this.lbl4.TabIndex = 14;
            this.lbl4.Text = "Apellido";
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Ordenar.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ordenar.Location = new System.Drawing.Point(42, 276);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(382, 45);
            this.btn_Ordenar.TabIndex = 15;
            this.btn_Ordenar.Text = "Ordenar por apellido";
            this.btn_Ordenar.UseVisualStyleBackColor = false;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // btn_Serializar
            // 
            this.btn_Serializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Serializar.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Serializar.Location = new System.Drawing.Point(42, 343);
            this.btn_Serializar.Name = "btn_Serializar";
            this.btn_Serializar.Size = new System.Drawing.Size(382, 44);
            this.btn_Serializar.TabIndex = 16;
            this.btn_Serializar.Text = "Guardar lista actual en archivo JSON";
            this.btn_Serializar.UseVisualStyleBackColor = false;
            this.btn_Serializar.Click += new System.EventHandler(this.btn_Serializar_Click);
            // 
            // listBox_Clientes
            // 
            this.listBox_Clientes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Clientes.FormattingEnabled = true;
            this.listBox_Clientes.ItemHeight = 25;
            this.listBox_Clientes.Location = new System.Drawing.Point(511, 76);
            this.listBox_Clientes.Name = "listBox_Clientes";
            this.listBox_Clientes.Size = new System.Drawing.Size(630, 479);
            this.listBox_Clientes.TabIndex = 10;
            // 
            // btn_CambiarColores
            // 
            this.btn_CambiarColores.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_CambiarColores.Location = new System.Drawing.Point(0, -1);
            this.btn_CambiarColores.Name = "btn_CambiarColores";
            this.btn_CambiarColores.Size = new System.Drawing.Size(324, 30);
            this.btn_CambiarColores.TabIndex = 17;
            this.btn_CambiarColores.Text = "Cambiar colores de botones al hacer clic";
            this.btn_CambiarColores.UseVisualStyleBackColor = false;
            this.btn_CambiarColores.Click += new System.EventHandler(this.btn_CambiarColores_Click);
            // 
            // btn_CantidadClientes
            // 
            this.btn_CantidadClientes.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_CantidadClientes.Location = new System.Drawing.Point(511, 576);
            this.btn_CantidadClientes.Name = "btn_CantidadClientes";
            this.btn_CantidadClientes.Size = new System.Drawing.Size(324, 30);
            this.btn_CantidadClientes.TabIndex = 18;
            this.btn_CantidadClientes.Text = "Cantidad total actual de clientes:";
            this.btn_CantidadClientes.UseVisualStyleBackColor = false;
            this.btn_CantidadClientes.Click += new System.EventHandler(this.btn_CantidadClientes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(860, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = " ";
            // 
            // FrmMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1231, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CantidadClientes);
            this.Controls.Add(this.btn_CambiarColores);
            this.Controls.Add(this.btn_Serializar);
            this.Controls.Add(this.btn_Ordenar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Clientes);
            this.Controls.Add(this.btn_ModificarCliente);
            this.Controls.Add(this.btn_ActualizarLista);
            this.Controls.Add(this.btn_EliminarCliente);
            this.Controls.Add(this.btn_CargarCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu De Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CargarCliente;
        private System.Windows.Forms.Button btn_EliminarCliente;
        private System.Windows.Forms.Button btn_ActualizarLista;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_ModificarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.Button btn_Serializar;
        private System.Windows.Forms.ListBox listBox_Clientes;
        private System.Windows.Forms.Button btn_CambiarColores;
        private System.Windows.Forms.Button btn_CantidadClientes;
        private System.Windows.Forms.Label label4;
    }
}