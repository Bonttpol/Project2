namespace Курсовой2
{
    partial class Osnova
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
            this.Telefon = new System.Windows.Forms.Label();
            this.Zayvka = new System.Windows.Forms.Label();
            this.Redact = new System.Windows.Forms.Label();
            this.but_redact = new System.Windows.Forms.Button();
            this.but_zayv = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.Label();
            this.Rezult = new System.Windows.Forms.Label();
            this.but_tell = new System.Windows.Forms.Button();
            this.vvodFIO = new System.Windows.Forms.TextBox();
            this.okFIO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_Z = new System.Windows.Forms.CheckBox();
            this.check_AB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.Telefon.Location = new System.Drawing.Point(27, 236);
            this.Telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(206, 17);
            this.Telefon.TabIndex = 0;
            this.Telefon.Text = "Узнать телефон родителя";
            // 
            // Zayvka
            // 
            this.Zayvka.AutoSize = true;
            this.Zayvka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.Zayvka.Location = new System.Drawing.Point(27, 171);
            this.Zayvka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Zayvka.Name = "Zayvka";
            this.Zayvka.Size = new System.Drawing.Size(136, 17);
            this.Zayvka.TabIndex = 2;
            this.Zayvka.Text = "Создание заявки";
            // 
            // Redact
            // 
            this.Redact.AutoSize = true;
            this.Redact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.Redact.Location = new System.Drawing.Point(27, 110);
            this.Redact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Redact.Name = "Redact";
            this.Redact.Size = new System.Drawing.Size(205, 17);
            this.Redact.TabIndex = 3;
            this.Redact.Text = "Редактирование списоков";
            // 
            // but_redact
            // 
            this.but_redact.Location = new System.Drawing.Point(255, 102);
            this.but_redact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_redact.Name = "but_redact";
            this.but_redact.Size = new System.Drawing.Size(100, 28);
            this.but_redact.TabIndex = 4;
            this.but_redact.Text = "Редакт";
            this.but_redact.UseVisualStyleBackColor = true;
            this.but_redact.Click += new System.EventHandler(this.but_redact_Click);
            // 
            // but_zayv
            // 
            this.but_zayv.Location = new System.Drawing.Point(255, 164);
            this.but_zayv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_zayv.Name = "but_zayv";
            this.but_zayv.Size = new System.Drawing.Size(100, 28);
            this.but_zayv.TabIndex = 5;
            this.but_zayv.Text = "Заявка";
            this.but_zayv.UseVisualStyleBackColor = true;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(27, 284);
            this.FIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(42, 17);
            this.FIO.TabIndex = 6;
            this.FIO.Text = "ФИО";
            // 
            // Rezult
            // 
            this.Rezult.AutoSize = true;
            this.Rezult.Location = new System.Drawing.Point(27, 373);
            this.Rezult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(0, 17);
            this.Rezult.TabIndex = 8;
            // 
            // but_tell
            // 
            this.but_tell.Location = new System.Drawing.Point(255, 223);
            this.but_tell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_tell.Name = "but_tell";
            this.but_tell.Size = new System.Drawing.Size(100, 28);
            this.but_tell.TabIndex = 9;
            this.but_tell.Text = "Тел";
            this.but_tell.UseVisualStyleBackColor = true;
            this.but_tell.Click += new System.EventHandler(this.but_tell_Click);
            // 
            // vvodFIO
            // 
            this.vvodFIO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vvodFIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.vvodFIO.Location = new System.Drawing.Point(101, 284);
            this.vvodFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vvodFIO.Name = "vvodFIO";
            this.vvodFIO.Size = new System.Drawing.Size(252, 22);
            this.vvodFIO.TabIndex = 10;
            // 
            // okFIO
            // 
            this.okFIO.Location = new System.Drawing.Point(255, 318);
            this.okFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okFIO.Name = "okFIO";
            this.okFIO.Size = new System.Drawing.Size(100, 28);
            this.okFIO.TabIndex = 11;
            this.okFIO.Text = "ОК";
            this.okFIO.UseVisualStyleBackColor = true;
            this.okFIO.Click += new System.EventHandler(this.okFIO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите клуб";
            // 
            // check_Z
            // 
            this.check_Z.AutoSize = true;
            this.check_Z.Location = new System.Drawing.Point(285, 46);
            this.check_Z.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_Z.Name = "check_Z";
            this.check_Z.Size = new System.Drawing.Size(71, 21);
            this.check_Z.TabIndex = 13;
            this.check_Z.Text = "Зебра";
            this.check_Z.UseVisualStyleBackColor = true;
            // 
            // check_AB
            // 
            this.check_AB.AutoSize = true;
            this.check_AB.Location = new System.Drawing.Point(65, 46);
            this.check_AB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_AB.Name = "check_AB";
            this.check_AB.Size = new System.Drawing.Size(169, 21);
            this.check_AB.TabIndex = 12;
            this.check_AB.Text = "Андрей Боголюбский";
            this.check_AB.UseVisualStyleBackColor = true;
            // 
            // Osnova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_Z);
            this.Controls.Add(this.check_AB);
            this.Controls.Add(this.okFIO);
            this.Controls.Add(this.vvodFIO);
            this.Controls.Add(this.but_tell);
            this.Controls.Add(this.Rezult);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.but_zayv);
            this.Controls.Add(this.but_redact);
            this.Controls.Add(this.Redact);
            this.Controls.Add(this.Zayvka);
            this.Controls.Add(this.Telefon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Osnova";
            this.Text = "Клуб \"Андрей Боголюбский\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Label Zayvka;
        private System.Windows.Forms.Label Redact;
        private System.Windows.Forms.Button but_redact;
        private System.Windows.Forms.Button but_zayv;
        private System.Windows.Forms.Label FIO;
        private System.Windows.Forms.Label Rezult;
        private System.Windows.Forms.Button but_tell;
        private System.Windows.Forms.TextBox vvodFIO;
        private System.Windows.Forms.Button okFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_Z;
        private System.Windows.Forms.CheckBox check_AB;
    }
}

