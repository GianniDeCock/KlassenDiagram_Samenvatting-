using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasDemoKlasDiagrammen3.Core
{
    public abstract class Company : ICompany
    {
        public string Name { get; set; }
        public string Country { get;}
        public Company(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public abstract string GetCompanyInformation();
    }
}
