using list_method;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students  = new List<Student>();
        {
            new Student(" ", 12);
        };

        students.Add (new("gunay babayeva",20));
        students.Add (new( "guler esgerli", 5));
        students.Add (new ( "perviz eliyev", 13));
        students.Add (new ( "gunel Qasimov", 24));

        
      //yasi 18 den boyuk olanlari ekrana yazdirsin
        List<Student> findStudents= students.FindAll(s=> s.Age>18);
       //Id i mueyyen deyere = olaninstudentin ekraa yazdirsin 
       Student?findStudent=students.Find(s => s.Id==2);
       findStudents.ForEach(s=>Console.WriteLine(s.Fullname)); 
        // if (findStident!=null)
        //{
        //Console.WriteLine(find.Student.Fullname);
        //}
        students.RemoveAll(s=>s.Age>18);
        students.ForEach(student=>Console.WriteLine(student.Id+ student.Fullname));
        
        

    }
}