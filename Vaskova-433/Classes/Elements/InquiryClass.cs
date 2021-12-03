using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vaskova_433.Classes.Elements
{
    [DataContract]
    class InquiryClass
    {
        public enum status_inquiry : sbyte
        {
            rejected,
            in_processing,
            done
        };
        [DataMember]
        [Key]
        public int id { get; set; }
        [DataMember]
        [Required, Column(TypeName = "Date"), DataType(DataType.Date)]
        public string date { get; set; }
        [DataMember]
        public int classTrainess { get; set; }
        [DataMember]
        [Required, MaxLength(32)]
        public string firstName { get; set; }
        [DataMember]
        [Required, MaxLength(32)]
        public string lastName { get; set; }
        [DataMember]
        [MaxLength(32)]
        public string middleName { get; set; }
        [DataMember]

        [Required, MaxLength(1024)]
        public string inquiry { get; set; }
        [DataMember]
        [Required]
        public status_inquiry status { get; set; }
    }
}
