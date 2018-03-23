namespace WP_Server
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourS = new System.Windows.Forms.TextBox();
            this.txtYourR = new System.Windows.Forms.TextBox();
            this.ButBua = new System.Windows.Forms.Button();
            this.ButBao = new System.Windows.Forms.Button();
            this.ButKeo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Your Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Your Selection :";
            // 
            // txtYourS
            // 
            this.txtYourS.Location = new System.Drawing.Point(127, 65);
            this.txtYourS.Name = "txtYourS";
            this.txtYourS.Size = new System.Drawing.Size(160, 20);
            this.txtYourS.TabIndex = 18;
            // 
            // txtYourR
            // 
            this.txtYourR.Location = new System.Drawing.Point(127, 254);
            this.txtYourR.Name = "txtYourR";
            this.txtYourR.Size = new System.Drawing.Size(160, 20);
            this.txtYourR.TabIndex = 17;
            // 
            // ButBua
            // 
            this.ButBua.Location = new System.Drawing.Point(304, 141);
            this.ButBua.Name = "ButBua";
            this.ButBua.Size = new System.Drawing.Size(86, 66);
            this.ButBua.TabIndex = 16;
            this.ButBua.Text = "Búa";
            this.ButBua.UseVisualStyleBackColor = true;
            this.ButBua.Click += new System.EventHandler(this.ButBua_Click);
            // 
            // ButBao
            // 
            this.ButBao.Location = new System.Drawing.Point(197, 141);
            this.ButBao.Name = "ButBao";
            this.ButBao.Size = new System.Drawing.Size(90, 66);
            this.ButBao.TabIndex = 15;
            this.ButBao.Text = "Bao";
            this.ButBao.UseVisualStyleBackColor = true;
            this.ButBao.Click += new System.EventHandler(this.ButBao_Click);
            // 
            // ButKeo
            // 
            this.ButKeo.Location = new System.Drawing.Point(90, 141);
            this.ButKeo.Name = "ButKeo";
            this.ButKeo.Size = new System.Drawing.Size(88, 66);
            this.ButKeo.TabIndex = 14;
            this.ButKeo.Text = "Kéo";
            this.ButKeo.UseVisualStyleBackColor = true;
            this.ButKeo.Click += new System.EventHandler(this.ButKeo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Your client :";
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(127, 99);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(160, 20);
            this.txtclient.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourS);
            this.Controls.Add(this.txtYourR);
            this.Controls.Add(this.ButBua);
            this.Controls.Add(this.ButBao);
            this.Controls.Add(this.ButKeo);
            this.Name = "Form1";
            this.Text = "server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYourS;
        private System.Windows.Forms.TextBox txtYourR;
        private System.Windows.Forms.Button ButBua;
        private System.Windows.Forms.Button ButBao;
        private System.Windows.Forms.Button ButKeo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclient;
    }
}

