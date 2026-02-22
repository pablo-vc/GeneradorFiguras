namespace Ej6DI
{
    partial class GeneradorCuadros
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBrushSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDontFill = new System.Windows.Forms.RadioButton();
            this.rbFill = new System.Windows.Forms.RadioButton();
            this.btnUndo = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbBrown = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbPulple = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.btnBackground = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(311, 586);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(40, 37);
            this.btnSubstract.TabIndex = 5;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 586);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBrushSize
            // 
            this.lblBrushSize.AutoSize = true;
            this.lblBrushSize.Location = new System.Drawing.Point(313, 561);
            this.lblBrushSize.Name = "lblBrushSize";
            this.lblBrushSize.Size = new System.Drawing.Size(86, 20);
            this.lblBrushSize.TabIndex = 7;
            this.lblBrushSize.Text = "Brush Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDontFill);
            this.groupBox1.Controls.Add(this.rbFill);
            this.groupBox1.Location = new System.Drawing.Point(682, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill";
            // 
            // rbDontFill
            // 
            this.rbDontFill.AutoSize = true;
            this.rbDontFill.Checked = true;
            this.rbDontFill.Location = new System.Drawing.Point(74, 25);
            this.rbDontFill.Name = "rbDontFill";
            this.rbDontFill.Size = new System.Drawing.Size(54, 24);
            this.rbDontFill.TabIndex = 10;
            this.rbDontFill.TabStop = true;
            this.rbDontFill.Text = "No";
            this.rbDontFill.UseVisualStyleBackColor = true;
            // 
            // rbFill
            // 
            this.rbFill.AutoSize = true;
            this.rbFill.Location = new System.Drawing.Point(6, 25);
            this.rbFill.Name = "rbFill";
            this.rbFill.Size = new System.Drawing.Size(62, 24);
            this.rbFill.TabIndex = 9;
            this.rbFill.Text = "Yes";
            this.rbFill.UseVisualStyleBackColor = true;
            this.rbFill.CheckedChanged += new System.EventHandler(this.rbFill_CheckedChanged);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(915, 581);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(106, 42);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBrown);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Controls.Add(this.rbYellow);
            this.gbColor.Controls.Add(this.rbPulple);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbWhite);
            this.gbColor.Location = new System.Drawing.Point(1082, 136);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(253, 419);
            this.gbColor.TabIndex = 10;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // rbBrown
            // 
            this.rbBrown.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBrown.AutoSize = true;
            this.rbBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rbBrown.Location = new System.Drawing.Point(6, 383);
            this.rbBrown.Name = "rbBrown";
            this.rbBrown.Size = new System.Drawing.Size(64, 30);
            this.rbBrown.TabIndex = 22;
            this.rbBrown.TabStop = true;
            this.rbBrown.Text = "Brown";
            this.rbBrown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBrown.UseVisualStyleBackColor = false;
            this.rbBrown.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBlue.AutoSize = true;
            this.rbBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbBlue.Location = new System.Drawing.Point(6, 224);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(51, 30);
            this.rbBlue.TabIndex = 21;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlue.UseVisualStyleBackColor = false;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbYellow
            // 
            this.rbYellow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbYellow.AutoSize = true;
            this.rbYellow.BackColor = System.Drawing.Color.Yellow;
            this.rbYellow.Location = new System.Drawing.Point(6, 273);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(65, 30);
            this.rbYellow.TabIndex = 20;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbYellow.UseVisualStyleBackColor = false;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbPulple
            // 
            this.rbPulple.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPulple.AutoSize = true;
            this.rbPulple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbPulple.Location = new System.Drawing.Point(6, 331);
            this.rbPulple.Name = "rbPulple";
            this.rbPulple.Size = new System.Drawing.Size(64, 30);
            this.rbPulple.TabIndex = 19;
            this.rbPulple.TabStop = true;
            this.rbPulple.Text = "Purple";
            this.rbPulple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPulple.UseVisualStyleBackColor = false;
            this.rbPulple.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRed.AutoSize = true;
            this.rbRed.BackColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(6, 126);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(49, 30);
            this.rbRed.TabIndex = 18;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRed.UseVisualStyleBackColor = false;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbGreen.AutoSize = true;
            this.rbGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGreen.Location = new System.Drawing.Point(6, 177);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(64, 30);
            this.rbGreen.TabIndex = 17;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGreen.UseVisualStyleBackColor = false;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBlack.AutoSize = true;
            this.rbBlack.BackColor = System.Drawing.Color.Black;
            this.rbBlack.Checked = true;
            this.rbBlack.ForeColor = System.Drawing.Color.White;
            this.rbBlack.Location = new System.Drawing.Point(6, 29);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(58, 30);
            this.rbBlack.TabIndex = 11;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlack.UseVisualStyleBackColor = false;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbWhite
            // 
            this.rbWhite.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(6, 76);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(60, 30);
            this.rbWhite.TabIndex = 12;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(458, 581);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(140, 42);
            this.btnBackground.TabIndex = 11;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 418);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = global::Ej6DI.Properties.Resources.rectangle;
            this.btnRectangle.Location = new System.Drawing.Point(43, 467);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(178, 88);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Image = global::Ej6DI.Properties.Resources.triangle;
            this.btnTriangle.Location = new System.Drawing.Point(43, 351);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(178, 88);
            this.btnTriangle.TabIndex = 2;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Image = global::Ej6DI.Properties.Resources.circle;
            this.btnCircle.Location = new System.Drawing.Point(43, 245);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(178, 88);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = global::Ej6DI.Properties.Resources.line;
            this.btnLine.Location = new System.Drawing.Point(43, 136);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(178, 88);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // GeneradorCuadros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrushSize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLine);
            this.Name = "GeneradorCuadros";
            this.Size = new System.Drawing.Size(1405, 798);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBrushSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDontFill;
        private System.Windows.Forms.RadioButton rbFill;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.RadioButton rbBrown;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbPulple;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
    }
}
