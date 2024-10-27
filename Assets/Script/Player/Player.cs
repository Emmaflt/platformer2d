using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(20);
        }
    }
    
    public void TakeDamage(int damage) {

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        Debug.Log("Vie du joueur : " + currentHealth);
        
        if (currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        // Animation de mort ou recharger la scène
        Debug.Log("Le joueur est mort");
    }
}
