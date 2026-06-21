namespace RayoMcQueen
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
            this.components = new System.ComponentModel.Container();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.btnLuces = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLuces = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReversa = new System.Windows.Forms.Button();
            this.timerFreno = new System.Windows.Forms.Timer(this.components);
            this.timerAcelerar = new System.Windows.Forms.Timer(this.components);
            this.timerInercia = new System.Windows.Forms.Timer(this.components);
            this.timerEncender = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(38, 34);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(206, 30);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado: Apagado";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.Location = new System.Drawing.Point(38, 73);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(216, 30);
            this.lblVelocidad.TabIndex = 1;
            this.lblVelocidad.Text = "Velocidad: 0 km/h";
            // 
            // btnEncender
            // 
            this.btnEncender.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender.Location = new System.Drawing.Point(203, 248);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(125, 33);
            this.btnEncender.TabIndex = 2;
            this.btnEncender.Text = "Encender";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            this.btnEncender.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEncender_MouseDown);
            this.btnEncender.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEncender_MouseUp);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(334, 248);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(125, 33);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcelerar.Location = new System.Drawing.Point(203, 287);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(125, 33);
            this.btnAcelerar.TabIndex = 4;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            this.btnAcelerar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAcelerar_MouseDown);
            this.btnAcelerar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAcelerar_MouseUp);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrenar.Location = new System.Drawing.Point(334, 287);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(125, 33);
            this.btnFrenar.TabIndex = 5;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            this.btnFrenar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFrenar_MouseDown);
            this.btnFrenar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFrenar_MouseUp);
            // 
            // btnLuces
            // 
            this.btnLuces.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuces.Location = new System.Drawing.Point(465, 287);
            this.btnLuces.Name = "btnLuces";
            this.btnLuces.Size = new System.Drawing.Size(125, 33);
            this.btnLuces.TabIndex = 6;
            this.btnLuces.Text = "Luces";
            this.btnLuces.UseVisualStyleBackColor = true;
            this.btnLuces.Click += new System.EventHandler(this.btnLuces_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RayoMcQueen.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(0, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblLuces
            // 
            this.lblLuces.AutoSize = true;
            this.lblLuces.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuces.Location = new System.Drawing.Point(38, 115);
            this.lblLuces.Name = "lblLuces";
            this.lblLuces.Size = new System.Drawing.Size(209, 30);
            this.lblLuces.TabIndex = 8;
            this.lblLuces.Text = "Luces: Apagadas";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(38, 152);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(270, 30);
            this.lblMarca.TabIndex = 9;
            this.lblMarca.Text = "Marca: Rayo McQueen";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(38, 192);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(205, 30);
            this.lblAccion.TabIndex = 10;
            this.lblAccion.Text = "Listo para correr";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReversa
            // 
            this.btnReversa.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReversa.Location = new System.Drawing.Point(465, 248);
            this.btnReversa.Name = "btnReversa";
            this.btnReversa.Size = new System.Drawing.Size(125, 33);
            this.btnReversa.TabIndex = 11;
            this.btnReversa.Text = "Reversa";
            this.btnReversa.UseVisualStyleBackColor = true;
            this.btnReversa.Click += new System.EventHandler(this.btnReversa_Click);
            // 
            // timerFreno
            // 
            this.timerFreno.Interval = 60;
            this.timerFreno.Tick += new System.EventHandler(this.timerFreno_Tick);
            // 
            // timerAcelerar
            // 
            this.timerAcelerar.Tick += new System.EventHandler(this.timerAcelerar_Tick);
            // 
            // timerInercia
            // 
            this.timerInercia.Interval = 200;
            this.timerInercia.Tick += new System.EventHandler(this.timerInercia_Tick);
            // 
            // timerEncender
            // 
            this.timerEncender.Tick += new System.EventHandler(this.timerEncender_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RayoMcQueen.Properties.Resources.ChatGPT_Image_17_jun_2026__09_59_24_p_m_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1486, 826);
            this.Controls.Add(this.btnReversa);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblLuces);
            this.Controls.Add(this.btnLuces);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Rayo McQueen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrenar;
        private System.Windows.Forms.Button btnLuces;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLuces;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReversa;
        private System.Windows.Forms.Timer timerFreno;
        private System.Windows.Forms.Timer timerAcelerar;
        private System.Windows.Forms.Timer timerInercia;
        private System.Windows.Forms.Timer timerEncender;
    }
}

