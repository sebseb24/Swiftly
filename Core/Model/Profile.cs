using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiftly.Core.Model
{
    public class Profile
    {
        public required string Name { get; set; }

        public bool IsActive { get; set; } = true;

        public string OutputDevice { get; set; } = "";

        public string InputDevice { get; set; } = "";
    }
}
