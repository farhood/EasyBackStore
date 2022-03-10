namespace EasyBackStore
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}