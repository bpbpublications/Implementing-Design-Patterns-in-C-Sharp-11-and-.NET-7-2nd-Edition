namespace Chapter3.Models
{
    public static class Helper
    {
        public static string GenerateUniqueIdentifier()
        {
            return Guid.NewGuid().ToString();
        }
    }
}


