namespace Курсовой2
{
    partial class Izmeneniya
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
            this.Deustvie = new System.Windows.Forms.Label();
            this.newchild = new System.Windows.Forms.CheckBox();
            this.izmenit = new System.Windows.Forms.CheckBox();
            this.Delet = new System.Windows.Forms.CheckBox();
            this.groupBox_new = new System.Windows.Forms.GroupBox();
            this.but_new = new System.Windows.Forms.Button();
            this.Child_datar = new System.Windows.Forms.TextBox();
            this.Child_otch = new System.Windows.Forms.TextBox();
            this.Child_name = new System.Windows.Forms.TextBox();
            this.Child_Surname = new System.Windows.Forms.TextBox();
            this.listBox_spis = new System.Windows.Forms.ListBox();
            this.groupBox_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // Deustvie
            // 
            this.Deustvie.AutoSize = true;
            this.Deustvie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deustvie.Location = new System.Drawing.Point(12, 22);
            this.Deustvie.Name = "Deustvie";
            this.Deustvie.Size = new System.Drawing.Size(124, 13);
            this.Deustvie.TabIndex = 2;
            this.Deustvie.Text = "Выберите действие";
            // 
            // newchild
            // 
            this.newchild.AutoSize = true;
            this.newchild.Location = new System.Drawing.Point(223, 40);
            this.newchild.Name = "newchild";
            this.newchild.Size = new System.Drawing.Size(76, 17);
            this.newchild.TabIndex = 3;
            this.newchild.Text = "Добавить";
            this.newchild.UseVisualStyleBackColor = true;
            this.newchild.CheckedChanged += new System.EventHandler(this.newchild_CheckedChanged);
            // 
            // izmenit
            // 
            this.izmenit.AutoSize = true;
            this.izmenit.Location = new System.Drawing.Point(16, 40);
            this.izmenit.Name = "izmenit";
            this.izmenit.Size = new System.Drawing.Size(77, 17);
            this.izmenit.TabIndex = 4;
            this.izmenit.Text = "Изменить";
            this.izmenit.UseVisualStyleBackColor = true;
            this.izmenit.CheckedChanged += new System.EventHandler(this.izmenit_CheckedChanged);
            // 
            // Delet
            // 
            this.Delet.AutoSize = true;
            this.Delet.Location = new System.Drawing.Point(122, 40);
            this.Delet.Name = "Delet";
            this.Delet.Size = new System.Drawing.Size(69, 17);
            this.Delet.TabIndex = 5;
            this.Delet.Text = "Удалить";
            this.Delet.UseVisualStyleBackColor = true;
            this.Delet.CheckedChanged += new System.EventHandler(this.Delet_CheckedChanged);
            // 
            // groupBox_new
            // 
            this.groupBox_new.Controls.Add(this.but_new);
            this.groupBox_new.Controls.Add(this.Child_datar);
            this.groupBox_new.Controls.Add(this.Child_otch);
            this.groupBox_new.Controls.Add(this.Child_name);
            this.groupBox_new.Controls.Add(this.Child_Surname);
            this.groupBox_new.Enabled = false;
            this.groupBox_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_new.Location = new System.Drawing.Point(379, 18);
            this.groupBox_new.Name = "groupBox_new";
            this.groupBox_new.Size = new System.Drawing.Size(220, 235);
            this.groupBox_new.TabIndex = 7;
            this.groupBox_new.TabStop = false;
            this.groupBox_new.Text = "Данные ученика";
            // 
            // but_new
            // 
            this.but_new.Location = new System.Drawing.Point(67, 201);
            this.but_new.Name = "but_new";
            this.but_new.Size = new System.Drawing.Size(75, 23);
            this.but_new.TabIndex = 4;
            this.but_new.Text = "ОК";
            this.but_new.UseVisualStyleBackColor = true;
            this.but_new.Click += new System.EventHandler(this.but_new_Click);
            // 
            // Child_datar
            // 
            this.Child_datar.Location = new System.Drawing.Point(29, 157);
            this.Child_datar.Name = "Child_datar";
            this.Child_datar.Size = new System.Drawing.Size(159, 20);
            this.Child_datar.TabIndex = 3;
            this.Child_datar.Text = "Дата рождения";
            // 
            // Child_otch
            // 
            this.Child_otch.Location = new System.Drawing.Point(29, 117);
            this.Child_otch.Name = "Child_otch";
            this.Child_otch.Size = new System.Drawing.Size(159, 20);
            this.Child_otch.TabIndex = 2;
            this.Child_otch.Text = "Отчество";
            // 
            // Child_name
            // 
            this.Child_name.Location = new System.Drawing.Point(29, 80);
            this.Child_name.Name = "Child_name";
            this.Child_name.Size = new System.Drawing.Size(159, 20);
            this.Child_name.TabIndex = 1;
            this.Child_name.Text = "Имя";
            // 
            // Child_Surname
            // 
            this.Child_Surname.AccessibleDescription = "";
            this.Child_Surname.Location = new System.Drawing.Point(29, 44);
            this.Child_Surname.Name = "Child_Surname";
            this.Child_Surname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Child_Surname.Size = new System.Drawing.Size(159, 20);
            this.Child_Surname.TabIndex = 0;
            this.Child_Surname.Text = "Фамилия";
            // 
            // listBox_spis
            // 
            this.listBox_spis.Enabled = false;
            this.listBox_spis.FormattingEnabled = true;
            this.listBox_spis.Location = new System.Drawing.Point(41, 75);
            this.listBox_spis.Name = "listBox_spis";
            this.listBox_spis.Size = new System.Drawing.Size(258, 173);
            this.listBox_spis.TabIndex = 8;
            this.listBox_spis.SelectedIndexChanged += new System.EventHandler(this.listBox_spis_SelectedIndexChanged);
            // 
            // Izmeneniya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 272);
            this.Controls.Add(this.listBox_spis);
            this.Controls.Add(this.groupBox_new);
            this.Controls.Add(this.Delet);
            this.Controls.Add(this.izmenit);
            this.Controls.Add(this.newchild);
            this.Controls.Add(this.Deustvie);
            this.Name = "Izmeneniya";
            this.Text = "Редактирование";
            this.groupBox_new.ResumeLayout(false);
            this.groupBox_new.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Deustvie;
        private System.Windows.Forms.CheckBox newchild;
        private System.Windows.Forms.CheckBox izmenit;
        private System.Windows.Forms.CheckBox Delet;
        private System.Windows.Forms.GroupBox groupBox_new;
        private System.Windows.Forms.TextBox Child_datar;
        private System.Windows.Forms.TextBox Child_otch;
        private System.Windows.Forms.TextBox Child_name;
        private System.Windows.Forms.TextBox Child_Surname;
        private System.Windows.Forms.Button but_new;
        private System.Windows.Forms.ListBox listBox_spis;
    }
}