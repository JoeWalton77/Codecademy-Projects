using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        private int Age
        {
          get { return age; }
          set { if (value >= 18) { age = value; }  
          else
                {
                    throw new ArgumentException("Invalid age");
                }
            }

        }  

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }


        public string ViewProfile()
        {
            string userProfile = $"Name: {name}\nAge: {age}\nLocation: {city}, {country}\nPronouns: {pronouns}";
            userProfile += "\nHobbies:\n";
            foreach (string hobby in hobbies)
            {
                userProfile += $"- {hobby}\n";
            }
            return userProfile;
            
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
