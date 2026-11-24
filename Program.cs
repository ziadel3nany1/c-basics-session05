
namespace Assignment05
{
    class Program
    {
        class Book
        {
            private string password = "Secret";
        }
        public static void Main()
        {
            #region Question 1
            // 1. Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            Book B = new Book();
            //Console.WriteLine(B.password); it will not print because the access modifier private can only access in it's own class

            #endregion

        }
    }
}