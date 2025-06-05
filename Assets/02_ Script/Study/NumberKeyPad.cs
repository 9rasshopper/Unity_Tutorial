using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class NumberKeyPad : MonoBehaviour
{
    public string password;
    public string keyPadNumber;
    public GameObject doorLock; 
    public Animator doorAnim;
    public void OnInputNumber(string numString)
    {
        keyPadNumber += numString;
        Debug.Log($"현재 입력 : {keyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            //Debug.Log("비밀번호가 일치합니다.");
            keyPadNumber = "";
            doorAnim.SetTrigger("Open");
            doorLock.SetActive(false);
            
        }
        else
        {
            keyPadNumber = ""; 
            //Debug.Log("비밀번호가 틀렸습니다.");
        }
    }
}
