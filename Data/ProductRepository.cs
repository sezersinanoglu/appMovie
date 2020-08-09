using appMovie.Models;
using System.Collections.Generic;
using System.Linq;

namespace appMovie.Data
{
    public static class ProductRepository
    {
        private static List<Movie> _movies = null;

        static ProductRepository()
        {
            _movies = new List<Movie>()
            {
                    new Movie() {
                        Id=1,
                        Name="Shazam",
                        Description="<p>Lorem Ipsum, dizgi ve baský endüstrisinde kullanýlan mýgýr metinlerdir. " +
                        "Lorem Ipsum, adý bilinmeyen bir matbaacýnýn bir hurufat numune kitabý oluþturmak üzere bir yazý " +
                        "galerisini alarak karýþtýrdýðý 1500'lerden beri endüstri standardý sahte metinler olarak kullanýlmýþtýr.<p>",
                        ShortDescription="Shazam v1.00",
                        ImageUrl="https://image.tmdb.org/t/p/w1280/jGxWpk1XfT3j9f8zHICPjYs9ZqL.jpg",
                        CategoryId=1
                    },
                    new Movie() {Id=2,
                        Name="Amazing Grace",
                        Description="<p>Lorem Ipsum, dizgi ve baský endüstrisinde kullanýlan mýgýr metinlerdir. " +
                        "Lorem Ipsum, adý bilinmeyen bir matbaacýnýn bir hurufat numune kitabý oluþturmak üzere bir yazý " +
                        "galerisini alarak karýþtýrdýðý 1500'lerden beri endüstri standardý sahte metinler olarak kullanýlmýþtýr.<p>",
                        ShortDescription="Amazing Greece v1.10",
                        ImageUrl="https://resources.tidal.com/images/83219ca2/9d46/414e/9493/c2f31d281e24/640x640.jpg",
                        CategoryId=2
                    },
                    new Movie() {Id=3,
                        Name="High Life",
                        Description="<p>Lorem Ipsum, dizgi ve baský endüstrisinde kullanýlan mýgýr metinlerdir. " +
                        "Lorem Ipsum, adý bilinmeyen bir matbaacýnýn bir hurufat numune kitabý oluþturmak üzere bir yazý " +
                        "galerisini alarak karýþtýrdýðý 1500'lerden beri endüstri standardý sahte metinler olarak kullanýlmýþtýr.<p>",
                        ShortDescription="High Life v1.00",
                        ImageUrl="https://www.highonfilms.com/wp-content/uploads/2019/04/High_Life_HOF1.jpg",
                        CategoryId=1
                    },
                    new Movie() {Id=4,
                        Name="Billboard",
                        Description="<p>Lorem Ipsum, dizgi ve baský endüstrisinde kullanýlan mýgýr metinlerdir. " +
                        "Lorem Ipsum, adý bilinmeyen bir matbaacýnýn bir hurufat numune kitabý oluþturmak üzere bir yazý " +
                        "galerisini alarak karýþtýrdýðý 1500'lerden beri endüstri standardý sahte metinler olarak kullanýlmýþtýr.<p>",
                        ShortDescription="Bilboard v1.00",
                        ImageUrl="https://pt-blog.ru/wp-content/uploads/2017/09/11-11.jpg",
                        CategoryId=2
                    },
                    new Movie() {Id=5,
                        Name="Storm Bay",
                        Description="<p>Lorem Ipsum, dizgi ve baský endüstrisinde kullanýlan mýgýr metinlerdir. " +
                        "Lorem Ipsum, adý bilinmeyen bir matbaacýnýn bir hurufat numune kitabý oluþturmak üzere bir yazý " +
                        "galerisini alarak karýþtýrdýðý 1500'lerden beri endüstri standardý sahte metinler olarak kullanýlmýþtýr.<p>",
                        ShortDescription="Storm Bay",
                        ImageUrl="https://hkcinema.ru/foto/5b995bbf4709d.jpg",
                        CategoryId=2
                    }
            };

        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}