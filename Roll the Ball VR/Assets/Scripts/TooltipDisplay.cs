using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipDisplay : MonoBehaviour
{
    public TextMesh tooltipText;
    private float timePassed = 0f;
    private float switchAfter = 5f;

    public string hint_1;
    public string hint_2;

    void Update()
    {
        timePassed += Time.deltaTime;

        // switch between the two hint messages
        // after some time has passed
        if (timePassed >= switchAfter)
        {
            if (tooltipText.text == hint_1)
            {
                tooltipText.text = hint_2;
            }
            else
            {
                tooltipText.text = hint_1;
            }
            timePassed = 0f;
        }
    }
}
