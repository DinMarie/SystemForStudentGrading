// See https://aka.ms/new-console-template for more information


namespace SystemForStudentGrading{
    using StudentLibrary;
    class Grading
    {
        static void Main(string[] args)
        {
            StudentInformation studentInformation = new StudentInformation();
            Student student = new Student();

            Grades grade = new Grades();


            Console.WriteLine("EDUCATION IS OUR PASSPORT TO THE FUTURE, FOR TOMORROW BELONGS ONLY TO THE PEOPLE WHO PREPARE FOR IT TODAY. - MALCOLM X");
            Console.WriteLine("\n\n");
            Console.WriteLine("Please Enter Student Name:");
            studentInformation.studentName = Console.ReadLine();
            // Console.WriteLine(studentInformation.studentName);

            Console.WriteLine("Please Enter Student Course:");
            studentInformation.course = Console.ReadLine();
            // Console.WriteLine(studentInformation.course);

            Console.WriteLine("Please Enter Student ID:");
            studentInformation.studentID = Console.ReadLine();
            //Console.WriteLine(studentInformation.studentID);

            student.AddStudentRecord(studentInformation);

            //Console.WriteLine("Please enter Number of Subject:");
            //grade.NumberOfSubject =Convert.ToInt32( Console.ReadLine());


            Subjects subjects = new Subjects();

            Console.WriteLine("\n\n");

            // for (int i = 0; i < grade.NumberOfSubject; i++) {


            Console.WriteLine("Please Enter Subject Name:");
            subjects.subjectName = Console.ReadLine();


            Console.WriteLine("Please Enter Professor Name:");
            subjects.professorName = Console.ReadLine();

            Console.WriteLine("Please Enter Grade:");
            subjects.grade = Console.ReadLine();

            Console.WriteLine("FeedBack Message:");
            subjects.grade = Console.ReadLine();

            Console.WriteLine("\n\n");

            Console.WriteLine("SUCCESS IS NOT FINAL, FAILURE IS NOT FATAL, IT IS THE COURAGE TO CONTINUE THE COUNTS....");
          
                grade.AddSubject(subjects);

            Console.WriteLine("\n\n");
            // }
            student.DisplayStudentInfo(studentInformation);
            grade.DisplaySubjectDetails(subjects);
        }
    }
}
