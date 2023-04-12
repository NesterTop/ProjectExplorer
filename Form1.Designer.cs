namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_show_all_proj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add_proj = new System.Windows.Forms.Button();
            this.button_update_proj = new System.Windows.Forms.Button();
            this.button_del_proj = new System.Windows.Forms.Button();
            this.button_add_tasks = new System.Windows.Forms.Button();
            this.button_upd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_show_all_proj
            // 
            this.button_show_all_proj.Location = new System.Drawing.Point(468, 233);
            this.button_show_all_proj.Name = "button_show_all_proj";
            this.button_show_all_proj.Size = new System.Drawing.Size(157, 35);
            this.button_show_all_proj.TabIndex = 1;
            this.button_show_all_proj.Text = "Показать все проекты";
            this.button_show_all_proj.UseVisualStyleBackColor = true;
            this.button_show_all_proj.Click += new System.EventHandler(this.button_show_all_proj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вывести все задачи к выбранному проекту:";
            // 
            // button_add_proj
            // 
            this.button_add_proj.Location = new System.Drawing.Point(631, 12);
            this.button_add_proj.Name = "button_add_proj";
            this.button_add_proj.Size = new System.Drawing.Size(110, 35);
            this.button_add_proj.TabIndex = 6;
            this.button_add_proj.Text = "Добавить проект";
            this.button_add_proj.UseVisualStyleBackColor = true;
            this.button_add_proj.Click += new System.EventHandler(this.button_add_proj_Click);
            // 
            // button_update_proj
            // 
            this.button_update_proj.Location = new System.Drawing.Point(631, 53);
            this.button_update_proj.Name = "button_update_proj";
            this.button_update_proj.Size = new System.Drawing.Size(110, 35);
            this.button_update_proj.TabIndex = 7;
            this.button_update_proj.Text = "Редактировать проект";
            this.button_update_proj.UseVisualStyleBackColor = true;
            this.button_update_proj.Click += new System.EventHandler(this.button_update_proj_Click);
            // 
            // button_del_proj
            // 
            this.button_del_proj.Location = new System.Drawing.Point(631, 94);
            this.button_del_proj.Name = "button_del_proj";
            this.button_del_proj.Size = new System.Drawing.Size(110, 35);
            this.button_del_proj.TabIndex = 8;
            this.button_del_proj.Text = "Удалить проект";
            this.button_del_proj.UseVisualStyleBackColor = true;
            this.button_del_proj.Click += new System.EventHandler(this.button_del_proj_Click);
            // 
            // button_add_tasks
            // 
            this.button_add_tasks.Location = new System.Drawing.Point(249, 233);
            this.button_add_tasks.Name = "button_add_tasks";
            this.button_add_tasks.Size = new System.Drawing.Size(122, 35);
            this.button_add_tasks.TabIndex = 9;
            this.button_add_tasks.Text = "Добавить задачи к проекту";
            this.button_add_tasks.UseVisualStyleBackColor = true;
            this.button_add_tasks.Click += new System.EventHandler(this.button_add_tasks_Click);
            // 
            // button_upd
            // 
            this.button_upd.Location = new System.Drawing.Point(631, 188);
            this.button_upd.Name = "button_upd";
            this.button_upd.Size = new System.Drawing.Size(110, 42);
            this.button_upd.TabIndex = 10;
            this.button_upd.Text = "Обновить данные";
            this.button_upd.UseVisualStyleBackColor = true;
            this.button_upd.Click += new System.EventHandler(this.button_upd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_upd);
            this.Controls.Add(this.button_add_tasks);
            this.Controls.Add(this.button_del_proj);
            this.Controls.Add(this.button_update_proj);
            this.Controls.Add(this.button_add_proj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_show_all_proj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_show_all_proj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add_proj;
        private System.Windows.Forms.Button button_update_proj;
        private System.Windows.Forms.Button button_del_proj;
        private System.Windows.Forms.Button button_add_tasks;
        private System.Windows.Forms.Button button_upd;
    }
}

