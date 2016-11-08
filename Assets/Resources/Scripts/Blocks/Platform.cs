using UnityEngine;
using System.Collections;

//Platform.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Platforms are indestructible blocks

public class Platform : Block
{
    //Sprites

    //Watch Tower Sprites
    //These Sprites are for the middle platform that an EnemyCommander walks on
    public static Sprite WATCH_TOWER_LEFT;
    public static Sprite[] WATCH_TOWER_MIDDLES;

    //Loads all the sprites once the engine is ready to make the compiler happy
    public static void LoadSprites()
    {
        WATCH_TOWER_LEFT = Resources.Load<Sprite>("Images/Watch Tower Images/Platform Left Side");
        WATCH_TOWER_MIDDLES = Resources.LoadAll<Sprite>("Images/Watch Tower Images/Platform Middles");
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.PLATFORM;
    }

    // Update is called once per frame
    protected override void Update()
    {

    }

    //Since its easier to add the sprites at original creation the sprites are saved in the PrimitiveBlocks and then added to the actual blocks
    //During Instantiation
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = map[x][y].spr;
        sr.flipX = map[x][y].flipX;
        sr.flipY = map[x][y].flipY;
    }
}

