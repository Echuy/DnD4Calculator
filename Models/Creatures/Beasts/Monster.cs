using System.Collections.Generic;

namespace DnD4Calculator.Models.Creatures.Beasts
{
    public class Monster : DnDObject
    {
        public int Level { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Tag> Roles { get; set; }

        public int Exp { get; set; }


    }
}
