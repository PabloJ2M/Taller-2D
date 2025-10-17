using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TiendaUI_Entry : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private Image _icono;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _cost;

    private Item Item;

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponentInParent<TiendaUI>().ShowPreview(Item);
    }

    public void Setup(Item item)
    {
        Item = item;

        _icono.SetImage(item.Icon);
        _name?.SetText(item.Name);
        _cost.SetText(item.Cost.ToString());
    }
}