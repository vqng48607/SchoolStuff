using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling
{
    public class PriorityQueue
    {
        private List<PCB> pCBList = new List<PCB>();
        public void Enqueue(PCB pcb)
        {
            pCBList.Add(pcb);
            pCBList = pCBList.OrderBy(p => p.ProcessPriority)                  
                             .ToList();
        }
        public void Dequeue()
        {
            pCBList.RemoveAt(0);
        }
        public void Reprioritize(string processName, int newPriority)
        {
            foreach(PCB pcb in pCBList)
            {
                if(pcb.ProcessName == processName)
                {
                    pcb.ProcessPriority = newPriority;
                }
            }

            pCBList = pCBList.OrderBy(p => p.ProcessPriority)
                             .ToList();
        }
        public override string ToString()
        {
            string result = string.Join(",", pCBList);
            

            return $"{{{result}}}";
        }

    }
}
