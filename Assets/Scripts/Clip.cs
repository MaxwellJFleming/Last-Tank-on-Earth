using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Clip
{
    //the number of bullets you get after reloading
    public static int clipSize = 10;

    //the number of times you can fire before needing to reload
    public static int clip;

    public static bool reloading = false;

    //refills clip to clipSize
    public static void reload()
    {
        clip = clipSize;
    }

    //removes a bullet from clip
    public static void fire()
    {
        clip -= 1;
    }
}
