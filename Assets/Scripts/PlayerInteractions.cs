using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System;

public class PlayerInteractions : MonoBehaviour
{
    public BlockReference clueBlock;
    public VariableReference clue;

    ClueObject[] clueObjects = new ClueObject[2];

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {
        clue.Set("Use the Arrow Keys to Move Your Character and press the Spacebar to Interact with Objects and find Clues.");
        clueBlock.Execute();

        clueObjects[0] = new ClueObject();
        clueObjects[0].clueLocation = 12;
        clueObjects[0].clueText = "Hola";

        clueObjects[1] = new ClueObject();
        clueObjects[1].clueLocation = 20;
        clueObjects[1].clueText = "Hello";

        string json = JsonHelper.ToJson(clueObjects, true);
        Debug.Log(json);

        ClueObject[] clueReread = JsonHelper.FromJson<ClueObject>(json);

        Debug.Log(clueReread[0].clueLocation);
        Debug.Log(clueReread[0].clueText);

        Debug.Log(clueReread[1].clueLocation);
        Debug.Log(clueReread[1].clueText);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

[Serializable]
public class ClueObject
{
    public int clueLocation;
    public string clueText;
}