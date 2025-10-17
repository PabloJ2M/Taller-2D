using UnityEngine;

public enum ProductType
{
    Consumible,
    Arma,
    Armadura
}

[CreateAssetMenu(fileName = "Item Tienda", menuName = "Tienda/Item Tienda")]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public ProductType Type;
    public float Cost;
}