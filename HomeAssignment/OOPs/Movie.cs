using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPs
{
    class Movie
    {
        string movie_name, director, producer,actor,actoress;
        float rating;
        public void SetMovieName()
        {
            Console.WriteLine("Enter Movie Name");
            movie_name = Console.ReadLine();

        }
        public void SetDirector()
        {
            Console.WriteLine("Enter Director Name");
            director = Console.ReadLine();

        }
        public void SetProducer()
        {
            Console.WriteLine("Enter Producer Name");
            producer = Console.ReadLine();

        }
        public void SetActor()
        {
            Console.WriteLine("Enter Actor Name");
            actor = Console.ReadLine();

        }
        public void SetActress()
        {
            Console.WriteLine("Enter Actress Name");
            actoress = Console.ReadLine();

        }
        public void SetRating()
        {
            Console.WriteLine("Enter Ratings");
            rating = Convert.ToSingle(Console.ReadLine());

        }

        public string GetMovieName()
        {
            return movie_name;

        }
        public string GetDirector()
        {
            return director;
        }
        public string GetProducer()
        {
           return producer;

        }
        public string GetActor()
        {
           return actor;

        }
        public string GetActress()
        {
           return actoress;

        }
        public float GetRating()
        {
           return rating ;

        }
        static void Main(string[] args)
        {
            Movie m =new  Movie();
            m.SetMovieName();
            m.SetProducer();
            m.SetDirector();
            m.SetActor();
            m.SetActress();
            m.SetRating();
            Console.WriteLine("Movie Name:"+ m.GetMovieName());
            Console.WriteLine( "Producer Name:"+m.GetProducer());
            Console.WriteLine("Director Name"+ m.GetDirector());
            Console.WriteLine("Actor Name:"+ m.GetActor());
            Console.WriteLine(  "Actoress name:"+ m.GetActress());
            Console.WriteLine(  "Ratings:"+m.GetRating());


        }





    }
}
