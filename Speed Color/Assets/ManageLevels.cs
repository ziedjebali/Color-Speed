﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageLevels : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }
}
