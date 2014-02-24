using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class NPC
    {
        private string name;
        private string job;

        public NPC(string name, string job)
        {
            this.Name = name;
            this.Job = job;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Job
        {
            get
            {
                return this.job;
            }
            set
            {
                this.job = value;
            }
        }

    }
}
