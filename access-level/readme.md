# Exercise - Complete a Challenge Activity using Boolean Expressions

## Description:
This is an exercise from Microsoft Learn where you will implement decision logic based on a series of business rules. The challenge involves creating code branches that display different messages to users based on their role-based permissions and career level.

## Challenge Details:
### Initialize Permission and Level Values:
Ensure you have an empty `Program.cs` file open in Visual Studio Code.

1. Open Visual Studio Code and navigate to the CsharpProjects folder.
2. Open the `Program.cs` file.
3. Clear any existing code and add the following lines:
    ```csharp
    string permission = "Admin|Manager";
    int level = 55;
    ```
4. Review the initial code lines. Your application will use a combination of `permission` and `level` to apply and evaluate the business rules.

### Implement Business Rules:
You will need to use the `Contains()` helper method to check if the `permission` string contains one of the specified permission values in the "business rules".

Here are the Business Rules your solution must satisfy:

1. If the user is an Admin with a level greater than 55, output:

2. If the user is an Admin with a level less than or equal to 55, output:

3. If the user is a Manager with a level 20 or greater, output:

4. If the user is a Manager with a level less than 20, output:

5. If the user is not an Admin or a Manager, output:

### Update Your Program.cs Code:
Modify your `Program.cs` code to accommodate each of the business rules.

### Testing:
1. Save your code.
2. Build and run your code.
3. Evaluate the output based on the initial data values.
4. Test for other business rules:
- Update the values assigned to `permission` and `level`.
- Save and run your code.
- Evaluate the output to verify that other business rules are satisfied.

This exercise is designed to reinforce your understanding of Boolean expressions and decision logic in C#.
