using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("attendance")]
public class AttendanceRecord : BaseModel
{
    [Column("class_id")]
    public string ClassId { get; set; }

    [Column("student_id")]
    public string StudentId { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [Column("status")]
    public string Status { get; set; }
}