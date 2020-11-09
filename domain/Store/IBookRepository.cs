
namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);
   
        Book[] GetAllByTitleOrAuthor(string titleOrAutor);

        Book GetById(int id);
    }
}
