namespace Aplicacion_Conjuntos
{
    partial class FrmConjuntoDoble
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.txtConjuntoB = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnionAB = new System.Windows.Forms.TextBox();
            this.txtInterseccionAB = new System.Windows.Forms.TextBox();
            this.txtDiferenciaAB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 499);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conjunto A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conjunto B";
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.BackColor = System.Drawing.Color.DarkCyan;
            this.txtConjuntoA.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConjuntoA.ForeColor = System.Drawing.Color.White;
            this.txtConjuntoA.Location = new System.Drawing.Point(38, 117);
            this.txtConjuntoA.Margin = new System.Windows.Forms.Padding(6);
            this.txtConjuntoA.Multiline = true;
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.Size = new System.Drawing.Size(362, 363);
            this.txtConjuntoA.TabIndex = 2;
            // 
            // txtConjuntoB
            // 
            this.txtConjuntoB.BackColor = System.Drawing.Color.DarkCyan;
            this.txtConjuntoB.Font = new System.Drawing.Font("SimSun", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConjuntoB.ForeColor = System.Drawing.Color.White;
            this.txtConjuntoB.Location = new System.Drawing.Point(540, 118);
            this.txtConjuntoB.Margin = new System.Windows.Forms.Padding(6);
            this.txtConjuntoB.Multiline = true;
            this.txtConjuntoB.Name = "txtConjuntoB";
            this.txtConjuntoB.Size = new System.Drawing.Size(362, 362);
            this.txtConjuntoB.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MintCream;
            this.btnLimpiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(319, 1031);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(532, 48);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.Azure;
            this.btnOperar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOperar.Location = new System.Drawing.Point(319, 902);
            this.btnOperar.Margin = new System.Windows.Forms.Padding(6);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(532, 75);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Realizar Operacion ";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Union";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Interseccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 754);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diferencia";
            // 
            // txtUnionAB
            // 
            this.txtUnionAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnionAB.Location = new System.Drawing.Point(505, 231);
            this.txtUnionAB.Margin = new System.Windows.Forms.Padding(6);
            this.txtUnionAB.Name = "txtUnionAB";
            this.txtUnionAB.Size = new System.Drawing.Size(346, 49);
            this.txtUnionAB.TabIndex = 5;
            // 
            // txtInterseccionAB
            // 
            this.txtInterseccionAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterseccionAB.Location = new System.Drawing.Point(505, 470);
            this.txtInterseccionAB.Margin = new System.Windows.Forms.Padding(6);
            this.txtInterseccionAB.Name = "txtInterseccionAB";
            this.txtInterseccionAB.Size = new System.Drawing.Size(346, 49);
            this.txtInterseccionAB.TabIndex = 6;
            // 
            // txtDiferenciaAB
            // 
            this.txtDiferenciaAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiferenciaAB.Location = new System.Drawing.Point(505, 742);
            this.txtDiferenciaAB.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiferenciaAB.Name = "txtDiferenciaAB";
            this.txtDiferenciaAB.Size = new System.Drawing.Size(346, 49);
            this.txtDiferenciaAB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtDiferenciaAB);
            this.panel1.Controls.Add(this.btnOperar);
            this.panel1.Controls.Add(this.txtInterseccionAB);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtUnionAB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(992, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 1103);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MintCream;
            this.btnSalir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(1073, 50);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(282, 48);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConjuntoDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2442, 1103);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConjuntoB);
            this.Controls.Add(this.txtConjuntoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmConjuntoDoble";
            this.Text = "Conjuntos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConjuntoA;
        private System.Windows.Forms.TextBox txtConjuntoB;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnionAB;
        private System.Windows.Forms.TextBox txtInterseccionAB;
        private System.Windows.Forms.TextBox txtDiferenciaAB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}

