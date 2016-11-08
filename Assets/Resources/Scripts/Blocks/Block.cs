using UnityEngine;
using System.Collections;

//Block.cs
//Author(s): Michal Jez
//Shadowstruck Software

//This file contains classes and enums relating to Blocks
//Blocks form the terrain that Players can walk on and destroy

//Block is the base abstract class for any Block that appears in the Game
//It contains basic methods that are usually overridden in derived classes

public abstract class Block : MonoBehaviour
{
    protected static GameObject baseParticle;

    protected SpriteRenderer sr;

    protected BlockType blockType;                                          //The type of the block

    protected int x, y;                                                     //The coordinates of the Block
    
	// Use this for initialization
    //Initializes the SpriteRenderer for the Block
	protected virtual void Awake()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();                 //Gets the SpriteRenderer
    }

    // Update is called once per frame
    protected virtual void Update ()
    {
	    //CheckForCollisions();
	}

    //Sets the position of the Block
    public virtual void SetPosition(int nx, int ny)
    {
        x = nx;
        y = ny;
        gameObject.transform.position = new Vector2(x, y);
    }

    //Gets the block type
    public BlockType GetBlockType()
    {
        return blockType;
    }

    //Sets the Sprite for the Block
    public void SetSprite(Sprite spr)
    {
        sr.sprite = spr;
    }

    //Flips the Sprite in the directions chosen
    public void FlipSprite(bool flipX, bool flipY)
    {
        sr.flipX = flipX;
        sr.flipY = flipY;
    }

    //Initializes the correct sprite for the Block
    public virtual void InitializeSprite(PrimitiveBlock[][] map)
    {
        sr.sprite = null;
    }

    public virtual void Destroy()
    {
        GameObject go;
        for (int i = 0; i < 10; i++)
        {
            if (baseParticle == null)
                baseParticle = Resources.Load<GameObject>("Prefabs/Particles/Particle");
            go = Instantiate(baseParticle);
            go.transform.position = transform.position;
            go.GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle * 50, ForceMode2D.Impulse);
            go.GetComponent<SpriteRenderer>().sprite = sr.sprite;
        }

        Destroy(gameObject);
    }
} 

//Enum of all different types of blocks that can be present in any biome
public enum BlockType
{
    DIRT,                   //Dirt: Most common block type
    BRIDGE,
    LADDER,
    TRENCH,
    PLATFORM,
    ROOF,
    BOX,
    BACKGROUND_BLOCK,
    EXPLOSIVE,
    AIR
}

//Primitive struct for Blocks to be made
//Used during initial terrain generation in a 2D array and also to allow for the actual GameObjects to be made
//In the Start() function to avoid runtime errors
//Since for some Blocks it is easier to initialize their Sprites while generating the map compared to after the fact
//Primitive Blocks can also store the Sprite for the Block that will be Instantiated later
//It also keeps track of any transformations that are to be applied to the Sprite using the SpriteRenderer
public struct PrimitiveBlock
{
    public int x;
    public int y;
    public BlockType bt;
    public Sprite spr;
    public bool flipX;
    public bool flipY;

    public PrimitiveBlock(int nx, int ny, BlockType nbt)
    {
        x = nx;
        y = ny;
        bt = nbt;
        spr = null;
        flipX = false;
        flipY = false;
    }

    public PrimitiveBlock(int nx, int ny)
    {
        x = nx;
        y = ny;
        bt = BlockType.AIR;
        spr = null;
        flipX = false;
        flipY = false;
    }

    public PrimitiveBlock(int nx, int ny, BlockType nbt, Sprite nspr) : this(nx, ny, nbt)
    {
        spr = nspr;
    }

    public PrimitiveBlock(int nx, int ny, BlockType nbt, Sprite nspr, bool nflipX, bool nFlipY) : this(nx, ny, nbt, nspr)
    {
        flipX = nflipX;
        flipY = nFlipY;
    }

    public void SetBT(BlockType nbt)
    {
        bt = nbt;
    }

    //Returns whether or not you can walk on this block
    //We can't assume that bt will not change after creation so we must re-calculate every time CanWalkOn() is called
    public bool CanWalkOn()
    {
        return bt != BlockType.AIR && bt != BlockType.LADDER;
    }
}