namespace GoodNewsProject.Data.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }      
    }
}