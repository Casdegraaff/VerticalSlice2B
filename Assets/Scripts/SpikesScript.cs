﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : Extra
{
    public SpriteRenderer ram;
    public Sprite spikeSprite;
    public Sprite noSpikeSprite;

    // Start is called before the first frame update
    protected void Start()
    {
        //Spikes
        ram = GetComponent<SpriteRenderer>();
        spikeSprite = Resources.Load<Sprite>("Spike");
        noSpikeSprite = Resources.Load<Sprite>("noSpike");

        ram.sprite = spikeSprite;
    }

    // Update is called once per frame
    protected void Update()
    {
        //if()
        //{
        //    GetComponent<BoxCollider2D>().enabled = false;
        //}
        
    }
}
