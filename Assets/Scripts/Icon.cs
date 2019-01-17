using UnityEngine;

public class Icon
{
    [SerializeField]
    Sprite image;

    [SerializeField]
    string tooltip;

    public Sprite Image
    {
        get { return image; }
        set { image = value; }
    }

    public string Tooltip
    {
        get { return tooltip; }
        set { tooltip = value; }
    }
}
