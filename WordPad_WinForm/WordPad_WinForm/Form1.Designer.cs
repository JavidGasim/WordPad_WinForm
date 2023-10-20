namespace WordPad_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            font_button = new Button();
            fontDialog1 = new FontDialog();
            richTextBox1 = new RichTextBox();
            color_btn = new Button();
            colorDialog1 = new ColorDialog();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            save_btn = new Button();
            load_btn = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // font_button
            // 
            font_button.Location = new Point(12, 12);
            font_button.Name = "font_button";
            font_button.Size = new Size(119, 29);
            font_button.TabIndex = 0;
            font_button.Text = "FONT";
            font_button.UseVisualStyleBackColor = true;
            font_button.Click += font_button_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 378);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // color_btn
            // 
            color_btn.Location = new Point(153, 12);
            color_btn.Name = "color_btn";
            color_btn.Size = new Size(122, 29);
            color_btn.TabIndex = 2;
            color_btn.Text = "COLOR";
            color_btn.UseVisualStyleBackColor = true;
            color_btn.Click += color_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(298, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(554, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(417, 12);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 5;
            save_btn.Text = "SAVE";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(694, 10);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 29);
            load_btn.TabIndex = 6;
            load_btn.Text = "LOAD";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(load_btn);
            Controls.Add(save_btn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(color_btn);
            Controls.Add(richTextBox1);
            Controls.Add(font_button);
            Name = "Form1";
            Text = "WordPad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button font_button;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private Button color_btn;
        private ColorDialog colorDialog1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button save_btn;
        private Button load_btn;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}