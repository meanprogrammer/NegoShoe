using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NegoshoePH.Web.Models
{
    public class SQLScriptModel
    {
        [DataType(DataType.MultilineText)]
        public string query { get; set; }
    }
}