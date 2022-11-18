namespace classes_3_new
{
    internal class Book : Product
    {
        public string category;
        public Book(string name, string category, int num, int price) : base(name, num, price)
        {
            this.category = category;
        }
        public void getInfo()
        {
            Console.WriteLine("****************/////////////**************");
            Console.WriteLine($"name: {name} \n category: {category} \n num: {num} \n price: {price}\n**********Product**********\n");
        }
    }
}
