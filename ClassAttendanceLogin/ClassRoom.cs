using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("classes")]
public class ClassRoom : BaseModel
{
    [PrimaryKey("id")]
    public string Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("teacher_id")]
    public string TeacherId { get; set; }

    public override string ToString() => Name;
}