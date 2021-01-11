namespace API.Entities
{
    public class AppUser
    {
        //try to follow camelcase and Id name as this only
        //or else there will be a good amount of refractoring to be done
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}