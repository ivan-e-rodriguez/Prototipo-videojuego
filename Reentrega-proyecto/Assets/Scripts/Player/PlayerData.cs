using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
     [SerializeField]
    private int live = 5;
    public int HP { get { return live; } }

    public Vector3 StartPosition { get => startPosition; set => startPosition = value; }

    private Vector3 startPosition = new Vector3(12.6599998f,0.409999996f,-1.74000001f);

    public void Healing(int value)
    {
        live += value;
    }

    public void Damage(int value)
    {
        live -= value;
    }
}
