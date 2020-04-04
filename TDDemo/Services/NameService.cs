using System;
using System.Collections.Generic;
using System.Text;

namespace TDDemo.Services
{
    public class NameService : INameService
    {
        public string GetMrName(string name)
        {
            return $"Mr. {name}";
        }
    }
}
