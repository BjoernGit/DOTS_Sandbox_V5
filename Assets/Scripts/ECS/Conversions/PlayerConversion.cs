using Unity.Entities;
using UnityEngine;

public class PlayerConversion : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager manager, GameObjectConversionSystem conversionSystem)
    {
        AppManager.instance.playerEntity = entity;
    }
}