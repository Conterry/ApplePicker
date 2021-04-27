using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownDestroyer : MonoBehaviour
{

    public event System.Action OnAppleWentOutOfTheField;

    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == "Apple")
        {
            OnAppleWentOutOfTheField();
        }

        Destroy(coll.gameObject);
    }


}
