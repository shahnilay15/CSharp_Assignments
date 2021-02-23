using System;

namespace Assignment_1
{
         public delegate void DelEventHandler();
    class Program
    {

        public static event DelEventHandler add;

        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Press q for quite or continue press any except q");

                if (Convert.ToChar(Console.ReadLine()) == 'q')
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Write employee id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write employee name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write department_name");
                    string dname = Console.ReadLine();
                    Employee e = new Employee(id, name, dname);
                    Getdata(e);
                    Console.WriteLine("_______________________________________________________");

                    Console.WriteLine("Type y if you want to update data and n for continue ");
                    Console.WriteLine("_______________________________________________________");
                    if (Convert.ToChar(Console.ReadLine()) == 'y')
                    { Updatedata(e); }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        private static void Updatedata(Employee e)
        {
            Console.WriteLine("Write id to be updated");
            int id = Convert.ToInt32(Console.ReadLine());
            e.update(12);
            Console.WriteLine("Write name to be updated");
            string name = Console.ReadLine();
            e.update(name);
            Console.WriteLine("Write department_name to be updated");
            string dname = Console.ReadLine();
            e.update(id, dname);
            Console.WriteLine("---------------------");
            Console.WriteLine("Successfully updated");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Updated Result : ");
            Console.WriteLine("");
            Getdata(e);
            Console.WriteLine("----------------------------------------------------------");
        }

        private static void Getdata(Employee e)
        {
            Console.WriteLine($"Employee id         : {e.GetId()}");
            add += new DelEventHandler(OnGetId);
            Console.WriteLine($"Employee name       : {e.GetName()}");
            add += new DelEventHandler(OnGetName);
            Console.WriteLine($"Employee Department : {e.GetDepartmentName()}");
            add += new DelEventHandler(OnGetDname);
            add.Invoke();

        }

        public static void OnGetDname()
        {
            Console.WriteLine("GetDname() called");
        }

        public static void OnGetId()
        {
            Console.WriteLine("GetId() called");
        }
        public static void OnGetName()
        {
            Console.WriteLine("GetName() called");
        }
    }
}
