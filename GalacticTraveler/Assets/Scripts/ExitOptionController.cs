using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOptionController : MonoBehaviour
{
    GameManager gm;
    public Location Exit;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    public void ChangeLocation()
    {
        gm.ChangeLocation(Exit);
    }
}
