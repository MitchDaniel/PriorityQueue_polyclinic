using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var priorityQueue = new PriorityQueue<Patient, int>();
            priorityQueue.Enqueue(new Patient("Denis", 19), 1);
            priorityQueue.Enqueue(new Patient("Ivan", 31), 2);
            priorityQueue.Enqueue(new Patient("Sergey", 40), 3);
            priorityQueue.Enqueue(new Patient("Oleksey", 29), 1);

            while (priorityQueue.Count > 0)
            {
                var patient = priorityQueue.Dequeue();
                Console.WriteLine(patient);
            }
        }
    }
}

//Создайте приложение, эмулирующее очередь в поликлинику. 
//Пациенты приходят к врачу и попадают в очередь.
//Если в очереди три пациента и приходит четвёртый, он попадает в конец очереди. 
//Врач принимает по одному пациенту за определенный момент времени.
//При разработке приложения используйте класс PriorityQueue.