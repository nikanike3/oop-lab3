
namespace Arrays1DWinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonUnleash = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.Array2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewSort = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість елементів:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(36, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добуток відємних елементів:";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownCount.Location = new System.Drawing.Point(296, 33);
            this.numericUpDownCount.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(111, 32);
            this.numericUpDownCount.TabIndex = 2;
            this.numericUpDownCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonGenerate.Location = new System.Drawing.Point(625, 185);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 40);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Генерувати";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonUnleash
            // 
            this.buttonUnleash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnleash.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUnleash.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonUnleash.Location = new System.Drawing.Point(625, 319);
            this.buttonUnleash.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUnleash.Name = "buttonUnleash";
            this.buttonUnleash.Size = new System.Drawing.Size(150, 39);
            this.buttonUnleash.TabIndex = 4;
            this.buttonUnleash.Text = "Розвязати";
            this.buttonUnleash.UseVisualStyleBackColor = false;
            this.buttonUnleash.Click += new System.EventHandler(this.buttonUnleash_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AllowUserToAddRows = false;
            this.dataGridViewArray.AllowUserToDeleteRows = false;
            this.dataGridViewArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewArray.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Array2});
            this.dataGridViewArray.Location = new System.Drawing.Point(41, 145);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.ReadOnly = true;
            this.dataGridViewArray.RowHeadersWidth = 5;
            this.dataGridViewArray.ShowCellErrors = false;
            this.dataGridViewArray.ShowCellToolTips = false;
            this.dataGridViewArray.ShowEditingIcon = false;
            this.dataGridViewArray.ShowRowErrors = false;
            this.dataGridViewArray.Size = new System.Drawing.Size(217, 244);
            this.dataGridViewArray.TabIndex = 5;
            // 
            // Array2
            // 
            this.Array2.HeaderText = "Масив";
            this.Array2.MinimumWidth = 2;
            this.Array2.Name = "Array2";
            this.Array2.ReadOnly = true;
            this.Array2.Width = 210;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxResult.Location = new System.Drawing.Point(357, 425);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(246, 32);
            this.textBoxResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість перших елементів для впорядку по спаданню:";
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Enabled = false;
            this.numericUpDownK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numericUpDownK.Location = new System.Drawing.Point(634, 91);
            this.numericUpDownK.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(111, 32);
            this.numericUpDownK.TabIndex = 8;
            this.numericUpDownK.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dataGridViewSort
            // 
            this.dataGridViewSort.AllowUserToAddRows = false;
            this.dataGridViewSort.AllowUserToDeleteRows = false;
            this.dataGridViewSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSort.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewSort.Location = new System.Drawing.Point(336, 145);
            this.dataGridViewSort.Name = "dataGridViewSort";
            this.dataGridViewSort.ReadOnly = true;
            this.dataGridViewSort.RowHeadersWidth = 5;
            this.dataGridViewSort.ShowCellErrors = false;
            this.dataGridViewSort.ShowCellToolTips = false;
            this.dataGridViewSort.ShowEditingIcon = false;
            this.dataGridViewSort.ShowRowErrors = false;
            this.dataGridViewSort.Size = new System.Drawing.Size(217, 244);
            this.dataGridViewSort.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Масив (сорт.)";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClear.Location = new System.Drawing.Point(625, 247);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 39);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(647, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Григорчук В. Ю. П-42";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arrays1DWinForms.Properties.Resources.istockphoto_825778252_612x612;
            this.ClientSize = new System.Drawing.Size(824, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewSort);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonUnleash);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(840, 503);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3. Завдання 1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonUnleash;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Array2;
        private System.Windows.Forms.DataGridView dataGridViewSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label4;
    }
}

