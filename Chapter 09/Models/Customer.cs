using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapterr9.Models
{
    public class Customer
    {
        [SetsRequiredMembers]
        public Customer (string documentNumber)
        {
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public required string DocumentNumber { get; set; }
    }
}


