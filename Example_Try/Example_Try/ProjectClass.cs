using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example_Try
{
    class ProjectClass
    {
        public string name;
        public TypeTest type;
        public TypeError typeerror;
        public ExProject exProject;

        // For Test 1 
        public string Code;
        // For Test 2 
        public int IDByte;
        public byte Byte;
        //For Test 3
        public bool ConnectedStatus;
        public double Data;
        public uint Speed;

        public bool error;

        /// <summary>
        /// ()
        /// </summary>
        public ProjectClass()
        {
            this.name = "";
            this.type = 0;
            this.Code = "";
            this.IDByte = 0;
            this.Byte = 0;
            this.ConnectedStatus = false;
            this.Data = 0.0f;
            this.Speed = 0;
            this.error = false;
            this.typeerror = TypeError.none;
            this.exProject = new ExProject();
        }

        /// <summary>
        /// Test1
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="HeshCode">Данные</param>
        public ProjectClass(string name, string HeshCode)
        {
            this.name = name;
            this.type = TypeTest.test1;
            this.typeerror = TypeError.none;
            this.exProject = new ExProject();
            this.Code = HeshCode;
            this.error = false;
        }

        /// <summary>
        /// Test2
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="IDByte">id байта</param>
        /// <param name="Byte">1 байт</param>
        public ProjectClass(string name, int IDByte, byte Byte)
        {
            this.name = name;
            this.type = TypeTest.test2;
            this.typeerror = TypeError.none;
            this.exProject = new ExProject();
            this.IDByte = IDByte;
            this.Byte = Byte;
            this.error = false;
        }

        /// <summary>
        /// Test3
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="ConnectedStatus">Статус связи</param>
        /// <param name="Data">Кооэфициент</param>
        /// <param name="Speed">Скорость передачи данных</param>
        public ProjectClass(string name, bool ConnectedStatus, double Data, uint Speed)
        {
            this.name = name;
            this.type = TypeTest.test3;
            this.typeerror = TypeError.none;
            this.exProject = new ExProject();
            this.ConnectedStatus = ConnectedStatus;
            this.Data = Data;
            this.Speed = Speed;
            this.error = false;
        }


    }

}
