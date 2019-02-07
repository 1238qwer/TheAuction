using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool EnemyBuying()
    {
        int rnd = Random.Range(0, 5);

        if (rnd == 1)
            return false;

        return true;
    }
}
