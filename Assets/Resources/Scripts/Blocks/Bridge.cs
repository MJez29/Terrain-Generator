using UnityEngine;
using System.Collections;

//Bridge.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Bridges are Blocks that can be jumped through from below but cannot be fallen through from above
//Most bridges have ladders attached to them

public class Bridge : Block//DestructibleBlock
{
    public static Sprite BRIDGE;

    //Loads all the sprites once Unity is ready
    public static void LoadSprites()
    {
        BRIDGE = Resources.Load<Sprite>("Images/Bridge Images/Bridge");
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.BRIDGE;
    }
	
	// Update is called once per frame
	protected override void Update ()
    {
	    
	}

    //If no Sprite has been assigned to the Bridge block it gets the default bridge block
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = BRIDGE;
    }
}
