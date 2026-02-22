namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generadorCuadros1 = new Ej6DI.GeneradorCuadros();
            this.SuspendLayout();
            // 
            // generadorCuadros1
            // 
            this.generadorCuadros1.Location = new System.Drawing.Point(1, 0);
            this.generadorCuadros1.Name = "generadorCuadros1";
            this.generadorCuadros1.Size = new System.Drawing.Size(1405, 798);
            this.generadorCuadros1.TabIndex = 0;
            this.generadorCuadros1.Tint = System.Drawing.Color.Black;
            this.generadorCuadros1.Weight = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 498);
            this.Controls.Add(this.generadorCuadros1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generados de cuadros aleatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private Ej6DI.GeneradorCuadros generadorCuadros1;
    }
}

