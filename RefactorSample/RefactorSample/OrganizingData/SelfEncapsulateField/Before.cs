﻿namespace RefactorSample.OrganizingData.SelfEncapsulateField;

public class Before
{
    class Range 
    {
        private int low, high;
  
        bool Includes(int arg) 
        {
            return arg >= low && arg <= high;
        }
    }
}