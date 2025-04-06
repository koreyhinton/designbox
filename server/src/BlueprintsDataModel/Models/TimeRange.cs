namespace BlueprintsDataModel.Models;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("TimeRanges", Schema = "IF")]
public class TimeRange
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    [ForeignKey(nameof(AuthoringTeamTimelineId))]
    public int AuthoringTeamTimelineId { get; set; }

    [InverseProperty("TimeRanges")]
    public AuthoringTeamMemberTimeline? AuthoringTeamTimeline { get; set; }
}
