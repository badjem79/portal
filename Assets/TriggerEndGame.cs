using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerEndGame : MonoBehaviour
{
    public MessagesScript ms;
    private AudioSource audio;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ms.setMessage("WELL DONE!\nYou WIN", 20);
            audio.Play();
        }
    }
}
