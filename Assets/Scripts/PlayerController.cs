using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        //By default gravity is turned off for the object
        Physics.gravity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

        


            //This checks to see if the left or right arrow key is pressed to then move them in the respective direction
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                Vector3 position = this.transform.position;
                if (position.x - 1 > -42)
                {
                    position.x--;
                }
                this.transform.position = position;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                Vector3 position = this.transform.position;
                if (position.x - 1 < 20)
                {
                    position.x++;
                }
                this.transform.position = position;
            }
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //When space is pressed gravity is turned on
            Physics.gravity = Vector3.down*9.81f;
            
        }
    }
}
