using School.IncorrectGroup;

namespace School.Students
{
    internal class Student
    {
        private int id;
        private string name;
        private string surname;
        private string groupno;
        public static int Id { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string GroupNo
        {
            get
            {
                return groupno;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    groupno = value;
                }
                else
                {
                    throw new IncorrectGroupExtension("Group name not correct!");
                }
            }
        }
        public static bool CheckGroupNo(string value)
        {
            int upperCharCounter = 0;
            int digitCharCounter = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[i]))
                {
                    upperCharCounter++;
                }
                if (Char.IsDigit(value[i]))
                {
                    digitCharCounter++;
                }
            }

            if (upperCharCounter == 2 && digitCharCounter == 3)
            {
                return true;
            }
            else
            {
                
                return false;
            }


        }
        public Student(string name, string surname, string groupNo)
        {
            Id++;
            id = Id;
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Name : {name} | Surname : {surname} | GroupNo : {groupno} Id : {id}");
        }
     
    }
}
