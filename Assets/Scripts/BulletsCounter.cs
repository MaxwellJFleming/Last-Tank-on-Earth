using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCounter : MonoBehaviour
{
    [SerializeField]
    private Text BulletsText;
    
    void Update()
    {
        if (Clip.reloading)
        {
            //notifies player while the gun is reloading
            BulletsText.text = "RELOADING";
        } else
        {
            //displays the amount of bullets left in the clip
            BulletsText.text = $"BULLETS: {Clip.clip}";
        }
        
    }
}
