using UnityEngine;

public class StringExtensionExample : MonoBehaviour
{
    public bool Test = false;

    public string Word = "";

    private void OnValidate()
    {
        if (Test)
        {
            Test = false;

            Word = Word.Combine("", 1, true, gameObject, new int[] {1, 5, 123});
            print(Word);
        }
    }
}