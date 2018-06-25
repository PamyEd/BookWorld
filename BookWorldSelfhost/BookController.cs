using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;
//using BookWorldSelfhost;

namespace BookWorldSelfhost
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BookController : ApiController
    {
        public List<clsGenre> GetGenreList()
        {
            DataTable lcResult = ClsDBConnection.GetDataTable("SELECT GenreId,GenreName,Description FROM tbl_genre", null);
            List<clsGenre> lcGenre = new List<clsGenre>();
            foreach (DataRow dr in lcResult.Rows)
                lcGenre.Add(new clsGenre
                {
                    Id = (int)dr[0],
                    Name = (string)dr[1],
                    Desc = (string)dr[2]

                });
            return lcGenre;
        }

        public List<clsBook> GetBookListByGenreId(string Genre)
        {
            Console.WriteLine("Gen {0}", Genre);
            Dictionary<string, object> par = new Dictionary<string, object>(1);


            par.Add("GenreName", Genre);

            DataTable lcGenreId = ClsDBConnection.GetDataTable("SELECT GenreId FROM tbl_genre where GenreName=@GenreName", par);
            Console.WriteLine(lcGenreId.Rows[0]["GenreId"]);
            par.Add("Id", lcGenreId.Rows[0]["GenreId"]);
            DataTable lcResult = ClsDBConnection.GetDataTable("SELECT BookName,BooksLeft,BookDesc FROM tbl_book where ct_id=@Id", par);
            List<clsBook> lcBookList = new List<clsBook>();
            foreach (DataRow dr in lcResult.Rows)
                lcBookList.Add(new clsBook
                {
                    BookName = (string)dr[0],

                    BooksLeft = (int)dr[1],
                    BookDesc = (string)dr[2]

                });
            return lcBookList;
        }

        public string GetGenreIdByName(string Genre)
        {

            Console.WriteLine("etthi");
            string GenreId = "";
            Dictionary<string, object> par = new Dictionary<string, object>(1);

            par.Add("Genre", Genre);

            DataTable lcResult =

            ClsDBConnection.GetDataTable("SELECT * FROM tbl_genre WHERE GenreName = @Genre", par);
            List<clsGenre1> lcGenre = new List<clsGenre1>();
            if (lcResult.Rows.Count > 0)
            {
                foreach (DataRow dr in lcResult.Rows)
                    lcGenre.Add(new clsGenre1
                    {
                        Id = (int)dr[0],
                        Name = (string)dr[1],
                        Desc = (string)dr[2]

                    });
                Console.WriteLine(GenreId);
                GenreId = lcGenre[0].ToString();
                return GenreId;
            }
            else
                return null;

        }



        public string GetBookNameByName(string BookName)
        {
            string Result = "";
            Dictionary<string, object> par = new Dictionary<string, object>(1);

            par.Add("BookName", BookName);

            DataTable lcResult =

            ClsDBConnection.GetDataTable("SELECT * FROM tbl_book WHERE BookName = @BookName", par);

            if (lcResult.Rows.Count > 0)
            {
                Result = "1";
            }
            else
            {
                Result = "0";
            }
            return Result;
        }

        public string GetBookIdByName(string BookName)
        {
            string Result = "";
            Dictionary<string, object> par = new Dictionary<string, object>(1);

            par.Add("BookName", BookName.Trim());

            DataTable lcResult =

            ClsDBConnection.GetDataTable("SELECT * FROM tbl_book WHERE BookName = @BookName", par);

            if (lcResult.Rows.Count > 0)
            {
                Result = lcResult.Rows[0][0].ToString();
            }
            else
            {
                Result = "0";
            }
            return Result;
        }

        public clsBook GetBookDetailsById(string BookId)
        {
            Console.WriteLine("ssss");
            Dictionary<string, object> par = new Dictionary<string, object>(1);


            par.Add("BookId", BookId);

            DataTable dtBooks = ClsDBConnection.GetDataTable("SELECT * FROM tbl_book where BookId=@BookId", par);

            //List<clsBook> lcBookList = new List<clsBook>();

            //lcBookList.Add(new clsBook
            //{
            clsBook _Book = new clsBook();
            _Book.BookId = (int)dtBooks.Rows[0][0];
            _Book.BookName = (string)dtBooks.Rows[0][1];
            _Book.AuthorName = (string)dtBooks.Rows[0][2];
            _Book.ISBN = (int)dtBooks.Rows[0][3];
            _Book.BookDesc = (string)dtBooks.Rows[0][4];
            _Book.Price = (decimal)dtBooks.Rows[0][5];
            _Book.BooksLeft = (int)dtBooks.Rows[0][6];
            _Book.LastUpdatedDate = (dtBooks.Rows[0][7]).ToString();
            _Book.Condition = (string)dtBooks.Rows[0][8];
            _Book.GenreId = (int)dtBooks.Rows[0][9];
            _Book.Antique = Convert.ToBoolean(dtBooks.Rows[0][10]);
            _Book.Package = (string)dtBooks.Rows[0][11];
            _Book.Weight = (decimal)dtBooks.Rows[0][12];

            //});
            return _Book;


            //    return new clsBook()
            //    {
            //        BookId = (int)dtBooks.Rows[0][0];
            //}
        }

        public string GetGenreNameById(string GenreId)
        {
            string Genre = "";
            Dictionary<string, object> par = new Dictionary<string, object>(1);

            par.Add("GenreId", GenreId);

            DataTable lcResult =

            ClsDBConnection.GetDataTable("SELECT GenreName FROM tbl_genre WHERE GenreId = @GenreId", par);

            if (lcResult.Rows.Count > 0)
            {
                Genre = lcResult.Rows[0]["GenreName"].ToString();

                Console.WriteLine("Genre: {0}", Genre);
                return Genre;
            }
            else
                return null;

        }

        public string DeleteBook(string BookId)
        {
            try
            {

                Dictionary<string, object> par = new Dictionary<string, object>(11);
                par.Add("BookId", BookId);


                int lcRecCount = ClsDBConnection.Execute("DELETE FROM tbl_book WHERE BookId=@BookId", par);
                if (lcRecCount == 1)
                    return "One product Deleted";
                else
                    return "Error Unexpected product delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.GetBaseException().Message;
            }

        }


        public string PostBook(clsBook prBook)
        {
            Console.WriteLine("fgfgfgf {0}", prBook.Package);
            try
            {

                Dictionary<string, object> par = new Dictionary<string, object>(11);
                par.Add("BookName", prBook.BookName);
                par.Add("AuthorName", prBook.AuthorName);
                par.Add("ISBN", prBook.ISBN);
                par.Add("BookDesc", prBook.BookDesc);
                par.Add("Price", prBook.Price.ToString());
                par.Add("BooksLeft", prBook.BooksLeft.ToString());
                par.Add("LastUpdatedDate", prBook.LastUpdatedDate.ToString());
                par.Add("BookCondition", prBook.Condition);
                par.Add("GenreId", prBook.GenreId.ToString());
                par.Add("Antique", prBook.Antique.ToString());
                par.Add("Package", prBook.Package);
                par.Add("Weight", prBook.Weight.ToString());
                Console.WriteLine("fgfgfgf tertre {0}", prBook.Package);

                int lcRecCount = ClsDBConnection.Execute("INSERT INTO tbl_book " +
                    "(BookName, AuthorName, ISBN, BookDesc, Price, BooksLeft, LastUpdtDate, BookCondition, ct_id, Antique, Package, Weight) " +
                    "VALUES (@BookName, @AuthorName, @ISBN, @BookDesc, @Price, @BooksLeft, @LastUpdatedDate, @BookCondition, @GenreId, @Antique, @Package, @Weight)", par);
                if (lcRecCount == 1) return "One Book inserted";
                else return "Error Unexpected Book insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.GetBaseException().Message;
            }
        }

        public string UpdateBook(clsBook prBook)
        {
            try
            {

                Dictionary<string, object> par = new Dictionary<string, object>(11);
                par.Add("BookId", prBook.BookId.ToString());
                par.Add("BookName", prBook.BookName);
                par.Add("AuthorName", prBook.AuthorName);
                par.Add("ISBN", prBook.ISBN);
                par.Add("BookDesc", prBook.BookDesc);
                par.Add("Price", prBook.Price.ToString());
                par.Add("BooksLeft", prBook.BooksLeft.ToString());
                par.Add("LastUpdatedDate", prBook.LastUpdatedDate.ToString());
                par.Add("BookCondition", prBook.Condition);
                par.Add("GenreId", prBook.GenreId.ToString());
                par.Add("Antique", prBook.Antique.ToString());
                par.Add("Package", prBook.Package);
                par.Add("Weight", prBook.Weight.ToString());

                int lcRecCount = ClsDBConnection.Execute(
                "UPDATE tbl_book SET BookName = @BookName, AuthorName = @AuthorName, ISBN = @ISBN, BookDesc = @BookDesc, Price = @Price, BooksLeft = @BooksLeft, LastUpdtDate = @LastUpdtDate, " +
                "BookCondition = @BookCondition, ct_id = @GenreId, Antique = @Antique, Package = @Package, Weight = @Weight WHERE BookId = @BookId", par);
                if (lcRecCount == 1)
                    return "One product updated";
                else
                    return "Error Unexpected product update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.GetBaseException().Message;
            }

        }

        

    }
}
        //public clsGenre GetGenreById(string Id)

        //{

        //    Dictionary<string, object> par = new Dictionary<string, object>(1);

        //    par.Add("Id", Id);

        //    DataTable lcResult =

        //    ClsDBConnection.GetDataTable("SELECT * FROM tbl_genre WHERE Name = @Id", par);

        //    if (lcResult.Rows.Count > 0)

        //        return new clsGenre()

        //        {

        //            Id = (int)lcResult.Rows[0]["GenreId"],

        //            Name = (string)lcResult.Rows[0]["GenreName"],

        //            Desc = (string)lcResult.Rows[0]["Desc"]

        //        };

        //    else

        //        return null;

        //}
    