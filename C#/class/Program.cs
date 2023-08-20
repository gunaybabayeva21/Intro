internal class Program
{
    private static void Main(string[] args)
    {
        Human human1 = new Human();
     {
            human1.Name = "Gunay";
            human1.Surname = "babayeva";
            human1.Age= 30;
            Console.WriteLine(human1.Name+" "+human1.Surname+" "+human1.Age);
     }

        Human human2 = new Human();
        {

            human1.Name = "Ayten";
            human1.Surname = "resulova";
            human1.Age = 30;
        }


        Student student1 = new Student();
        {
            student1.Name = "Ayten";
            student1.Surname = "resulova";
            student1.Age = 30;
            student1.scholarship = 80;

        }


        Student student2 = new Student();
        {
            student2.Name = "nergiz";
            student2.Surname = "esgerli";
            student2.Age = 20;
            student2.scholarship = 70;

        }
       
        
    }
    
    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        
    
    }
    class Teacher : Human 
    {
      public byte Salary;
        public string GroupNo;
    
    }

    class Student: Teacher
        {
        public byte scholarship;
       

        }

}