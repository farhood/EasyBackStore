namespace EasyBackStore
{
    internal static class CException
    {
        public static void ExceptionHandler(Exception exception, string method)
        {
            string message = $"{method}\n{exception.Message}{(exception.InnerException != null ? $"\n{exception.InnerException.Message}" : null)}\nSource: {exception.Source}\nStackTrace: {exception.StackTrace}\nTargetSite: {exception.TargetSite}";
            MessageBox.Show(message, "Exception Handled", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
