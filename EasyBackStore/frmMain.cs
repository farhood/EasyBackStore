using EasyBackStore.Classes;

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

            }
            catch (Exception ex)
            {
                CException.ExceptionHandler(ex,"frmMain()");
            }
        }
    }
}