using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaskova_433.Classes.Entityes
{
    public class UsersClass
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(32)]
        public string firstName { get; set; }
        [Required, MaxLength(32)]
        public string lastName { get; set; }
        [MaxLength(32)]
        public string middleName { get; set; }
        [Required, MaxLength(32)]
        public string login { get; set; }
        [Required, MaxLength(32)]
        public string password { get; set; }
        public byte[] userPhoto { get; set; }
    }
}
