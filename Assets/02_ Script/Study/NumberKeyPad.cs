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
        Debug.Log($"���� �Է� : {keyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            //Debug.Log("��й�ȣ�� ��ġ�մϴ�.");
            keyPadNumber = "";
            doorAnim.SetTrigger("Open");
            doorLock.SetActive(false);
            
        }
        else
        {
            keyPadNumber = ""; 
            //Debug.Log("��й�ȣ�� Ʋ�Ƚ��ϴ�.");
        }
    }
}
