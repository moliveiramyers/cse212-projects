
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


        //first step is to create an Array that will hold the multiples including the number
        double[] multiples = new double[length];

        //second step is to create a foreach loop that will iterete starting from one to and including the length number
        for (int i = 1; i <= length; ++i)
        {
            //third step is to add it to the list each time it was we multiple by the i until it gets to length.
            multiples[i - 1] = number * i;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


    //I first created a list to add the part of the list that will move to the begining
        List<int> lastSlice = data.GetRange(data.Count - amount, amount);
    //then I deleted it from the main list
        data.RemoveRange(data.Count - amount, amount);
    //at last I inserted the numbers on the right side that were removed and added to the lastSlice in the begining of the data list
        data.InsertRange(0, lastSlice);

    }
}
