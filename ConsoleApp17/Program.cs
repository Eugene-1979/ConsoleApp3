namespace ConsoleApp17
{
    public class Program
    {
        protected Program()
            {
                    
            }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.F(q =>
            {
                q.Q1();
                q.Q();
            });
        }
    }


    class MyClass
        {
        B b=new B();

       public void F(Action<B> action) {
            action.Invoke(b);
        }

        }

    internal class B
        {
        public void Q() { }
        public void Q1() { }
        }
    }
