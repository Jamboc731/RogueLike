using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Enemy", menuName = "New Enemy")]
public class EnemySO : ScriptableObject
{

    public new string name;
    public int maxHealth;
    public float moveSpeed;
    public int damage;
    public Sprite sprite;

}
