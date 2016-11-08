using UnityEngine;
using System.Collections;

public class Explosive : Block
{
    private int layerMask = (1 << LayerMask.NameToLayer("Foreground"))/* | (1 << LayerMask.NameToLayer("Players")) | (1 << LayerMask.NameToLayer("Enemies"))*/;

    public override void InitializeSprite(PrimitiveBlock[][] map) { }

    private bool destroyCalled;

    public void Start()
    {
        blockType = BlockType.EXPLOSIVE;
    }

    public override void Destroy()
    {
        if (destroyCalled) return;

        Collider2D[] colls = Physics2D.OverlapCircleAll(transform.position, 5f, layerMask);
        destroyCalled = true;
        
        foreach (var coll in colls)
        {
            try
            {
                coll.gameObject.GetComponent<Block>().Destroy();
            }
            catch { }
        }

        Destroy(gameObject);
    }
}
