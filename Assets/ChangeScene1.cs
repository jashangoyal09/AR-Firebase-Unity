﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene1 : MonoBehaviour
{
    // Update is called once per frame
    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
