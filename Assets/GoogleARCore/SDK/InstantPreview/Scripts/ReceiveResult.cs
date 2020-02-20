using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReceiveResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Text").GetComponent<Text>().text = "You need to be connected to Internet";
    }

    void onActivityResult(string recognizedText)
    {
        char[] delimiterChars = { '~' };
        string[] result = recognizedText.Split(delimiterChars);

        //You can get the number of results with result.Length
        //And access a particular result with result[i] where i is an int
        //I have just assigned the best result to UI text
        GameObject.Find("DestinationText").GetComponent<Text>().text = result[0];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
