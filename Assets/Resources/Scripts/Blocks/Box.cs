using UnityEngine;
using System.Collections;

//Box.cs
//Author(s): Michal Jez
//Shadowstruck Software

//

public class Box : Block//DestructibleBlock
{
    public static Sprite BOX;

    //Loads the Sprites once Unity is ready
    public static void LoadSprites()
    {
        BOX = Resources.Load<Sprite>("Images/Box Images/Box");
    }

    protected override void Awake()
    {
        base.Awake();
        blockType = BlockType.BOX;
    }

    protected override void Update()
    {

    }

    //Every Box has the exact same sprite
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = BOX;
    }
}