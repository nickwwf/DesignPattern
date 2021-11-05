using System;
using System.Collections.Generic;
using System.Text;

namespace _19中介者模式
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " [" + user.GetName() + "] : " + message);
        }
    }
}
