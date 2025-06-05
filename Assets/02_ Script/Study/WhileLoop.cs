using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int count =0;
    void Start()
    {

        while (count <= 10)
        {
            count++;

            if(count % 3 == 0)
            {
                Debug.Log("¹Ú¼ö Â¦");
                continue;
            }

            Debug.Log(count);

        }
    }

}
