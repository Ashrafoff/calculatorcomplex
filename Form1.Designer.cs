using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(801, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "0";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ActiveCaption;
            richTextBox2.Location = new Point(480, 94);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(100, 357);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(23, 120);
            button1.Name = "button1";
            button1.Size = new Size(61, 49);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(105, 120);
            button2.Name = "button2";
            button2.Size = new Size(61, 49);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(23, 198);
            button3.Name = "button3";
            button3.Size = new Size(61, 49);
            button3.TabIndex = 5;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(187, 120);
            button4.Name = "button4";
            button4.Size = new Size(61, 49);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(187, 198);
            button5.Name = "button5";
            button5.Size = new Size(61, 49);
            button5.TabIndex = 7;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(105, 198);
            button6.Name = "button6";
            button6.Size = new Size(61, 49);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(187, 275);
            button7.Name = "button7";
            button7.Size = new Size(61, 49);
            button7.TabIndex = 10;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Teal;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(105, 275);
            button8.Name = "button8";
            button8.Size = new Size(61, 49);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Teal;
            button9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(23, 275);
            button9.Name = "button9";
            button9.Size = new Size(61, 49);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Teal;
            button10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(105, 351);
            button10.Name = "button10";
            button10.Size = new Size(61, 49);
            button10.TabIndex = 11;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(192, 0, 0);
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.Location = new Point(23, 351);
            button11.Name = "button11";
            button11.Size = new Size(61, 49);
            button11.TabIndex = 12;
            button11.Text = "delete";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Teal;
            button12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ActiveCaptionText;
            button12.Location = new Point(187, 351);
            button12.Name = "button12";
            button12.Size = new Size(61, 49);
            button12.TabIndex = 13;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Yellow;
            button14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.ActiveCaptionText;
            button14.Location = new Point(305, 351);
            button14.Name = "button14";
            button14.Size = new Size(61, 49);
            button14.TabIndex = 20;
            button14.Text = "%";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Yellow;
            button15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.ForeColor = SystemColors.ActiveCaptionText;
            button15.Location = new Point(387, 198);
            button15.Name = "button15";
            button15.Size = new Size(61, 49);
            button15.TabIndex = 19;
            button15.Text = "x*2";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.Yellow;
            button16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = SystemColors.ActiveCaptionText;
            button16.Location = new Point(305, 275);
            button16.Name = "button16";
            button16.Size = new Size(61, 49);
            button16.TabIndex = 18;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Yellow;
            button17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.ForeColor = SystemColors.ActiveCaptionText;
            button17.Location = new Point(387, 120);
            button17.Name = "button17";
            button17.Size = new Size(61, 49);
            button17.TabIndex = 17;
            button17.Text = ":";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Yellow;
            button18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.ForeColor = SystemColors.ActiveCaptionText;
            button18.Location = new Point(305, 198);
            button18.Name = "button18";
            button18.Size = new Size(61, 49);
            button18.TabIndex = 16;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(0, 192, 0);
            button19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = SystemColors.ActiveCaptionText;
            button19.Location = new Point(387, 275);
            button19.Name = "button19";
            button19.Size = new Size(61, 49);
            button19.TabIndex = 15;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.Yellow;
            button20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.ForeColor = SystemColors.ActiveCaptionText;
            button20.Location = new Point(305, 120);
            button20.Name = "button20";
            button20.Size = new Size(61, 49);
            button20.TabIndex = 14;
            button20.Text = "-";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(579, 450);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}