using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyMusic(transform.gameObject);
    }
}
