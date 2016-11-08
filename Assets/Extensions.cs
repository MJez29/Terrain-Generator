using UnityEngine;
using System.Collections;

//Extensions.cs
//Author(s): Michal Jez
//Shadowstruck Software

//An assortment of various extension methods

public static class Extensions
{
    public static System.Random rand = new System.Random();

    //Shuffles an array of type T
    public static void Shuffle<T>(this T[] objs)
    {
        int n;
        T temp;
        for (int i = objs.Length - 1; i >= 1; i--)
        {
            n = rand.Next(i);
            temp = objs[i];
            objs[i] = objs[n];
            objs[n] = temp;
        }
    }

    //Shuffles 2 linked arrays
    //An object in objsT will be linked to the same object in objsU before and after shuffling by index
    public static void ShuffleLinked<T, U>(this T[] objsT, U[] objsU)
    {
        //Both arrays need to be the same size for the shuffling to work properly
        if (objsT.Length != objsU.Length) return;

        int n;
        T objT;
        U objU;
        for (int i = objsT.Length - 1; i >= 1; i--)
        {
            n = rand.Next(i);

            objT = objsT[i];
            objU = objsU[i];

            objsT[i] = objsT[n];
            objsU[i] = objsU[n];

            objsT[n] = objT;
            objsU[n] = objU;
        }
    }

    //Returns whether or not the current collection is empty (0 elements)
    public static bool Empty(this ICollection coll)
    {
        return coll.Count == 0;
    }
}