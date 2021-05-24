
namespace MestintBeadando
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
            this.tablePB = new System.Windows.Forms.PictureBox();
            this.logPB = new System.Windows.Forms.PictureBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.srchCB = new System.Windows.Forms.ComboBox();
            this.stepLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePB
            // 
            this.tablePB.Location = new System.Drawing.Point(13, 13);
            this.tablePB.Name = "tablePB";
            this.tablePB.Size = new System.Drawing.Size(462, 425);
            this.tablePB.TabIndex = 0;
            this.tablePB.TabStop = false;
            this.tablePB.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // logPB
            // 
            this.logPB.Location = new System.Drawing.Point(500, 13);
            this.logPB.Name = "logPB";
            this.logPB.Size = new System.Drawing.Size(288, 178);
            this.logPB.TabIndex = 1;
            this.logPB.TabStop = false;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(204, 444);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(165, 42);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "Előző";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(375, 444);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(165, 42);
            this.nxtBtn.TabIndex = 3;
            this.nxtBtn.Text = "Következő";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // srchCB
            // 
            this.srchCB.FormattingEnabled = true;
            this.srchCB.Location = new System.Drawing.Point(12, 453);
            this.srchCB.Name = "srchCB";
            this.srchCB.Size = new System.Drawing.Size(186, 24);
            this.srchCB.TabIndex = 4;
            this.srchCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stepLbl
            // 
            this.stepLbl.AutoSize = true;
            this.stepLbl.Location = new System.Drawing.Point(546, 456);
            this.stepLbl.Name = "stepLbl";
            this.stepLbl.Size = new System.Drawing.Size(46, 17);
            this.stepLbl.TabIndex = 5;
            this.stepLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.stepLbl);
            this.Controls.Add(this.srchCB);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.logPB);
            this.Controls.Add(this.tablePB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tablePB;
        private System.Windows.Forms.PictureBox logPB;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.ComboBox srchCB;
        private System.Windows.Forms.Label stepLbl;
    }
}

