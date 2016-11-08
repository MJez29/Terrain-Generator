using UnityEngine;
using System.Collections.Generic;
using System;

//CampController.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Controls all camps in the game

public class CampController : MonoBehaviour
{
    private static System.Random rand = new System.Random();

    protected LinkedList<Camp> camps;

    private void Awake()
    {
        camps = new LinkedList<Camp>();
    }

    //Makes a camp given the positions of the campfire and tent
    public void MakeCamp(Vector2 cf, Vector2 t)
    {
        camps.AddLast(Camp.Make(cf, t).GetComponent<Camp>());
    }
}