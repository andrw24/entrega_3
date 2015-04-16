namespace AppColores
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.chkColor1 = new System.Windows.Forms.CheckBox();
            this.chkColor2 = new System.Windows.Forms.CheckBox();
            this.chkColor3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(98, 112);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkColor1
            // 
            this.chkColor1.AutoSize = true;
            this.chkColor1.Location = new System.Drawing.Point(45, 30);
            this.chkColor1.Name = "chkColor1";
            this.chkColor1.Size = new System.Drawing.Size(62, 17);
            this.chkColor1.TabIndex = 1;
            this.chkColor1.Text = "Amarillo";
            this.chkColor1.UseVisualStyleBackColor = true;
            // 
            // chkColor2
            // 
            this.chkColor2.AutoSize = true;
            this.chkColor2.Location = new System.Drawing.Point(45, 53);
            this.chkColor2.Name = "chkColor2";
            this.chkColor2.Size = new System.Drawing.Size(46, 17);
            this.chkColor2.TabIndex = 2;
            this.chkColor2.Text = "Azul";
            this.chkColor2.UseVisualStyleBackColor = true;
            // 
            // chkColor3
            // 
            this.chkColor3.AutoSize = true;
            this.chkColor3.Location = new System.Drawing.Point(45, 76);
            this.chkColor3.Name = "chkColor3";
            this.chkColor3.Size = new System.Drawing.Size(48, 17);
            this.chkColor3.TabIndex = 3;
            this.chkColor3.Text = "Rojo";
            this.chkColor3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkColor3);
            this.Controls.Add(this.chkColor2);
            this.Controls.Add(this.chkColor1);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "Form1";
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.CheckBox chkColor1;
        private System.Windows.Forms.CheckBox chkColor2;
        private System.Windows.Forms.CheckBox chkColor3;
    }
}

