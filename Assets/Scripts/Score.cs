using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public Player player;

    void Update(){
        text.text =  ""+player.getLogs();
    }
}