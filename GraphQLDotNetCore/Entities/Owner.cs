using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQLDotNetCore.Entities
{
    public class Owner: Entity
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
