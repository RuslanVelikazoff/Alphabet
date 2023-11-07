using UnityEngine;
using UnityEngine.UI;

public class DeleteAdds : MonoBehaviour
{
    [SerializeField] private Button deleteAddButton;

    public void Initialize()
    {
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (deleteAddButton != null)
        {
            deleteAddButton.onClick.RemoveAllListeners();
            deleteAddButton.onClick.AddListener(() =>
            {
                Debug.Log("Delete add");
            });
        }
    }
}
