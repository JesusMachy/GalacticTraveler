using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public void CloseWindowButton()
    {
        gameObject.SetActive(false);
    }
}
