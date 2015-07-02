using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WFPostgreSQLClient
{
    public partial class FrmPGClient : Form
    {
        BusinessLayer layer = null;
        string dbSelectedName = string.Empty;
        string m_connectionString = string.Empty;

        public FrmPGClient()
        {
            InitializeComponent();
            InitializeConnectionString();

            LoadDatabases();
        }

        private void InitializeConnectionString()
        {
            try
            {
                ConnectionStringSettingsCollection csSection = ConfigurationManager.ConnectionStrings;
                m_connectionString = csSection["pgsqlconn"].ConnectionString;
                dbSelectedName = GetDatabaseName(m_connectionString);
                layer = new BusinessLayer(m_connectionString);
                lblServerDetails.Text = m_connectionString;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        private string GetDatabaseName(string m_connectionString)
        {
            string[] parts = Regex.Split(m_connectionString, @"\W+");
            int i = 0;
            while (!parts[i].Equals("Database")) i++;
            return parts[++i];
        }

        public void LoadDatabases()
        {
            DataTable dt = layer.GetDatabases();
            cmbDatabases.DataSource = dt;
            cmbDatabases.DisplayMember = "datname";
            cmbDatabases.SelectedText = dbSelectedName;
        }

        private void btnExecuteSQLStatement_Click(object sender, EventArgs e)
        {
            if (!ckOptimize.Checked)
            {
                //daca nu se optimizeaza executia interogarii
                var watch = Stopwatch.StartNew();
                // the code that you want to measure comes here
                DataTable dtresult = (DataTable) layer.ExecuteBatch(rtSQLStatements.Text.Trim());
                watch.Stop();
                dgvResults.DataSource = null;
                dgvResults.DataSource = dtresult;
                lblExecTime.Text = watch.ElapsedMilliseconds.ToString() + " ms";
            }
        }

        private void cmbDatabases_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDatabases.Text != dbSelectedName)
            {
                //trebuie sa schimbam stringul de connection se baza selectata
                string dbNewName = cmbDatabases.Text;
                m_connectionString = m_connectionString.Replace(dbSelectedName, dbNewName);
                lblServerDetails.Text = m_connectionString;
                layer = new BusinessLayer(m_connectionString);
                dbSelectedName = dbNewName;
            }
        }
    }
}
