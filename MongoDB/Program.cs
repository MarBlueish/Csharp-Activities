using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_RAFAEL_ALBUQUERQUE
{
    internal class Program
    {

        public class Book
        {
            public ObjectId _id { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public int year_published { get; set; }

            public override string ToString() // return a string representation from the object.
            {

                return $"Book: {title} ||| Author: {author} ||| Year Published: {year_published}";

            }

        }

        static void Main(string[] args)
        {

            string connection_string = "mongodb+srv://rafalbuquerquecra:Mongo87@cluster0.oabbhg8.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            string database_name = "DB_Book"; 
            string collection_name = "books"; //like tables.

            //Connect to MongoDB
            var client = new MongoClient(connection_string);                // Creates a Client to connect.
            var database = client.GetDatabase(database_name);               // Creates a Database with the string named above.   
            var collection = database.GetCollection<Book>(collection_name); // Creates table.

            Book book = new Book(); // Class Instance
           
            Console.Write("Title: ");
            book.title = Console.ReadLine();

            Console.Write("Author: ");
            book.author = Console.ReadLine();

            Console.Write("Year Published: ");
            book.year_published = int.Parse(Console.ReadLine());

            collection.InsertOne(book); // Inserts book into a connection.

            var filter = Builders<Book>.Filter.Empty;          // Select * From books.
            var all_books = collection.Find(filter).ToList();  // Uses the query.

            if (all_books.Any()) //If there are any books
            {

                Console.WriteLine("Todos os Livros"); //Display message.

                foreach (Book book1 in all_books) { //Iterate over a list.

                    Console.WriteLine(book1); //Calls the method ToWrite.               

                }

            }
            else //If there are no books.
            {

                Console.WriteLine("No books to report"); //Displays message.

            }

            var filter2 = Builders<Book>.Filter.Gt(x => x.year_published, 1999); // Select * From books Where year_published > 1999.
            var new_books = collection.Find(filter2).ToList();                   // Uses the query.

            Console.WriteLine("Livros publicados após 1999:");  //Displays message.

            if (new_books.Any()) //If there are any books
            {

                foreach (Book book1 in new_books) //Iterate over a list.
                {

                    Console.WriteLine(book1); //Displays message.

                }

            }
            else //If there are no books.
            {

                Console.WriteLine("Nenhum livro publicado após 1999 encontrado."); //Displays message.

            }

        }

    }

}
