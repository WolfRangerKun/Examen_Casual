using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionChangeSprite : MonoBehaviour
{
    public List<Sprite> spritesVaso;
    public Sprite spriteVasoOriginal;
    public SpriteRenderer renderVaso;
    // Start is called before the first frame update
   

    public IEnumerator CambiarSpriteVaso(int x)
    {
        renderVaso.sprite = spritesVaso[x];
        yield return new WaitForSeconds(.1f);
        renderVaso.sprite = spriteVasoOriginal;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
