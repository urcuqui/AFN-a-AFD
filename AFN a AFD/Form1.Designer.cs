namespace AFN_a_AFD
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_alfabeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_estados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_inicio = new System.Windows.Forms.TextBox();
            this.btn_transiciones = new System.Windows.Forms.Button();
            this.label_formula = new System.Windows.Forms.Label();
            this.list_q = new System.Windows.Forms.ListBox();
            this.list_s = new System.Windows.Forms.ListBox();
            this.label_q = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.list_qi = new System.Windows.Forms.ListBox();
            this.label_qi = new System.Windows.Forms.Label();
            this.btn_agregarAFuncion = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_aceptacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos separados por \r\ncomas en los siguientes campos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Σ=";
            // 
            // txt_alfabeto
            // 
            this.txt_alfabeto.Location = new System.Drawing.Point(41, 109);
            this.txt_alfabeto.Name = "txt_alfabeto";
            this.txt_alfabeto.Size = new System.Drawing.Size(61, 20);
            this.txt_alfabeto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Q=";
            // 
            // txt_estados
            // 
            this.txt_estados.Location = new System.Drawing.Point(41, 138);
            this.txt_estados.Name = "txt_estados";
            this.txt_estados.Size = new System.Drawing.Size(147, 20);
            this.txt_estados.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "q0=";
            // 
            // txt_inicio
            // 
            this.txt_inicio.Location = new System.Drawing.Point(41, 164);
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(25, 20);
            this.txt_inicio.TabIndex = 6;
            // 
            // btn_transiciones
            // 
            this.btn_transiciones.Location = new System.Drawing.Point(41, 228);
            this.btn_transiciones.Name = "btn_transiciones";
            this.btn_transiciones.Size = new System.Drawing.Size(75, 35);
            this.btn_transiciones.TabIndex = 7;
            this.btn_transiciones.Text = "generar \r\nfunción";
            this.btn_transiciones.UseVisualStyleBackColor = true;
            this.btn_transiciones.Click += new System.EventHandler(this.btn_transiciones_Click);
            // 
            // label_formula
            // 
            this.label_formula.AutoSize = true;
            this.label_formula.BackColor = System.Drawing.SystemColors.WindowText;
            this.label_formula.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_formula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_formula.Location = new System.Drawing.Point(283, 109);
            this.label_formula.Name = "label_formula";
            this.label_formula.Size = new System.Drawing.Size(56, 14);
            this.label_formula.TabIndex = 8;
            this.label_formula.Text = "∆(q,s)=qi";
            this.label_formula.Visible = false;
            // 
            // list_q
            // 
            this.list_q.FormattingEnabled = true;
            this.list_q.HorizontalScrollbar = true;
            this.list_q.Location = new System.Drawing.Point(257, 138);
            this.list_q.Name = "list_q";
            this.list_q.Size = new System.Drawing.Size(40, 95);
            this.list_q.TabIndex = 9;
            this.list_q.Visible = false;
            // 
            // list_s
            // 
            this.list_s.FormattingEnabled = true;
            this.list_s.HorizontalScrollbar = true;
            this.list_s.Location = new System.Drawing.Point(313, 138);
            this.list_s.Name = "list_s";
            this.list_s.Size = new System.Drawing.Size(36, 95);
            this.list_s.TabIndex = 10;
            this.list_s.Visible = false;
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.BackColor = System.Drawing.SystemColors.WindowText;
            this.label_q.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_q.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_q.Location = new System.Drawing.Point(263, 123);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(14, 14);
            this.label_q.TabIndex = 11;
            this.label_q.Text = "q";
            this.label_q.Visible = false;
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.BackColor = System.Drawing.SystemColors.WindowText;
            this.label_s.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_s.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_s.Location = new System.Drawing.Point(313, 123);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(12, 14);
            this.label_s.TabIndex = 12;
            this.label_s.Text = "s";
            this.label_s.Visible = false;
            // 
            // list_qi
            // 
            this.list_qi.FormattingEnabled = true;
            this.list_qi.HorizontalScrollbar = true;
            this.list_qi.Location = new System.Drawing.Point(358, 138);
            this.list_qi.Name = "list_qi";
            this.list_qi.Size = new System.Drawing.Size(34, 95);
            this.list_qi.TabIndex = 13;
            this.list_qi.Visible = false;
            // 
            // label_qi
            // 
            this.label_qi.AutoSize = true;
            this.label_qi.BackColor = System.Drawing.SystemColors.WindowText;
            this.label_qi.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_qi.Location = new System.Drawing.Point(355, 123);
            this.label_qi.Name = "label_qi";
            this.label_qi.Size = new System.Drawing.Size(17, 14);
            this.label_qi.TabIndex = 14;
            this.label_qi.Text = "qi";
            this.label_qi.Visible = false;
            // 
            // btn_agregarAFuncion
            // 
            this.btn_agregarAFuncion.Location = new System.Drawing.Point(257, 240);
            this.btn_agregarAFuncion.Name = "btn_agregarAFuncion";
            this.btn_agregarAFuncion.Size = new System.Drawing.Size(57, 23);
            this.btn_agregarAFuncion.TabIndex = 15;
            this.btn_agregarAFuncion.Text = "agregar";
            this.btn_agregarAFuncion.UseVisualStyleBackColor = true;
            this.btn_agregarAFuncion.Visible = false;
            this.btn_agregarAFuncion.Click += new System.EventHandler(this.btn_agregarAFuncion_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(257, 270);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_finalizar.TabIndex = 16;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Visible = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.WindowText;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "F=";
            // 
            // txt_aceptacion
            // 
            this.txt_aceptacion.Location = new System.Drawing.Point(39, 190);
            this.txt_aceptacion.Name = "txt_aceptacion";
            this.txt_aceptacion.Size = new System.Drawing.Size(147, 20);
            this.txt_aceptacion.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AFN_a_AFD.Properties.Resources.la_tierra_desde_la_luna_para_AFN_AFD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 366);
            this.Controls.Add(this.txt_aceptacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_agregarAFuncion);
            this.Controls.Add(this.label_qi);
            this.Controls.Add(this.list_qi);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_q);
            this.Controls.Add(this.list_s);
            this.Controls.Add(this.list_q);
            this.Controls.Add(this.label_formula);
            this.Controls.Add(this.btn_transiciones);
            this.Controls.Add(this.txt_inicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_estados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_alfabeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de información";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_alfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_estados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_inicio;
        private System.Windows.Forms.Button btn_transiciones;
        private System.Windows.Forms.Label label_formula;
        private System.Windows.Forms.ListBox list_q;
        private System.Windows.Forms.ListBox list_s;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.ListBox list_qi;
        private System.Windows.Forms.Label label_qi;
        private System.Windows.Forms.Button btn_agregarAFuncion;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_aceptacion;
    }
}

