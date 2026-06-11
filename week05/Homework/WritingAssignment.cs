public class WritingAssignment: Assignment
{
    private string _title;

    public WritingAssignment(
        string studentName,
        string topic,
        string _title)
        : base(studentName, topic)

    {
        _title = _title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}