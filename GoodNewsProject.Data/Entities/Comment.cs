using System;

namespace GoodNewsProject.Data.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public int  UserID { get; set; }
        public int ArticleID { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}