
namespace Assignment05
{
    class Program
    {
        class Book
        {
            private string password = "Secret";
            internal int copiesInStock = 5;
            public string title = "Clean Code";
            public Genre genre = Genre.Science;
        }
        enum Genre
        {
            Fiction = 1,
            NonFiction,
            Science
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
            Console.WriteLine(B.title); // access modifier public it accessed anywhere for anyone
            #endregion

            #region Question 4 
            // 4.Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.

            Console.WriteLine(B.genre);
            #endregion

            #region Question 5 
            // 5.Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);


            #endregion

        }
    }
}