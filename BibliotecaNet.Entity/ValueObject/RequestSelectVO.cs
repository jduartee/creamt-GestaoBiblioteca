using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.ValueObject
{
    public class RequestSelectVO
    {
        public IList<SelectResult> results { get; set; }
    }

    public class SelectResult
    {
        public object id { get; set; }
        public string text { get; set; }
    }
}
