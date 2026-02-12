using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee

        
    {
       
        private string idNo;

        public string IDNO
        {
            get
            {
                if (string.IsNullOrEmpty(idNo))
                    return "Invalid ID";

                return idNo.Substring(0, 5) + "******";
            }
            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool isNumber = char.IsNumber(value[i]);

                        if (!isNumber)
                        {
                            control = true;
                            break;
                        }

                    }
                    if (control) {
                        Console.WriteLine("ID No expect only number!");
                        return;
                      
                    }




                }
                if (value.Length != 11)
                {
                    Console.WriteLine("ID No must be exactly 11 characters");
                    idNo = null;
                    return;
                }


                idNo = value;



            }
        }



    }
}
