using TMPro;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI pointCont;

    private void Update()
    {
        pointCont.text = score.ToString();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Moeda")
        {
            score += 10;
            Destroy(col.gameObject);
        }
    }
}
