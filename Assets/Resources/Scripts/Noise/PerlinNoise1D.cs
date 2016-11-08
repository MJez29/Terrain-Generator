using UnityEngine;
using System.Collections;
using System;

//PerlinNoise1D.cs
//Author(s): Michal Jez
//Shadowstruck Software

//Class to generate the heightmap for the game
//http://freespace.virgin.net/hugo.elias/models/m_perlin.htm
//Methods and instructions were taken from this site to develop the following methods and tailor them to get nive fluid heightmaps

public class PerlinNoise1D
{
    private static int n1 = 15731, n2 = 789221, n3 = 1376312589, n4 = 1073741824, octaves = 4;
    private static double persistance = 0.5;

    private static double Noise(int x)
    {
        //Gets a random number
        x = (x << 13) ^ x;
        return (1.0 - ((x * (x * x * n1 + n2) + n3) & 0x7fffffff) / n4);
    }

    private static double Smoothed_Noise(double x)
    {
        //Smoothes noise to make it flow
        return Noise((int)x) / 2 + Noise((int)x - 1) / 4 + Noise((int)x + 1) / 4;
    }

    private static double Cosine_Interpolate(double a, double b, double x)
    {
        //For smoother curves rather than jagged interpolation using a linear approach
        double ft = x * Math.PI;
        double f = (1 - Math.Cos(ft)) * 0.5;

        return a * (1 - f) + b * f;
    }

    private static double Interpolated_Noise(double x)
    {
        //Interpolates noise
        int intX = (int) x;
        double fractionalX = x - intX;

        double v1 = Smoothed_Noise(intX);
        double v2 = Smoothed_Noise(intX + 1);

        return Cosine_Interpolate(v1, v2, fractionalX);
    }

    public static double getNoise(double x)
    {
        //Function called by the user to get noise at a specific X-position
        double total = 0.0f;

        for (int i = 0; i < octaves; i++)
        {
            int freq = 2 << (i - 1);        //"2 ** i" in python
            double amp = Math.Pow(persistance, i);

            total += Interpolated_Noise(x * freq) * amp;
        }
        return total;
    }
}