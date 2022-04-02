using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectWaterWave : MonoBehaviour
{
    public Texture[] textures;
    private Material _material;
    private int index;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        InvokeRepeating(nameof(ChangeTexture), 0f, 0.1f);
    }

    private void ChangeTexture()
    {
        _material.mainTexture = textures[index++];
        index %= textures.Length;
    }
}