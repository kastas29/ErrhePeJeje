using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialButtonAlphaFixer : MonoBehaviour
{
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.alphaHitTestMinimumThreshold = 0.5f;

    }

    public void clicked()
    {
        print("clickede " + this.gameObject.name);
    }
}
