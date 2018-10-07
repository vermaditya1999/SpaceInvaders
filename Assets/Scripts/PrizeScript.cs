using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && this.tag == "Prize")
        {
            PlayerMovement p = collision.gameObject.GetComponent<PlayerMovement>();
            p.score += 1;
            if (gameObject != null)
            {
                GetComponent<AudioSource>().UnPause();
                Destroy(gameObject);
            }
        }
    }
}
