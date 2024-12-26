namespace demoekz
{
    partial class FilterForm
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
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExecutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(88, 12);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusFilter.TabIndex = 0;
            // 
            // cmbPriorityFilter
            // 
            this.cmbPriorityFilter.FormattingEnabled = true;
            this.cmbPriorityFilter.Location = new System.Drawing.Point(88, 89);
            this.cmbPriorityFilter.Name = "cmbPriorityFilter";
            this.cmbPriorityFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbPriorityFilter.TabIndex = 2;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(11, 128);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(198, 23);
            this.btnApplyFilter.TabIndex = 3;
            this.btnApplyFilter.Text = "Отфильтровать";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Приоритет";
            // 
            // txtExecutor
            // 
            this.txtExecutor.Location = new System.Drawing.Point(88, 52);
            this.txtExecutor.Name = "txtExecutor";
            this.txtExecutor.Size = new System.Drawing.Size(121, 20);
            this.txtExecutor.TabIndex = 7;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 174);
            this.Controls.Add(this.txtExecutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.cmbPriorityFilter);
            this.Controls.Add(this.cmbStatusFilter);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.ComboBox cmbPriorityFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExecutor;
    }
}