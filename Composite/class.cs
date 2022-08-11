using System;
namespace Composite{
    abstract class Game_Laptop //Component
    {
        public Game_Laptop() { }
        public double price;

        public abstract string Get_Extensions();

        public abstract double Get_Total_Price();       

        public virtual void Add(Game_Laptop component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Game_Laptop component)
        {
            throw new NotImplementedException();
        }

    }


    class Camera : Game_Laptop  //price 1500 //Leaf
    {

        public override string Get_Extensions()
        {
            return "Camera added";
        }
        public override double Get_Total_Price()
        {
            this.price+=1500;
            return this.price;
        }
    }
    class Microphone : Game_Laptop  //price 1500 //Leaf
    {
        public override string Get_Extensions()
        {
            return "Microphone added";
        }
        public override double Get_Total_Price()
        {
            this.price+=1500;
            return this.price;
        }
    }

    class Ram8gb : Game_Laptop  //price 2000 //Leaf
    {
        public override string Get_Extensions()
        {
            return "RAM8GB added";
        }
        public override double Get_Total_Price()
        {
            this.price+=2000;
            return this.price;
        }
    }


    class Internal_board : Game_Laptop  //price 2000 //Leaf
    {
        public override string Get_Extensions()
        {
            return "Internal_board added";
        }
        public override double Get_Total_Price()
        {
            this.price+=2000;
            return this.price;
        }
    }

    class Gpu : Game_Laptop  //price 1500 //Leaf
    {
        public override string Get_Extensions()
        {
            return "GPU added";
        }
        public override double Get_Total_Price()
        {
            this.price+=1500;
            return this.price;
        }
    }

    class Cpu : Game_Laptop  //price 3000  //Leaf
    {
        public override string Get_Extensions()
        {
            return "CPU added";
        }
        public override double Get_Total_Price()
        {
            this.price+=3000;
            return this.price;
        }
    }



   
    class Motherboard : Game_Laptop  //Composite
    {
        protected List<Game_Laptop> _children = new List<Game_Laptop>();
        public Motherboard() { }



        public override void Add(Game_Laptop component)
        {
            this._children.Add(component);
        }

        public override void Remove(Game_Laptop component)
        {
            this._children.Remove(component);
        }

        
        public override string Get_Extensions()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Game_Laptop component in this._children)
            {
                result += component.Get_Extensions();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }

        public override double Get_Total_Price()
        {
            int i = 0;
            double total_price=0;

            foreach (Game_Laptop component in this._children)
            {

                total_price += component.Get_Total_Price();
                if (i != this._children.Count - 1)
                {
                    total_price += this.Get_Total_Price();
                }
                i++;
            }

            return this.Get_Total_Price();
        }

    }

    class Sensors : Game_Laptop  //Composite
    {
        protected List<Game_Laptop> _children = new List<Game_Laptop>();


        public override void Add(Game_Laptop component)
        {
            this._children.Add(component);
        }

        public override void Remove(Game_Laptop component)
        {
            this._children.Remove(component);
        }

        
        public override string Get_Extensions()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Game_Laptop component in this._children)
            {
                result += component.Get_Extensions();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }

        public override double Get_Total_Price()
        {
            int i = 0;
            double total_price=0;

            foreach (Game_Laptop component in this._children)
            {

                total_price += component.Get_Total_Price();
                if (i != this._children.Count - 1)
                {
                    total_price += this.Get_Total_Price();
                }
                i++;
            }

            return this.Get_Total_Price();
        }
    }
}