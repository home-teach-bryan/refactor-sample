﻿namespace RefactorSample.SimplifyingMethodCalls.ReplaceParameterWithExplicitMethods;

public class After
{
    private int height;
    private int width;

    void SetHeight(int arg) 
    {
        height = arg;
    }
    void SetWidth(int arg) 
    {
        width = arg;
    }
}