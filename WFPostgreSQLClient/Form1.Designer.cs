namespace WFPostgreSQLClient
{
    partial class FrmPGClient
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
            this.lblPGDatabases = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblServerDetails = new System.Windows.Forms.Label();
            this.rtSQLStatements = new System.Windows.Forms.RichTextBox();
            this.lblSQLStatements = new System.Windows.Forms.Label();
            this.ckOptimize = new System.Windows.Forms.CheckBox();
            this.btnExecuteSQLStatement = new System.Windows.Forms.Button();
            this.rtResults = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblExecutionTime = new System.Windows.Forms.Label();
            this.lblExecTime = new System.Windows.Forms.Label();
            this.lblExecTimeOpt = new System.Windows.Forms.Label();
            this.lblExecutionTimeOpt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPGDatabases
            // 
            this.lblPGDatabases.AutoSize = true;
            this.lblPGDatabases.Location = new System.Drawing.Point(24, 9);
            this.lblPGDatabases.Name = "lblPGDatabases";
            this.lblPGDatabases.Size = new System.Drawing.Size(118, 13);
            this.lblPGDatabases.TabIndex = 0;
            this.lblPGDatabases.Text = "PostgreSQL Databases";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(148, 6);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(169, 21);
            this.cmbDatabases.TabIndex = 1;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(323, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(98, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "PostgreSQL Server";
            // 
            // lblServerDetails
            // 
            this.lblServerDetails.AutoSize = true;
            this.lblServerDetails.Location = new System.Drawing.Point(427, 9);
            this.lblServerDetails.Name = "lblServerDetails";
            this.lblServerDetails.Size = new System.Drawing.Size(83, 13);
            this.lblServerDetails.TabIndex = 3;
            this.lblServerDetails.Text = "<Server details>";
            // 
            // rtSQLStatements
            // 
            this.rtSQLStatements.Location = new System.Drawing.Point(27, 67);
            this.rtSQLStatements.Name = "rtSQLStatements";
            this.rtSQLStatements.Size = new System.Drawing.Size(675, 189);
            this.rtSQLStatements.TabIndex = 4;
            this.rtSQLStatements.Text = "";
            // 
            // lblSQLStatements
            // 
            this.lblSQLStatements.AutoSize = true;
            this.lblSQLStatements.Location = new System.Drawing.Point(24, 51);
            this.lblSQLStatements.Name = "lblSQLStatements";
            this.lblSQLStatements.Size = new System.Drawing.Size(84, 13);
            this.lblSQLStatements.TabIndex = 5;
            this.lblSQLStatements.Text = "SQL Statements";
            // 
            // ckOptimize
            // 
            this.ckOptimize.AutoSize = true;
            this.ckOptimize.Location = new System.Drawing.Point(27, 491);
            this.ckOptimize.Name = "ckOptimize";
            this.ckOptimize.Size = new System.Drawing.Size(118, 17);
            this.ckOptimize.TabIndex = 6;
            this.ckOptimize.Text = "Optimize execution ";
            this.ckOptimize.UseVisualStyleBackColor = true;
            // 
            // btnExecuteSQLStatement
            // 
            this.btnExecuteSQLStatement.Location = new System.Drawing.Point(559, 487);
            this.btnExecuteSQLStatement.Name = "btnExecuteSQLStatement";
            this.btnExecuteSQLStatement.Size = new System.Drawing.Size(143, 23);
            this.btnExecuteSQLStatement.TabIndex = 7;
            this.btnExecuteSQLStatement.Text = "Execute SQLStatement";
            this.btnExecuteSQLStatement.UseVisualStyleBackColor = true;
            // 
            // rtResults
            // 
            this.rtResults.Location = new System.Drawing.Point(27, 296);
            this.rtResults.Name = "rtResults";
            this.rtResults.Size = new System.Drawing.Size(675, 162);
            this.rtResults.TabIndex = 8;
            this.rtResults.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(24, 280);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "Results";
            // 
            // lblExecutionTime
            // 
            this.lblExecutionTime.AutoSize = true;
            this.lblExecutionTime.Location = new System.Drawing.Point(31, 461);
            this.lblExecutionTime.Name = "lblExecutionTime";
            this.lblExecutionTime.Size = new System.Drawing.Size(77, 13);
            this.lblExecutionTime.TabIndex = 10;
            this.lblExecutionTime.Text = "ExecutionTime";
            // 
            // lblExecTime
            // 
            this.lblExecTime.AutoSize = true;
            this.lblExecTime.Location = new System.Drawing.Point(132, 461);
            this.lblExecTime.Name = "lblExecTime";
            this.lblExecTime.Size = new System.Drawing.Size(38, 13);
            this.lblExecTime.TabIndex = 11;
            this.lblExecTime.Text = "<time>";
            // 
            // lblExecTimeOpt
            // 
            this.lblExecTimeOpt.AutoSize = true;
            this.lblExecTimeOpt.Location = new System.Drawing.Point(594, 461);
            this.lblExecTimeOpt.Name = "lblExecTimeOpt";
            this.lblExecTimeOpt.Size = new System.Drawing.Size(38, 13);
            this.lblExecTimeOpt.TabIndex = 13;
            this.lblExecTimeOpt.Text = "<time>";
            // 
            // lblExecutionTimeOpt
            // 
            this.lblExecutionTimeOpt.AutoSize = true;
            this.lblExecutionTimeOpt.Location = new System.Drawing.Point(493, 461);
            this.lblExecutionTimeOpt.Name = "lblExecutionTimeOpt";
            this.lblExecutionTimeOpt.Size = new System.Drawing.Size(77, 13);
            this.lblExecutionTimeOpt.TabIndex = 12;
            this.lblExecutionTimeOpt.Text = "ExecutionTime";
            // 
            // FrmPGClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.lblExecTimeOpt);
            this.Controls.Add(this.lblExecutionTimeOpt);
            this.Controls.Add(this.lblExecTime);
            this.Controls.Add(this.lblExecutionTime);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.rtResults);
            this.Controls.Add(this.btnExecuteSQLStatement);
            this.Controls.Add(this.ckOptimize);
            this.Controls.Add(this.lblSQLStatements);
            this.Controls.Add(this.rtSQLStatements);
            this.Controls.Add(this.lblServerDetails);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.lblPGDatabases);
            this.Name = "FrmPGClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPGDatabases;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblServerDetails;
        private System.Windows.Forms.RichTextBox rtSQLStatements;
        private System.Windows.Forms.Label lblSQLStatements;
        private System.Windows.Forms.CheckBox ckOptimize;
        private System.Windows.Forms.Button btnExecuteSQLStatement;
        private System.Windows.Forms.RichTextBox rtResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblExecutionTime;
        private System.Windows.Forms.Label lblExecTime;
        private System.Windows.Forms.Label lblExecTimeOpt;
        private System.Windows.Forms.Label lblExecutionTimeOpt;
    }
}

