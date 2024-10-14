using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Begger : INPC
{
  public void Speak(TextMeshProUGUI npcText)
    {
        npcText.text="Do you have some change to spare?";
    }
}
