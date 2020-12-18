using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility
{
    //returns a random audio clip from array
    public static AudioClip randomAudioClip(AudioClip[] arr)
    {
        return arr[Random.Range(0, arr.Length-1)];
    }

    //destroys all GameObjects with the tag "tag", then returns the number of objects destroyed this way
    public static int destroyAllWithTag(string tag)
    {
        GameObject[] arr = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in arr)
        {
            GameObject.Destroy(obj);
        }
        GameObject[] newArr = GameObject.FindGameObjectsWithTag(tag);
        return arr.Length - newArr.Length;
    }
}
