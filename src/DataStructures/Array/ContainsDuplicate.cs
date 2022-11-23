﻿namespace DataStructures.Array;

public static class ContainsDuplicate
{
    public static bool Verify(IEnumerable<int> array)
    {
        var hashSet = new HashSet<int>();
        foreach (var item in array)
        {
            if (hashSet.Contains(item))
            {
                return true;
            }

            hashSet.Add(item);
        }

        return false;
    }

    public static bool VerifyWithLinq(int[] array)
    {
        var distinctCount = array.Distinct().Count();
        return distinctCount != array.Length;
    }
}