using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessagesScript : MonoBehaviour
{
    public TextMeshProUGUI message;

    public GameObject playerCamera;

    public GameObject gate;

    private Animator anim;

    private bool keyFound = false;

    private bool waitToHide = true;


    bool gateOpen = false;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(hideMessageAfter(6));
        anim = gate.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // struct object that will hold our raycast information
        RaycastHit hit;

        int activeLayer = 6;

        // if we collide with an object with our raycast, spawn a portal there
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.TransformDirection(Vector3.forward), out hit, 2f, (1 << activeLayer)))
        {

            if (hit.transform.tag == "info")
            {
                message.text = "You will fint the gate key inside the building";
            }
            else if (hit.transform.tag == "door")
            {
                if (!keyFound)
                {
                    message.text = "This gate is locked";
                }
                else
                {
                    if (!gateOpen)
                    {
                        message.text = "This gate is opening";
                        StartCoroutine(hideMessageAfter(3));
                        gateOpen = true;
                        anim.Play("GateOpen");
                    }
                }
            }
            else if (hit.transform.tag == "loot")
            {
                if (!keyFound)
                {
                    message.text = "You found a key";
                    StartCoroutine(hideMessageAfter(6));
                    keyFound = true;
                } else
                {
                    if (!waitToHide)
                    {
                        message.text = "This case is emtpy now";
                    }
                }
            }
            else if (hit.transform.tag == "loot empty")
            {
                message.text = "This case is emtpy";
            }
            else/* if (hit.transform.tag == "Finish")
            {
                message.text = "WELL DONE!\nYou WIN";
            }
            else*/
            {
                if (!waitToHide)
                {
                    message.text = "";
                }
            }
        }
        else
        {
            if (!waitToHide)
            {
                message.text = "";
            }
        }

    }

    public void setMessage(string msg, int time)
    {
        message.text = msg;
        StartCoroutine(hideMessageAfter(time));
    }

    IEnumerator hideMessageAfter(int seconds)
    {
        waitToHide = true;
        yield return new WaitForSeconds(seconds); //wait 6 seconds
        waitToHide = false;
    }
}
