using System.Reflection;

namespace modul9_1302213102
{
    public class Movie
    {
        public string Title { set; get; }
        public string Director { set; get; }
        public List<string> Stars { set; get; }
        public string Description {set; get; }
        public Movie(string Title, string Director, List<string> Stars, string Description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Stars = Stars;
            this.Description = Description;
        }
    
    }
}
