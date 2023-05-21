using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public List<TextData> TextData { get; set; }

    public List<TextCondition> TextCondition { get; set; }

    public List<ChoiceText> ChoiceText { get; set; }

    public List<ResultText> ResultText { get; set; }


    private void Awake()
    {
        
    }
}
