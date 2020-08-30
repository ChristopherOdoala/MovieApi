using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.ViewModels
{
    public class FileViewModel
    {
        public Guid FileId { get; set; }
        public string File { get; set; }
        public string Name { get; set; }
    }
}
