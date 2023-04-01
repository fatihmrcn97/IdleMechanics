using UnityEngine;

public class TestScri : MonoBehaviour
{
    int[] myNum0 = { 1, 2, 10, 3, 15, 1, 2, 2 };



    int[] myNum = { 5, 2, 10, 3, 15, 1, 2, 2 };

    int[] myNum2 = { 1, 2, 10, 3, 15, 16, 2, 2 };

    int[] myNum3 = { 3, 2, 18, 1, 0, 3, -11, 1, 3 };

    int[] myNum4 = { 2, 3, 1, 1, 18 };

    int[] myNum5 = { 8, 2, 1, 1, 18, 3, 5 };

    int[] myNum6 = { 3, 3, 3, 3, 3, 3 };

    int[] myNum7 = { 1 };
    int[] myNum8 = { };


    void Start()
    {
        //hasNValues(myNum, 2);
        //Debug.Log(hasNValues(myNum0, 2));
        //Debug.Log(hasNValues(myNum, 3));
        //Debug.Log(hasNValues(myNum2, 10));
        //Debug.Log(hasNValues(myNum3, 3));
        //Debug.Log(hasNValues(myNum4, 2));
        //Debug.Log(hasNValues(myNum5, 20));


        //Debug.Log("1 : "+isMercurial(myNum0));
        //Debug.Log("2 : " + isMercurial(myNum));
        //Debug.Log("3 : " + isMercurial(myNum2));
        //Debug.Log("4 : " + isMercurial(myNum3));
        //Debug.Log("5 : " + isMercurial(myNum4));
        //Debug.Log("6 : " + isMercurial(myNum5));
        //Debug.Log("7 : " + isMercurial(myNum6));
        //Debug.Log("8 : " + isMercurial(myNum7));
        //Debug.Log("9 : " + isMercurial(myNum8));


        Debug.Log(closestFibonacci(12));
        Debug.Log(closestFibonacci(33));
        Debug.Log(closestFibonacci(34));


    }

    int hasNValues(int[] a, int n)
    {
        int[] values = new int[a.Length];
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < count; j++)
            {
                if (a[i] == values[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                values[count] = a[i];
                count++;
            }
        }

        if (count == n) return 1;
        else return 0;

    }


    int isMercurial(int[] a)
    {
        if (a.Length <= 2) return 1;
        bool foundOne = false;
        bool foundTree = false; 
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 1)
            {
                if (foundOne && foundTree) return 0;
                foundOne = true;
            }
            else if (a[i] == 3)
            {
                if(foundOne)
                    foundTree = true;
            }
            
        }
        return 1;
    }




    int closestFibonacci(int n)
    {
        if (n < 1) return 0;
        int firstNumber = 0, secondLast = 1, lastNumber = 1;
        while (lastNumber <= n)
        {
            firstNumber = secondLast;
            secondLast = lastNumber;
            lastNumber = firstNumber + secondLast;
        }
        return secondLast;
    }


}
