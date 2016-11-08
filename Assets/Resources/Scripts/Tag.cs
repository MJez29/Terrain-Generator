using UnityEngine;
using System.Collections;

//Tag.cs
//Author(s): Michal Jez
//Shadowstruck Software

//"A Tag is a word which you link to one or more GameObjects."
//  - Unity docs (https://docs.unity3d.com/Manual/Tags.html)
//This file contains a struct of all the tags used in the game

public struct Tag
{
    public const string BLOCK = "Block";
    public const string BACKGROUND = "Background";
    public const string ENEMY = "Enemy";
    public const string PLAYER = "Player";
    public const string PROJECTILE = "Projectile";
}