namespace Stringbuilder_Clear
{
    internal class Appends
    {
        public string Capacity; // property
        public string AppendS(string text)
        {
            Capacity += text + " ";
            return Capacity;
        }
    }
}
