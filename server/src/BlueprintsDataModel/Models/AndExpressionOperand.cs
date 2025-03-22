namespace BlueprintsDataModel.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("AndExpressionOperands", Schema = "IF")]
public class AndExpressionOperand
{
    [ForeignKey(nameof(AndExpressionId))]
    public int AndExpressionId { get; set; }
    [InverseProperty("AndExpressionOperands")]
    public AndExpression? AndExpression { get; set; }

    [ForeignKey(nameof(AndOperandId))]
    public int AndOperandId { get; set; }
    [InverseProperty("AndExpressionOperands")]
    public AndOperand? AndOperand { get; set; }
}
