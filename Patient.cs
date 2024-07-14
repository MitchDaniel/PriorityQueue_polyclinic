using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Patient
    {
        public Patient(string fullname, int age)
        {
            Fullname = fullname;
            Age = age;
        }
        public string Fullname { set; get; }

        public int Age { set; get; }

        List<string> _diseases = new List<string>();

        public void AddDisease(string disease) => _diseases.Add(disease);

        public void RemoveDisease(string disease)
        {
            if(_diseases.Remove(disease))
            {
                throw new Exception("Disease not found");
            }
        }

        public override string ToString()
        {
            StringBuilder patient = new StringBuilder();
            patient.Append(Fullname + ", " + Age.ToString() + " years old\n");
            foreach (var disease in _diseases)
            {
                patient.Append(disease);
            }
            return patient.ToString();
        }
    }
}
