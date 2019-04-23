namespace CC_Clicker_2._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickBox = new System.Windows.Forms.CheckBox();
            this.rightBox = new System.Windows.Forms.CheckBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.DelmBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.delmVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clickBox
            // 
            this.clickBox.AutoSize = true;
            this.clickBox.Location = new System.Drawing.Point(12, 14);
            this.clickBox.Name = "clickBox";
            this.clickBox.Size = new System.Drawing.Size(49, 17);
            this.clickBox.TabIndex = 0;
            this.clickBox.Text = "Click";
            this.clickBox.UseVisualStyleBackColor = true;
            this.clickBox.CheckedChanged += new System.EventHandler(this.clickBox_CheckedChanged);
            // 
            // rightBox
            // 
            this.rightBox.AutoSize = true;
            this.rightBox.Location = new System.Drawing.Point(12, 42);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(51, 17);
            this.rightBox.TabIndex = 1;
            this.rightBox.Text = "Right";
            this.rightBox.UseVisualStyleBackColor = true;
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBox.BackColor = System.Drawing.Color.White;
            this.timeBox.Location = new System.Drawing.Point(101, 12);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 20);
            this.timeBox.TabIndex = 2;
            this.timeBox.Text = "100";
            this.timeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // keyButton
            // 
            this.keyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.keyButton.BackColor = System.Drawing.Color.Red;
            this.keyButton.Location = new System.Drawing.Point(101, 38);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(100, 23);
            this.keyButton.TabIndex = 3;
            this.keyButton.Text = "Click to set key";
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // DelmBox
            // 
            this.DelmBox.AutoSize = true;
            this.DelmBox.Location = new System.Drawing.Point(12, 69);
            this.DelmBox.Name = "DelmBox";
            this.DelmBox.Size = new System.Drawing.Size(69, 17);
            this.DelmBox.TabIndex = 4;
            this.DelmBox.Text = "DelayMix";
            this.DelmBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delmVal
            // 
            this.delmVal.BackColor = System.Drawing.Color.White;
            this.delmVal.Location = new System.Drawing.Point(101, 67);
            this.delmVal.Name = "delmVal";
            this.delmVal.Size = new System.Drawing.Size(100, 20);
            this.delmVal.TabIndex = 5;
            this.delmVal.Text = "4";
            this.delmVal.TextChanged += new System.EventHandler(this.delmVal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 93);
            this.Controls.Add(this.delmVal);
            this.Controls.Add(this.DelmBox);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.clickBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 132);
            this.MinimumSize = new System.Drawing.Size(229, 132);
            this.Name = "Form1";
            this.Text = "CC-Clicker 2.0";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox clickBox;
        private System.Windows.Forms.CheckBox rightBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.CheckBox DelmBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox delmVal;
    }
}

