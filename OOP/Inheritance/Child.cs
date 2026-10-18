namespace OOP.Inheritance
{
    class Child : Parent
    {
        //clr will auto generate default constructor if no user defined constructor exists
        //that will call the default constructor of parent class
        //public Child() : base() {   }

        //public int A { get; set; }

        public int B { get; set; }

        public Child(int _a, int _b) : base(_a)
        {
            //A = _a;
            B = _b;
        }

        //public void ShowRole()
        //{
        //    Console.WriteLine("Hi I am Child");
        //}

        //public void PrintDetails()
        //{
        //    Console.WriteLine($"Child : A = {A} , B = {B}");
        //}
    }

}
