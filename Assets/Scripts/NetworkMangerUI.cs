using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkMangerUI : MonoBehaviour
{
    [SerializeField] Button ServerBtn;
    [SerializeField] Button HostBtn;
    [SerializeField] Button ClientBtn;

    private void Awake()
    {
        ServerBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer();
        });

        HostBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
        });

        ClientBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
    }
}
