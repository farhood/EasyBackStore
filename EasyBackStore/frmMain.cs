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
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                string backupQuery = $"USE {cmbDatabases.Text}{Environment.NewLine}";

                if (checkBox4.Checked == true)
                {
                    backupQuery += $"ALTER DATABASE {cmbDatabases.Text} SET RECOVERY SIMPLE;{Environment.NewLine}DBCC SHRINKFILE ({cmbDatabases.Text}_log, 1);{Environment.NewLine}ALTER DATABASE {cmbDatabases.Text} SET RECOVERY FULL;{Environment.NewLine}";
                }

                backupQuery += $"BACKUP DATABASE {cmbDatabases.Text} To Disk = N'{sfdSave.FileName}'{Environment.NewLine}";

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

                if (listItems.Count>0)
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

                System.Diagnostics.Debug.WriteLine(backupQuery);

                int? result = cDatabase.ExecuteQuery(backupQuery,CommandType.Text);

                System.Diagnostics.Debug.WriteLine(Convert.ToInt32(result));
            }
        }
    }
}