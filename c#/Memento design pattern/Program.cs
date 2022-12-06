//using System;

//namespace Memento.Structural
//{
//    /// <summary>
//    /// Memento Design Pattern
//    /// </summary>

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Originator o = new Originator();
//            o.State = "On";

//            // Store internal state

//            Caretaker c = new Caretaker();
//            c.Memento = o.CreateMemento();

//            // Continue changing originator

//            o.State = "Off";

//            // Restore saved state

//            o.SetMemento(c.Memento);

//            // Wait for user

//            Console.ReadKey();
//        }
//    }

//    /// <summary>
//    /// The 'Originator' class
//    /// </summary>

//    public class Originator
//    {
//        string state;

//        public string State
//        {
//            get { return state; }
//            set
//            {
//                state = value;
//                Console.WriteLine("State = " + state);
//            }
//        }

//        // Creates memento 

//        public Memento CreateMemento()
//        {
//            return (new Memento(state));
//        }

//        // Restores original state

//        public void SetMemento(Memento memento)
//        {
//            Console.WriteLine("Restoring state...");
//            State = memento.State;
//        }
//    }

//    /// <summary>
//    /// The 'Memento' class
//    /// </summary>

//    public class Memento
//    {
//        string state;

//        // Constructor

//        public Memento(string state)
//        {
//            this.state = state;
//        }

//        public string State
//        {
//            get { return state; }
//        }
//    }

//    /// <summary>
//    /// The 'Caretaker' class
//    /// </summary>

//    public class Caretaker
//    {
//        Memento memento;

//        public Memento Memento
//        {
//            set { memento = value; }
//            get { return memento; }
//        }
//    }
//}


//class Program
//{
//    public static void Main()
//    {
//        Originator origin = new Originator();
//        Random rand = new Random();
//        origin.State = 23;

//        // Creating a Memento
//        Caretaker caret = new Caretaker();
//        caret.Memento = origin.CreateMemento();

//        //Changing the state
//        origin.State =11;

//        // Restoring the State
//        origin.RestoreMemento(caret.Memento);

//        // Wait for user
//        Console.ReadKey();
//    }
//}

//public class Originator
//{
//    int _statesnap;
//    public int State
//    {
//        get { return _statesnap; }
//        set
//        {
//            _statesnap = value;
//            Console.WriteLine("State is " + _statesnap);
//        }
//    }

//    public Memento CreateMemento()
//    {
//        return new Memento(_statesnap);
//    }

//    public void RestoreMemento(Memento memento)
//    {
//        Console.WriteLine("The Previous State was: ");
//        State = memento.Statesnap;
//    }
//}

//public class Memento
//{
//    int _statesnap;

//    public Memento(int statesnap)
//    {
//        this._statesnap = statesnap;
//    }

//    public int Statesnap
//    {
//        get { return _statesnap; }
//    }
//}

//public class Caretaker
//{
//    Memento memento;
//    public Memento Memento
//    {
//        set { memento = value; }
//        get { return memento; }
//    }
//}








public class Memento
{
    int memElement;
    public Memento(int mem)
    {
        MemElement = mem;
    }
    public int MemElement
    {
        get
        {
            return memElement;
        }
        set
        {
            memElement = value;
        }
    }
}


public class Orginator
{
    int state;
    public int State
    {
        get { return state; }
        set
        {
            state = value;
        }
    }
    public void SetMemento(Memento a)
    {
        State = a.MemElement;
    }
    public Memento CreateMemento()
    {
        return new Memento(state);
    }
    public void RestoreMemento(Memento memento)
    {
        State = memento.MemElement;
        Console.WriteLine("restored state : "+state);
    }
}


public class CareTaker
{
    Memento memento;
    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}
class Program
{
    public static void Main()
    {
        Orginator org=new Orginator();
        org.State = 12;
        CareTaker nexcare=new CareTaker();
        nexcare.Memento = org.CreateMemento();
        org.State = 13;
        org.RestoreMemento(nexcare.Memento);
        Console.WriteLine("check again :" + org.State);

    }
}