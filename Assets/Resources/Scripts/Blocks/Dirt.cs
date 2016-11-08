using UnityEngine;
using System.Collections;

//Dirt.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Dirt is the most common block in the Game
//Dirt is not very special except that sometimes its edges can be lined with grass or rock
//Initializing their Sprites is a pain

public class Dirt : Block//DestructibleBlock
{
    //All the images of the dirt
    private static Sprite DIRT;

    private static Sprite GRASS_TOP;
	private static Sprite GRASS_LEFT;
	private static Sprite ROCK_BOTTOM;
		
	private static Sprite GRASS_TOP__GRASS_LEFT;
	private static Sprite GRASS_TOP__GRASS_LEFT__GRASS_RIGHT;
	private static Sprite GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM;
	private static Sprite GRASS_TOP__ROCK_BOTTOM;
	private static Sprite GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER;
	
	private static Sprite ROCK_LEFT__ROCK_RIGHT__ROCK_BOTTOM;
	private static Sprite GRASS_LEFT__GRASS_RIGHT;
	private static Sprite ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER;
	private static Sprite ROCK_LEFT__ROCK_BOTTOM;
	private static Sprite GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT__GRASS_RIGHT_TOP_CORNER;
	private static Sprite GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT__ROCK_BOTTOM;

	private static Sprite ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER;
	private static Sprite ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
	
	private static Sprite GRASS_LEFT_TOP_CORNER;
	private static Sprite ROCK_LEFT_BOTTOM_CORNER;
	
	private static Sprite ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
	private static Sprite GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;

    //Loads all the sprites once Unity is ready
    public static void LoadSprites()
    {
        DIRT = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Dirt");
        GRASS_TOP = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top");
        GRASS_LEFT = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left");
        ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Bottom");
        GRASS_TOP__GRASS_LEFT = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Grass Left");
        GRASS_TOP__GRASS_LEFT__GRASS_RIGHT = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Grass Left + Grass Right");
        GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Grass Left + Rock Bottom");
        GRASS_TOP__ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Rock Bottom");
        GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Grass Left + Rock Right Bottom Corner");
        GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Rock Left Bottom Corner + Rock Right Bottom Corner");
        GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Top + Rock Left Bottom Corner");
        ROCK_LEFT__ROCK_RIGHT__ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Left + Rock Right + Rock Bottom");
        GRASS_LEFT__GRASS_RIGHT = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left + Grass Right");
        ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Left + Rock Bottom + Grass Right Top Corner");
        ROCK_LEFT__ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Left + Rock Bottom");
        GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left + Rock Right Bottom Corner");
        GRASS_LEFT__GRASS_RIGHT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left + Grass Right Top Corner");
        GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left + Grass Right Top Corner + Rock Right Bottom Corner");
        GRASS_LEFT__ROCK_BOTTOM = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left + Rock Bottom");
        ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Bottom + Grass Left Top Corner");
        ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Bottom + Grass Left Top Corner + Grass Right Top Corner");
        GRASS_LEFT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner");
        ROCK_LEFT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Left Bottom Corner");
        ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Rock Left Bottom Corner + Rock Right Bottom Corner");
        GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Rock Right Bottom Corner");
        GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Rock Left Bottom Corner");
        GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Rock Left Bottom Corner");
        GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Grass Right Top Corner");
        GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Rock Left Bottom Corner + Rock Right Bottom Corner");
        GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Grass Right Top Corner + Rock Left Bottom Corner");
        GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER = Resources.Load<Sprite>("Images/Dirt Images/Forest foreground/Grass Left Top Corner + Grass Right Top Corner + Rock Left Bottom Corner + Rock Right Bottom Corner");
    }

	// Use this for initialization
	protected override void Awake ()
    {
        base.Awake();
        blockType = BlockType.DIRT;
	}
	
	// Update is called once per frame
	protected override void Update ()
    {
	
	}

    //Sets the Sprite to be rendered to the correct one based on the surrounding block around it
    public override void InitializeSprite(PrimitiveBlock[][] map)
    {
        x++;            //The map passed in is padded so map[0][0] is paddedMap[1][1]
        y++;

        //if (sr.sprite != null) return;

        int w = map.Length - 1;
        int h = map[0].Length - 1;
        //Block above is not dirt
        if (y != h && map[x][y + 1].bt != BlockType.DIRT)
        {
            //Block to the left is not dirt
            if (x != 0 && map[x - 1][y].bt != BlockType.DIRT)
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    sr.sprite = GRASS_TOP__GRASS_LEFT__GRASS_RIGHT;
                }
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM;
                    }
                    else
                    {
                        //If block to the bottom right isn't dirt
                        if (y != 0 && x != w && map[x + 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                        }
                        else
                        {
                            sr.sprite = GRASS_TOP__GRASS_LEFT;
                        }
                    }
                }
            }
            //Block to the left is dirt
            else
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.flipX = true;
                        sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM;
                    }
                    else
                    {
                        //Block below to the left is not dirt
                        if (x != 0 && y != 0 && map[x - 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                        }
                        //Block below to the left is dirt
                        else
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__GRASS_LEFT;
                        }
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = GRASS_TOP__ROCK_BOTTOM;
                    }
                    //Block below is dirt
                    else
                    {
                        //Blocks to the bottom right and left are dirt
                        if (y == 0 || (x != 0 && x != w && y != 0 && map[x - 1][y - 1].bt == BlockType.DIRT && map[x + 1][y - 1].bt == BlockType.DIRT))
                        {
                            sr.sprite = GRASS_TOP;
                        }
                        //Blocks to the bottom left and right are not dirt
                        else if (x != 0 && x != w && y != 0 && y != h && map[x - 1][y - 1].bt != BlockType.DIRT && map[x + 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                        }

                        //Block to the bottom left is dirt while the one to the bottom right isn't
                        else if (x != 0 && y != 0 && map[x - 1][y - 1].bt == BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER;
                        }
                        else
                        {
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER;
                        }
                    }
                }
            }
        }
        //Block above is dirt
        else
        {
            //If block to the left is not dirt
            if (x != 0 && map[x - 1][y].bt != BlockType.DIRT)
            {
                //If the block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = ROCK_LEFT__ROCK_RIGHT__ROCK_BOTTOM;
                    }
                    //Block below is dirt
                    else
                    {
                        sr.sprite = GRASS_LEFT__GRASS_RIGHT;
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        //If the block above to the right is not dirt
                        if (x != w && y != h && map[x + 1][y + 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER;
                        }
                        else
                        {
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block contains dirt
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            bool br = map[x + 1][y - 1].bt == BlockType.DIRT;
                            //Blocks above and below to the right are dirt
                            if (tr && br)
                            {
                                sr.sprite = GRASS_LEFT;
                            }
                            //Block above to the right is dirt while block below to the right is not
                            else if (tr && !br)
                            {
                                sr.sprite = GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Block below to the right is dirt while the block above to the right is not
                            else if (!tr && br)
                            {
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER;
                            }
                            //Blocks above and below to the right are not dirt
                            else
                            {
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
            }
            //If the block to the left is dirt
            else
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        //Block to the top left is not dirt
                        if (x != 0 && y != h && map[x - 1][y + 1].bt != BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER;
                        }
                        //Block to the top left is dirt
                        else
                        {
                            sr.flipX = true;
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool bl = map[x - 1][y - 1].bt == BlockType.DIRT;
                            //Blocks to the top and bottom left are dirt
                            if (tl && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT;
                            }
                            //Block to the top left is dirt but the block to the bottom left is not
                            else if (tl && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Block to the top left is not dirt while the one to the bottom left is
                            else if (!tl && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER;
                            }
                            //Blocks above and below to the left are not dirt
                            else
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        if (x != 0 && x != w && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            //Blocks to the top left and right are dirt
                            if (tl && tr)
                            {
                                sr.sprite = ROCK_BOTTOM;
                            }
                            //Block to the top left is dirt while the one to the top right is not
                            else if (tl && !tr)
                            {
                                sr.flipX = true;
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER;
                            }
                            //Block to the top right is dirt while the one to the top left is not
                            else if (!tl && tr)
                            {
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER;
                            }
                            //Blocks to the top right and left are not dirt
                            else
                            {
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            bool br = map[x + 1][y - 1].bt == BlockType.DIRT;
                            bool bl = map[x - 1][y - 1].bt == BlockType.DIRT;
                            //---All 4 corners are dirt---
                            if (tl && tr && br && bl)
                            {
                                sr.sprite = DIRT;
                            }
                            //---3 Corners are dirt---
                            //Top left is not dirt
                            else if (!tl && tr && br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER;
                            }
                            //Top right is not dirt
                            else if (tl && !tr && br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER;
                            }
                            //Bottom right is not dirt
                            else if (tl && tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Bottom left is not dirt
                            else if (tl && tr && br && !bl)
                            {
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //---2 Corners are dirt---
                            //Top left and top right are dirt
                            else if (tl && tr && !br && !bl)
                            {
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top left corner and bottom right corner are dirt
                            else if (tl && !tr && br && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top left and bottom left are dirt
                            else if (tl && !tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Top right and bottom right are dirt
                            else if (!tl && tr && br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Top right and bottom left are dirt
                            else if (!tl && tr && !br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Bottom left and right are dirt
                            else if (!tl && !tr && br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
                            }

                            //---1 Corner is dirt---
                            //Top left is dirt
                            else if (tl && !tr && !br && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top right is dirt
                            else if (!tl && tr && !br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Right bottom is dirt
                            else if (!tl && !tr && br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Left bottom is dirt
                            else if (!tl && !tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }

                            //---4 Corners are dirt---
                            else
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
            }
        }

        x--;
        y--;
    }

    //Used by background blocks that are basically dirt but they don't have a dirt component
    //This still allows them to get the correct sprite
    public static void InitializeSprite(PrimitiveBlock[][] map, SpriteRenderer sr, int x, int y)
    {
        x++;            //The map passed in is padded so map[0][0] is paddedMap[1][1]
        y++;

        if (sr.sprite != null) return;

        int w = map.Length - 1;
        int h = map[0].Length - 1;
        //Block above is not dirt
        if (y != h && map[x][y + 1].bt != BlockType.DIRT)
        {
            //Block to the left is not dirt
            if (x != 0 && map[x - 1][y].bt != BlockType.DIRT)
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    sr.sprite = GRASS_TOP__GRASS_LEFT__GRASS_RIGHT;
                }
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM;
                    }
                    else
                    {
                        //If block to the bottom right isn't dirt
                        if (y != 0 && x != w && map[x + 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                        }
                        else
                        {
                            sr.sprite = GRASS_TOP__GRASS_LEFT;
                        }
                    }
                }
            }
            //Block to the left is dirt
            else
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.flipX = true;
                        sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_BOTTOM;
                    }
                    else
                    {
                        //Block below to the left is not dirt
                        if (x != 0 && y != 0 && map[x - 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                        }
                        //Block below to the left is dirt
                        else
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__GRASS_LEFT;
                        }
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = GRASS_TOP__ROCK_BOTTOM;
                    }
                    //Block below is dirt
                    else
                    {
                        //Blocks to the bottom right and left are dirt
                        if (y == 0 || (x != 0 && x != w && y != 0 && map[x - 1][y - 1].bt == BlockType.DIRT && map[x + 1][y - 1].bt == BlockType.DIRT))
                        {
                            sr.sprite = GRASS_TOP;
                        }
                        //Blocks to the bottom left and right are not dirt
                        else if (x != 0 && x != w && y != 0 && y != h && map[x - 1][y - 1].bt != BlockType.DIRT && map[x + 1][y - 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                        }

                        //Block to the bottom left is dirt while the one to the bottom right isn't
                        else if (x != 0 && y != 0 && map[x - 1][y - 1].bt == BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER;
                        }
                        else
                        {
                            sr.sprite = GRASS_TOP__ROCK_LEFT_BOTTOM_CORNER;
                        }
                    }
                }
            }
        }
        //Block above is dirt
        else
        {
            //If block to the left is not dirt
            if (x != 0 && map[x - 1][y].bt != BlockType.DIRT)
            {
                //If the block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        sr.sprite = ROCK_LEFT__ROCK_RIGHT__ROCK_BOTTOM;
                    }
                    //Block below is dirt
                    else
                    {
                        sr.sprite = GRASS_LEFT__GRASS_RIGHT;
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        //If the block above to the right is not dirt
                        if (x != w && y != h && map[x + 1][y + 1].bt != BlockType.DIRT)
                        {
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER;
                        }
                        else
                        {
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block contains dirt
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            bool br = map[x + 1][y - 1].bt == BlockType.DIRT;
                            //Blocks above and below to the right are dirt
                            if (tr && br)
                            {
                                sr.sprite = GRASS_LEFT;
                            }
                            //Block above to the right is dirt while block below to the right is not
                            else if (tr && !br)
                            {
                                sr.sprite = GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Block below to the right is dirt while the block above to the right is not
                            else if (!tr && br)
                            {
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER;
                            }
                            //Blocks above and below to the right are not dirt
                            else
                            {
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
            }
            //If the block to the left is dirt
            else
            {
                //Block to the right is not dirt
                if (x != w && map[x + 1][y].bt != BlockType.DIRT)
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        //Block to the top left is not dirt
                        if (x != 0 && y != h && map[x - 1][y + 1].bt != BlockType.DIRT)
                        {
                            sr.flipX = true;
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM__GRASS_RIGHT_TOP_CORNER;
                        }
                        //Block to the top left is dirt
                        else
                        {
                            sr.flipX = true;
                            sr.sprite = ROCK_LEFT__ROCK_BOTTOM;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool bl = map[x - 1][y - 1].bt == BlockType.DIRT;
                            //Blocks to the top and bottom left are dirt
                            if (tl && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT;
                            }
                            //Block to the top left is dirt but the block to the bottom left is not
                            else if (tl && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Block to the top left is not dirt while the one to the bottom left is
                            else if (!tl && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER;
                            }
                            //Blocks above and below to the left are not dirt
                            else
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT__GRASS_RIGHT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
                //Block to the right is dirt
                else
                {
                    //Block below is not dirt
                    if (y != 0 && map[x][y - 1].bt != BlockType.DIRT)
                    {
                        if (x != 0 && x != w && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            //Blocks to the top left and right are dirt
                            if (tl && tr)
                            {
                                sr.sprite = ROCK_BOTTOM;
                            }
                            //Block to the top left is dirt while the one to the top right is not
                            else if (tl && !tr)
                            {
                                sr.flipX = true;
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER;
                            }
                            //Block to the top right is dirt while the one to the top left is not
                            else if (!tl && tr)
                            {
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER;
                            }
                            //Blocks to the top right and left are not dirt
                            else
                            {
                                sr.sprite = ROCK_BOTTOM__GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                    //Block below is dirt
                    else
                    {
                        if (x != 0 && x != w && y != 0 && y != h)
                        {
                            //True if the block is dirt
                            bool tl = map[x - 1][y + 1].bt == BlockType.DIRT;
                            bool tr = map[x + 1][y + 1].bt == BlockType.DIRT;
                            bool br = map[x + 1][y - 1].bt == BlockType.DIRT;
                            bool bl = map[x - 1][y - 1].bt == BlockType.DIRT;
                            //---All 4 corners are dirt---
                            if (tl && tr && br && bl)
                            {
                                sr.sprite = DIRT;
                            }
                            //---3 Corners are dirt---
                            //Top left is not dirt
                            else if (!tl && tr && br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER;
                            }
                            //Top right is not dirt
                            else if (tl && !tr && br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER;
                            }
                            //Bottom right is not dirt
                            else if (tl && tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Bottom left is not dirt
                            else if (tl && tr && br && !bl)
                            {
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //---2 Corners are dirt---
                            //Top left and top right are dirt
                            else if (tl && tr && !br && !bl)
                            {
                                sr.sprite = ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top left corner and bottom right corner are dirt
                            else if (tl && !tr && br && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top left and bottom left are dirt
                            else if (tl && !tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Top right and bottom right are dirt
                            else if (!tl && tr && br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Top right and bottom left are dirt
                            else if (!tl && tr && !br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Bottom left and right are dirt
                            else if (!tl && !tr && br && bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER;
                            }

                            //---1 Corner is dirt---
                            //Top left is dirt
                            else if (tl && !tr && !br && !bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Top right is dirt
                            else if (!tl && tr && !br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                            //Right bottom is dirt
                            else if (!tl && !tr && br && !bl)
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }
                            //Left bottom is dirt
                            else if (!tl && !tr && !br && bl)
                            {
                                sr.flipX = true;
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER;
                            }

                            //---4 Corners are dirt---
                            else
                            {
                                sr.sprite = GRASS_LEFT_TOP_CORNER__GRASS_RIGHT_TOP_CORNER__ROCK_LEFT_BOTTOM_CORNER__ROCK_RIGHT_BOTTOM_CORNER;
                            }
                        }
                        else
                        {
                            sr.sprite = DIRT;
                        }
                    }
                }
            }
        }

        x--;
        y--;
    }
}
