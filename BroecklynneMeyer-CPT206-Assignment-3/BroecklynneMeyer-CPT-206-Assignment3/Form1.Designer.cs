
namespace BroecklynneMeyer_CPT_206_Assignment3
{
    partial class SelectStateForm
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateInfoButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.stateDataToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(99, 93);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(251, 24);
            this.stateComboBox.TabIndex = 0;
            this.stateDataToolTip.SetToolTip(this.stateComboBox, "Click down arrow and select a state.");
            // 
            // stateInfoButton
            // 
            this.stateInfoButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.stateInfoButton.Location = new System.Drawing.Point(147, 172);
            this.stateInfoButton.Name = "stateInfoButton";
            this.stateInfoButton.Size = new System.Drawing.Size(150, 30);
            this.stateInfoButton.TabIndex = 1;
            this.stateInfoButton.Text = "View &State Information";
            this.stateDataToolTip.SetToolTip(this.stateInfoButton, "Click to view information on your chosen state.");
            this.stateInfoButton.UseVisualStyleBackColor = true;
            this.stateInfoButton.Click += new System.EventHandler(this.stateInfoButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchButton.Location = new System.Drawing.Point(147, 219);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 30);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "&Search or Sort Data";
            this.stateDataToolTip.SetToolTip(this.searchButton, "Click to search, sort, or update any state\'s data.");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitButton.Location = new System.Drawing.Point(176, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 28);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.stateDataToolTip.SetToolTip(this.exitButton, "Click to exit.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.ForeColor = System.Drawing.Color.Indigo;
            this.selectLabel.Location = new System.Drawing.Point(154, 44);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(143, 25);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Select a State";
            this.stateDataToolTip.SetToolTip(this.selectLabel, "Select a state to view information about it.");
            // 
            // SelectStateForm
            // 
            this.AcceptButton = this.stateInfoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.stateInfoButton);
            this.Controls.Add(this.stateComboBox);
            this.Name = "SelectStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Information";
            this.Load += new System.EventHandler(this.SelectStateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stateInfoButton;
        private System.Windows.Forms.ToolTip stateDataToolTip;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label selectLabel;
        public System.Windows.Forms.ComboBox stateComboBox;
    }
}

