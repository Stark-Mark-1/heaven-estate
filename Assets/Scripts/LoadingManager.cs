using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
    public static LoadingManager Instance;

    [Header("GameObjects")]
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject signup;
    [SerializeField] private GameObject signin;
    [SerializeField] private Slider slider;


    [SerializeField] private int levelnum = 2;

    private void Awake()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void signIntohome()
    {
        signin.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadLevelAsync(levelnum));
    }

    public void signUptohome()
    {
        signup.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadLevelAsync(levelnum));
    }

    private IEnumerator LoadLevelAsync(int levelnum)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelnum);

        while (!loadOperation.isDone)
        {
            float progressvalue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            slider.value = progressvalue;
            yield return null;
        }
    }
}
