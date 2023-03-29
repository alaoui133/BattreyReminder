namespace BattryReminder
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            battreyLifeLabel = new Label();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(321, 142);
            button1.Name = "button1";
            button1.Size = new Size(146, 70);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // battreyLifeLabel
            // 
            battreyLifeLabel.AutoSize = true;
            battreyLifeLabel.Location = new Point(677, 372);
            battreyLifeLabel.Name = "battreyLifeLabel";
            battreyLifeLabel.Size = new Size(116, 20);
            battreyLifeLabel.TabIndex = 1;
            battreyLifeLabel.Text = "battreyLifeLabel";
            // 
            // button2
            // 
            button2.Location = new Point(321, 238);
            button2.Name = "button2";
            button2.Size = new Size(146, 70);
            button2.TabIndex = 2;
            button2.Text = "Close Programme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(battreyLifeLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label battreyLifeLabel;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}