using fs_2025_a_api_demo_002.Data;

namespace fs_2025_a_api_demo_002.Endpoints
{
    public static class BookEndPoints
    {
        public static void AddBookEndPoints(this WebApplication app)
        {
            // GET all books
            app.MapGet("/books", (BookData bookData) =>
            {
                return Results.Ok(bookData.Books);
            });

            // GET book by id
            app.MapGet("/books/{id:int}", (int id, BookData bookData) =>
            {
                var book = bookData.Books.FirstOrDefault(b => b.Id == id);
                return book is not null ? Results.Ok(book) : Results.NotFound();
            });
        }
    }
}
