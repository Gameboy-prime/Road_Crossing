using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosManager : MonoBehaviour
{
    #region Singleton

    public static PosManager instance;
    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject pos;
}