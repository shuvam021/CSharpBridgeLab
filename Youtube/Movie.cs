namespace CSharpBridgeLab.Youtube
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string a_title, string a_director, string a_rating)
        {
            title = a_title;
            director = a_director;
            Rating = a_rating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG-13" || value == "NR") rating = value;
                else rating = "NR";
            }
        }
    }
}