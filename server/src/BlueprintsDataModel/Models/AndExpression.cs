namespace BlueprintsDataModel.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("TableName", Schema = "IF")]
public class AndExpression
{
    public int Id { get; set; }

    [InverseProperty("AndExpression")]
    public ICollection<AndExpressionOperand> AndExpressionOperands { get; set; } = new List<AndExpressionOperand>();
}
