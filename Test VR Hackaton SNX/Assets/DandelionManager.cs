using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandelionManager : MonoBehaviour
{
  public  List<FlowerPetale> petalesAvaiable;
   public List<FlowerPetale> petaleUnavaiable;

   public Dandelion dandelion{
       get{
            if(m_dandelion == null)
                m_dandelion = GetComponent<Dandelion>();
            return m_dandelion;           
       }
   }
   public Dandelion m_dandelion;

    public bool isAlive = true;
    public bool canEffect;

    public float updateInterval = 0.1f;

   public void TryRemovePetale(){
       
       if(petalesAvaiable.Count > 0 ){
           int choosed;
            choosed = Random.Range(0,petalesAvaiable.Count);
            

            RemovePetale(choosed);
            dandelion.SpawnFlowers();
       }
       else{

       }


   }

   public void RemovePetale(int choosed){
            petaleUnavaiable.Add(petalesAvaiable[choosed]);
            
            petalesAvaiable[choosed].gameObject.SetActive(false);
            petalesAvaiable.RemoveAt(choosed);


            //aqui dar play nas particulas 

   }

   public void TryAddPetale(){
       
       if(petaleUnavaiable.Count ==0)
            return;

        int choosed;
            choosed = Random.Range(0,petaleUnavaiable.Count);

        AddPetale(choosed);

   }

   public void AddPetale(int choose){

       
       petalesAvaiable.Add(petaleUnavaiable[choose]);
       petaleUnavaiable[choose].gameObject.SetActive(true);
       petaleUnavaiable.RemoveAt(choose);
   }

   private void Start() {
       StartCoroutine(PetaleRoutine());
   }

   IEnumerator PetaleRoutine(){
       while(isAlive){
           
           yield return new WaitForSeconds(updateInterval);
           TryAddPetale();
       }
   }

   private void OnTriggerEnter(Collider other) {
//       Debug.Log("Está Chegando Vento");
       if(other.CompareTag("Wind")){
           TryRemovePetale();
            TryRemovePetale();
             TryRemovePetale();
              TryRemovePetale();

       }
   }
}
