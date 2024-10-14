using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Wolf : INPC
{
    public void Speak(TextMeshProUGUI npcText)
    {
        npcText.text = "Grrrrr... Bark!";
    }
}
