
using DesgnPatternMemento.Memento;

Orginator org=new Orginator();
CareTaker ct = new();
org.State = 12;
ct.Mem=org.CreateMemento(org.State);
org.State = 13;
Console.WriteLine(org.State);
org.ReturnOldVersion(ct.Mem);
Console.WriteLine(org.State);
