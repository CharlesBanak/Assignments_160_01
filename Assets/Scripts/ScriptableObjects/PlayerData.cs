using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : ScriptableObject
{
    [SerializeField] private string PlayerName;
    [SerializeField] private string PlayerHealth;

    public string PlayerName1 { get => PlayerName; set => PlayerName = value; }
    public string PlayerHealth1 { get => PlayerHealth; set => PlayerHealth = value; }
}
