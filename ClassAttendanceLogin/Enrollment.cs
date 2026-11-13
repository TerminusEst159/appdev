using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("enrollments")]
public class Enrollment : BaseModel
{
    [Column("class_id")]
    public string ClassId { get; set; }

    [Column("student_id")]
    public string StudentId { get; set; }
}