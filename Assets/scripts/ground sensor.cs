using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundsensor : MonoBehaviour
{
    public bool isgrounder;
    void OnTriggerStay2D(Collider2D collider)
    {
        isgrounder = true;
    }
    void OnTriggerExit2D (Collider2D collider)
    {
        isgrounder = false;
    }
}


