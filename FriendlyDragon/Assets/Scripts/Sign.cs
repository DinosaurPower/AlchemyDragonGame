using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bananagodzilla
{
    

public class Sign : MonoBehaviour
{
    public string Interactable;

    public TMPro.TMP_Text txt;
    // Start is called before the first frame update
 

    private void OnTriggerEnter2D(Collider2D col)
    {
        txt.text = Interactable;
    }
}
}