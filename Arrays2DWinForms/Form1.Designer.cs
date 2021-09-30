
namespace Arrays2DWinForms
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
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonUnleash = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewSum = new System.Windows.Forms.DataGridView();
            this.sumRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMinRow = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість рядків:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість стовпців:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(278, 31);
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownN.TabIndex = 2;
            this.numericUpDownN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(278, 89);
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownM.TabIndex = 3;
            this.numericUpDownM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonGenerate.Location = new System.Drawing.Point(433, 55);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(143, 34);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Генерувати";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonUnleash
            // 
            this.buttonUnleash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnleash.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUnleash.Location = new System.Drawing.Point(780, 55);
            this.buttonUnleash.Name = "buttonUnleash";
            this.buttonUnleash.Size = new System.Drawing.Size(151, 34);
            this.buttonUnleash.TabIndex = 5;
            this.buttonUnleash.Text = "Розвязати";
            this.buttonUnleash.UseVisualStyleBackColor = false;
            this.buttonUnleash.Click += new System.EventHandler(this.buttonUnleash_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(26, 145);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.ShowCellErrors = false;
            this.dataGridViewMatrix.ShowCellToolTips = false;
            this.dataGridViewMatrix.ShowEditingIcon = false;
            this.dataGridViewMatrix.ShowRowErrors = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(828, 416);
            this.dataGridViewMatrix.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClear.Location = new System.Drawing.Point(603, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(151, 34);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewSum
            // 
            this.dataGridViewSum.AllowUserToAddRows = false;
            this.dataGridViewSum.AllowUserToDeleteRows = false;
            this.dataGridViewSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSum.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumRow});
            this.dataGridViewSum.Location = new System.Drawing.Point(875, 145);
            this.dataGridViewSum.Name = "dataGridViewSum";
            this.dataGridViewSum.Size = new System.Drawing.Size(252, 416);
            this.dataGridViewSum.TabIndex = 8;
            // 
            // sumRow
            // 
            this.sumRow.HeaderText = "Сума рядків";
            this.sumRow.MinimumWidth = 2;
            this.sumRow.Name = "sumRow";
            this.sumRow.Width = 210;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Найменша сума модулів рядка матриці:";
            // 
            // textBoxMinRow
            // 
            this.textBoxMinRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMinRow.Location = new System.Drawing.Point(475, 604);
            this.textBoxMinRow.Name = "textBoxMinRow";
            this.textBoxMinRow.ReadOnly = true;
            this.textBoxMinRow.Size = new System.Drawing.Size(213, 32);
            this.textBoxMinRow.TabIndex = 10;
            // 
            // buttonSort
            // 
            this.buttonSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSort.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSort.Location = new System.Drawing.Point(950, 55);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(151, 34);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортувати";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(531, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(496, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "(При сортуванні та розвязуванні знаходяться модулі елементів)";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(908, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Григорчук В. Ю. П-42";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arrays2DWinForms.Properties.Resources.istockphoto_825778252_612x612;
            this.ClientSize = new System.Drawing.Size(1148, 658);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxMinRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSum);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonUnleash);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1164, 697);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3. Завдання 2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonUnleash;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMinRow;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

