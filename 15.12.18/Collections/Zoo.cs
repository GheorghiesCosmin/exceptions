using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Zoo

    {
        public List<Animal> Animals { get; set; }
        public List<Gender> Genders { get; set; }
    }
    public class Zoo()
    {
        Animals = new List<Animal>();
        InitZoo();
    }

    private void InitZoo()
    {
        Animals.Add(new Animal("Elephant", Gender.Female));
        Animals.Add(new Animal("Dolphin", Gender.Male));
        Animals.Add(new Animal("Shark", Gender.Male));
        Animals.Add(new Animal("Fox", Gender.Female));
    }



}
