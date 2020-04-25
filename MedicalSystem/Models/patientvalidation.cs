
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalSystem.Models
{
    [MetadataType(typeof(patientMetaData))]
    public  partial class patient
    {
        public class patientMetaData
        {

            [DisplayName("PatientName")]
            public string patientname { get; set; }

            [DisplayName("Address")]
            public string address { get; set; }


            [DisplayName("Mobile")]
            public Nullable<int> mobile { get; set; }
        }
    }
}