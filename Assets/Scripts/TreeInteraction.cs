using UnityEngine;


public class TreeInteraction : MonoBehaviour
{
   public Sprite logs2Sprite;
   public Sprite logs1Sprite;
   public Sprite logs0Sprite;
 
   public SpriteRenderer spriteRenderer;
 
   private int logs;
   private int MAX_LOGS = 2;
   private int MIN_LOGS = 0;
   private int CUT_LOGS = 1;
   private int GROW_LOGS = 1;

   void Awake(){
      logs = MAX_LOGS;
   }
   
   /*
      Player Interactions
   */ 
   void OnCollisionEnter2D(Collision2D other){
      if (other.gameObject.CompareTag("Player")){
         if(cutTree()){
            Player p = other.gameObject.GetComponent<Player>();
            p.addLogs(CUT_LOGS);
         }
      }
   }

   /*
      Helper functions
   */
 
   private void updateSprite(){
      if(logs==1){
         spriteRenderer.sprite = logs1Sprite;
      }else if(logs==0){
         spriteRenderer.sprite = logs0Sprite;
      }else {
         spriteRenderer.sprite = logs2Sprite;
      }
   }
   
   private void growTree(){
      Debug.Log(gameObject.name);
      if(logs <= MAX_LOGS-GROW_LOGS){
         logs = logs + GROW_LOGS;
      }
      updateSprite(); // important
   }

   private bool cutTree(){
      int minLogCountToCut = MIN_LOGS + CUT_LOGS;
      if(logs >= minLogCountToCut){ 
         logs -= CUT_LOGS;
         updateSprite(); // important
         Invoke("growTree", 5.0f); 
         return true;
      }
      return false;   
   }
   
}
