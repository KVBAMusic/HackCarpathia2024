using UnityEngine;
using System;

public class Audio : MonoBehaviour {
    AudioSource click;
    public AudioClip tileClick, uiClick, buildFailed, advance;
    private static Action onTileClick; 
    private static Action onUIClick; 
    private static Action onBuildFailed; 
    private static Action onAdvance; 
    void Awake() {
        onTileClick += PlayTile;
        onUIClick += PlayUI;
        onBuildFailed += PlayFail;
        onAdvance += PlayAdvance;
        click = gameObject.AddComponent<AudioSource>();
    }

    void OnDisable() {
        onTileClick -= PlayTile;
        onUIClick -= PlayUI;
        onBuildFailed -= PlayFail;
        onAdvance -= PlayAdvance;
    }

    public static void TileClick() {
        onTileClick?.Invoke();
    }

    public static void UIClick() {
        onUIClick?.Invoke();
    }

    public static void BuildFailed() {
        onBuildFailed?.Invoke();
    }

    public static void Advance() {
        onAdvance?.Invoke();
    }

    private void PlayTile() {
        click.clip = tileClick;
        click.Play();
    }

    private void PlayUI() {
        click.clip = uiClick;
        click.Play();
    }

    private void PlayFail() {
        click.clip = buildFailed;
        click.Play();
    }

    private void PlayAdvance() {
        click.clip = advance;
        click.Play();
    }
}