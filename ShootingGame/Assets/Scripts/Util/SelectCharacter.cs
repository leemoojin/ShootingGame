using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/*public class SelectCharacter : MonoBehaviour
{
    public Character character;
    Animator anim;
    SpriteRenderer sr;
   
    
    public SelectCharacter[] chars;
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        if (DataManager.instance.currentCharacter == character) OnSelect();
        else OnDeSelect();
    }

    void Update()
    {
      
    }

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != this) chars[i].OnDeSelect(); 
        }
       
    }

    void OnSelect()
    {
        sr.color = new Color(1f, 1f, 1f);
    }

    void OnDeSelect()
    {
        sr.color = new Color(0.4f, 0.4f, 0.4f);
    }

   
}
*/