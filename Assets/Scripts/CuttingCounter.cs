using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject())
            {
                //Player is carrying sth
                player.GetKitchenObject().SetKitchenObjectParent(this);

            }
            else
            {
                //Player is carrying nothing
            }
        }
        else
        {
            // there is a kitchenobject here
            if (player.HasKitchenObject())
            {
                if (player.HasKitchenObject())
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

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();

            Transform kitchenObjectTransform = Instantiate(cutKitchenObjectSO.prefab);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }
    }

}
    

