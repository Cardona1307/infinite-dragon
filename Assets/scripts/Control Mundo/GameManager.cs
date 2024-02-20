using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pantallaMuerte;
    [SerializeField] private float initialScrollSpeed;
    [SerializeField] private TextMeshProUGUI timerText;

    private float scrollSpeed;
    private float timer = 0f;
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Update()
    {
        UpdateSpeed();
        UpdateTimer();
    }

    public void ShowPantallaMuerte()
    {
        pantallaMuerte.SetActive(true);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public float GetScrollSpeed()
    {
        return scrollSpeed;
    }

    private void UpdateSpeed()
    {
        float speedDivider = 20f;
        scrollSpeed = initialScrollSpeed + timer / speedDivider;
    }

    private void UpdateTimer()
    {
        timer += Time.deltaTime;
        int seconds = Mathf.FloorToInt(timer % 60);
        int minutes = Mathf.FloorToInt(timer / 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}