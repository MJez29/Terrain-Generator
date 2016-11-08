using UnityEngine;
using System.Collections;

//BackgroundBlock.cs
//Author(s): Michal Jez
//Shadowstruck Software

//BackgroundBlocks form the background of the scene
//Players cannot walk into these blocks and sometimes when blocks are destroyed
//They will reveal background blocks hidden behind

public class BackgroundBlock : Block
{
    //Sprites

    //Watch Tower Sprites
    public static Sprite WATCH_TOWER_PILLAR;

    //Loads all the sprites once the engine is ready to make the compiler happy
    public static void LoadSprites()
    {
        WATCH_TOWER_PILLAR = Resources.Load<Sprite>("Images/Watch Tower Images/Pillar");
    }

    // Use this for initialization
    protected override void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }

    public override void SetPosition(int nx, int ny)
    {
        x = nx;
        y = ny;
        gameObject.transform.position = new Vector3(x, y, 1);
    }

    //Since it easier to add the sprites at original creation the sprites are saved in the PrimitiveBlocks and then added to the actual blocks
    //During Instantiation
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        if (map[x][y].spr != null)
        {
            sr.sprite = map[x][y].spr;
            sr.flipX = map[x][y].flipX;
            sr.flipY = map[x][y].flipY;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

