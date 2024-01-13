using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Try
{
    class Randomazier
    {
        
        public string RandomCode(List<string> ListCode)
        {
            return ListCode[new Random().Next(ListCode.Count)];
        }

        public byte RandomByte(List<byte> ListByte)
        {
            return ListByte[new Random().Next(ListByte.Count)];
        }

        public double RandomData(List<double> ListData)
        {
            return ListData[new Random().Next(ListData.Count)];
        }

        public uint RandomSpeed(List<uint> ListSpeed)
        {
            return ListSpeed[new Random().Next(ListSpeed.Count)];
        }

        public bool RandomBool()
        {
            int rand = new Random().Next(10);
            if (rand > 3)
                return true;
            else
                return false;
        }

        public int RandomIDByte(List<int> ListIDByte)
        {
            return ListIDByte[new Random().Next(ListIDByte.Count)];
        }

        public int RandomTestTime() 
        {
            return new Random().Next(10, 30);
        }

    }
}
