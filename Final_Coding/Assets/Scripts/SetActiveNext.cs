using UnityEngine;

public class SetActiveNext : MonoBehaviour
{
    public GameObject nextPuzzleStep;
    public void On()
    {
        nextPuzzleStep.SetActive(true);
    }

    public void Off()
    {
        nextPuzzleStep.SetActive(false);
    }
}
