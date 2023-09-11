using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CartoonFlipbook : MonoBehaviour
{
    public Sprite[] imageArray;
    Image _image;
    int _index = 0;

    private void Start()
    {
        TryGetComponent<Image>(out _image);
        _image.sprite = imageArray[_index];

    }

    public void ChangeImage(bool next)
    {
        if (next)
        {
            if(_index < imageArray.Length - 1)
            {
                ++_index;
                _image.sprite = imageArray[_index];
            }
        }
        else
        {
            if(_index > 0)
            {
                --_index;
                _image.sprite = imageArray[_index];
            }
        }
    }
}