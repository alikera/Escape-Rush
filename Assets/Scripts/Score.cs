using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform pTransform;

    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        float score = pTransform.position.z + 30;
        scoreText.text = (score).ToString("0");
    }
}
