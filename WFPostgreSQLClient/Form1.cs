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
using System.Threading;

namespace WFPostgreSQLClient
{
    public partial class FrmPGClient : Form
    {
        BusinessLayer layer = null;
        string dbSelectedName = string.Empty;
        string m_connectionString = string.Empty;

        DataTable tblRezult = new DataTable();

        public FrmPGClient()
        {
            InitializeComponent();
            InitializeConnectionString();

            LoadDatabases();
        }

        private System.ComponentModel.BackgroundWorker backWorked;

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
            else
            {
                //daca optimizam interogarea.

                string[] sqlStatems = rtSQLStatements.Text.Trim().Split(new string[] { "UNION", "UNION ALL"}, StringSplitOptions.None);
                for ( int i =0; i< sqlStatems.Count(); i++)
                {
                    //initializeaza workerul 
                    backWorked = new BackgroundWorker();
                    backWorked.DoWork += new DoWorkEventHandler(backWorker_DoWork);
                    backWorked.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backWorker_RunWorkerCompleted);

                    string sql = sqlStatems[i];
                    backWorked.RunWorkerAsync(sql);
                    //Thread th = new Thread(threadAction);
                    //th.Start(sql);

                }           

            }
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            DataTable tbl1 = (DataTable)layer.ExecuteBatch((string)e.Argument);
            watch.Stop();
            MessageBox.Show("completed "+e.Argument.ToString()
                +" sql statements in " + watch.ElapsedMilliseconds.ToString() + " ms");
            e.Result = tbl1;
        }

        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataTable tbl = (DataTable)e.Result;
            tblRezult.Merge(tbl);
            dgvResults.DataSource = null;
            dgvResults.DataSource = tblRezult;
        }


        //public void threadAction(object sqlStatement)
        //{
        //    var watch = Stopwatch.StartNew();
        //    DataTable tbl1 = (DataTable)layer.ExecuteBatch(sqlStatement.ToString());
        //    watch.Stop();
        //    MessageBox.Show("completed sql statements "+ watch.ElapsedMilliseconds.ToString() + " ms");
        //}

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

        private void dgvResults_DataSourceChanged(object sender, EventArgs e)
        {
            try {
                txtNrInregistrari.Text = ((DataTable)dgvResults.DataSource).Rows.Count.ToString();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvResults.DataSource = null;
            FlushMemory();
            GC.Collect();
            
        }

        public static void FlushMemory()
        {
            Process prs = Process.GetCurrentProcess();
            try
            {
                prs.MinWorkingSet = (IntPtr)(300000);
            }
            catch (Exception exception)
            {
                throw new Exception();
            }
        }
    }
}
