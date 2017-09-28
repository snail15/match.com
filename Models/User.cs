using System;

namespace match.Models
{
    public class User : BaseEntity {
    
        public int Id { get; set;}
        public string Name {get; set;}

        public string Email { get; set; }

        public string Password {get; set;}

        public int Smoke {get; set;}

        public int BodyType { get; set; }

        public int Height { get; set;}

        public int Religion { get; set;}

        public int Ethnicity { get; set; }

        public int Kid { get; set; }

        public int Drink { get; set; }

        public int Relationship { get; set; }

        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        public int MinAge { get; set; }
        public int MaxAge { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }



    }
}
