namespace GameEngine
{
    partial class Constructor
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1Scenario = new System.Windows.Forms.Label();
            this.Label2AddRecord = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 772);
            this.listBox1.TabIndex = 0;
            // 
            // label1Scenario
            // 
            this.label1Scenario.AutoSize = true;
            this.label1Scenario.Location = new System.Drawing.Point(9, 24);
            this.label1Scenario.Name = "label1Scenario";
            this.label1Scenario.Size = new System.Drawing.Size(64, 17);
            this.label1Scenario.TabIndex = 1;
            this.label1Scenario.Text = "Scenario";
            // 
            // Label2AddRecord
            // 
            this.Label2AddRecord.AutoSize = true;
            this.Label2AddRecord.Location = new System.Drawing.Point(274, 24);
            this.Label2AddRecord.Name = "Label2AddRecord";
            this.Label2AddRecord.Size = new System.Drawing.Size(78, 17);
            this.Label2AddRecord.TabIndex = 2;
            this.Label2AddRecord.Text = "Add record";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Constructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 842);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label2AddRecord);
            this.Controls.Add(this.label1Scenario);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.Name = "Constructor";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1Scenario;
        private System.Windows.Forms.Label Label2AddRecord;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}