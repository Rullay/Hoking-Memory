using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{

    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
             
    }   

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }      
    }  

    public void OnMouseDown()
    {   
        transform.localScale = new Vector3(0.3f, 0.3f, 0.4f);
             
    }    

    public void OnMouseUP()
    {
        transform.localScale = Vector3.one; /*new Vector3(0.25f, 0.25f, 0.4f);*/
        if (targetObject != null)   
        {
           targetObject.SendMessage(targetMessage);
           // GetComponent<SceneController>().Restart();
        }
             
    }   
    
}
