using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerEndGame : MonoBehaviour
{
    public MessagesScript ms;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ms.setMessage("WELL DONE!\nYou WIN", 20);
        }
    }
}
