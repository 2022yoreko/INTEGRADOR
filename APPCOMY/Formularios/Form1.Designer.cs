
namespace APPCOMY
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIniciar = new System.Windows.Forms.Button();
            this.txtRegistrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMANDO PARTE DEL CAMBIO";
            // 
            // txtIniciar
            // 
            this.txtIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.txtIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIniciar.BackgroundImage")));
            this.txtIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.txtIniciar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtIniciar.Location = new System.Drawing.Point(12, 428);
            this.txtIniciar.MaximumSize = new System.Drawing.Size(70, 70);
            this.txtIniciar.Name = "txtIniciar";
            this.txtIniciar.Size = new System.Drawing.Size(70, 70);
            this.txtIniciar.TabIndex = 2;
            this.txtIniciar.UseVisualStyleBackColor = false;
            this.txtIniciar.Click += new System.EventHandler(this.txtIniciar_Click);
            // 
            // txtRegistrate
            // 
            this.txtRegistrate.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtRegistrate.BackgroundImage")));
            this.txtRegistrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtRegistrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRegistrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(162)))));
            this.txtRegistrate.Location = new System.Drawing.Point(12, 362);
            this.txtRegistrate.MaximumSize = new System.Drawing.Size(60, 60);
            this.txtRegistrate.Name = "txtRegistrate";
            this.txtRegistrate.Size = new System.Drawing.Size(60, 60);
            this.txtRegistrate.TabIndex = 3;
            this.txtRegistrate.UseVisualStyleBackColor = false;
            this.txtRegistrate.Click += new System.EventHandler(this.txtRegistrate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APPCOMY.Properties.Resources.Imagen_de_APPCOMY2;
            this.ClientSize = new System.Drawing.Size(654, 510);
            this.Controls.Add(this.txtRegistrate);
            this.Controls.Add(this.txtIniciar);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(670, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtIniciar;
        private System.Windows.Forms.Button txtRegistrate;
    }
}

