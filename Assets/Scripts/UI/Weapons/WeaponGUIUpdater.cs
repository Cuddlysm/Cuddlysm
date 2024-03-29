using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponGUIUpdater : MonoBehaviour
{
    [SerializeField] private Image _weaponSprite;
    [SerializeField] private Image _ammoBarGUI;
    [SerializeField] private TextMeshProUGUI _magazineAmmoGUI;
    [SerializeField] private TextMeshProUGUI _storageAmmoGUI;

    public void UpdateAmmoGUI(string magazineAmmo, string storageAmmo)
    {
        _magazineAmmoGUI.text = magazineAmmo;
        _storageAmmoGUI.text = storageAmmo;
    }

    public void FillAmmoBar(float fillAmount)
    {
        _ammoBarGUI.fillAmount = fillAmount;
    }

    public void SetWeaponSprite(Sprite sprite)
    {
        _weaponSprite.sprite = sprite;
    }
}
