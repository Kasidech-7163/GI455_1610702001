using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OK : MonoBehaviour
{
    public string ShowText;
    public GameObject Random;
    public GameObject Show;



    public void Showname()
    {
        ShowText = Random.GetComponent<Text>().text;
        Show.GetComponent<Text>().text = ShowText + "ฮัลโหลตัวเองง";
    }
}
