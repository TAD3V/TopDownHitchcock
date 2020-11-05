using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System;

public class PlayerInteractions : MonoBehaviour
{
    public BlockReference clueBlock;
    public VariableReference clue;

    ClueObject[] clueReread;

    public TextAsset textFile;

    public GameObject clueCollision;

    public CircleCollider2D circleCol;

    System.Random randomDirection;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {
        clue.Set("Use the Arrow Keys to Move Your Character and press the Spacebar to Interact with Objects and find Clues.");
        clueBlock.Execute();

        /*clueObjects[0] = new ClueObject();
        clueObjects[0].clueLocation = 12;
        clueObjects[0].clueText = "Hola";

        clueObjects[1] = new ClueObject();
        clueObjects[1].clueLocation = 20;
        clueObjects[1].clueText = "Hello";

        string json = JsonHelper.ToJson(clueObjects, true);
        Debug.Log(json);*/

        randomDirection = new System.Random();

        string jsonFile = textFile.text;

        clueReread = JsonHelper.FromJson<ClueObject>(jsonFile);

        Debug.Log(clueReread[0].clueLocation);
        Debug.Log(clueReread[0].clueText);

        Debug.Log(clueReread[1].clueLocation);
        Debug.Log(clueReread[1].clueText);

        Debug.Log(clueReread.Length);
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        // col.gameObject;

        if (Input.GetKeyDown("space"))
        {
            switch (col.gameObject.tag)
            {
                case "Piano":
                    Debug.Log(col.gameObject.tag);

                    clue.Set("Hitchcock has a habit of including homosexual themes in his villians without directly stating it as the depiction of homosexuality in films was banned until 1974.");
                    clueBlock.Execute();

                    break;
                case "CreepChair":
                    Debug.Log(col.gameObject.tag);

                    clue.Set("In over ten of his movies, Alfred Hitchcock uses the theme of The Wrong Man. This is when the main character is in the wrong place at the wrong time and is suspected of a crime of some sort.");
                    clueBlock.Execute();

                    break;
                case "Coffin":
                    Debug.Log(col.gameObject.tag);

                    clue.Set("Hitchcock gave his wife creative control over most of his movies as he trusted her opinion over anyone elses.As he went further into his career she was relegated more and more backstage but still was consulted for major decisions.") ;
                    clueBlock.Execute();

                    break;
                case "Ciggies":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[3].clueText);
                    clueBlock.Execute();

                    break;
                case "Outside":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[4].clueText);
                    clueBlock.Execute();

                    break;
                case "Bed":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[5].clueText);
                    clueBlock.Execute();

                    break;
                case "Bath":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[6].clueText);
                    clueBlock.Execute();

                    break;
                case "Dining":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[7].clueText);
                    clueBlock.Execute();

                    break;
                case "Kitchen":
                    Debug.Log(col.gameObject.tag);

                    clue.Set(clueReread[8].clueText);
                    clueBlock.Execute();

                    break;
            }
            /*int randomNum = randomDirection.Next(0, clueReread.Length);

            clue.Set(clueReread[randomNum].clueText);
            Debug.Log(randomNum);
            clueBlock.Execute();*/
        }
    }
}

[Serializable]
public class ClueObject
{
    public int clueLocation;
    public string clueText;
}