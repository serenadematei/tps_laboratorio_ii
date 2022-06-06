
namespace Forms
{
    partial class FrmAgenda
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
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btn_nuevoTurno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Masaje = new System.Windows.Forms.RadioButton();
            this.rb_TerapiaHolistica = new System.Windows.Forms.RadioButton();
            this.rb_Ducha = new System.Windows.Forms.RadioButton();
            this.cmb_Holistica = new System.Windows.Forms.ComboBox();
            this.cmb_MinutosHolistica = new System.Windows.Forms.ComboBox();
            this.cmb_Ducha = new System.Windows.Forms.ComboBox();
            this.cmb_MinutosDucha = new System.Windows.Forms.ComboBox();
            this.cmb_MinutosMasaje = new System.Windows.Forms.ComboBox();
            this.cmb_Masaje = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(123, 77);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            // 
            // btn_nuevoTurno
            // 
            this.btn_nuevoTurno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_nuevoTurno.Location = new System.Drawing.Point(589, 687);
            this.btn_nuevoTurno.Name = "btn_nuevoTurno";
            this.btn_nuevoTurno.Size = new System.Drawing.Size(256, 47);
            this.btn_nuevoTurno.TabIndex = 1;
            this.btn_nuevoTurno.Text = "Agregar turno";
            this.btn_nuevoTurno.UseVisualStyleBackColor = true;
            this.btn_nuevoTurno.Click += new System.EventHandler(this.btn_nuevoTurno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Masaje);
            this.groupBox1.Controls.Add(this.rb_TerapiaHolistica);
            this.groupBox1.Controls.Add(this.rb_Ducha);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(123, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // rb_Masaje
            // 
            this.rb_Masaje.AutoSize = true;
            this.rb_Masaje.Location = new System.Drawing.Point(71, 37);
            this.rb_Masaje.Name = "rb_Masaje";
            this.rb_Masaje.Size = new System.Drawing.Size(77, 24);
            this.rb_Masaje.TabIndex = 0;
            this.rb_Masaje.TabStop = true;
            this.rb_Masaje.Text = "Masaje";
            this.rb_Masaje.UseVisualStyleBackColor = true;
            this.rb_Masaje.CheckedChanged += new System.EventHandler(this.rb_Masaje_CheckedChanged);
            // 
            // rb_TerapiaHolistica
            // 
            this.rb_TerapiaHolistica.AutoSize = true;
            this.rb_TerapiaHolistica.Location = new System.Drawing.Point(628, 37);
            this.rb_TerapiaHolistica.Name = "rb_TerapiaHolistica";
            this.rb_TerapiaHolistica.Size = new System.Drawing.Size(143, 24);
            this.rb_TerapiaHolistica.TabIndex = 2;
            this.rb_TerapiaHolistica.TabStop = true;
            this.rb_TerapiaHolistica.Text = "Terapia Holistica";
            this.rb_TerapiaHolistica.UseVisualStyleBackColor = true;
            this.rb_TerapiaHolistica.CheckedChanged += new System.EventHandler(this.rb_TerapiaHolistica_CheckedChanged);
            // 
            // rb_Ducha
            // 
            this.rb_Ducha.AutoSize = true;
            this.rb_Ducha.Location = new System.Drawing.Point(365, 37);
            this.rb_Ducha.Name = "rb_Ducha";
            this.rb_Ducha.Size = new System.Drawing.Size(75, 24);
            this.rb_Ducha.TabIndex = 1;
            this.rb_Ducha.TabStop = true;
            this.rb_Ducha.Text = "Ducha";
            this.rb_Ducha.UseVisualStyleBackColor = true;
            this.rb_Ducha.CheckedChanged += new System.EventHandler(this.rb_Ducha_CheckedChanged);
            // 
            // cmb_Holistica
            // 
            this.cmb_Holistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Holistica.FormattingEnabled = true;
            this.cmb_Holistica.Location = new System.Drawing.Point(611, 26);
            this.cmb_Holistica.Name = "cmb_Holistica";
            this.cmb_Holistica.Size = new System.Drawing.Size(151, 28);
            this.cmb_Holistica.TabIndex = 5;
            // 
            // cmb_MinutosHolistica
            // 
            this.cmb_MinutosHolistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MinutosHolistica.FormattingEnabled = true;
            this.cmb_MinutosHolistica.Location = new System.Drawing.Point(611, 26);
            this.cmb_MinutosHolistica.Name = "cmb_MinutosHolistica";
            this.cmb_MinutosHolistica.Size = new System.Drawing.Size(151, 28);
            this.cmb_MinutosHolistica.TabIndex = 8;
            // 
            // cmb_Ducha
            // 
            this.cmb_Ducha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ducha.FormattingEnabled = true;
            this.cmb_Ducha.Location = new System.Drawing.Point(333, 26);
            this.cmb_Ducha.Name = "cmb_Ducha";
            this.cmb_Ducha.Size = new System.Drawing.Size(151, 28);
            this.cmb_Ducha.TabIndex = 4;
            // 
            // cmb_MinutosDucha
            // 
            this.cmb_MinutosDucha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MinutosDucha.FormattingEnabled = true;
            this.cmb_MinutosDucha.Location = new System.Drawing.Point(333, 26);
            this.cmb_MinutosDucha.Name = "cmb_MinutosDucha";
            this.cmb_MinutosDucha.Size = new System.Drawing.Size(151, 28);
            this.cmb_MinutosDucha.TabIndex = 7;
            // 
            // cmb_MinutosMasaje
            // 
            this.cmb_MinutosMasaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MinutosMasaje.FormattingEnabled = true;
            this.cmb_MinutosMasaje.Location = new System.Drawing.Point(62, 25);
            this.cmb_MinutosMasaje.Name = "cmb_MinutosMasaje";
            this.cmb_MinutosMasaje.Size = new System.Drawing.Size(151, 28);
            this.cmb_MinutosMasaje.TabIndex = 6;
            // 
            // cmb_Masaje
            // 
            this.cmb_Masaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Masaje.FormattingEnabled = true;
            this.cmb_Masaje.Location = new System.Drawing.Point(62, 26);
            this.cmb_Masaje.Name = "cmb_Masaje";
            this.cmb_Masaje.Size = new System.Drawing.Size(151, 28);
            this.cmb_Masaje.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(480, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 284);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Masaje);
            this.groupBox2.Controls.Add(this.cmb_Ducha);
            this.groupBox2.Controls.Add(this.cmb_Holistica);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(123, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(236, 687);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(256, 49);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_MinutosMasaje);
            this.groupBox3.Controls.Add(this.cmb_MinutosDucha);
            this.groupBox3.Controls.Add(this.cmb_MinutosHolistica);
            this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(123, 585);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 68);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duracion(Minutos)";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1110, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_nuevoTurno);
            this.Controls.Add(this.calendario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btn_nuevoTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Holistica;
        private System.Windows.Forms.ComboBox cmb_Ducha;
        private System.Windows.Forms.ComboBox cmb_Masaje;
        private System.Windows.Forms.RadioButton rb_TerapiaHolistica;
        private System.Windows.Forms.RadioButton rb_Ducha;
        private System.Windows.Forms.RadioButton rb_Masaje;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmb_MinutosHolistica;
        private System.Windows.Forms.ComboBox cmb_MinutosDucha;
        private System.Windows.Forms.ComboBox cmb_MinutosMasaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}