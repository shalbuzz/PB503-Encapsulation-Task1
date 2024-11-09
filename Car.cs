using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public double Speed { get; set; }

        public string CarCode { get;  set; }


        
        public string GenerateCarCode(int id,string name)
        {

            string firstOfLetters = name.Substring(0 , 2).ToUpper();

            int countSum = id + 1000;

            return  firstOfLetters + countSum.ToString();
        }

        public Car(int id, string name, double speed)
        {
            this.Id = id;
            this.Name = name;
            this.Speed = speed;
           this.CarCode= GenerateCarCode(id,name);
        }





    }
}
