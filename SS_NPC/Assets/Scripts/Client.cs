using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public TextMeshProUGUI speakBubble;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        } 

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_SpawnerNPC.m_Farmer.Speak(speakBubble);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_SpawnerNPC.m_Begger.Speak(speakBubble);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.m_Shopowner.Speak(speakBubble);
        }
    }
}
