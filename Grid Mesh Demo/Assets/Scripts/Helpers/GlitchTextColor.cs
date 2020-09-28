using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchTextColor : MonoBehaviour
{
    private TextMesh _textMesh;

    [SerializeField] private Color col1;
    [SerializeField] private Color col2;
    void Start()
    {
        _textMesh = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        _textMesh.color = Glitcher.GlitchInt == 1 ? col1 : col2;
    }
}
