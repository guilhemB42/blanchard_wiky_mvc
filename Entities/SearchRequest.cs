using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class SearchRequest

    {
        public List<Article> Articles {  get; set; }
        public string val { get; set; }
    }
}
