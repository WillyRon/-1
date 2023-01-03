namespace Matrix
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
            this.Info = new System.Windows.Forms.Label();
            this.mat1_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mar1_2 = new System.Windows.Forms.TextBox();
            this.mat2_1 = new System.Windows.Forms.TextBox();
            this.mat2_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_init = new System.Windows.Forms.Button();
            this.dataGridViewM1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewM2 = new System.Windows.Forms.DataGridView();
            this.Multiply = new System.Windows.Forms.Button();
            this.labelParallelTime = new System.Windows.Forms.Label();
            this.labelSequentialTime = new System.Windows.Forms.Label();
            this.dataGridViewM3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM3)).BeginInit();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Dubai Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(175, 20);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(260, 21);
            this.Info.TabIndex = 0;
            this.Info.Text = "Выберите размерость матриц\r\n";
            // 
            // mat1_1
            // 
            this.mat1_1.Location = new System.Drawing.Point(494, 21);
            this.mat1_1.Name = "mat1_1";
            this.mat1_1.Size = new System.Drawing.Size(44, 20);
            this.mat1_1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(544, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(752, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "на";
            // 
            // mar1_2
            // 
            this.mar1_2.Location = new System.Drawing.Point(580, 20);
            this.mar1_2.Name = "mar1_2";
            this.mar1_2.Size = new System.Drawing.Size(44, 20);
            this.mar1_2.TabIndex = 4;
            // 
            // mat2_1
            // 
            this.mat2_1.Location = new System.Drawing.Point(702, 20);
            this.mat2_1.Name = "mat2_1";
            this.mat2_1.Size = new System.Drawing.Size(44, 20);
            this.mat2_1.TabIndex = 5;
            // 
            // mat2_2
            // 
            this.mat2_2.Location = new System.Drawing.Point(788, 20);
            this.mat2_2.Name = "mat2_2";
            this.mat2_2.Size = new System.Drawing.Size(44, 20);
            this.mat2_2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(458, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "M1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(666, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "M2";
            // 
            // b_init
            // 
            this.b_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_init.Location = new System.Drawing.Point(887, 17);
            this.b_init.Name = "b_init";
            this.b_init.Size = new System.Drawing.Size(102, 26);
            this.b_init.TabIndex = 9;
            this.b_init.Text = "Создать";
            this.b_init.UseVisualStyleBackColor = true;
            this.b_init.Click += new System.EventHandler(this.b_init_Click);
            // 
            // dataGridViewM1
            // 
            this.dataGridViewM1.AllowUserToAddRows = false;
            this.dataGridViewM1.AllowUserToDeleteRows = false;
            this.dataGridViewM1.AllowUserToResizeColumns = false;
            this.dataGridViewM1.AllowUserToResizeRows = false;
            this.dataGridViewM1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM1.ColumnHeadersVisible = false;
            this.dataGridViewM1.EnableHeadersVisualStyles = false;
            this.dataGridViewM1.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewM1.Name = "dataGridViewM1";
            this.dataGridViewM1.RowHeadersVisible = false;
            this.dataGridViewM1.RowTemplate.ReadOnly = true;
            this.dataGridViewM1.Size = new System.Drawing.Size(411, 278);
            this.dataGridViewM1.TabIndex = 10;
            // 
            // dataGridViewM2
            // 
            this.dataGridViewM2.AllowUserToAddRows = false;
            this.dataGridViewM2.AllowUserToDeleteRows = false;
            this.dataGridViewM2.AllowUserToResizeColumns = false;
            this.dataGridViewM2.AllowUserToResizeRows = false;
            this.dataGridViewM2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM2.ColumnHeadersVisible = false;
            this.dataGridViewM2.Location = new System.Drawing.Point(446, 91);
            this.dataGridViewM2.Name = "dataGridViewM2";
            this.dataGridViewM2.RowHeadersVisible = false;
            this.dataGridViewM2.Size = new System.Drawing.Size(376, 278);
            this.dataGridViewM2.TabIndex = 11;
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(254, 399);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(284, 43);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "Умножить";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // labelParallelTime
            // 
            this.labelParallelTime.AutoSize = true;
            this.labelParallelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParallelTime.Location = new System.Drawing.Point(928, 410);
            this.labelParallelTime.Name = "labelParallelTime";
            this.labelParallelTime.Size = new System.Drawing.Size(0, 22);
            this.labelParallelTime.TabIndex = 13;
            // 
            // labelSequentialTime
            // 
            this.labelSequentialTime.AutoSize = true;
            this.labelSequentialTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSequentialTime.Location = new System.Drawing.Point(928, 438);
            this.labelSequentialTime.Name = "labelSequentialTime";
            this.labelSequentialTime.Size = new System.Drawing.Size(0, 22);
            this.labelSequentialTime.TabIndex = 14;
            // 
            // dataGridViewM3
            // 
            this.dataGridViewM3.AllowUserToAddRows = false;
            this.dataGridViewM3.AllowUserToDeleteRows = false;
            this.dataGridViewM3.AllowUserToResizeColumns = false;
            this.dataGridViewM3.AllowUserToResizeRows = false;
            this.dataGridViewM3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM3.ColumnHeadersVisible = false;
            this.dataGridViewM3.Location = new System.Drawing.Point(887, 91);
            this.dataGridViewM3.Name = "dataGridViewM3";
            this.dataGridViewM3.RowHeadersVisible = false;
            this.dataGridViewM3.Size = new System.Drawing.Size(376, 278);
            this.dataGridViewM3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 651);
            this.Controls.Add(this.dataGridViewM3);
            this.Controls.Add(this.labelSequentialTime);
            this.Controls.Add(this.labelParallelTime);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.dataGridViewM2);
            this.Controls.Add(this.dataGridViewM1);
            this.Controls.Add(this.b_init);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mat2_2);
            this.Controls.Add(this.mat2_1);
            this.Controls.Add(this.mar1_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mat1_1);
            this.Controls.Add(this.Info);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Info;
        internal System.Windows.Forms.TextBox mat1_1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox mar1_2;
        internal System.Windows.Forms.TextBox mat2_1;
        internal System.Windows.Forms.TextBox mat2_2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button b_init;
        private System.Windows.Forms.DataGridView dataGridViewM2;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Label labelParallelTime;
        private System.Windows.Forms.Label labelSequentialTime;
        internal System.Windows.Forms.DataGridView dataGridViewM1;
        private System.Windows.Forms.DataGridView dataGridViewM3;
    } 
}

