﻿namespace RefactorSample.OrganizingData.EncapsulateField;

public class After
{
    class Person 
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}