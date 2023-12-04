using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;


  private void Start()
    {

        RandomizePocition();
    }


    private void RandomizePocition()
    {

        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.00f);

    }


    private void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Player" || other.tag == "Player1"){
            RandomizePocition();
        }
 
    }

}
