using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Youlose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        //If the Player touches this object the "you lose" scene is loaded
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}

