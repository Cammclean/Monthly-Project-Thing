using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextStuff : MonoBehaviour {

    public Text text;
    public Text nameText;
    public GameObject textBox;
    public TextAsset file;
    public string[] textArray;

    public int currLine;
    public int endLine;

    public bool isActive;
    private bool isTyping = false;
    private bool cancelTyping = false;

    public float typeSpeed;

    public bool PlayerOrNPC; //not using right now, but could be used to specify who is talking in a 2 person conversation, would need an enum/int for more than 2

	// Use this for initialization
	void Start ()
    {
	    if(file != null)
        {
            textArray = file.text.Split('\n');
        }

        if(endLine == 0)
        {
            endLine = textArray.Length - 1;
        }

        EnableTextBox();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!isTyping)
            {

                
                currLine++;

                if (currLine > endLine)
                {
                    textBox.SetActive(false);
                }

                else
                {
                    StartCoroutine(TextScroll(textArray[currLine]));
                }
            }

            else if(isTyping && !cancelTyping)
            {

                cancelTyping = true;
            }
        }


	}

    private IEnumerator TextScroll(string line)
    {
        if (line.Contains(":"))
        {
            nameText.text = textArray[currLine];
            currLine++;
            line = textArray[currLine];
        }

        int letter = 0;
        text.text = "";
        isTyping = true;
        cancelTyping = false;

        while(isTyping && !cancelTyping && (letter < line.Length - 1))
        {
            text.text += line[letter];
            letter++;

            yield return new WaitForSeconds(typeSpeed);
        }

        text.text = line;
        isTyping = false;
        cancelTyping = false;
    }

    public void EnableTextBox()
    {
        textBox.SetActive(false);
        isActive = true;
        StartCoroutine(TextScroll(textArray[currLine]));
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
    }

    public void NewText(TextAsset text)
    {
        if (text != null)
        {
            textArray = new string[1];
            textArray = file.text.Split('\n');
        }
    }
}
