using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate(){
      float moveSpeed = 7;
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");
      transform.Translate(new Vector3(horizontalInput, verticalInput, 0 ) * moveSpeed * Time.deltaTime);
    }
}
