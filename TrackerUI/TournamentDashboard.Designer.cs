
namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.Headerlabel = new System.Windows.Forms.Label();
            this.loadingExistingDropDown = new System.Windows.Forms.ComboBox();
            this.loadingExistingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Headerlabel
            // 
            this.Headerlabel.AutoSize = true;
            this.Headerlabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headerlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Headerlabel.Location = new System.Drawing.Point(344, 76);
            this.Headerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Headerlabel.Name = "Headerlabel";
            this.Headerlabel.Size = new System.Drawing.Size(416, 51);
            this.Headerlabel.TabIndex = 14;
            this.Headerlabel.Text = "Tournament Dashboard";
            // 
            // loadingExistingDropDown
            // 
            this.loadingExistingDropDown.FormattingEnabled = true;
            this.loadingExistingDropDown.Location = new System.Drawing.Point(353, 261);
            this.loadingExistingDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.loadingExistingDropDown.Name = "loadingExistingDropDown";
            this.loadingExistingDropDown.Size = new System.Drawing.Size(407, 45);
            this.loadingExistingDropDown.TabIndex = 21;
            // 
            // loadingExistingTournamentLabel
            // 
            this.loadingExistingTournamentLabel.AutoSize = true;
            this.loadingExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadingExistingTournamentLabel.Location = new System.Drawing.Point(385, 199);
            this.loadingExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingExistingTournamentLabel.Name = "loadingExistingTournamentLabel";
            this.loadingExistingTournamentLabel.Size = new System.Drawing.Size(334, 38);
            this.loadingExistingTournamentLabel.TabIndex = 20;
            this.loadingExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentButton.Location = new System.Drawing.Point(404, 409);
            this.createTournamentButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(296, 56);
            this.createTournamentButton.TabIndex = 24;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.AutoSize = true;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadTournamentButton.Location = new System.Drawing.Point(436, 333);
            this.loadTournamentButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(232, 38);
            this.loadTournamentButton.TabIndex = 25;
            this.loadTournamentButton.Text = "Load Tournament";
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 690);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadingExistingDropDown);
            this.Controls.Add(this.loadingExistingTournamentLabel);
            this.Controls.Add(this.Headerlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Headerlabel;
        private System.Windows.Forms.ComboBox loadingExistingDropDown;
        private System.Windows.Forms.Label loadingExistingTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Label loadTournamentButton;
    }
}