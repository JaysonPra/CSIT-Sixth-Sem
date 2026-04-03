namespace CSVReader;

using System.Data;
using System.IO;
using System.Linq;

public record Student(
    int StudentId,
    string Gender,
    double StudyHours,
    double Attendance,
    double AssignmentScore,
    double MidtermScore,
    double FinalScore,
    double ParticipationScore,
    bool HasInternet,
    bool ExtraClasses,
    string ParentEdu,
    double SleepHours,
    double OverallScore,
    string Grade
);

class Program
{
    static async Task<List<string>> DataIngestion(string fileName)
    {
        using StreamReader reader = new($"{fileName}.csv");
        var rows = new List<string>();

        string? line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
            if (line != null)
            {
                rows.Add(line);
            }
        }

        return rows;
    }

    static List<Student> ParseData(List<string> csv_file)
    {
        var students = new List<Student>();

        foreach (var row in csv_file.Skip(1))
        {
            string[] cols = row.Split(',');

            var student = new Student(
                        StudentId: int.Parse(cols[0]),
                        Gender: cols[1],
                        StudyHours: double.Parse(cols[2]),
                        Attendance: double.Parse(cols[3]),
                        AssignmentScore: double.Parse(cols[4]),
                        MidtermScore: double.Parse(cols[5]),
                        FinalScore: double.Parse(cols[6]),
                        ParticipationScore: double.Parse(cols[7]),
                        HasInternet: cols[8].ToLower() == "yes",
                        ExtraClasses: cols[9].ToLower() == "yes",
                        ParentEdu: cols[10],
                        SleepHours: double.Parse(cols[11]),
                        OverallScore: double.Parse(cols[12]),
                        Grade: cols[13]
            );

            students.Add(student);
        }

        return students;
    }

    static string Describe(List<string> csv_file)
    {
        List<Student> students = ParseData(csv_file);
        List<string> result = [];

        var avgFinal = students.Average(s => s.FinalScore);
        var topStudents = students.Where(s => s.OverallScore > 90).ToList();

        result.Add($"Total Students: {students.Count}");
        result.Add($"Average Final Exam Score: {avgFinal:F2}");
        result.Add($"Students with honors: {topStudents.Count}");

        return string.Join(Environment.NewLine, result);
    }

    static async Task Main(string[] args)
    {
        Console.Write("Enter the file name of the CSV: ");
        string file_name = Console.ReadLine() ?? "default";

        var csv_file = await DataIngestion(file_name);
        Console.WriteLine(Describe(csv_file));
    }
}