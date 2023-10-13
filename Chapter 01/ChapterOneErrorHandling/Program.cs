namespace ChapterOneErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            try
            {
                ValidAge(age);

                SavePerson();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("You must specify a valid value for the age information. Info:" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            finally
            {
                CloseDbConnection();
            }
        }

        static bool ValidAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException("The age must be greater than 0");
            }

            return true;
        }

        static void SavePerson()
        {

        }

        static void CloseDbConnection()
        {

        }
    }