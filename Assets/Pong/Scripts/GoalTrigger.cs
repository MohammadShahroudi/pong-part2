using UnityEngine;

/*
 * Mo
 */

public class GoalTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Score score;

    void OnTriggerEnter(Collider other)
    {
        gameManager.OnGoalTrigger(this);

        // if (other.gameObject.CompareTag("rightGoal"))
        // {
        //     score.AddScore();
        // }

        // if (other.gameObject.CompareTag("leftGoal"))
        // {
        //     score.AddScore();
        // }
    }
}
