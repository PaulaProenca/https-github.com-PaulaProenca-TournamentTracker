
namespace TrackerUI
{
    partial class TournamentNameLabel
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
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentlabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.entryfeeValue = new System.Windows.Forms.Label();
            this.createPrizebutton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizebutton = new System.Windows.Forms.Button();
            this.prizeslabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlabel
            // 
            this.Headerlabel.AutoSize = true;
            this.Headerlabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headerlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Headerlabel.Location = new System.Drawing.Point(12, 20);
            this.Headerlabel.Name = "Headerlabel";
            this.Headerlabel.Size = new System.Drawing.Size(343, 51);
            this.Headerlabel.TabIndex = 1;
            this.Headerlabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(21, 124);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(337, 43);
            this.tournamentNameValue.TabIndex = 10;
            this.tournamentNameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged);
            // 
            // tournamentlabel
            // 
            this.tournamentlabel.AutoSize = true;
            this.tournamentlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentlabel.Location = new System.Drawing.Point(14, 83);
            this.tournamentlabel.Name = "tournamentlabel";
            this.tournamentlabel.Size = new System.Drawing.Size(247, 38);
            this.tournamentlabel.TabIndex = 9;
            this.tournamentlabel.Text = "Tournament Name";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(177, 196);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(155, 43);
            this.teamOneScoreValue.TabIndex = 12;
            this.teamOneScoreValue.Text = "0";
            this.teamOneScoreValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged_1);
            // 
            // entryfeeValue
            // 
            this.entryfeeValue.AutoSize = true;
            this.entryfeeValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryfeeValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.entryfeeValue.Location = new System.Drawing.Point(13, 196);
            this.entryfeeValue.Name = "entryfeeValue";
            this.entryfeeValue.Size = new System.Drawing.Size(132, 38);
            this.entryfeeValue.TabIndex = 11;
            this.entryfeeValue.Text = "Entry Fee";
            this.entryfeeValue.Click += new System.EventHandler(this.teamOneScorelabel_Click);
            // 
            // createPrizebutton
            // 
            this.createPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createPrizebutton.Location = new System.Drawing.Point(118, 473);
            this.createPrizebutton.Name = "createPrizebutton";
            this.createPrizebutton.Size = new System.Drawing.Size(181, 61);
            this.createPrizebutton.TabIndex = 18;
            this.createPrizebutton.Text = "Create Prize";
            this.createPrizebutton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(454, 124);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(418, 189);
            this.tournamentPlayersListBox.TabIndex = 20;
            this.tournamentPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentPlayersListBox_SelectedIndexChanged);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(447, 86);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(193, 38);
            this.tournamentPlayersLabel.TabIndex = 21;
            this.tournamentPlayersLabel.Text = "Teams/Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(909, 178);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(130, 106);
            this.DeleteSelectedPlayersButton.TabIndex = 22;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizebutton
            // 
            this.deleteSelectedPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteSelectedPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizebutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteSelectedPrizebutton.Location = new System.Drawing.Point(902, 411);
            this.deleteSelectedPrizebutton.Name = "deleteSelectedPrizebutton";
            this.deleteSelectedPrizebutton.Size = new System.Drawing.Size(137, 114);
            this.deleteSelectedPrizebutton.TabIndex = 25;
            this.deleteSelectedPrizebutton.Text = "Delete Selected";
            this.deleteSelectedPrizebutton.UseVisualStyleBackColor = true;
            // 
            // prizeslabel
            // 
            this.prizeslabel.AutoSize = true;
            this.prizeslabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizeslabel.Location = new System.Drawing.Point(447, 336);
            this.prizeslabel.Name = "prizeslabel";
            this.prizeslabel.Size = new System.Drawing.Size(193, 38);
            this.prizeslabel.TabIndex = 24;
            this.prizeslabel.Text = "Teams/Players";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(454, 374);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(418, 189);
            this.prizesListBox.TabIndex = 23;
            // 
            // createTournamentbutton
            // 
            this.createTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentbutton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentbutton.Location = new System.Drawing.Point(401, 600);
            this.createTournamentbutton.Name = "createTournamentbutton";
            this.createTournamentbutton.Size = new System.Drawing.Size(283, 61);
            this.createTournamentbutton.TabIndex = 27;
            this.createTournamentbutton.Text = "Create Tournament";
            this.createTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentNameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 697);
            this.Controls.Add(this.createTournamentbutton);
            this.Controls.Add(this.deleteSelectedPrizebutton);
            this.Controls.Add(this.prizeslabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.createPrizebutton);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.entryfeeValue);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentlabel);
            this.Controls.Add(this.Headerlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentNameLabel";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Headerlabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentlabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label entryfeeValue;
        private System.Windows.Forms.Button createPrizebutton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizebutton;
        private System.Windows.Forms.Label prizeslabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentbutton;
    }
}