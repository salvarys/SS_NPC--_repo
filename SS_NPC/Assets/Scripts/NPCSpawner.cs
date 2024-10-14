using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    public INPC m_Farmer;
    public INPC m_Begger;
    public INPC m_Shopowner;

    public void SpawnVillagers()
    {
        m_Begger = m_Factory.GetNPC(NPCType.Begger);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

    }
}
