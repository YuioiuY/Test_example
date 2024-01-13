using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Try
{
    class ExProject
    {
        public string data;
        public TypeError error;

        /// <summary>
        /// if TypeError must be none
        /// </summary>
        public ExProject() 
        {
            this.data = "";
            this.error = TypeError.none;
        }

        /// <summary>
        /// if TypeError not none
        /// </summary>
        /// <param name="data"> элемент который вызвал ошибку </param>
        /// <param name="error"> название ошибки </param>
        public ExProject(string data, TypeError error)
        {
            this.data = data;
            this.error = error;
        }


    }
}
