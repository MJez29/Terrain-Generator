using UnityEngine;
using System.Collections;

//Ladder.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Ladders allow for easy access to the various elevations of Blocks in the Game
//They can be climbed and be fallen through

public class Ladder : Block
{
    private static Sprite LADDER;

    //Loads all the sprites once Unity is ready
    public static void LoadSprites()
    {
        LADDER = Resources.Load<Sprite>("Images/Ladder Images/Ladder");
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.LADDER;
    }

    // Update is called once per frame
    protected override void Update()
    {

    }

    //If no Sprite has been assigned to the Ladder block it gets the default Ladder Sprite
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = LADDER;
    }
}