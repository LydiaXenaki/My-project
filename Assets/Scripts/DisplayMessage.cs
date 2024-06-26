using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;


public class DisplayMessage : MonoBehaviour
{
    public static DisplayMessage Instance;
    // Reference to the Text component
    public TextMeshProUGUI messageText, messageText2;
    public Image bg;

    // Message to display
    public string message;

    // Time to display the message
    public float displayDuration = 5f;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        // Initially hide the message
      messageText.gameObject.SetActive(false);
        bg.gameObject.SetActive(false);
    }
    private void Update()
    {
     // if(Input.GetKeyDown(KeyCode.Tab))  messageText.gameObject.SetActive(!messageText.gameObject.activeSelf);
    }
    public void Display_message_fuc(string textt)
    {
        print("aaaaa");
        messageText.gameObject.SetActive(true);
        messageText.text = textt;
    }
    public void Display_message_fuc2(string textt,bool sl)
    {
        if (sl)
        {
        messageText2.text = textt;
       bg.gameObject.SetActive(true);
            bg.color = Color.green;
        }
        else
        {
            messageText2.text = textt;
            bg.gameObject.SetActive(true);
            bg.color = Color.red;
        }
    }


    public void SHAQO_Q()
    
    {
        messageText.gameObject.SetActive(false);
    }
    
}
