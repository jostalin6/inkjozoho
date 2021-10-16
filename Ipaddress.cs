using System;
using System.Collections.Generic;
using static INKJOLEARN.ClassRoom;

namespace INKJOLEARN
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Student> students = new List<Student>() {
            //  new Student { deptName = "CSE1", rollNo = 1, name = "" }
            //};

            //Given IP address Valid or not
            //172.12.1.10 -IPV4  --32 bits
            //0-255 
            string ipAddress = "256.10.1.23";

            int len = ipAddress.Split('.').Length;

            if(len==4)
            {
                for(int i = 0;i<4;i++)
                {
                    string ip = ipAddress.Split('.')[i];
                    if(ip!=""&&ip!=null)
                    {
                        try
                        {
                          var address = Convert.ToByte(ip);
                        }catch(Exception e)
                        {
                            Console.Write("Given ip is not valid!");
                        }
                    }
                    else
                       Console.Write("Given ip is not valid!");
                }
                Console.Write("Given ip is valid!");

            }
            else
                Console.Write("Given ip is not valid!");
           
            
        }

       
    }
}
