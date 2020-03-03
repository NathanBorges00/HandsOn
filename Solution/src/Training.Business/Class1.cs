using System;
using LoremNET;

namespace Training.Business
{
    public class Class1
    {
        public static string GetMessage()
        {
            var message = Lorem.Words(10);
            return message;
        }
    }
}
