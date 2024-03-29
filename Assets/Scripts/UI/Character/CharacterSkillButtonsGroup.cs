using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkillButtonsGroup : MonoBehaviour
{
    [Header("Component")] 
    public GameObject buttons;
    
    [Header("Settings")]
    public CharacterDetailsSO characterDetails;
    public CharacterGameData characterGameData;
    //[Header("Debug")]

    private void OnEnable()
    {
        EventHandler.CharacterCardPress += OnCharacterCardPress;
        EventHandler.CharacterObjectGeneratedDone += InitialUpdateData;
    }
    private void OnDisable()
    {
        EventHandler.CharacterCardPress -= OnCharacterCardPress;
        EventHandler.CharacterObjectGeneratedDone -= InitialUpdateData;
    }

    private void OnCharacterCardPress(CharacterDetailsSO data)
    {
        buttons.SetActive(data == characterDetails);
    }

    public void InitialUpdateData()
    {
        buttons.SetActive(false);
        characterGameData = CharacterManager.Instance.LoadData(characterDetails.characterName);
        
        for (int i = 0; i < buttons.transform.childCount; i++)
        {
            SkillButton skillButton = buttons.transform.GetChild(i).GetComponent<SkillButton>();
            skillButton.InitialUpdate(this);
        }
    }
}
