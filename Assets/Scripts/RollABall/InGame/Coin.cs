using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;
    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10;
    private int bonusScoreValue = 20;
    private int bigBonusScoreValue = 100;

    private enum bonusChance
    { 
    Invalide = -1,
    BigBonus,
    SmallBonus,
    NoBonus
    
    }

    private bonusChance bonusChances;

    public Material coinMaterial;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }

    IEnumerator BonusTimeCoroutine()
    {
        bonusChances = bonusChance.BigBonus;

        yield return new WaitForSeconds(bigBonusTime);

        bonusChances = bonusChance.SmallBonus;

        yield return new WaitForSeconds(bonusTime - bigBonusTime);
        bonusChances = bonusChance.NoBonus;
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {

            switch (bonusChances) {
                case bonusChance.BigBonus:
                    coinMaterial.color = Color.yellow;
                    ScoreManager.ScoreCount += bigBonusScoreValue;
                    break;

                case bonusChance.SmallBonus:
                    coinMaterial.color = Color.cyan;
                    ScoreManager.ScoreCount += bonusScoreValue;
                    break;

                case bonusChance.NoBonus:
                    coinMaterial.color = Color.red;
                    ScoreManager.ScoreCount += scoreValue;
                    break;
            }

            Destroy(gameObject);
        }
    }
}
