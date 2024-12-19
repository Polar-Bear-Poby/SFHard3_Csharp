namespace WindowsFormsApp_C_sharp_geon
{
    partial class Practice_1219_1st
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.radioButton_True = new System.Windows.Forms.RadioButton();
            this.radioButton_False = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(115, 169);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_result.Size = new System.Drawing.Size(544, 225);
            this.textBox_result.TabIndex = 2;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(115, 113);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(411, 28);
            this.textBox_input.TabIndex = 0;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(532, 113);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(127, 28);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // radioButton_True
            // 
            this.radioButton_True.AutoSize = true;
            this.radioButton_True.Location = new System.Drawing.Point(115, 144);
            this.radioButton_True.Name = "radioButton_True";
            this.radioButton_True.Size = new System.Drawing.Size(64, 22);
            this.radioButton_True.TabIndex = 3;
            this.radioButton_True.TabStop = true;
            this.radioButton_True.Text = "true";
            this.radioButton_True.UseVisualStyleBackColor = true;
            this.radioButton_True.CheckedChanged += new System.EventHandler(this.radioButton_True_CheckedChanged);
            this.radioButton_True.Click += new System.EventHandler(this.radioButton_True_CheckedChanged);
            // 
            // radioButton_False
            // 
            this.radioButton_False.AutoSize = true;
            this.radioButton_False.Location = new System.Drawing.Point(176, 144);
            this.radioButton_False.Name = "radioButton_False";
            this.radioButton_False.Size = new System.Drawing.Size(71, 22);
            this.radioButton_False.TabIndex = 4;
            this.radioButton_False.TabStop = true;
            this.radioButton_False.Text = "false";
            this.radioButton_False.UseVisualStyleBackColor = true;
            this.radioButton_False.Click += new System.EventHandler(this.radioButton_False_CheckedChanged);
            // 
            // Practice_1219_1st
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_False);
            this.Controls.Add(this.radioButton_True);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_result);
            this.Name = "Practice_1219_1st";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Pracitce_1219_1st";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.RadioButton radioButton_True;
        private System.Windows.Forms.RadioButton radioButton_False;
    }
}

