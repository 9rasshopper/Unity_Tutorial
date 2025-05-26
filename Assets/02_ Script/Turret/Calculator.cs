using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int num1, num2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod();

        int minusResult = MinusMethod();

        Debug.Log($"더한값 : {addResult} / 뺸값 : {minusResult}");

    }
        public int AddMethod()
    {
        int result = num1 + num2;
    Debug.Log(result);
        return result;
    }

    int MinusMethod()
    {   
        int result = num1 - num2;

        Debug.Log(result);
        return result;
    }
}
