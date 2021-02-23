namespace Assignment_1
{
     class Employee
    {
           //public event DelEventHandler add;
        private int id;
        private string name;
        private string dname;

        public Employee()
        {
            id = 0;
            name = "";
            dname ="";
        }
        public Employee(int id,string name,string dname)
        {
            this.id = id;
            this.name = name;
            this.dname = dname;
        }

        public int GetId()
        {
            return id;
            
        }
        public string GetName()
        {
            return name;
        }
        public string GetDepartmentName()
        {
            return dname;
        }

        public void update(int x)
        {
            this.id = x;
        }
        public void update(string name)
        {
            this.name = name;
        }

        public void update(int i,string x)
        {
            if(this.id == i)
                this.dname = x;
        }

    }
}