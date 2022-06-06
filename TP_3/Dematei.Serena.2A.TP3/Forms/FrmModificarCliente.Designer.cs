
namespace Forms
{
    partial class FrmModificarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AceptarCambios = new System.Windows.Forms.Button();
            this.btn_CancelarCambios = new System.Windows.Forms.Button();
            this.rtb_ClienteEncontrado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente encontrado:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(235, 272);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PlaceholderText = "(solo uno)";
            this.tb_nombre.Size = new System.Drawing.Size(235, 27);
            this.tb_nombre.TabIndex = 4;
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(235, 323);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.PlaceholderText = "(solo uno)";
            this.tb_Apellido.Size = new System.Drawing.Size(235, 27);
            this.tb_Apellido.TabIndex = 5;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(235, 382);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.PlaceholderText = "(10 digitos)";
            this.tb_telefono.Size = new System.Drawing.Size(235, 27);
            this.tb_telefono.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(150, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(150, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(147, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono:";
            // 
            // btn_AceptarCambios
            // 
            this.btn_AceptarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_AceptarCambios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AceptarCambios.Location = new System.Drawing.Point(456, 473);
            this.btn_AceptarCambios.Name = "btn_AceptarCambios";
            this.btn_AceptarCambios.Size = new System.Drawing.Size(218, 41);
            this.btn_AceptarCambios.TabIndex = 10;
            this.btn_AceptarCambios.Text = "Aceptar cambios";
            this.btn_AceptarCambios.UseVisualStyleBackColor = false;
            this.btn_AceptarCambios.Click += new System.EventHandler(this.btn_AceptarCambios_Click);
            // 
            // btn_CancelarCambios
            // 
            this.btn_CancelarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CancelarCambios.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarCambios.Location = new System.Drawing.Point(38, 473);
            this.btn_CancelarCambios.Name = "btn_CancelarCambios";
            this.btn_CancelarCambios.Size = new System.Drawing.Size(220, 41);
            this.btn_CancelarCambios.TabIndex = 11;
            this.btn_CancelarCambios.Text = "Descartar cambios";
            this.btn_CancelarCambios.UseVisualStyleBackColor = false;
            this.btn_CancelarCambios.Click += new System.EventHandler(this.btn_CancelarCambios_Click);
            // 
            // rtb_ClienteEncontrado
            // 
            this.rtb_ClienteEncontrado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_ClienteEncontrado.Location = new System.Drawing.Point(214, 37);
            this.rtb_ClienteEncontrado.Name = "rtb_ClienteEncontrado";
            this.rtb_ClienteEncontrado.Size = new System.Drawing.Size(315, 120);
            this.rtb_ClienteEncontrado.TabIndex = 12;
            this.rtb_ClienteEncontrado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese nuevos datos:";
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(720, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_ClienteEncontrado);
            this.Controls.Add(this.btn_CancelarCambios);
            this.Controls.Add(this.btn_AceptarCambios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_Apellido);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AceptarCambios;
        private System.Windows.Forms.Button btn_CancelarCambios;
        private System.Windows.Forms.RichTextBox rtb_ClienteEncontrado;
        private System.Windows.Forms.Label label1;
    }
}