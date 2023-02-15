using System;
namespace movies
{
    class Program
    {
        enum Genre
        {
            PopRock,
            Singing,
            Folk,
            Popular,
            Jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private Genre? Genre;

            public string Display()
            {
                return "Title: " + Title + "\nDescription: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre + "\n";
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the title of your favorite song?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("What is the artist's name?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the name of the album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length of the song?");
                    collection[i].setLength(double.Parse(Console.ReadLine()));
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("P - PopRock\nS - Singing\nF - Folk Music\nU - Popular\nJ - Jazz");
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'P':
                            collection[i].setGenre(Genre.PopRock);
                            break;
                        case 'S':
                            collection[i].setGenre(Genre.Singing);
                            break;
                        case 'F':
                            collection[i].setGenre(Genre.Folk);
                            break;
                        case 'U':
                            collection[i].setGenre(Genre.Popular);
                            break;
                        case 'J':
                            collection[i].setGenre(Genre.Jazz);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}