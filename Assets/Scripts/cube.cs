using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class cube : MonoBehaviour
{
    public GameObject objectToDisable;

    public DisplayMessage displayMessage;
    private bool firstmessage = false;
    void Start()
    {
       
    }

    // Update is called once per frame
   
  

    void Update()
    {
        if(firstmessage&&Input.GetKeyDown(KeyCode.Space))
        {
            DisplayMessage.Instance.SHAQO_Q();
            firstmessage=false;
            DisplayMessage.Instance.Display_message_fuc("PEOS2");
        }
        if (Input.GetKeyDown(KeyCode.A) && firstmessage == false)
        {
            DisplayMessage.Instance.Display_message_fuc2("PEOSL",false);
        }
        else if (Input.GetKeyDown(KeyCode.B) && firstmessage == false)

        {
            DisplayMessage.Instance.Display_message_fuc2("PEOSL",false);
        }
        else if (Input.GetKeyDown(KeyCode.C) && firstmessage == false)
        {
            DisplayMessage.Instance.Display_message_fuc2("PEOSS",true);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        // Disable the GameObject when the trigger is entered
        objectToDisable.SetActive(false);
        if (other.CompareTag("Player"))
        {
           
            DisplayMessage.Instance.Display_message_fuc("PEOS");
            firstmessage = true;

        }
    }
}
