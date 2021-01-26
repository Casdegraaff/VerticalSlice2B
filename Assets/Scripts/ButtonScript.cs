﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : SpikesScript
{
    private GameObject[] puzzleArray;
    private GameObject[] spikeArray;
    private SpriteRenderer but;
    private Sprite buttonUp;
    private Sprite buttonDown;
    private Extra extraScript;
    private SpikesScript scSprike;

    // Start is called before the first frame update
    void Start()
    {
        but = GetComponent<SpriteRenderer>();
        puzzleArray = GameObject.FindGameObjectsWithTag("PuzzlePieces");
        spikeArray = GameObject.FindGameObjectsWithTag("SpikesPieces");
        extraScript = GameObject.Find("kruisje").GetComponent<Extra>();
        scSprike = GameObject.Find("_pikesUp").GetComponent<SpikesScript>();
        buttonUp = Resources.Load<Sprite>("ButtonUp");
        buttonDown = Resources.Load<Sprite>("ButtonDown");
        but.sprite = buttonUp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnTriggerEnter2D(Collider2D collision2D)
    {
        //Button + Spikes
        if (collision2D.gameObject.tag == "Player")
        {
            but.sprite = buttonDown;
            Debug.Log("Almost");
            if (extraScript.points == 15)
            {
                Debug.Log("Not that");
                foreach (GameObject obj in puzzleArray)
                {
                    obj.GetComponent<SpriteRenderer>().sprite = extraScript.circleGreenSprite;
                }
                //rend.sprite = extraScript.circleGreenSprite;
                //ram.sprite = scSprike.noSpikeSprite;
                foreach (GameObject apj in spikeArray)
                {
                    apj.GetComponent<SpriteRenderer>().sprite = scSprike.noSpikeSprite;
                }
            }
            else
            {
                foreach (GameObject obj in puzzleArray)
                {
                    obj.GetComponent<SpriteRenderer>().sprite = extraScript.xSprite;
                }
                extraScript.points = 0;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        but.sprite = buttonUp;
    }
}
