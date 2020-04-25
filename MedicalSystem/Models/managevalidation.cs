using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalSystem.Models
{
    [MetadataType(typeof(managementMetaData))]
    public partial class management

    {
        public class managementMetaData
        {
            [DisplayName("RoomNo")]
            public string roomno { get; set; }

            [DisplayName("Products")]
            public string products { get; set; }

            [DisplayName("ProductModel")]
            public string productmodel { get; set; }

            [DisplayName("Available")]
            public string available { get; set; }
        }
    }





    }
