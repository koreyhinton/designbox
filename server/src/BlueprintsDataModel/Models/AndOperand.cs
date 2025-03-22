namespace BlueprintsDataModel.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("AndOperands", Schema = "IF")]
public class AndOperand
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [InverseProperty("AndOperand")]
    public ICollection<AndExpressionOperand> AndExpressionOperands { get; set; } = new List<AndExpressionOperand>();
}
