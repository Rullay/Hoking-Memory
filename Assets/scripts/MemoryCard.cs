using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    
    [SerializeField] public GameObject cardBack;
    [SerializeField] private SceneController controller;

    private int _id;
    public int id {
        get {return _id;}
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnMouseDown() 
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }   
        
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    public void SetCard(int id, Sprite image)
    {
        {
            _id = id;
            GetComponent<SpriteRenderer>().sprite = image;
        }
    }
}
