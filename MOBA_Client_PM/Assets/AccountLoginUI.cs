using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AccountLoginUI : MonoBehaviour
{

    [SerializeField] TMP_InputField accountName;
    [SerializeField] TMP_InputField accountPass;
    [SerializeField] Button loginAccountButton;
    [SerializeField] Button createAccountButton;

    [SerializeField] NetworkClient networkClient;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createAccountButton.onClick.AddListener(OnCreateButtonPress);
        loginAccountButton.onClick.AddListener(OnLoginButtonPress);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLoginButtonPress()
    {
        Debug.Log("fwegwegwegweg");
        //accountName.text;
        //accountPass.text;

        //string msg = accountName.text + "," + accountPass.text;

        networkClient.SendMessageToServer("Login Account Button Pressed");


    }
    public void OnCreateButtonPress()
    {
        //Debug.Log("herhertjt4rj");
        networkClient.SendMessageToServer("Create Account Button Pressed");
        
    }
}
