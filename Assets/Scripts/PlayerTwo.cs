using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : Player
{
    // Update is called once per frame
    void FixedUpdate(){
      float moveSpeed = 7;
      float horizontalInput = Input.GetAxis("HorizontalPlayerTwo");
      float verticalInput = Input.GetAxis("VerticalPlayerTwo");
      if(verticalInput!=0 && horizontalInput!=0){
        float theta = Mathf.Abs(Mathf.Atan(verticalInput/horizontalInput));
        horizontalInput = horizontalInput * Mathf.Cos(theta);
        verticalInput = verticalInput * Mathf.Sin(theta);
      }
      transform.Translate(new Vector3(horizontalInput, verticalInput, 0 ) * moveSpeed * Time.deltaTime);
    }
}