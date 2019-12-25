﻿using System;

namespace CourseApp
{
    public class Movie : Media
    {
        private int year;

        public Movie()
        : this(1990, "No title", "No country")
        {
        }

        public Movie(int year, string name, string country)
        : base(year, name, country)
        {
        }

        public override int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value < 1990 || value > DateTime.Now.Year)
                {
                    throw new System.Exception($"Production year should be between 1990 and {DateTime.Now.Year}");
                }
                else
                {
                    this.year = value;
                }
            }
        }

        public override string Check()
        {
        return $"I'm watching a movie, named {Name}, which came out in {Year} from {Country}";
        }

        public override string Mark(int mark)
        {
           switch (mark)
           {
               case 1:
               return $"{Name} is a piece of trash, because i can't explain it other way... ";

               case 2:
               return $"Well, {Name} pretty good, but it could be better.";

               case 3:
               return $"{Name} is a great movie! You should really watch it too!";

               default:
               return "Can't help, i didn't watch this film, sorry";
           }
        }

        public override string Send(string who)
        {
            return $"Hi {who}, can you check {Name}({Year}) to watch? I want you to tell me something about it as a movie expert";
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Год: {Year}, Страна: {Country}";
        }
    }
}
