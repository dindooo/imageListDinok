namespace imageListDinoK
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcrSlike = new System.Windows.Forms.PictureBox();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcrSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // pcrSlike
            // 
            this.pcrSlike.Location = new System.Drawing.Point(79, 46);
            this.pcrSlike.Name = "pcrSlike";
            this.pcrSlike.Size = new System.Drawing.Size(331, 170);
            this.pcrSlike.TabIndex = 0;
            this.pcrSlike.TabStop = false;
            this.pcrSlike.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgLista
            // 
            this.imgLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLista.ImageStream")));
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLista.Images.SetKeyName(0, "Ucinoca2.jpg");
            this.imgLista.Images.SetKeyName(1, "Ucionica23.jpg");
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(79, 255);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(139, 30);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Promjeni sliku";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.pcrSlike);
            this.Name = "Form1";
            this.Text = "ImageList";
            ((System.ComponentModel.ISupportInitialize)(this.pcrSlike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcrSlike;
        private System.Windows.Forms.ImageList imgLista;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

