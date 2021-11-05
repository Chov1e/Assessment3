using UnityEngine.UI;
using UnityEngine;

public class FlashingEffect : MonoBehaviour
{
    public SpriteRenderer m_SpriteRenderer;

    public Color red => Color.red;
    public Color purple => new Color(r: 0.5f, g: 0.48f, b:0.84f);
    public Color white => Color.white;
    
    public void Update()
    {
        m_SpriteRenderer.color = Lerp(firstColor:purple, secondColor:white, speed:4);
    }

    public Color Lerp(Color firstColor, Color secondColor, float speed) => Color.Lerp(a: firstColor, b: secondColor, t: Mathf.Sin(f:Time.time * speed));
}
