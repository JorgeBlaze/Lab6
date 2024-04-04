namespace Lab6.Data
{
    public interface IData
    {

        static List<Book> books = new List<Book>();
        static List<User> users = new List<User>();
        static Dictionary<User, List<Book>> borrowedBooks = new Dictionary<User, List<Book>>();


    }
}
