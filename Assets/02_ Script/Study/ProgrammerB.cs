using UnityEngine;
using DevA;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA programmerA;
    // ����Ƽ ������  = new ProgrammerA();����

    private void Start()
    {
        //programmerA.Num = 10; 
        // int Num;�� private�� �����Ǿ��ִ� ������ ���� �Ұ�

        programmerA.publicNum = 20;

        // programmerA.serializedNum = 30;
        //programmerA.serializedNum2 = 40;
        // serializedNum�� private�� �����Ǿ��ִ� ������ ���� �Ұ�


    }
}
