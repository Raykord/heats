namespace HeatsGame.Features.Shop
{
    using HeatsGame.Features.EquipmentSystem;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class ShopView : MonoBehaviour
    {
        [SerializeField] GameObject shopObject;
        [SerializeField] Text cash;
        [SerializeField] Button exitButton;

        protected const string GAME_SCENE = "Game";

        protected ShopController controller = null;
        protected GameObject instances = null;

        protected void Awake()
        {
            controller = FindObjectOfType<ShopController>();
            
        }

        protected void OnEnable()
        {
            exitButton.onClick.AddListener(LoadGame);
            controller.IsItemSold += ReloadCahs;
        }

        protected void OnDisable()
        {
            exitButton.onClick.RemoveListener(LoadGame);
            controller.IsItemSold -= ReloadCahs;
        }

        protected void Start()
        {
            if (controller != null)
            {
                foreach (AbstractEquipmentObject item in controller.GetShopItems().Equipment)
                {
                    GameObject tempShopItem = Instantiate(shopObject);
                    Image itemImage = tempShopItem.GetComponentInChildren<Image>();
                    Text[] itemTexts = tempShopItem.GetComponentsInChildren<Text>();
                    ShopItem shopItem = tempShopItem.GetComponent<ShopItem>();

                    if (itemImage != null)
                    {
                        itemImage.sprite = item.Icon;
                    }

                    if (itemTexts != null)
                    {
                        foreach (Text itemText in itemTexts)
                        {
                            if (itemText.tag == "ItemNameText")
                            {
                                itemText.text = item.ItemName;
                            }
                            else
                            {
                                itemText.text = item.Price.ToString();
                            }
                        }
                        
                    }

                    if (shopItem != null)
                    {
                        shopItem.EquipmentObject = item;
                    }
                    tempShopItem.transform.SetParent(transform, false);
                }

                ReloadCahs();
            }
        }

        protected void ReloadCahs()
        {
            cash.text = controller.Inventory.GetCash().ToString();
        }

        protected void LoadGame()
        {
            SceneManager.LoadSceneAsync(GAME_SCENE);
        }
    }
}
