using System;

namespace Interfaces
{
    class Program
    {
        // interface new'lenemez!
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();


            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());
        }
    }

    interface IPersonManager
    {
        // implemented operation
        void Add();
        void Delete();
        void Update();
        void GetAllPeople();

    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern eklendi!");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAllPeople()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Intern guncellendi!");
        }
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi!");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAllPeople()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Customer update edildi!");
        }
    }

    // inherits - class --------------- implements - interface
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personal ekleme 
            Console.WriteLine("Personal eklendi!");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAllPeople()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Personal update edildi!");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}

