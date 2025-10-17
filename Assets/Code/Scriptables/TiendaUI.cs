using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class TiendaUI : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private TiendaUI_Entry prefab;

    [SerializeField] private Item[] productos;

    [SerializeField] private Image PreviewImage;

    void Start()
    {
        foreach (Item item in productos)
        {
            Instantiate(prefab, parent).Setup(item);
        }

        Destroy(prefab.gameObject);
    }
    public void ShowPreview(Item item)
    {
        if (PreviewImage != null)
            PreviewImage.sprite = item.Icon;
    }
}