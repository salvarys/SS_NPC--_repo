using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Farmer : INPC
{
    public void Speak(TextMeshProUGUI npcText)
    {
        npcText.text="You reap what you sow!";
    }
}
