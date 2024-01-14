using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Try
{
    class DataClass
    {
        //for test1
        public List<string> ListCode = new List<string>();
        //for test2
        public List<byte> ListByte = new List<byte>();
        public List<int> ListIDByte = new List<int>();
        //for test3
        public List<double> ListData = new List<double>();
        public List<uint> ListSpeed = new List<uint>();
        //Status Thread
        public List<string> ListStatus = new List<string>(); 



        /// <summary>
        /// Create Data to example 
        /// </summary>
        public DataClass() 
        {
            this.ListCode = new List<string>() { "FF", "FF", "FF","FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FC" };
            this.ListByte = new List<byte>() { 100, 255, 100, 100, 100, 100, 100 };
            this.ListIDByte = new List<int>() {0,1,1,1};
            this.ListData = new List<double>() {0.0,0.1, 0.2, 0.3, 0.5,0.9,1.0};
            this.ListSpeed = new List<uint>() { 0, 20, 40, 100 };
            this.ListStatus = new List<string>() 
            {
                "",
                "в процессе",
                "принудительно остановлен",
                "завершен успешно",
                "завершен с ошибкой",
            };
        }

    }
}
