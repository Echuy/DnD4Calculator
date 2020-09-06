using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD4Calculator.Models
{
    public class DnDObject : DbContext
    {
        public DnDObject()
        {

        }
        public DnDObject(Tag type)
        {
            this.Type = type;
        }
        public int Id { get; set; }
        public Tag Type { get; set;}
    }

    public class Tag
    {
        public Tag (string name, string sysName, Tag parentTag)
        {
            this.Name = name;
            this.SysName = sysName;
            this.ParentTag = ParentTag;
        }
        public int id {get;}

        public Tag ParentTag { get; set; }
        public string Name { get; set; }

        public string SysName { get; set; }

        public string ImageName { get; set; }

    }
}
