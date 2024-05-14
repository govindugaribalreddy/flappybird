using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddlescript : MonoBehaviour
    
{
    public addscores logic; 
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<addscores>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
