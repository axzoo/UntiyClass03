using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public float A = 12, B = 3;
    public float f = 54;

    private void Start()
    {
        #region
        Debug.Log(A + B);
        Debug.Log(A - B);
        Debug.Log(A * B);
        Debug.Log(A % B);
        Debug.Log(A / B);
        Debug.Log((1 + 2) * 3);

        Debug.Log(f++);
        Debug.Log(f);

        Debug.Log(++f);
        #endregion
    }
}