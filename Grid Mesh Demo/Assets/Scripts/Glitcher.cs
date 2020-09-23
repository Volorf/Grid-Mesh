using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitcher : MonoBehaviour
{
    public static int GlitchInt;
    
    private void Update()
    {
        GlitchInt = Random.Range(0, 2);
        print(GlitchInt);
    }
}
