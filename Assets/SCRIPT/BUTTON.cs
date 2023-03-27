using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // para utilizar botones

public class BUTTON : MonoBehaviour
{
    private Button _button;
    private Material _material;
    public GameObject ball;

    public Button YellowButton; //hacer refferencia de esos botones
    public Button RedButton; // arrastrar al inspector al ser publicas
    public Button BlueButton;

    public Color colors;
    public bool hasBeenClicked;

    //acceder a la meshrenderr material, material al color


    private void Start()
    {
        _button = GetComponent<Button>();
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        ColorYellowButton();
        ColorRedButton();
        ColorBlueButton();

    }

    public void ColorYellowButton()
    {
        if (hasBeenClicked == true)
        {
           
            _material.color = Color.yellow;
        }
    }

   
    public void ColorRedButton()
    {
        if (hasBeenClicked == true)
        {

            _material.color = Color.red;
        }
    }

    public void ColorBlueButton()
    {

    }













    /*public void PlayButtonFunfaction() //activar el play y desactivar el play
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    } 

    public void PauseButtonFunfaction() //activar el play y activar el pause y desactivar el play
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }

    public void PlayPauseButtonFunfaction(bool playButtonHasBeenPressed)
    {
        playButton.interactable = !playButtonHasBeenPressed; //false;
        pauseButton.interactable = playButtonHasBeenPressed; //true;
}*/

}

