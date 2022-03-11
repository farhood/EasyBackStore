using EasyBackStore.Classes;
using System.Data;

namespace EasyBackStore
{
    public partial class frmMain : Form
    {
        private readonly CDatabase cDatabase;

        public frmMain()
        {
            InitializeComponent();
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "servername.txt");
                if (File.Exists(filePath))
                {
                    using StreamReader reader = new(File.OpenRead(filePath));

                    while (!reader.EndOfStream)
                    {
                        txtServerName.Text = reader.ReadLine();
                    }

                    reader.Close();

                    cDatabase = new CDatabase($"Data Source= {txtServerName.Text}; Initial Catalog= master; Persist Security Info=False; Integrated Security=True; TimeOut=6000;");

                    DataTable dataTable = new("dt");

                    dataTable.Load(new DataTableReader(cDatabase.LoadDatatTable(tableName: "databases",
                                                                                query: "Select [name] From sys.databases Where owner_sid <> 0x01 Order By [name]",
                                                                                commandType: CommandType.Text)));

                    cmbDatabases.DataSource = dataTable;
                    cmbDatabases.DisplayMember = "Name";
                    //comboBox.ValueMember = valueMember;
                }
                else
                {
                    toolsMain.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                CException.ExceptionHandler(ex, "frmMain()");
            }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            toolsMain.Enabled = !txtServerName.Text.IsEmpty();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (sfdBakFile.ShowDialog() == DialogResult.OK)
            {
                string backupQuery = $"USE {cmbDatabases.Text}{Environment.NewLine}";

                if (checkBox4.Checked == true)
                {
                    backupQuery += $"ALTER DATABASE {cmbDatabases.Text} SET RECOVERY SIMPLE;{Environment.NewLine}DBCC SHRINKFILE ({cmbDatabases.Text}_log, 1);{Environment.NewLine}ALTER DATABASE {cmbDatabases.Text} SET RECOVERY FULL;{Environment.NewLine}";
                }

                backupQuery += $"BACKUP DATABASE {cmbDatabases.Text} To Disk = N'{sfdBakFile.FileName}'{Environment.NewLine}";

                List<string> listItems = new();

                if (checkBox1.Checked == true)
                {
                    listItems.Add("Init");
                }

                if (checkBox2.Checked == true)
                {
                    listItems.Add("Format");
                }

                if (checkBox3.Checked == true)
                {
                    listItems.Add("Copy_Only");
                }

                if (listItems.Count > 0)
                {
                    int i = 0;

                    foreach (var item in listItems)
                    {
                        if (i++ == 0)
                        {
                            backupQuery += $"WITH {item}";
                        }
                        else
                        {
                            backupQuery += $", {item}";
                        }
                    }
                }

                int? result = cDatabase.ExecuteQuery(backupQuery, CommandType.Text);
            }
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            if (ofdBakFile.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = ofdBakFile.FileName;
            }
        }

        private void btnDataFolder_Click(object sender, EventArgs e)
        {
            if (fbdRelocateFolder.ShowDialog() == DialogResult.OK)
            {
                txtDataFolder.Text = fbdRelocateFolder.SelectedPath;
            }
        }

        private void btnLogFolder_Click(object sender, EventArgs e)
        {
            if (fbdRelocateFolder.ShowDialog() == DialogResult.OK)
            {
                txtLogFolder.Text = fbdRelocateFolder.SelectedPath;
            }
        }

        private void chkRelocate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRelocate.Checked == true)
            {
                label4.Enabled = true;
                label5.Enabled = true;
                txtDataFolder.Enabled = true;
                txtLogFolder.Enabled = true;
                btnDataFolder.Enabled = true;
                btnLogFolder.Enabled = true;
            }
            else
            {
                txtDataFolder.Clear();
                txtLogFolder.Clear();

                label4.Enabled = false;
                label5.Enabled = false;
                txtDataFolder.Enabled = false;
                txtLogFolder.Enabled = false;
                btnDataFolder.Enabled = false;
                btnLogFolder.Enabled = false;
            }
        }

        private void lblFileName_TextChanged(object sender, EventArgs e)
        {
            tsbRestore.Enabled = !lblFileName.Text.IsEmpty();
            chkRelocate.Enabled = !lblFileName.Text.IsEmpty();
            panelRestoreOptions.Enabled = !lblFileName.Text.IsEmpty();
        }

        private void tsbRestore_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show(text: $"Do you want to restore database {cmbDatabases.Text}?",
                                    caption: "Restore database",
                                    buttons: MessageBoxButtons.YesNo,
                                    icon: MessageBoxIcon.Question,
                                    defaultButton: MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    toolsMain.Enabled = false;

                    string restoreQuery = $"Use master{Environment.NewLine}";

                    if (chkCloseConnections.Checked == true)
                    {
                        restoreQuery = $"Alter Database {cmbDatabases.Text} Set Single_User With Rollback Immediate{Environment.NewLine}{restoreQuery}";
                    }

                    restoreQuery = $"{restoreQuery}{Environment.NewLine}Restore Database {cmbDatabases.Text} From Disk = N'{lblFileName.Text}' ";

                    List<string> listItems = new();

                    if (chkReplace.Checked == true)
                    {
                        listItems.Add("REPLACE");
                    }

                    if (chkRecovery.Checked == true)
                    {
                        listItems.Add("Recovery");
                    }
                    else
                    {
                        listItems.Add("NoRecovery");
                    }

                    int i = 0;

                    foreach (var item in listItems)
                    {
                        if (i++ == 0)
                        {
                            restoreQuery = $"{restoreQuery} WITH {item}";
                        }
                        else
                        {
                            restoreQuery = $"{restoreQuery}, {item}";
                        }
                    }

                    //System.Diagnostics.Debug.WriteLine(restoreQuery);

                    int? result = cDatabase.ExecuteQuery(restoreQuery, CommandType.Text);

                    if (result != null)
                    {
                        MessageBox.Show($"Database {cmbDatabases.Text} is restored successfully!!", "Restore done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //System.Diagnostics.Debug.WriteLine(result);

                    toolsMain.Enabled = true;
                }
            }
            catch (Exception ex) 
            {
                CException.ExceptionHandler(ex, "tsbRestore_Click()");
            }
            finally
            {
                try
                {
                    cDatabase.ExecuteQuery($"ALTER DATABASE {cmbDatabases.Text}{Environment.NewLine}SET MULTI_USER{Environment.NewLine}WITH ROLLBACK IMMEDIATE", CommandType.Text);
                }
                catch (Exception exx)
                {
                    CException.ExceptionHandler(exx, "tsbRestore_Click(finaly)");
                }
            }
        }
    }
}