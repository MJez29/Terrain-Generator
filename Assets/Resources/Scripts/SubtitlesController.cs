using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SubtitlesController : MonoBehaviour
{
    protected Text textComponent;

    protected string text;

    protected Queue<string> buffer;

	// Use this for initialization
	void Start ()
    { 
        textComponent = GetComponent<Text>();

        buffer = new Queue<string>();

        StartCoroutine(TextAdder());
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (textComponent.text == "" && !buffer.Empty())
        {
            textComponent.text = buffer.Dequeue();
            StartCoroutine(ClearText(textComponent.text));
        }
	}

    public void AddText(string s)
    {
        if (textComponent.text != "")
            buffer.Enqueue(s);
        else
        {
            textComponent.text = s;
            StartCoroutine(ClearText(s));
        }
    }

    private IEnumerator TextAdder()
    {
        string[] strs = new string[] { "Hello", "Goodbye", "Good night", "Don't skip leg day", "I'm tired", "What's up" };
        while (true)
        {
            AddText(strs[Random.Range(0, strs.Length)]);

            yield return new WaitForSeconds(Random.Range(1f, 5f));
        }
    }

    private IEnumerator ClearText(string curText)
    {
        yield return new WaitForSeconds(2f);

        if (textComponent.text == curText)
            textComponent.text = "";

        yield break;
    }
}