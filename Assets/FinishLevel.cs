
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject compleLevelUI;
    void OnTriggerEnter()
    {
        Debug.Log("Meta hit !!!");
        compleLevelUI.SetActive(true);
    }
}
