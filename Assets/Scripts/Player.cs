using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int logs = 0;

    public void addLogs(int num){
        logs += num;
    }

    public int getLogs(){
        return logs;
    }
}