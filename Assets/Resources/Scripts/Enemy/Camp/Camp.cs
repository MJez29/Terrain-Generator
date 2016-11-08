using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Camp.cs
//Author(s): Michal Jez
//Shadowstruck Software

//A camp is comprised of a tent and a campfire
//There are special kinds of enemies that are to be found around the camp
//  - Camp Guards (2 per camp)
//      - They patrol the camp pacing back and forth from the campfire to the tent
//  - Campers (2 per camp)
//      - When un-alert these enemies stand around the campfire playing cards
//      - Depending on the situation they may go to the tent to exchange their cards for a real weapon
//Camps link all these 4 enemies together
//If 1 enemy sees a player it will alert this script and this script will co-ordinate the attack on the player
//Whether it may be that all the enemies stand and shoot or they all charge

public class Camp : MonoBehaviour
{
    private static System.Random rand = new System.Random();
    private static GameObject baseCamp;

    //The centers of each of these objects
    public Vector2 campfire;
    public Vector2 tent;
    //Creates a camp
    public static GameObject Make(Vector2 cf, Vector2 t)
    {
        //If the camp prefab is not loaded it loads it
        if (baseCamp == null)
            baseCamp = Resources.Load<GameObject>("Prefabs/Structures/Camp");

        GameObject go = Instantiate(baseCamp);
        Camp cmp = go.GetComponent<Camp>();

        go.transform.position = new Vector2((cf.x + t.x) / 2f, (cf.y + t.y) / 2f);

        cmp.campfire = cf;
        cmp.tent = t;

        return go;
    }
}