using System;

public class Array : IMath
{
    private int[] elements;

    public Array(int[] arr)
    {
        elements = arr;
    }

    public int Max()
    {
        int max = elements[0];
        foreach (var element in elements)
        {
            if (element > max)
                max = element;
        }
        return max;
    }

    public int Min()
    {
        int min = elements[0];
        foreach (var element in elements)
        {
            if (element < min)
                min = element;
        }
        return min;
    }

    public float Avg()
    {
        float sum = 0;
        foreach (var element in elements)
        {
            sum += element;
        }
        return sum / elements.Length;
    }

    public bool Search(int valueToSearch)
    {
        foreach (var element in elements)
        {
            if (element == valueToSearch)
                return true;
        }
        return false;
    }
}
