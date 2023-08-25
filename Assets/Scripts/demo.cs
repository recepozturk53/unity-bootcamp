using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{   
   public int bullet =5;
   public float speed = 1.0f;
   public String stateInfo = "Ba�ar�l�";
    // Start is called before the first frame update
    void Start()
    {
        haveBullet();
        speedInfo();
        isSuccess();
        Debug.Log("isSuccess : " + isSuccess().ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool haveBullet() {
        if (bullet > 0)
        {
            Debug.Log("Mermi Var Ate� Edilebilir");
            return true;
        }
        else
        {
            Debug.Log("Mermi Yok Ate� Edilemez");
            return false;
        }
    }

    void speedInfo()
    {
        switch (speed)
        {
            case 0f:
                Debug.Log("Duruyor");
                break;
            case 1f:
                Debug.Log("Y�r�yor");
                break;
            case 2f:
                Debug.Log("Ko�uyor");
                break;
            default:
                Debug.Log("Bilinmeyen Durum");
                break;

        }
    }

    bool isSuccess()
    {
        while (stateInfo.Equals("Ba�ar�l�"))
        {
            return true;
        }

        return false;
    }

}
