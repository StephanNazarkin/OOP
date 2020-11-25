
namespace LW_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOct = new System.Windows.Forms.PictureBox();
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.pLabel = new System.Windows.Forms.Label();
            this.buttonOct = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOct
            // 
            this.pictureBoxOct.Location = new System.Drawing.Point(118, 42);
            this.pictureBoxOct.Name = "pictureBoxOct";
            this.pictureBoxOct.Size = new System.Drawing.Size(213, 155);
            this.pictureBoxOct.TabIndex = 0;
            this.pictureBoxOct.TabStop = false;
            this.pictureBoxOct.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxOct_Paint);
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.Location = new System.Drawing.Point(506, 42);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(220, 155);
            this.pictureBoxCircle.TabIndex = 1;
            this.pictureBoxCircle.TabStop = false;
            this.pictureBoxCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCircle_Paint);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimeterButton.Location = new System.Drawing.Point(12, 256);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(153, 29);
            this.perimeterButton.TabIndex = 4;
            this.perimeterButton.Text = "Calculate Perimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pLabel.Location = new System.Drawing.Point(201, 259);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(103, 20);
            this.pLabel.TabIndex = 5;
            this.pLabel.Text = "Perimeter = 0";
            // 
            // buttonOct
            // 
            this.buttonOct.Location = new System.Drawing.Point(7, 42);
            this.buttonOct.Name = "buttonOct";
            this.buttonOct.Size = new System.Drawing.Size(105, 23);
            this.buttonOct.TabIndex = 6;
            this.buttonOct.Text = "Draw Octagon";
            this.buttonOct.UseVisualStyleBackColor = true;
            this.buttonOct.Click += new System.EventHandler(this.buttonOct_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(404, 42);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(92, 23);
            this.buttonCircle.TabIndex = 7;
            this.buttonCircle.Text = "Draw Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 318);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonOct);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.pictureBoxCircle);
            this.Controls.Add(this.pictureBoxOct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOct;
        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.Button buttonOct;
        private System.Windows.Forms.Button buttonCircle;
    }
}

