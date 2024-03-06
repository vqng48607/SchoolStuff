using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_2._0_4
{
    class Buffer
    {
        private Queue<Car> bufferData;
        private int capacity;

        private object bufferLock = new object();
        private static SemaphoreSlim sem = new SemaphoreSlim(0, 50);

        public Buffer(int capacity)
        {
            this.capacity = capacity;
            bufferData = new Queue<Car>();
        }

        public void Put(Car car)
        {
            //Monitor.Enter(bufferLock);
            //Monitor.Pulse(bufferLock);

            sem.Wait(capacity);

            
            bufferData.Enqueue(car);

            Thread.Sleep(1000);


            if (bufferData.Count > capacity)
            {
                throw new System.ArgumentException("Køen er fuld");
            }

            sem.Release();

            //Monitor.Exit(bufferLock);


        }

        public Car Get()
        {
            Car car;
            //Monitor.Enter(bufferLock);
            //Monitor.Wait(bufferLock);

            sem.Wait(capacity);

            Thread.Sleep(1000);
            car = bufferData.Dequeue();

            

            //Monitor.Exit(bufferLock);
            sem.Release();
            return car;
        }

        public bool IsEmpty()
        {
            bool isempty;
            lock (bufferLock)
            {
                isempty = bufferData.Count == 0;
            }
            return isempty;
        }

        public bool IsFull()
        {
            bool isfull;
            lock (bufferLock)
            {
                isfull = bufferData.Count == capacity;
            }
            return isfull;
        }
    }

}
