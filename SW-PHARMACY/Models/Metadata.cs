using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW_PHARMACY.Models
{
    [MetadataType(typeof(LoginMetadata))]
    public partial class Login
    {

    }
    public partial class LoginMetadata
    {
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}