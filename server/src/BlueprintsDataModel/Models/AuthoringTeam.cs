namespace BlueprintsDataModel.Models;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("AuthoringTeams", Schema = "IF")]
public class AuthoringTeam
{
    public int Id { get; set; }

    [InverseProperty("AuthoringTeam")]
    public ICollection<AuthoringTeamMemberTimeline> MemberTimelines { get; set; } = new List<AuthoringTeamMemberTimeline>();
}
