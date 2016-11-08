using UnityEngine;
using System.Collections;

//Trench.cs
//Author(s): Michal Jez
//Shadowstruck Software

//A trench block is a block that lines the sides of a trench

public class Trench : Block//DestructibleBlock
{
    //Left wall means that the block is on the left half of the trench or spawner
    //Bottom wall means that the block is part of the floor of the trench
    public static Sprite LEFT_WALL;
	public static Sprite TOP_WALL;
	public static Sprite BOTTOM_LEFT_CORNER;
	public static Sprite TOP_LEFT_CORNER;
	public static Sprite TOP_CENTER_CORNER;

    //Loads all the sprites once the engine is ready to make the compiler happy
    public static void LoadSprites()
    {
        LEFT_WALL = Resources.Load<Sprite>("Images/Trench Images/Trench Side");
        TOP_WALL = Resources.Load<Sprite>("Images/Trench Images/Trench Top Side");
        BOTTOM_LEFT_CORNER = Resources.Load<Sprite>("Images/Trench Images/Trench Side + 2 Corner Trench");
        TOP_LEFT_CORNER = Resources.Load<Sprite>("Images/Trench Images/Trench Top Left Corner");
        TOP_CENTER_CORNER = Resources.Load<Sprite>("Images/Trench Images/Trench Top Center Corner");
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.TRENCH;
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