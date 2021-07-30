using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExerciseProject_OOP.BooksClasses
{
    public class Book
    {
        
        public Book()
        {                
        }

        public Book(string title, string author, double price)
        {
            if (title.Length < 3)  
            {
                throw new ArgumentException($"{title} is not a valid title! Must be 3 or more symbols");
            }
            if (price <= 0)
            {
                throw new ArgumentException($"Price {price} is not valid! Must be a positive number");
            }
            CheckForValidAuthorsName(author);

            Title = title;
            Author = author;
            Price = price;
        }       

        public string Title { get; set; }
        public string Author { get; set; }  // Must be in "FirstName SecondName" format
        public virtual double Price { get; set; }  // we override the Price in GoldenEditionBook - 30 % increase

        public override string ToString()   
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"Book: \"{Title}\" ");
            //sb.Append($"    by: {Author}");
            //sb.Append($"    costs: ${Price:f1}");
            //return sb.ToString();

            return $"Book: \"{Title}\"    by: {Author}    costs: ${Price:f1}";
        }
        private void CheckForValidAuthorsName(string author)
        {
            bool startsWithDigit = true;
            string secondName = author.Split(" ")[1];
            char firstSymbol = secondName.ToCharArray()[0];

            if (!Char.IsDigit(firstSymbol))
            {
                startsWithDigit = false;
            }

            if (!startsWithDigit)
            {
                throw new ArgumentException($"{author}'s name is not valid! Second name must start with a digit(0-9)");
            }
        }
    }

}
