using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWorldSelfhost
{
    public class clsGenre
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public override string ToString()
        {
            return Name;
        }

       
        //public List<clsAllWork> WorksList { get; set; }

    }

    public class clsGenre1
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }


        //public List<clsAllWork> WorksList { get; set; }

    }

    public class clsBook
    {

        public int BookId { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public int ISBN { get; set; }
        public string BookDesc { get; set; }

        public decimal Price { get; set; }
        public int BooksLeft { get; set; }
        public string LastUpdatedDate { get; set; }
        public string Condition { get; set; }
        public int GenreId { get; set; }
        public bool Antique { get; set; }
        public string Package { get; set; }
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return BookName +"  "+BooksLeft+"  "+BookDesc;
        }

        public static clsBook NewBook()
        {
            return new clsBook() {  };
        }
        //public List<clsAllWork> WorksList { get; set; }

    }
}
