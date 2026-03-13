using Standart_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_Interface
{

    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Horror,
        Fantasy
    }
    public class Director: ICloneable
    {
        public string fName {  get; set; }
        public string lName { get; set; }

        public Director()
        {
            fName = "Uknown";
            lName = "Uknown";
        }
        public Director(string f, string l)
        {
            fName = f;
            lName = l;
        }
        public override string ToString()
        {
            return $"Name: {fName} {lName}";
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }

    public class Movie : ICloneable, IComparable
    {
        

        public string title { get; set; }
        public Director dir { get; set; }
        public string country { get; set; }
        public Genre genre { get; set; }
        public int year { get; set; }
        public short rate { get; set; }

        public Movie()
        {
            title = "Unknown";
            dir = new Director();
            country = "Unknown";
            genre = 0;
            year = 0;
            rate = 0;
        }
        public Movie(string title, Director dir, string country, Genre genre, int year, short rate)
        {
            this.title = title;
            this.dir = dir;
            this.country = country;
            this.genre = genre;
            this.year = year;
            this.rate = rate;
        }
        public override string ToString()
        {
            return $"\t{title}\nDirector: {dir}\nCountry: {country}\nGenre: {genre}\nYear: {year}\nRating:{rate}";
        }



        public object Clone() 
        {
            Movie temp = (Movie)this.MemberwiseClone();
            temp.dir = new Director
            {
                fName = this.dir.fName,
                lName = this.dir.lName
            };
            return temp;
        }

        
        
        public int CompareTo(object obj) 
        {
            if (obj is Movie)
            {
                return rate.CompareTo((obj as Movie).rate);
            }
            throw new NotImplementedException();
        }

        
    }
    class MovieYearComparer : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.year.CompareTo(y.year);
        }
    }

    public class Cinema: IEnumerable
    {
        public List<Movie> movies = new List<Movie>();

        string adress;
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            movies.Sort(comparer);
        }

        public IEnumerator<Movie> GetEnumerator()
        {
            return movies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public override string ToString()
        {
            string result = $"Adress: {adress}\nMovies in cinema:\n";

            foreach (Movie m in movies)
            {
                result += m.ToString() + "\n";
            }

            return result;
        }
    }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();

            cinema.AddMovie(new Movie
            {
                title = "Film A",                
                dir = new Director { fName = "John", lName = "Smith" },
                country = "USA",
                genre = Genre.Action,
                year = 2020,
                rate = 8
            });

        cinema.AddMovie(new Movie
        {
            title = "Film B",

            dir = new Director { fName = "Ivan", lName = "Petrov" },
            country = "Ukraine",
            genre = Genre.Drama,
            year = 2018,
            rate = 7
        });

            cinema.Sort(new MovieYearComparer());

            foreach (var movie in cinema)
            {
                Console.WriteLine(movie);
            }
        
    }
}
