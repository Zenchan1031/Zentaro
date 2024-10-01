using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI textMeshPro;

    [System.NonSerialized]
    public int numberOfItem;

    public void RemoveScore()
    {
        --numberOfItem;
        textMeshPro.SetText("�c��{0}��", numberOfItem);
    }

    // Start is called before the first frame update
    void Start()
    {
        numberOfItem = 4;
        textMeshPro.SetText("�c��{0}��", numberOfItem);
    }
}

