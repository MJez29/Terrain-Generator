using UnityEngine;
using System.Collections;
using System;

//Air.cs
//Author(s): Michal Jez
//Shadowstruck Software

//A Roof Block is a Block that lines the top of a structure

public class Roof : Block//DestructibleBlock
{
    //Sprites

    //Watch Tower Roof Sprites
    public static Sprite[] WATCH_TOWER_ROOF_TOP;
    public static Sprite[] WATCH_TOWER_ROOF_BOTTOM;

    //Loads all the sprites once the engine is ready to make the compiler happy
    public static void LoadSprites()
    {
        //I'm not sure if Resources.LoadAll() will load from 0-4 so I'm gonna use a loop just to be sure
        WATCH_TOWER_ROOF_TOP = new Sprite[5];
        WATCH_TOWER_ROOF_BOTTOM = new Sprite[5];
        for (int i = 0; i < 5; i++)
        {
            WATCH_TOWER_ROOF_TOP[i] = Resources.Load<Sprite>("Images/Watch Tower Images/Roof T" + i);
            WATCH_TOWER_ROOF_BOTTOM[i] = Resources.Load<Sprite>("Images/Watch Tower Images/Roof B" + i);
        }
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.ROOF;
    }

    // Update is called once per frame
    protected override void Update()
    {

    }

    //Since it easier to add the sprites at original creation the sprites are saved in the PrimitiveBlocks and then added to the actual blocks
    //During Instantiation
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = map[x][y].spr;
        sr.flipX = map[x][y].flipX;
        sr.flipY = map[x][y].flipY;
    }
}

