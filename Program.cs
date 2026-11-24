
namespace Assignment05
{
    class Program
    {
        class Book
        {
            private string password = "Secret";
            internal int copiesInStock = 5;
            public string Title = "Clean Code";
        }
        public static void Main()
        {
            #region Question 1
            // 1. Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            Book B = new Book();
            //Console.WriteLine(B.password); it will not print because the access modifier private can only access in it's own class

            #endregion

            #region Question 2
            // 2. Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?
            Console.WriteLine(B.copiesInStock); // 5 , because access modifier internal it accessed in the same project 
            #endregion

            #region Question 3 
            // 3. Add a public string Title; field to Book. Set it and print it from Main.
            Console.WriteLine(B.Title); // access modifier public it accessed anywhere for anyone
            #endregion

        }
    }
}