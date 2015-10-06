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
            this.lblResults = new System.Windows.Forms.Label();
            this.lblExecutionTime = new System.Windows.Forms.Label();
            this.lblExecTime = new System.Windows.Forms.Label();
            this.lblExecTimeOpt = new System.Windows.Forms.Label();
            this.lblExecutionTimeOpt = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblNrInregistrari = new System.Windows.Forms.Label();
            this.txtNrInregistrari = new System.Windows.Forms.Label();
            this.lblLogs = new System.Windows.Forms.Label();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
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
            this.cmbDatabases.SelectedValueChanged += new System.EventHandler(this.cmbDatabases_SelectedValueChanged);
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
            this.lblServerDetails.Location = new System.Drawing.Point(427, 9);
            this.lblServerDetails.Name = "lblServerDetails";
            this.lblServerDetails.Size = new System.Drawing.Size(275, 55);
            this.lblServerDetails.TabIndex = 3;
            this.lblServerDetails.Text = "<Server details>";
            // 
            // rtSQLStatements
            // 
            this.rtSQLStatements.EnableAutoDragDrop = true;
            this.rtSQLStatements.Location = new System.Drawing.Point(27, 67);
            this.rtSQLStatements.Name = "rtSQLStatements";
            this.rtSQLStatements.Size = new System.Drawing.Size(675, 124);
            this.rtSQLStatements.TabIndex = 4;
            this.rtSQLStatements.Text = "SELECT * FROM incasari UNION SELECT * FROM plati;";
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
            this.ckOptimize.Location = new System.Drawing.Point(27, 409);
            this.ckOptimize.Name = "ckOptimize";
            this.ckOptimize.Size = new System.Drawing.Size(118, 17);
            this.ckOptimize.TabIndex = 6;
            this.ckOptimize.Text = "Optimize execution ";
            this.ckOptimize.UseVisualStyleBackColor = true;
            // 
            // btnExecuteSQLStatement
            // 
            this.btnExecuteSQLStatement.Location = new System.Drawing.Point(559, 405);
            this.btnExecuteSQLStatement.Name = "btnExecuteSQLStatement";
            this.btnExecuteSQLStatement.Size = new System.Drawing.Size(143, 23);
            this.btnExecuteSQLStatement.TabIndex = 7;
            this.btnExecuteSQLStatement.Text = "Execute SQLStatement";
            this.btnExecuteSQLStatement.UseVisualStyleBackColor = true;
            this.btnExecuteSQLStatement.Click += new System.EventHandler(this.btnExecuteSQLStatement_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(24, 198);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "Results";
            // 
            // lblExecutionTime
            // 
            this.lblExecutionTime.AutoSize = true;
            this.lblExecutionTime.Location = new System.Drawing.Point(31, 379);
            this.lblExecutionTime.Name = "lblExecutionTime";
            this.lblExecutionTime.Size = new System.Drawing.Size(77, 13);
            this.lblExecutionTime.TabIndex = 10;
            this.lblExecutionTime.Text = "ExecutionTime";
            // 
            // lblExecTime
            // 
            this.lblExecTime.AutoSize = true;
            this.lblExecTime.Location = new System.Drawing.Point(132, 379);
            this.lblExecTime.Name = "lblExecTime";
            this.lblExecTime.Size = new System.Drawing.Size(38, 13);
            this.lblExecTime.TabIndex = 11;
            this.lblExecTime.Text = "<time>";
            // 
            // lblExecTimeOpt
            // 
            this.lblExecTimeOpt.AutoSize = true;
            this.lblExecTimeOpt.Location = new System.Drawing.Point(594, 379);
            this.lblExecTimeOpt.Name = "lblExecTimeOpt";
            this.lblExecTimeOpt.Size = new System.Drawing.Size(38, 13);
            this.lblExecTimeOpt.TabIndex = 13;
            this.lblExecTimeOpt.Text = "<time>";
            // 
            // lblExecutionTimeOpt
            // 
            this.lblExecutionTimeOpt.AutoSize = true;
            this.lblExecutionTimeOpt.Location = new System.Drawing.Point(493, 379);
            this.lblExecutionTimeOpt.Name = "lblExecutionTimeOpt";
            this.lblExecutionTimeOpt.Size = new System.Drawing.Size(77, 13);
            this.lblExecutionTimeOpt.TabIndex = 12;
            this.lblExecutionTimeOpt.Text = "ExecutionTime";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(27, 214);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(675, 150);
            this.dgvResults.TabIndex = 14;
            this.dgvResults.DataSourceChanged += new System.EventHandler(this.dgvResults_DataSourceChanged);
            // 
            // lblNrInregistrari
            // 
            this.lblNrInregistrari.AutoSize = true;
            this.lblNrInregistrari.Location = new System.Drawing.Point(266, 379);
            this.lblNrInregistrari.Name = "lblNrInregistrari";
            this.lblNrInregistrari.Size = new System.Drawing.Size(69, 13);
            this.lblNrInregistrari.TabIndex = 15;
            this.lblNrInregistrari.Text = "Nr.Inregistrari";
            // 
            // txtNrInregistrari
            // 
            this.txtNrInregistrari.AutoSize = true;
            this.txtNrInregistrari.Location = new System.Drawing.Point(341, 379);
            this.txtNrInregistrari.Name = "txtNrInregistrari";
            this.txtNrInregistrari.Size = new System.Drawing.Size(52, 13);
            this.txtNrInregistrari.TabIndex = 16;
            this.txtNrInregistrari.Text = "<nrInreg>";
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(24, 451);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(36, 13);
            this.lblLogs.TabIndex = 17;
            this.lblLogs.Text = "Loguri";
            // 
            // rtbLogs
            // 
            this.rtbLogs.Location = new System.Drawing.Point(27, 467);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(675, 124);
            this.rtbLogs.TabIndex = 18;
            this.rtbLogs.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clean Datas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPGClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbLogs);
            this.Controls.Add(this.lblLogs);
            this.Controls.Add(this.txtNrInregistrari);
            this.Controls.Add(this.lblNrInregistrari);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.lblExecTimeOpt);
            this.Controls.Add(this.lblExecutionTimeOpt);
            this.Controls.Add(this.lblExecTime);
            this.Controls.Add(this.lblExecutionTime);
            this.Controls.Add(this.lblResults);
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
            this.Text = "WFP PostresSQL Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
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
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblExecutionTime;
        private System.Windows.Forms.Label lblExecTime;
        private System.Windows.Forms.Label lblExecTimeOpt;
        private System.Windows.Forms.Label lblExecutionTimeOpt;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblNrInregistrari;
        private System.Windows.Forms.Label txtNrInregistrari;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Button button1;
    }
}

