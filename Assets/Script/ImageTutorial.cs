using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageTutorial : MonoBehaviour
{
    public List<Sprite> spriteList;
    public List<string> textList;
    public Image image;
    public TMP_Text text;
    public int currentIndex = 0;

    // Reference to the buttons
    public Button previousButton;
    public Button nextButton;

    public void ResetIndex()
    {
        currentIndex = 0;
    }

    private void Start()
    {
        // Initialize button click listeners
        previousButton.onClick.AddListener(PreviousSprite);
        nextButton.onClick.AddListener(NextSprite);
        currentIndex = 0;
        UpdateImageAndText(0);
    }

    public void NextSprite()
    {
        currentIndex += 1;
        if (currentIndex >= spriteList.Count)
        {
            currentIndex = 0; // Kembali ke indeks pertama jika mencapai akhir daftar
        }
        UpdateImageAndText(currentIndex);
    }

    public void PreviousSprite()
    {
        currentIndex -= 1;
        if (currentIndex < 0)
        {
            currentIndex = spriteList.Count - 1; // Kembali ke indeks terakhir jika mencapai awal daftar
        }
        UpdateImageAndText(currentIndex);
    }

    private void UpdateImageAndText(int index)
    {
        image.sprite = spriteList[index];
        text.text = textList[index];
    }
}
