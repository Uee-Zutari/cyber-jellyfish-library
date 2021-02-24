using CyberJellyFish.Internal;
using UnityEngine;

public class ColorExtensionExample : MonoBehaviour
{
    public bool              Test = false;
    public Color Color;
    public SpriteRenderer    SpriteRenderer;

    private void OnValidate()
    {
        if (Test)
        {
            Test = false;
            SpriteRenderer.color = MyColours.Amber;
            Color.ToHtmlColor("#FF9800");
            Color.ChangeAlpha(.5f);
        }
    }
}