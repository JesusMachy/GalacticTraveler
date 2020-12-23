using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Map/Location")]
public class Location : ScriptableObject
{
    public bool isAvailable;
    public List<Location> Exits;
}
