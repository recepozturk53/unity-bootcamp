using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{   
   public int bullet =5;
   public float speed = 1.0f;
   public String stateInfo = "Baþarýlý";
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
            Debug.Log("Mermi Var Ateþ Edilebilir");
            return true;
        }
        else
        {
            Debug.Log("Mermi Yok Ateþ Edilemez");
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
                Debug.Log("Yürüyor");
                break;
            case 2f:
                Debug.Log("Koþuyor");
                break;
            default:
                Debug.Log("Bilinmeyen Durum");
                break;

        }
    }

    bool isSuccess()
    {
        while (stateInfo.Equals("Baþarýlý"))
        {
            return true;
        }

        return false;
    }

}
