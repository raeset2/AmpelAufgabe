
namespace AmpelmodellDesign
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
            this.lblPress = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.redLamp = new System.Windows.Forms.TextBox();
            this.yellowLamp = new System.Windows.Forms.TextBox();
            this.greenLamp = new System.Windows.Forms.TextBox();
            this.redWalker = new System.Windows.Forms.TextBox();
            this.greenWalker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.programmStarten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPress
            // 
            this.lblPress.Location = new System.Drawing.Point(310, 309);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(75, 23);
            this.lblPress.TabIndex = 0;
            this.lblPress.Text = "Press";
            this.lblPress.UseVisualStyleBackColor = true;
            this.lblPress.Click += new System.EventHandler(this.lblPress_Click);
            // 
            // redLamp
            // 
            this.redLamp.Location = new System.Drawing.Point(339, 169);
            this.redLamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redLamp.Name = "redLamp";
            this.redLamp.Size = new System.Drawing.Size(20, 20);
            this.redLamp.TabIndex = 1;
            this.redLamp.TextChanged += new System.EventHandler(this.redLamp_TextChanged);
            // 
            // yellowLamp
            // 
            this.yellowLamp.Location = new System.Drawing.Point(339, 207);
            this.yellowLamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yellowLamp.Name = "yellowLamp";
            this.yellowLamp.Size = new System.Drawing.Size(20, 20);
            this.yellowLamp.TabIndex = 2;
            this.yellowLamp.TextChanged += new System.EventHandler(this.yellowLamp_TextChanged);
            // 
            // greenLamp
            // 
            this.greenLamp.Location = new System.Drawing.Point(339, 251);
            this.greenLamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenLamp.Name = "greenLamp";
            this.greenLamp.Size = new System.Drawing.Size(20, 20);
            this.greenLamp.TabIndex = 3;
            this.greenLamp.TextChanged += new System.EventHandler(this.gruenLamp_TextChanged);
            // 
            // redWalker
            // 
            this.redWalker.Location = new System.Drawing.Point(485, 169);
            this.redWalker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redWalker.Name = "redWalker";
            this.redWalker.Size = new System.Drawing.Size(20, 20);
            this.redWalker.TabIndex = 4;
            // 
            // greenWalker
            // 
            this.greenWalker.Location = new System.Drawing.Point(484, 207);
            this.greenWalker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenWalker.Name = "greenWalker";
            this.greenWalker.Size = new System.Drawing.Size(20, 20);
            this.greenWalker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cars";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Walker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // programmStarten
            // 
            this.programmStarten.Location = new System.Drawing.Point(78, 183);
            this.programmStarten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programmStarten.Name = "programmStarten";
            this.programmStarten.Size = new System.Drawing.Size(121, 19);
            this.programmStarten.TabIndex = 8;
            this.programmStarten.Text = "Start traffic light";
            this.programmStarten.UseVisualStyleBackColor = true;
            this.programmStarten.Click += new System.EventHandler(this.programmStarten_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.programmStarten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenWalker);
            this.Controls.Add(this.redWalker);
            this.Controls.Add(this.greenLamp);
            this.Controls.Add(this.yellowLamp);
            this.Controls.Add(this.redLamp);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblPress;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.TextBox redLamp;
        private System.Windows.Forms.TextBox yellowLamp;
        private System.Windows.Forms.TextBox greenLamp;
        private System.Windows.Forms.TextBox redWalker;
        private System.Windows.Forms.TextBox greenWalker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button programmStarten;
        private System.Windows.Forms.Button button1;
    }
}

