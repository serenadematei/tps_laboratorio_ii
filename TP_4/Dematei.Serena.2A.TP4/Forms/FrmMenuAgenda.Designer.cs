
namespace Forms
{
    partial class FrmMenuAgenda
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
            this.btn_nuevoTurno = new System.Windows.Forms.Button();
            this.btn_CancelarTurno = new System.Windows.Forms.Button();
            this.btn_ListarTurnos = new System.Windows.Forms.Button();
            this.listBox_Turnos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_OrdenarPorFecha = new System.Windows.Forms.Button();
            this.btn_OrdenarPorNombre = new System.Windows.Forms.Button();
            this.btn_Serializar = new System.Windows.Forms.Button();
            this.btn_ImprimirTurno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nuevoTurno
            // 
            this.btn_nuevoTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_nuevoTurno.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nuevoTurno.Location = new System.Drawing.Point(11, 151);
            this.btn_nuevoTurno.Name = "btn_nuevoTurno";
            this.btn_nuevoTurno.Size = new System.Drawing.Size(246, 47);
            this.btn_nuevoTurno.TabIndex = 0;
            this.btn_nuevoTurno.Text = "Agendar nuevo turno";
            this.btn_nuevoTurno.UseVisualStyleBackColor = false;
            this.btn_nuevoTurno.Click += new System.EventHandler(this.btn_nuevoTurno_Click);
            // 
            // btn_CancelarTurno
            // 
            this.btn_CancelarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CancelarTurno.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarTurno.Location = new System.Drawing.Point(10, 216);
            this.btn_CancelarTurno.Name = "btn_CancelarTurno";
            this.btn_CancelarTurno.Size = new System.Drawing.Size(249, 47);
            this.btn_CancelarTurno.TabIndex = 1;
            this.btn_CancelarTurno.Text = "Cancelar turno";
            this.btn_CancelarTurno.UseVisualStyleBackColor = false;
            this.btn_CancelarTurno.Click += new System.EventHandler(this.btn_CancelarTurno_Click);
            // 
            // btn_ListarTurnos
            // 
            this.btn_ListarTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ListarTurnos.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ListarTurnos.Location = new System.Drawing.Point(14, 548);
            this.btn_ListarTurnos.Name = "btn_ListarTurnos";
            this.btn_ListarTurnos.Size = new System.Drawing.Size(238, 63);
            this.btn_ListarTurnos.TabIndex = 2;
            this.btn_ListarTurnos.Text = "Actualizar turnos";
            this.btn_ListarTurnos.UseVisualStyleBackColor = false;
            this.btn_ListarTurnos.Click += new System.EventHandler(this.btn_ListarTurnos_Click);
            // 
            // listBox_Turnos
            // 
            this.listBox_Turnos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Turnos.FormattingEnabled = true;
            this.listBox_Turnos.ItemHeight = 25;
            this.listBox_Turnos.Location = new System.Drawing.Point(280, 134);
            this.listBox_Turnos.Name = "listBox_Turnos";
            this.listBox_Turnos.Size = new System.Drawing.Size(1032, 554);
            this.listBox_Turnos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(428, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(721, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(842, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1101, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "SERVICIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1226, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "TIPO";
            // 
            // btn_OrdenarPorFecha
            // 
            this.btn_OrdenarPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_OrdenarPorFecha.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OrdenarPorFecha.Location = new System.Drawing.Point(10, 284);
            this.btn_OrdenarPorFecha.Name = "btn_OrdenarPorFecha";
            this.btn_OrdenarPorFecha.Size = new System.Drawing.Size(248, 48);
            this.btn_OrdenarPorFecha.TabIndex = 10;
            this.btn_OrdenarPorFecha.Text = "Ordenar por fecha";
            this.btn_OrdenarPorFecha.UseVisualStyleBackColor = false;
            this.btn_OrdenarPorFecha.Click += new System.EventHandler(this.btn_OrdenarPorFecha_Click);
            // 
            // btn_OrdenarPorNombre
            // 
            this.btn_OrdenarPorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_OrdenarPorNombre.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OrdenarPorNombre.Location = new System.Drawing.Point(11, 347);
            this.btn_OrdenarPorNombre.Name = "btn_OrdenarPorNombre";
            this.btn_OrdenarPorNombre.Size = new System.Drawing.Size(247, 48);
            this.btn_OrdenarPorNombre.TabIndex = 11;
            this.btn_OrdenarPorNombre.Text = "Ordenar por apellido";
            this.btn_OrdenarPorNombre.UseVisualStyleBackColor = false;
            this.btn_OrdenarPorNombre.Click += new System.EventHandler(this.btn_OrdenarPorNombre_Click);
            // 
            // btn_Serializar
            // 
            this.btn_Serializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Serializar.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Serializar.Location = new System.Drawing.Point(14, 632);
            this.btn_Serializar.Name = "btn_Serializar";
            this.btn_Serializar.Size = new System.Drawing.Size(238, 66);
            this.btn_Serializar.TabIndex = 12;
            this.btn_Serializar.Text = "Guardar cambios";
            this.btn_Serializar.UseVisualStyleBackColor = false;
            this.btn_Serializar.Click += new System.EventHandler(this.btn_Serializar_Click);
            // 
            // btn_ImprimirTurno
            // 
            this.btn_ImprimirTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ImprimirTurno.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ImprimirTurno.Location = new System.Drawing.Point(10, 412);
            this.btn_ImprimirTurno.Name = "btn_ImprimirTurno";
            this.btn_ImprimirTurno.Size = new System.Drawing.Size(247, 48);
            this.btn_ImprimirTurno.TabIndex = 13;
            this.btn_ImprimirTurno.Text = "Imprimir tarjeta de turno";
            this.btn_ImprimirTurno.UseVisualStyleBackColor = false;
            this.btn_ImprimirTurno.Click += new System.EventHandler(this.btn_ImprimirTurno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "FECHA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(570, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "APELLIDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(971, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "MINUTOS";
            // 
            // FrmMenuAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1448, 716);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ImprimirTurno);
            this.Controls.Add(this.btn_Serializar);
            this.Controls.Add(this.btn_OrdenarPorNombre);
            this.Controls.Add(this.btn_OrdenarPorFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Turnos);
            this.Controls.Add(this.btn_ListarTurnos);
            this.Controls.Add(this.btn_CancelarTurno);
            this.Controls.Add(this.btn_nuevoTurno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuAgenda_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoTurno;
        private System.Windows.Forms.Button btn_CancelarTurno;
        private System.Windows.Forms.Button btn_ListarTurnos;
        private System.Windows.Forms.ListBox listBox_Turnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_OrdenarPorFecha;
        private System.Windows.Forms.Button btn_OrdenarPorNombre;
        private System.Windows.Forms.Button btn_Serializar;
        private System.Windows.Forms.Button btn_ImprimirTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}