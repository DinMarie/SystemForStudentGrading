namespace StudentLibrary
{
    public class Student
    {


        public void AddStudentRecord(StudentInformation student)
        {
            List<StudentInformation> Studentlist = new List<StudentInformation>();

            Studentlist.Add(student);

        }
        public void DisplayStudentInfo(StudentInformation student)
        {

            Console.WriteLine("-----STUDENT INFORMATION-----");
            Console.WriteLine("STUDENT NAME: " + student.studentName);
            Console.WriteLine("STUDENT COURSE: " + student.course);
            Console.WriteLine("STUDENT ID: " + student.studentID);
            Console.WriteLine("\n\n");
        }


    }
    public class StudentInformation
    {

        public string studentName = "";
        public string course = "";
        public string studentID = "";
       
    }

}
