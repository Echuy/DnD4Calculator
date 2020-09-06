using System.Collections.Generic;

namespace DnD4Calculator.Models.Creatures.Beasts
{
    public class Monster : DnDObject
    {
        public Monster()
        {

        }
        public Monster(Tag type) 
        {
            this.Type = type;
        }

        public int Level { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Tag> Roles { get; set; }

        public Tag Type { get; set; }


    }
}
