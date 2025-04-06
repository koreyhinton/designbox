namespace BlueprintsDataModel.Models;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("AuthoringTeamMemberTimelines", Schema = "IF")]
public class AuthoringTeamMemberTimeline
{
    public int Id { get; set; }

    [ForeignKey(nameof(AuthoringTeamId))]
    public int AuthoringTeamId { get; set; }
    [InverseProperty("MemberTimelines")]
    public AuthoringTeam? AuthoringTeam { get; set; }

    [ForeignKey(nameof(AuthorId))]
    public int AuthorId { get; set; }
    [InverseProperty("TeamTimelines")]
    public Author? Author { get; set; }

    [InverseProperty("AuthoringTeamTimeline")]
    public List<TimeRange> TimeRanges { get; set; } = new();
}
