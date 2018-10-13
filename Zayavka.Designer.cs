namespace Курсовой2
{
    partial class Zayavka
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
            this.Spisok = new System.Windows.Forms.CheckedListBox();
            this.label_spisok = new System.Windows.Forms.Label();
            this.Svidetelstva = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Spisok
            // 
            this.Spisok.FormattingEnabled = true;
            this.Spisok.Location = new System.Drawing.Point(39, 63);
            this.Spisok.Name = "Spisok";
            this.Spisok.Size = new System.Drawing.Size(468, 94);
            this.Spisok.TabIndex = 0;
            // 
            // label_spisok
            // 
            this.label_spisok.AutoSize = true;
            this.label_spisok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_spisok.Location = new System.Drawing.Point(36, 24);
            this.label_spisok.Name = "label_spisok";
            this.label_spisok.Size = new System.Drawing.Size(108, 13);
            this.label_spisok.TabIndex = 1;
            this.label_spisok.Text = "Список учеников";
            // 
            // Svidetelstva
            // 
            this.Svidetelstva.AutoSize = true;
            this.Svidetelstva.Location = new System.Drawing.Point(39, 174);
            this.Svidetelstva.Name = "Svidetelstva";
            this.Svidetelstva.Size = new System.Drawing.Size(221, 17);
            this.Svidetelstva.TabIndex = 2;
            this.Svidetelstva.Text = "Отправить свидетельства о рождении";
            this.Svidetelstva.UseVisualStyleBackColor = true;
            // 
            // Zayavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 234);
            this.Controls.Add(this.Svidetelstva);
            this.Controls.Add(this.label_spisok);
            this.Controls.Add(this.Spisok);
            this.Name = "Zayavka";
            this.Text = "Создание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Spisok;
        private System.Windows.Forms.Label label_spisok;
        private System.Windows.Forms.CheckBox Svidetelstva;
    }
}