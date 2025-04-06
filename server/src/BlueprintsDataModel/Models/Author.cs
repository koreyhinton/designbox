namespace BlueprintsDataModel.Models;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("Authors", Schema = "IF")]
public class Author
{
    public int Id { get; set; }

    [InverseProperty("Author")]
    public ICollection<AuthoringTeamMemberTimeline> TeamTimelines { get; set; } = new List<AuthoringTeamMemberTimeline>();
}
