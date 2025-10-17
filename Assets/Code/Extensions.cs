using UnityEngine;
using UnityEngine.UI;

public static class Extensions
{
    public static void SetImage(this Image image, Sprite sprite)
    {
        if (image != null)
            image.sprite = sprite;
    }
}