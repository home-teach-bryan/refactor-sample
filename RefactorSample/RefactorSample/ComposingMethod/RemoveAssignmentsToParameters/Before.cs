﻿namespace RefactorSample.ComposingMethod.RemoveAssignmentsToParameters;

public class Before
{
    int Discount(int inputVal, int quantity) 
    {
        if (quantity > 50) 
        {
            inputVal -= 2;
        }
        // ...
        return inputVal;
    }
}