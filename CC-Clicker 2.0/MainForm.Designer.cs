namespace CC_Clicker_2._0
{
    partial class MainForm
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
                ov.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clickBox = new System.Windows.Forms.CheckBox();
            this.rightBox = new System.Windows.Forms.CheckBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.delmBox = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.delmVal = new System.Windows.Forms.TextBox();
            this.fixBox = new System.Windows.Forms.CheckBox();
            this.fixButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // clickBox
            // 
            this.clickBox.AutoSize = true;
            this.clickBox.Enabled = false;
            this.clickBox.Location = new System.Drawing.Point(12, 14);
            this.clickBox.Name = "clickBox";
            this.clickBox.Size = new System.Drawing.Size(49, 17);
            this.clickBox.TabIndex = 0;
            this.clickBox.Text = "Click";
            this.toolTip.SetToolTip(this.clickBox, "Check to start listening for the activation sequence");
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
            this.toolTip.SetToolTip(this.rightBox, "Check to use right clicks instead of left clicks");
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
            this.toolTip.SetToolTip(this.timeBox, "Base delay between clicks in milliseconds. Must be an even number above 0");
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
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
            this.toolTip.SetToolTip(this.keyButton, "Click and press a key to set it as the (de-)activation sequence");
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // delmBox
            // 
            this.delmBox.AutoSize = true;
            this.delmBox.Location = new System.Drawing.Point(12, 69);
            this.delmBox.Name = "delmBox";
            this.delmBox.Size = new System.Drawing.Size(69, 17);
            this.delmBox.TabIndex = 4;
            this.delmBox.Text = "DelayMix";
            this.toolTip.SetToolTip(this.delmBox, "Check to generate more human clicks by waiting a random amount of time instead of" +
        " a fixed amount");
            this.delmBox.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // delmVal
            // 
            this.delmVal.BackColor = System.Drawing.Color.White;
            this.delmVal.Location = new System.Drawing.Point(101, 67);
            this.delmVal.Name = "delmVal";
            this.delmVal.Size = new System.Drawing.Size(100, 20);
            this.delmVal.TabIndex = 5;
            this.delmVal.Text = "4";
            this.toolTip.SetToolTip(this.delmVal, "Maximum Delay that will be randomly added by DelayMix");
            this.delmVal.TextChanged += new System.EventHandler(this.delmVal_TextChanged);
            // 
            // fixBox
            // 
            this.fixBox.AutoSize = true;
            this.fixBox.Location = new System.Drawing.Point(12, 97);
            this.fixBox.Name = "fixBox";
            this.fixBox.Size = new System.Drawing.Size(79, 17);
            this.fixBox.TabIndex = 6;
            this.fixBox.Text = "Fix Position";
            this.toolTip.SetToolTip(this.fixBox, "Check to use a fixed click position instead of the Cursors position");
            this.fixBox.UseVisualStyleBackColor = true;
            this.fixBox.CheckedChanged += new System.EventHandler(this.fixBox_CheckedChanged);
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(101, 93);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(100, 23);
            this.fixButton.TabIndex = 7;
            this.fixButton.Text = "Set Position";
            this.toolTip.SetToolTip(this.fixButton, "Set the location where clicks will be simulated");
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            this.fixButton.MouseEnter += new System.EventHandler(this.fixButton_MouseEnter);
            this.fixButton.MouseLeave += new System.EventHandler(this.fixButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 126);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.fixBox);
            this.Controls.Add(this.delmVal);
            this.Controls.Add(this.delmBox);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.clickBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 165);
            this.Name = "MainForm";
            this.Text = "CC-Clicker 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox clickBox;
        private System.Windows.Forms.CheckBox rightBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.CheckBox delmBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox delmVal;
        private System.Windows.Forms.CheckBox fixBox;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

