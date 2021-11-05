namespace HurricanePrepCalc
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
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberOfPeopleTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.devInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Enter the number of people in your household";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(221, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(348, 25);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Hurricane Preparedness Calculator";
            // 
            // numberOfPeopleTextBox
            // 
            this.numberOfPeopleTextBox.Location = new System.Drawing.Point(445, 122);
            this.numberOfPeopleTextBox.Name = "numberOfPeopleTextBox";
            this.numberOfPeopleTextBox.Size = new System.Drawing.Size(228, 20);
            this.numberOfPeopleTextBox.TabIndex = 4;
            this.numberOfPeopleTextBox.Tag = "4";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Location = new System.Drawing.Point(86, 194);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(586, 143);
            this.resultsLabel.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(86, 407);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(160, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "C&alculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(305, 407);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(512, 407);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // devInfoLabel
            // 
            this.devInfoLabel.Location = new System.Drawing.Point(341, 485);
            this.devInfoLabel.Name = "devInfoLabel";
            this.devInfoLabel.Size = new System.Drawing.Size(100, 56);
            this.devInfoLabel.TabIndex = 9;
            this.devInfoLabel.Text = "Tom Bielawski\r\n10-4-2020\r\nFSCJ COP2360C\r\nProfessor Gherig";
            this.devInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.devInfoLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.numberOfPeopleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Hurricane Prepper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox numberOfPeopleTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label devInfoLabel;
    }
}

