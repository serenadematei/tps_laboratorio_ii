
namespace Forms
{
    partial class FrmCargarDatosCliente
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
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.tb_Dni = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(90, 109);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.PlaceholderText = "Nombre(solo uno)";
            this.tb_Nombre.Size = new System.Drawing.Size(235, 27);
            this.tb_Nombre.TabIndex = 0;
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(90, 151);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.PlaceholderText = "Apellido(solo uno)";
            this.tb_Apellido.Size = new System.Drawing.Size(235, 27);
            this.tb_Apellido.TabIndex = 1;
            // 
            // tb_Dni
            // 
            this.tb_Dni.Location = new System.Drawing.Point(90, 199);
            this.tb_Dni.Name = "tb_Dni";
            this.tb_Dni.PlaceholderText = "Dni (8 digitos)";
            this.tb_Dni.Size = new System.Drawing.Size(235, 27);
            this.tb_Dni.TabIndex = 2;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(90, 244);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.PlaceholderText = "Telefono (10 digitos)";
            this.tb_Telefono.Size = new System.Drawing.Size(235, 27);
            this.tb_Telefono.TabIndex = 3;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_Aceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Aceptar.Location = new System.Drawing.Point(295, 322);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(131, 38);
            this.bt_Aceptar.TabIndex = 4;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = false;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese datos del cliente";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(12, 322);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(131, 38);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FrmCargarDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 372);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.tb_Dni);
            this.Controls.Add(this.tb_Apellido);
            this.Controls.Add(this.tb_Nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarDatosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.TextBox tb_Dni;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}