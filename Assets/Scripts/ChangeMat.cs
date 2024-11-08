using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChanger : MonoBehaviour
{
    public Material[] materials = new Material[2];
    private SkinnedMeshRenderer meshRenderer;
    int index;

    void Start () {
            meshRenderer = GetComponent<SkinnedMeshRenderer>();
    }

    void Update () {
            if (Input.GetKeyDown(KeyCode.Space)){
                    index = (index + 1) % materials.Length;
                    SwapToNextMaterial(index);
            }
    }

    void SwapToNextMaterial (int index) {
            meshRenderer.material = materials[index % materials.Length];
    }
}
