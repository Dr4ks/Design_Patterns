using System;
namespace CompositeV2{
    abstract class Component
    {
        public Component() { }

        public abstract int GetNetSalaries();
    }


    class Developer : Component
    {
        public string name;
        public int salary;

        public Developer(string name,int salary){
            this.name=name;
            this.salary=salary;
        }
        public override int GetNetSalaries()
        {
            return this.salary;
        }
    }

    class Designer : Component
    {
        public string name;
        public int salary;

        public Designer(string name,int salary){
            this.name=name;
            this.salary=salary;
        }

        public override int GetNetSalaries()
        {
            return this.salary;
        }
    }

  
    class Organization : Component
    {
        protected List<Component> _children = new List<Component>();
        
        public  void AddEmployee(Component component)
        {
            this._children.Add(component);
        }

        public  void RemoveEmployee(Component component)
        {
            this._children.Remove(component);
        }


        public override int GetNetSalaries()
        {           
            int result=0;
            foreach(Component component in this._children){
                result+=component.GetNetSalaries();
            }
            return result;            
        }
    }

}