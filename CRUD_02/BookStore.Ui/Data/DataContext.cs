using BookStore.Ui.Models;
using System.Data.Entity;

namespace BookStore.Ui.Data
{
    public class DataContext : DbContext
    {
        //UTILIZANDO O CONSTRUTOR DO DBCONTEXT PARA INSERIR A STRING DE CONEXÃO
        public DataContext(): base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_bookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        //INFORMANDO O MODELO QUE VAI SER MAPEADO
        public DbSet<Book> Books { get; set; }
        public DbSet<Origem> Origems { get; set; }

    }
}