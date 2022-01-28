using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChatHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MoveDown();
    }

    private void MoveUp()
    {
        transform.DOMoveY(70, 0.5f)
            .SetEase(Ease.InBack)
            .OnComplete(() =>
            {
                MoveDown();
            });
    }
    
    private void MoveDown()
    {
        transform.DOMoveY(60, 0.5f)
            .SetEase(Ease.InBack)
            .OnComplete(() =>
            {
                MoveUp();
            });
    }
}
