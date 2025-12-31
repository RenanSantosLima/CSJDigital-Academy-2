using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject optionsMenu;
    private bool isActive;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;
            optionsMenu.SetActive(isActive);
        }
    }


    #region Outro jeito de mecher no botões
    [SerializeField] private Button startButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button exitMenuButton;

    [SerializeField] private GameObject options;


    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
        optionButton.onClick.AddListener(OptionOpenMenu);
        exitMenuButton.onClick.AddListener(OptionCloseMenu);
    }


    private void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    private void OptionOpenMenu()
    {
        options.SetActive(true);
    }

    private void OptionCloseMenu()
    {
        options.SetActive(false);
    }

    #endregion


    /*
    #region CSJDigital Curso
    //Aula da CSJDigital -- Wenes
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OptionOpenMenu(GameObject go)
    {
        go.SetActive(true);
    }

    public void OptionCloseMenu(GameObject go)
    {
        go.SetActive(false);
    }


    #endregion
    */







}
