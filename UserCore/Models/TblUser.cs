using System;
using System.Collections.Generic;

namespace UserCore.Models
{
    public partial class TblUser
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public bool? Status { get; set; }
    }
}
