﻿using Backend.Enums;

namespace Backend.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size{ get; set; }
        public ICollection<Job> Jobs { get; set; }

    }
}
