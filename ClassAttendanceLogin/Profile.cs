using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("profiles")]
public class Profile : BaseModel
{
    [PrimaryKey("id")]
    public string Id { get; set; }

    [Column("full_name")]
    public string FullName { get; set; }

    [Column("role")]
    public string Role { get; set; }
}