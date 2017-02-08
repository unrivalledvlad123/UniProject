using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB3Client.Classes
{
    public class ExampleClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime LatestChange { get; set; }
        public Guid UserId { get; set; }
        public List<int> SampleList { get; set; }
        public List<KeyValuePair<int, string>> SampleKvp { get; set; }
        public int[] SampleIntArray { get; set; }
    }
}
