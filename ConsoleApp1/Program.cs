using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

var qqqq=Observable.Create<int>(q=> new EmptyDispos());

var ee=qqqq.Subscribe(q => { });

IObserver<int> qqq = new A("u");

internal class EmptyDispos :IDisposable
    {
    public EmptyDispos()
        {
        }

    public void Dispose()
        {
        throw new NotImplementedException();
        }
    }

class A : IObserver<int>
    {
    public A(string myProperty)
        {
        MyProperty = myProperty;
        }

    public string MyProperty { get; set; }
    public void OnCompleted()
        {
        Console.WriteLine("ok");
        }

    public void OnError(Exception error)
        {
        throw new NotImplementedException();
        }

    public void OnNext(int value)
        {
        Console.WriteLine($"{MyProperty}    {value}");
        }
    }