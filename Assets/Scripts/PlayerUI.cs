using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField]
    RectTransform thrusterFuelFill;

    [SerializeField]
    GameObject pauseMenu;

    private PlayerController controller;

    void Start()
    {
        //pauseMenu.IsOn = false;
    }

    public void SetController(PlayerController _controller)
    {
        controller = _controller;
    }

    private void Update()
    {
        SetFuelAmount(controller.GetThrusterFuelAmount());

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        //PauseMenu.IsOn = pauseMenu.activeSelf;
    }

    void SetFuelAmount(float _amount)
    {
        thrusterFuelFill.localScale = new Vector3(1f, _amount, 1f);
    }
}
