namespace SourceChangeSearch
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
            this.text_input = new System.Windows.Forms.RichTextBox();
            this.results_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_input.BackColor = System.Drawing.Color.Black;
            this.text_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_input.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_input.ForeColor = System.Drawing.Color.Lime;
            this.text_input.Location = new System.Drawing.Point(0, 0);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(732, 70);
            this.text_input.TabIndex = 0;
            this.text_input.Text = "";
            this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
            // 
            // results_textbox
            // 
            this.results_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results_textbox.BackColor = System.Drawing.Color.Black;
            this.results_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.results_textbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_textbox.ForeColor = System.Drawing.Color.Lime;
            this.results_textbox.Location = new System.Drawing.Point(0, 70);
            this.results_textbox.Name = "results_textbox";
            this.results_textbox.ReadOnly = true;
            this.results_textbox.Size = new System.Drawing.Size(732, 385);
            this.results_textbox.TabIndex = 1;
            this.results_textbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 456);
            this.Controls.Add(this.results_textbox);
            this.Controls.Add(this.text_input);
            this.MinimumSize = new System.Drawing.Size(282, 194);
            this.Name = "Form1";
            this.Text = "Source Change Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_input;
        private System.Windows.Forms.RichTextBox results_textbox;
    }
}

