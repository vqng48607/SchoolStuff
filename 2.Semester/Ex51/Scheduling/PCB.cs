using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public enum ProcessStateType { New, Ready, Run, Exit, Wait };

    public class PCB
    {
        public string ProcessName { get; set; }

        public int ProcessPriority { get; set; }

        public ProcessStateType ProcessState { get; set; }

        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority.ToString()})";
        }
    }
}
