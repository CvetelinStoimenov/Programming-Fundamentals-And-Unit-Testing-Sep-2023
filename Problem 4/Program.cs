
bool result = BalancedBrackets.IsBalanced(new string[] { });
Console.WriteLine(result);


class BalancedBrackets
{
    public static bool IsBalanced(string[] input)
    {
        int balance = 0;

        foreach (string symbol in input)
        {
            if (symbol == "(")
            {
                balance++;
            }
            else if (symbol == ")")
            {
                balance--;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        return balance == 0;
    }
}

//public class BalancedBracketsTests
//{
//    [Test]
//    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
//    {
//        // Arrange
//        string[] input = { " " };
//        bool expected = true;

//        // Act
//        bool result = BalancedBrackets.IsBalanced(input);

//        // Assert
//        Assert.AreEqual(expected, result);
//    }
//}

//[Test]
//public void IsBalanced_WithOpeningAndClosingBrackets_ReturnsTrue()
//{
//    // Arrange
//    string[] input = { "(", ")" };
//    bool expected = true;

//    // Act
//    bool result = BalancedBrackets.IsBalanced(input);

//    // Assert
//    Assert.AreEqual(expected, result);
//}