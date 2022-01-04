using System;
using System.Linq;

class ArrayDeleteMethod
{
    public static void DeleteElem(ref int[] myArray, int index)
    {
        int[] newArray = new int[myArray.Length - 1];
        for (int i = 0; i < index; i++)
            newArray[i] = myArray[i];

        for (int i = index; i < myArray.Length; i++)
            newArray[i] = myArray[i + 1];

        myArray = newArray;
    }
    public static void DeleteFirst(ref int[] myArray)
    {
        DeleteElem(ref myArray, 0);
    }

    public static void DeleteLast(ref int[] myArray)
    {
        DeleteElem(ref myArray, myArray.Length - 1);
    }

    //for (int i = index+1; i<myArray.Length; i++)
    // newArray[i-1] = myArray[i];
}
