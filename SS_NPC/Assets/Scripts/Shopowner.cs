using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Shopowner : INPC
{
   public void Speak(TextMeshProUGUI npcText)
    {
        npcText.text="Do you want to purchase something?";
    }
}
