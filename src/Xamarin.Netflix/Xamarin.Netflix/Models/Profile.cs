namespace Xamarin.Netflix.Models
{
    public enum ProfileType
    {
        Profile,
        NewProfile,
        None
    }

    public class Profile
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public ProfileType ProfileType { get; set; }
    }
}