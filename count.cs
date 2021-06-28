using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public Text countText;
    int sec, min, hour;

    void Start()
    {
        StartCoroutine(counter());
    }

    IEnumerator counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            sec++;

            if(sec == 60)
            {
                sec = 0;
                min++;
            }

            if(min == 60)
            {
                min = 0;
                hour++;
            }

            countText.text = hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();
        }
    }
}
