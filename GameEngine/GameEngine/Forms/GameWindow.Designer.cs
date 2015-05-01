

namespace GameEngine
{
    partial class GameWindow
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

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.button3_CloseOptions = new System.Windows.Forms.Button();
            this.checkBoxOptions_toggleDominantColor = new System.Windows.Forms.CheckBox();
            this.labelOptions_BGcolor = new System.Windows.Forms.Label();
            this.button3_Options = new System.Windows.Forms.Button();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 

            this.button1.Location = new System.Drawing.Point(1815, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1734, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Minimize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.button3_CloseOptions);
            this.panelOptions.Controls.Add(this.checkBoxOptions_toggleDominantColor);
            this.panelOptions.Controls.Add(this.labelOptions_BGcolor);
            this.panelOptions.Location = new System.Drawing.Point(83, 25);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1069, 683);
            this.panelOptions.TabIndex = 2;
            this.panelOptions.Visible = false;
            // 
            // button3_CloseOptions
            // 
            this.button3_CloseOptions.BackColor = System.Drawing.Color.DarkOrange;
            this.button3_CloseOptions.Location = new System.Drawing.Point(975, 18);
            this.button3_CloseOptions.Name = "button3_CloseOptions";
            this.button3_CloseOptions.Size = new System.Drawing.Size(75, 70);
            this.button3_CloseOptions.TabIndex = 2;
            this.button3_CloseOptions.Text = "X";
            this.button3_CloseOptions.UseVisualStyleBackColor = false;
            this.button3_CloseOptions.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxOptions_toggleDominantColor
            // 
            this.checkBoxOptions_toggleDominantColor.AutoSize = true;
            this.checkBoxOptions_toggleDominantColor.Location = new System.Drawing.Point(288, 26);
            this.checkBoxOptions_toggleDominantColor.Name = "checkBoxOptions_toggleDominantColor";
            this.checkBoxOptions_toggleDominantColor.Size = new System.Drawing.Size(18, 17);
            this.checkBoxOptions_toggleDominantColor.TabIndex = 1;
            this.checkBoxOptions_toggleDominantColor.UseVisualStyleBackColor = true;
            this.checkBoxOptions_toggleDominantColor.CheckedChanged += new System.EventHandler(this.checkBoxOptions_toggleDominantColor_CheckedChanged);
            // 
            // labelOptions_BGcolor
            // 
            this.labelOptions_BGcolor.AutoSize = true;
            this.labelOptions_BGcolor.Location = new System.Drawing.Point(17, 24);
            this.labelOptions_BGcolor.Name = "labelOptions_BGcolor";
            this.labelOptions_BGcolor.Size = new System.Drawing.Size(270, 17);
            this.labelOptions_BGcolor.TabIndex = 0;
            this.labelOptions_BGcolor.Text = "Use dominant image color as background";
            // 
            // button3_Options
            // 
            this.button3_Options.Location = new System.Drawing.Point(1644, 12);
            this.button3_Options.Name = "button3_Options";
            this.button3_Options.Size = new System.Drawing.Size(75, 23);
            this.button3_Options.TabIndex = 3;
            this.button3_Options.Text = "Options";
            this.button3_Options.UseVisualStyleBackColor = true;
            this.button3_Options.Click += new System.EventHandler(this.button3_Options_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.ControlBox = false;
            this.Controls.Add(this.button3_Options);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameWindow_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameWindow_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameWindow_MouseDown);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.CheckBox checkBoxOptions_toggleDominantColor;
        private System.Windows.Forms.Label labelOptions_BGcolor;
        private System.Windows.Forms.Button button3_Options;
        private System.Windows.Forms.Button button3_CloseOptions;
    }
}