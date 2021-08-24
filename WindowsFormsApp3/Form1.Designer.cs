
namespace WindowsFormsApp3
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
            this.button00 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(164, 124);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(75, 50);
            this.button00.TabIndex = 0;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.button_Click);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(320, 124);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(75, 50);
            this.button01.TabIndex = 1;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(478, 124);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(75, 50);
            this.button02.TabIndex = 2;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(478, 219);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 50);
            this.button21.TabIndex = 3;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(320, 219);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 50);
            this.button11.TabIndex = 4;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(164, 219);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 50);
            this.button10.TabIndex = 5;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(164, 309);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 50);
            this.button20.TabIndex = 6;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(320, 309);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 50);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(478, 309);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 50);
            this.button22.TabIndex = 8;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player 2";
            // 
            // resultLabel
            // 
            //this.resultLabel.AutoSize = true;
            //this.resultLabel.Location = new System.Drawing.Point(333, 381);
            //this.resultLabel.Name = "resultLabel";
            //this.resultLabel.Size = new System.Drawing.Size(56, 17);
            //this.resultLabel.TabIndex = 11;
            //this.resultLabel.Text = "Result: ";
            //this.resultLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(320, 415);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Location = new System.Drawing.Point(316, 69);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(98, 17);
            this.turn.TabIndex = 13;
            this.turn.Text = "Turn: Player 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label turn;
    }
}

