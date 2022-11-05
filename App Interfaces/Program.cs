using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Do some programming");

            PasswordManager pm = new PasswordManager("iluvpie", false);
            tdl.Display();
            pm.Display();
            pm.ChangePassword("iluvpie", "eipvuli");
            pm.Display();
        }
    }
}
