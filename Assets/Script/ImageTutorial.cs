using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTutorial : MonoBehaviour
{
    public List<Sprite> spriteList; // Your list of sprites
    public Image image; // The image you want to change
    private int currentIndex = 0; // The current index of the sprite

    public void NextSprite()
    {
        // Increase the index and wrap around to the start if necessary
        currentIndex = (currentIndex + 1) % spriteList.Count;
        // Change the sprite
        image.sprite = spriteList[currentIndex];
    }

    public void PreviousSprite()
    {
        // Decrease the index and wrap around to the end if necessary
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = spriteList.Count - 1;
        }
        // Change the sprite
        image.sprite = spriteList[currentIndex];
    }
}
