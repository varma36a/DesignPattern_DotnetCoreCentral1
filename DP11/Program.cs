
namespace DP11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var student = new NewStudent.NewStudentBuilder()
                .SetFirstName("John")
                .SetLastName("Doe")
                .SetEmail("john.doe@example.com")
                .SetPhone("123-456-7890")
                .SetAddress("123 Main St")
                .Build();

            Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");




        }
    }
}
