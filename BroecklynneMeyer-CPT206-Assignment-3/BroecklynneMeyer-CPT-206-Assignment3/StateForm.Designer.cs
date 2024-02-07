
namespace BroecklynneMeyer_CPT_206_Assignment3
{
    partial class StateForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.individualToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateIdLabel = new System.Windows.Forms.Label();
            this.flagDescLabel = new System.Windows.Forms.Label();
            this.stateIdTextBox = new System.Windows.Forms.TextBox();
            this.flagDescTextBox = new System.Windows.Forms.TextBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.birdLabel = new System.Windows.Forms.Label();
            this.flowerLabel = new System.Windows.Forms.Label();
            this.capitolLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.secondLargLabel = new System.Windows.Forms.Label();
            this.jobsLabel = new System.Windows.Forms.Label();
            this.largLabel = new System.Windows.Forms.Label();
            this.thirdLargLabel = new System.Windows.Forms.Label();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.capitolTextBox = new System.Windows.Forms.TextBox();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.birdTextBox = new System.Windows.Forms.TextBox();
            this.flowerTextBox = new System.Windows.Forms.TextBox();
            this.secondLargTextBox = new System.Windows.Forms.TextBox();
            this.largTextBox = new System.Windows.Forms.TextBox();
            this.thirdLargTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchButton.Location = new System.Drawing.Point(131, 462);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 31);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "&Search or Sort Data";
            this.individualToolTip.SetToolTip(this.searchButton, "Click to search, sort, or update any state\'s data.");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.ForeColor = System.Drawing.Color.Indigo;
            this.exitButton.Location = new System.Drawing.Point(303, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 31);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.individualToolTip.SetToolTip(this.exitButton, "Click to exit.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(BroecklynneMeyer_CPT_206_Assignment3.State);
            // 
            // stateIdLabel
            // 
            this.stateIdLabel.AutoSize = true;
            this.stateIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateIdLabel.ForeColor = System.Drawing.Color.Indigo;
            this.stateIdLabel.Location = new System.Drawing.Point(89, 24);
            this.stateIdLabel.Name = "stateIdLabel";
            this.stateIdLabel.Size = new System.Drawing.Size(86, 15);
            this.stateIdLabel.TabIndex = 25;
            this.stateIdLabel.Text = "State Name:";
            // 
            // flagDescLabel
            // 
            this.flagDescLabel.AutoSize = true;
            this.flagDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagDescLabel.ForeColor = System.Drawing.Color.Indigo;
            this.flagDescLabel.Location = new System.Drawing.Point(59, 362);
            this.flagDescLabel.Name = "flagDescLabel";
            this.flagDescLabel.Size = new System.Drawing.Size(116, 15);
            this.flagDescLabel.TabIndex = 14;
            this.flagDescLabel.Text = "Flag Description:";
            // 
            // stateIdTextBox
            // 
            this.stateIdTextBox.Location = new System.Drawing.Point(185, 21);
            this.stateIdTextBox.Name = "stateIdTextBox";
            this.stateIdTextBox.ReadOnly = true;
            this.stateIdTextBox.Size = new System.Drawing.Size(269, 20);
            this.stateIdTextBox.TabIndex = 2;
            // 
            // flagDescTextBox
            // 
            this.flagDescTextBox.Location = new System.Drawing.Point(185, 362);
            this.flagDescTextBox.Multiline = true;
            this.flagDescTextBox.Name = "flagDescTextBox";
            this.flagDescTextBox.ReadOnly = true;
            this.flagDescTextBox.Size = new System.Drawing.Size(269, 73);
            this.flagDescTextBox.TabIndex = 13;
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.incomeLabel.Location = new System.Drawing.Point(65, 198);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(110, 15);
            this.incomeLabel.TabIndex = 19;
            this.incomeLabel.Text = "Median Income:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ForeColor = System.Drawing.Color.Indigo;
            this.colorLabel.Location = new System.Drawing.Point(130, 168);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 15);
            this.colorLabel.TabIndex = 20;
            this.colorLabel.Text = "Color:";
            // 
            // birdLabel
            // 
            this.birdLabel.AutoSize = true;
            this.birdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birdLabel.ForeColor = System.Drawing.Color.Indigo;
            this.birdLabel.Location = new System.Drawing.Point(138, 138);
            this.birdLabel.Name = "birdLabel";
            this.birdLabel.Size = new System.Drawing.Size(37, 15);
            this.birdLabel.TabIndex = 21;
            this.birdLabel.Text = "Bird:";
            // 
            // flowerLabel
            // 
            this.flowerLabel.AutoSize = true;
            this.flowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowerLabel.ForeColor = System.Drawing.Color.Indigo;
            this.flowerLabel.Location = new System.Drawing.Point(121, 109);
            this.flowerLabel.Name = "flowerLabel";
            this.flowerLabel.Size = new System.Drawing.Size(54, 15);
            this.flowerLabel.TabIndex = 22;
            this.flowerLabel.Text = "Flower:";
            // 
            // capitolLabel
            // 
            this.capitolLabel.AutoSize = true;
            this.capitolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitolLabel.ForeColor = System.Drawing.Color.Indigo;
            this.capitolLabel.Location = new System.Drawing.Point(119, 79);
            this.capitolLabel.Name = "capitolLabel";
            this.capitolLabel.Size = new System.Drawing.Size(56, 15);
            this.capitolLabel.TabIndex = 23;
            this.capitolLabel.Text = "Capitol:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationLabel.ForeColor = System.Drawing.Color.Indigo;
            this.populationLabel.Location = new System.Drawing.Point(95, 53);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(80, 15);
            this.populationLabel.TabIndex = 24;
            this.populationLabel.Text = "Population:";
            // 
            // secondLargLabel
            // 
            this.secondLargLabel.AutoSize = true;
            this.secondLargLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLargLabel.ForeColor = System.Drawing.Color.Indigo;
            this.secondLargLabel.Location = new System.Drawing.Point(37, 265);
            this.secondLargLabel.Name = "secondLargLabel";
            this.secondLargLabel.Size = new System.Drawing.Size(138, 15);
            this.secondLargLabel.TabIndex = 17;
            this.secondLargLabel.Text = "Second Largest City:";
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsLabel.ForeColor = System.Drawing.Color.Indigo;
            this.jobsLabel.Location = new System.Drawing.Point(19, 317);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(156, 30);
            this.jobsLabel.TabIndex = 15;
            this.jobsLabel.Text = "% of Computer-Related\r\n           Jobs Available:";
            // 
            // largLabel
            // 
            this.largLabel.AutoSize = true;
            this.largLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largLabel.ForeColor = System.Drawing.Color.Indigo;
            this.largLabel.Location = new System.Drawing.Point(89, 232);
            this.largLabel.Name = "largLabel";
            this.largLabel.Size = new System.Drawing.Size(86, 15);
            this.largLabel.TabIndex = 18;
            this.largLabel.Text = "Largest City:";
            // 
            // thirdLargLabel
            // 
            this.thirdLargLabel.AutoSize = true;
            this.thirdLargLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLargLabel.ForeColor = System.Drawing.Color.Indigo;
            this.thirdLargLabel.Location = new System.Drawing.Point(52, 294);
            this.thirdLargLabel.Name = "thirdLargLabel";
            this.thirdLargLabel.Size = new System.Drawing.Size(123, 15);
            this.thirdLargLabel.TabIndex = 16;
            this.thirdLargLabel.Text = "Third Largest City:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(185, 50);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.ReadOnly = true;
            this.populationTextBox.Size = new System.Drawing.Size(269, 20);
            this.populationTextBox.TabIndex = 3;
            // 
            // capitolTextBox
            // 
            this.capitolTextBox.Location = new System.Drawing.Point(185, 78);
            this.capitolTextBox.Name = "capitolTextBox";
            this.capitolTextBox.ReadOnly = true;
            this.capitolTextBox.Size = new System.Drawing.Size(269, 20);
            this.capitolTextBox.TabIndex = 4;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(185, 197);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.ReadOnly = true;
            this.incomeTextBox.Size = new System.Drawing.Size(269, 20);
            this.incomeTextBox.TabIndex = 8;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(185, 167);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.ReadOnly = true;
            this.colorTextBox.Size = new System.Drawing.Size(269, 20);
            this.colorTextBox.TabIndex = 7;
            // 
            // birdTextBox
            // 
            this.birdTextBox.Location = new System.Drawing.Point(185, 137);
            this.birdTextBox.Name = "birdTextBox";
            this.birdTextBox.ReadOnly = true;
            this.birdTextBox.Size = new System.Drawing.Size(269, 20);
            this.birdTextBox.TabIndex = 6;
            // 
            // flowerTextBox
            // 
            this.flowerTextBox.Location = new System.Drawing.Point(185, 108);
            this.flowerTextBox.Name = "flowerTextBox";
            this.flowerTextBox.ReadOnly = true;
            this.flowerTextBox.Size = new System.Drawing.Size(269, 20);
            this.flowerTextBox.TabIndex = 5;
            // 
            // secondLargTextBox
            // 
            this.secondLargTextBox.Location = new System.Drawing.Point(185, 264);
            this.secondLargTextBox.Name = "secondLargTextBox";
            this.secondLargTextBox.ReadOnly = true;
            this.secondLargTextBox.Size = new System.Drawing.Size(269, 20);
            this.secondLargTextBox.TabIndex = 10;
            // 
            // largTextBox
            // 
            this.largTextBox.Location = new System.Drawing.Point(185, 231);
            this.largTextBox.Name = "largTextBox";
            this.largTextBox.ReadOnly = true;
            this.largTextBox.Size = new System.Drawing.Size(269, 20);
            this.largTextBox.TabIndex = 9;
            // 
            // thirdLargTextBox
            // 
            this.thirdLargTextBox.Location = new System.Drawing.Point(185, 293);
            this.thirdLargTextBox.Name = "thirdLargTextBox";
            this.thirdLargTextBox.ReadOnly = true;
            this.thirdLargTextBox.Size = new System.Drawing.Size(269, 20);
            this.thirdLargTextBox.TabIndex = 11;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(185, 327);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.ReadOnly = true;
            this.jobTextBox.Size = new System.Drawing.Size(269, 20);
            this.jobTextBox.TabIndex = 12;
            // 
            // StateForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(618, 513);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.thirdLargTextBox);
            this.Controls.Add(this.largTextBox);
            this.Controls.Add(this.secondLargTextBox);
            this.Controls.Add(this.flowerTextBox);
            this.Controls.Add(this.birdTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.capitolTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.thirdLargLabel);
            this.Controls.Add(this.largLabel);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.secondLargLabel);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.capitolLabel);
            this.Controls.Add(this.flowerLabel);
            this.Controls.Add(this.birdLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.flagDescTextBox);
            this.Controls.Add(this.stateIdTextBox);
            this.Controls.Add(this.flagDescLabel);
            this.Controls.Add(this.stateIdLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Name = "StateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Individual State Information";
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip individualToolTip;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Label stateIdLabel;
        private System.Windows.Forms.Label flagDescLabel;
        private System.Windows.Forms.TextBox stateIdTextBox;
        private System.Windows.Forms.TextBox flagDescTextBox;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label birdLabel;
        private System.Windows.Forms.Label flowerLabel;
        private System.Windows.Forms.Label capitolLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label secondLargLabel;
        private System.Windows.Forms.Label jobsLabel;
        private System.Windows.Forms.Label largLabel;
        private System.Windows.Forms.Label thirdLargLabel;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox capitolTextBox;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox birdTextBox;
        private System.Windows.Forms.TextBox flowerTextBox;
        private System.Windows.Forms.TextBox secondLargTextBox;
        private System.Windows.Forms.TextBox largTextBox;
        private System.Windows.Forms.TextBox thirdLargTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
    }
}