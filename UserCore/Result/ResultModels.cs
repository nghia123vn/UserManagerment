using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCore.Result
{
    public class ResultModels
    {
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
    }
}
