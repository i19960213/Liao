﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPlayer : MonoBehaviour {

    public Collider testcol;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.gameObject.name == "左手掌")
        {
            this.transform.parent.SendMessage("GetDamageMessage");
        }
      
    }


}
