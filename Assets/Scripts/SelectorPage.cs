using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

[Serializable]
public struct SpritePrefabPair {
    public Sprite image;
    public GameObject prefab; 
}

public class SelectorPage : MonoBehaviour {
    public BuildingSpawner spawner;
    public List<SpritePrefabPair> buttons;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    private int currentPosition = 0;
    private int next => (currentPosition + 1) % buttons.Count;
    private int secondNext => (currentPosition + 2) % buttons.Count;

    void OnEnable() {
        RefreshButtons();
    }

    public void Next() {
        currentPosition = (currentPosition + 1) % buttons.Count;
        RefreshButtons();
    }

    public void Previous() {
        currentPosition -= 1;
        if (currentPosition < 0) {
            currentPosition += buttons.Count;
        }
        RefreshButtons();
    }

    private void RefreshButtons() {
        RefreshButton(btn1, buttons[currentPosition]);
        RefreshButton(btn2, buttons[next]);
        RefreshButton(btn3, buttons[secondNext]);
    }

    private void RefreshButton(Button button, SpritePrefabPair pair) {
        button.transform.GetChild(0).GetComponent<Image>().sprite = pair.image;
    }

    public void Build(int idx) {
        spawner.TrySpawn(buttons[(idx + currentPosition) % buttons.Count].prefab);
    }
}

