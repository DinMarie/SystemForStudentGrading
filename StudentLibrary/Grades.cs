public class Grades
{
    public int NumberOfSubject = 0;



    public void AddSubject(Subjects subject)
    {
        List<Subjects> subjectslist = new List<Subjects>();

        subjectslist.Add(subject);

    }
    public void DisplaySubjectDetails(Subjects subject)
    {


        Console.WriteLine("-----SUBJECT DETAILS-----");
        Console.WriteLine("SUBJECT NAME: " + subject.subjectName);
        Console.WriteLine("SUBJECT PROFESSOR:" + subject.professorName);
        Console.WriteLine("SUBJECT GRADE: " + subject.grade);
        Console.WriteLine("PROFESSOR MESSAGE: " + subject.profMessage);
        Console.WriteLine("\n\n");
        Console.WriteLine("EDUCATION IS THE KEY TO SUCCESS BUT YOU HAVE TO LOOK FOR THE RIGHT DOOR - CRUZ'S");
        Console.WriteLine("\n\n");
    }


}
public class Subjects
{

    public string subjectName = "";
    public string professorName = "";
    public string grade = "";
    public string profMessage = "";

}





