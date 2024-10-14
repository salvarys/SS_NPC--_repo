using UnityEngine.UI;
using TMPro;
using UnityEngine;

public interface INPC
{
    void Speak(TextMeshProUGUI npcText);
}

public enum NPCType
{
    Farmer,
    Begger,
    Shopowner
}