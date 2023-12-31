using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   float direction = 0.05f;
   float toward = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
         toward *= -1;
         direction *= -1;
      }
      if (transform.position.x > 2.8f)
      {
         toward = -1.0f;
         direction = -0.05f;
      }
      else if(transform.position.x < -2.8f)
      {
         toward = 1.0f;
         direction = 0.05f;
      }
      transform.localScale = new Vector3(toward, 1, 1);
      transform.position += new Vector3(direction, 0, 0);
    }
}
