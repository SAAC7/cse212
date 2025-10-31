using System.Xml.XPath;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //I will create an array of doubles with the size of length
        var multiples = new double[length];
        //I will use a for loop to iterate through the array and assign each index the value of number multiplied by the index + 1
        for (int i = 0; i < length; i++)
        {

            //At each index, I will assign the value of number multiplied by (i + 1) to account for the fact that arrays are 0-indexed
            multiples[i] = number * (i + 1);
        }



        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // I will get the last 'amount' of elements from the list and store them in a new list called 'endpart'
        var endpart = data.GetRange(data.Count - amount, amount);
        // I will get the first part of the list up to the point where 'endpart' starts and store it in a new list called 'startpart'
        var startpart = data.GetRange(0, data.Count - amount);
        // I will clear the original list and then add the elements from 'endpart' followed by the elements from 'startpart'
        data.Clear();
        //I will add the elements from 'endpart' to the original list
        data.AddRange(endpart);

        //I will add the elements from 'startpart' to the original list
        data.AddRange(startpart);
        
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
