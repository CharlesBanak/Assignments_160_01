/*****************************************************************************
// File Name : Fruits.cs
// Author : Charles Banak
// Creation Date : January 25, 2024
//
// Brief Description : Fruit classes
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//"start" and "update" will not work without monobehavior
public class Fruit 
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// Constructor for fruit class that takes 3 parameters
    /// </summary>
    /// <param name="name">name of fruit</param>
    /// <param name="c">color of fruit</param>
    /// <param name="w">weight of fruit</param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "banana";
        color = "blue";
        weight = 3.7f;
    }

    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
    }

    ~Fruit()
    {
        //write to a file
        name = "";
        weight = 0f;
        color = "clear";
    }
}
