using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour
{
    public BlockReference clueBlock;
    public BlockReference endBlock;
    public VariableReference clue;
    public IntegerVariable end;

    public Text text;

    ClueObject[] clueReread;

    public TextAsset textFile;

    public GameObject endText;

    private int randFilm;
    public int randFil;
    private int numOfClues;

    void Start()
    {
        clue.Set("Use the Arrow Keys to Move Your Character and press the Spacebar to Interact with Objects and find Clues. Hint: Go to the Piano for you're first clue. Once You Find All Nine Clues Interact with the White Spot Here.");
        clueBlock.Execute();

        string jsonFile = textFile.text;

        randFilm = UnityEngine.Random.Range(0, 2);

        text = endText.GetComponent<Text>();
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0f);

        end.Equals(4);

        numOfClues = 0;

        switch (randFilm)
        {
            case 0:
                randFil = 0;
                break;
            case 1:
                randFil = 9;
                break;
            case 2:
                randFil = 9;
                break;
        }

        Debug.Log(randFilm);

        clueReread = JsonHelper.FromJson<ClueObject>(jsonFile);
    }

    void Update()
    {
        string i = end.ToString();
        string j = randFilm.ToString();

        if (i == j)
        {
            EndGame();
        } 
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown("space"))
        {
            switch (col.gameObject.tag)
            {
                case "Piano":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[0 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "CreepChair":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[1 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Coffin":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[2 + randFil].clueText) ;
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Ciggies":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[3 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Outside":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[4 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Bed":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[5 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Bath":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[6 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Dining":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[7 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "Kitchen":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[8 + randFil].clueText);
                    clueBlock.Execute();

                    numOfClues++;

                    break;
                case "End":
                    if(numOfClues >= 6)
                    {
                        Debug.Log("Ending Sequence Started");

                        endBlock.Execute();
                    }

                    break;
            }
        }
    }

    public void EndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndMenu");
    }
}

[Serializable]
public class ClueObject
{
    public int clueLocation;
    public string clueText;
}