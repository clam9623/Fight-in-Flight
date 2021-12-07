using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    private int nextSceneToLoad;

    private void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }

    }

    // Update is called once per frame
    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
