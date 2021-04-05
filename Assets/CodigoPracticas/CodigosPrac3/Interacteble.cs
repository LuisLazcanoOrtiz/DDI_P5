﻿using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;


    
public class Interacteble : MonoBehaviour
{
    //variables para dar al color a la pelota , si me acerco o me alejo
    public Color AlejarColor;
    public Color AcercarColor;
    private Renderer render;

    //variable para dar false o true , cuando se acerca o se aleja
    public bool isInsideZone = false;
    
    //Variable , cuando das tecla "P" golpea la pelota
    // KeyCode interactionKey = KeyCode.P;

    public string interactionButton = "Interact";
    
    public GameObject Textocult;
    public GameObject imageOcult;
    

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    public virtual void Update()
    {
      //if (isInsideZone && Input.GetKeyDown(interactionKey))
      if(isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
        {
            Interact();
            //Oculta la imagen y el texto de cuando recogemos un item
            Textocult.gameObject.SetActive(false);
            imageOcult.gameObject.SetActive(false);
        }
         
    }


    ///////Cuando entra al espacio de la pelota////////////////
    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other" >The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        //Dar color cuando se acerque, y que el usuario lo pueda colocar el color que quiera
        render = GetComponent<Renderer>();
        render.material.color = AcercarColor;


        Debug.Log("Entró en el área");
        isInsideZone = true;
        
        //Oculta la imagen y el texto de cuando nos alejamos del objeto a recoger
        Textocult.gameObject.SetActive(true);
        imageOcult.gameObject.SetActive(true);
         
    }

    //////////////Caso contrario cuando estoy fuera////////////////////
    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        
        //Dar color cuando se aleje, y que el usuario lo pueda colocar el color que quiera
        render = GetComponent<Renderer>();
        render.material.color = AlejarColor;

        Debug.Log("Salió en el área");
        isInsideZone = false;
        
        //aparece la imagen y el texto de cuando nos acercamos al objeto a recoger
        Textocult.gameObject.SetActive(false);
        imageOcult.gameObject.SetActive(false);
        
    }

     public virtual void Interact()
    {
         
    }   


}
