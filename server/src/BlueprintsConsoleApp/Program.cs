using System;
using BlueprintsDataModel.Models;


var andExpression = new AndExpression();
andExpression.AndExpressionOperands = new List<AndExpressionOperand> {
    new AndExpressionOperand { AndOperand = new AndOperand { Name = "playerFoundKey" } },
    new AndExpressionOperand { AndOperand = new AndOperand { Name = "playerUnlockedDoor" } },
    new AndExpressionOperand { AndOperand = new AndOperand { Name = "playerEnteredCastle" } }
};

var interactiveFiction = "/*paste in browser console: */";
foreach (var operand in andExpression.AndExpressionOperands)
{
    interactiveFiction += $"var {operand.AndOperand?.Name ?? "start"} = true; ";
}

interactiveFiction += "if ( true ";
foreach (var operand in andExpression.AndExpressionOperands)
{
    interactiveFiction += " && " + operand.AndOperand?.Name ?? "start";
}
interactiveFiction += ") { console.log(\"You step into one of the castle's dark halls. A chilling voice can be heard, and you think it might be saying your name.\"); }";

Console.WriteLine(interactiveFiction);
