using UnityEngine;
using System.Collections;
using System;

//GameTime.cs
//Author(s): Michal Jez
//Shadowstruck Software

//GameTime keeps track of the time of day it is in the game
//It also adjusts the light emit by various light sources at various times of day
//Unity slows down when it has to add multiple lights on an object so to get around that
//Firelight is only emitted at night and regular directional light during the day
//Times between 6-8 AM and 7-9 PM are the times where sunlight and firelight are either fading in or out

public class GameTime : MonoBehaviour
{
    //The number of seconds in real life that will pass to represent 1 hour in the game
    public const int HOUR = 60;

    //Time is stored as an int between 1 and 24
    //Where 1 = 1 AM, 12 = 12 PM (noon), 24 = 12 AM (midnight)
    private int time;

    private Camera cam;

    private Color[] backgroundColors;

    private float[] sunlightIntensities, firelightIntensities;

	// Use this for initialization
	void Awake ()
    {
        time = 22;          //Set time 1 hour earlier than desired

        MakeBackgroundColors();
        MakeSunlightIntensities();
        MakeFireLightIntensities();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    //Called once GameMap has finished making the map and the game is ready to start
    public void StartTime()
    {
        cam = Camera.main;
        SetSkyColor();
        SetSunlightIntensity();
        SetFirelightIntensities();

        StartCoroutine("Tick");
    }

    //Ticks to represent every hour
    private IEnumerator Tick()
    {
        while (true)
        {
            time++;
            if (time > 24)
                time = 1;
            Debug.Log(time);
            SetSkyColor();
            SetSunlightIntensity();
            SetFirelightIntensities();
            yield return new WaitForSeconds(HOUR);
        }
    }

    public int GetTime()
    {
        return time;
    }

    //Sets the background color of the main camera to reflect the time of day
    private void SetSkyColor()
    {
        cam.backgroundColor = backgroundColors[time - 1];
    }

    //Instead of making a new Color instance every game hour the 24 possible colors are stored for reuse
    private void MakeBackgroundColors()
    {
        backgroundColors = new Color[24];
        //From midnight to noon
        for (int i = 0; i < 12; i++)
        {
            backgroundColors[i] = new Color((28f + i * 3.5f) / 255f,                    //r
                                             (45f + i * 5.333333f) / 255f,              //g
                                             (70f + i * 8.5f) / 255f);                  //b
        }

        //From noon to midnight
        for (int i = 11; i >= 0; i--)
        {
            backgroundColors[23 - i] = new Color((28f + i * 3.5f) / 255f,                  //r
                                                (45f + i * 5.333333f) / 255f,              //g
                                                (70f + i * 8.5f) / 255f);                  //b
        }
    }

    //Sets the intensity of the sun based on the current time of day
    private void SetSunlightIntensity()
    {
        GameObject light = GameObject.FindGameObjectWithTag("Sunlight");
        light.GetComponent<Light>().intensity = sunlightIntensities[time - 1];
    }

    //Initializes the sunlight intensities
    private void MakeSunlightIntensities()
    {
        sunlightIntensities = new float[24];

        //1-5 AM: 0 intensity
        for (int i = 0; i < 5; i++)
        {
            sunlightIntensities[i] = 0f;
        }

        //6 AM: 0.2
        //7 AM: 0.4
        //8 AM: 0.6
        for (int i = 5; i < 8; i++)
        {
            sunlightIntensities[i] = 0.2f * (i - 4);
        }

        //9AM-6PM: 0.8
        for (int i = 8; i < 18; i++)
        {
            sunlightIntensities[i] = 0.8f;
        }

        //7 PM: 0.6
        //8 PM: 0.4
        //9 PM: 0.2
        for (int i = 18; i < 21; i++)
        {
            sunlightIntensities[i] = 0.2f * (21 - i);
        }

        //10PM-12AM: 0.0
        for (int i = 21; i < 24; i++)
        {
            sunlightIntensities[i] = 0f;
        }
    }

    //Sets the intensities of the lights emitted by all fires in the scene based on the current time of day
    private void SetFirelightIntensities()
    {
        GameObject[] fires = GameObject.FindGameObjectsWithTag("Firelight");

        foreach (GameObject fire in fires)
        {
            fire.GetComponent<Light>().intensity = firelightIntensities[time - 1];
        }
    }

    //Initializes the intensities of firelights for all the times of day
    private void MakeFireLightIntensities()
    {
        firelightIntensities = new float[24];

        //1-5 AM: 2.0
        for (int i = 0; i < 5; i++)
        {
            firelightIntensities[i] = 2f;
        }

        //6 AM: 1.5
        //7 AM: 1
        //8 AM: 0.5
        for (int i = 5; i < 8; i++)
        {
            firelightIntensities[i] = 0.5f * (8 - i);
        }

        //9AM-6PM: 0.0
        for (int i = 8; i < 18; i++)
        {
            firelightIntensities[i] = 0.0f;
        }

        //7 PM: 0.5
        //8 PM: 1.0
        //9 PM: 1.5
        for (int i = 18; i < 21; i++)
        {
            firelightIntensities[i] = 0.5f * (i - 17);
        }

        //10PM-12AM: 2.0
        for (int i = 21; i < 24; i++)
        {
            firelightIntensities[i] = 2f;
        }
    }
}
