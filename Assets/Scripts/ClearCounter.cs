using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter 
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO; 


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject()){
                //Player is carrying sth
                player.GetKitchenObject().SetKitchenObjectParent(this);
                
            }else
            {
                //Player is carrying nothing
            }
        }
        else
        {
            // there is a kitchenobject here
            if (player.HasKitchenObject())
            {
                if(player.HasKitchenObject())
                {
                    //Player is carrying sth
                }
                else
                {
                    //Player is carrying nothing
                    GetKitchenObject().SetKitchenObjectParent(player);
                }
            }
        }
      
     }

 
   
}
