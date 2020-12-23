using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    UIManager UI;
    public Character Player;
    public Location PlayerLocation;

    // Start is called before the first frame update
    void Start()
    {
        UI = GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLocation(Location location)
    {
        Debug.Log("Changing location to " + location.name);
        PlayerLocation = location;
    }
}
