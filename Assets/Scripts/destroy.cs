using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    //場外に出たオブジェクトをっけす処理を書く

    private void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.tag=="Candy")
        {
            Destroy(other.gameObject);
        }
    }
}
