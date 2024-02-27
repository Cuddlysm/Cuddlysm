using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrench : BuildingTool
{

    [SerializeField] private Movement _movement;
    [SerializeField] private GameObject _previewBuilding;
    [SerializeField] private GameObject _buildingObject;
    [SerializeField] private float _buildDelay = 0.1f;
    [SerializeField] private float _buildCost = 50f;

    private float _nextTimeToBuild = 0;


    private void OnEnable()
    {
        _weaponGUIUpdater.SetWeaponSprite(sprite);
    }

    private void Update()
    {
        Vector3 buildPosition = new(_movement.targetPosition.x, 0, _movement.targetPosition.z);

        if (!_previewBuilding.activeSelf) _previewBuilding.SetActive(true);
        _previewBuilding.transform.position = buildPosition;
    }

    public override void UseTool()
    {
        Build();
        UpdateStaminaBar();
    }

    private void Build(bool ignoreBuildDelay = false)
    {
        if (!readyToBuild) return;

        Vector3 buildPosition = new(_movement.targetPosition.x, 0, _movement.targetPosition.z);

        bool isReadyToBuild = ignoreBuildDelay || Time.time >= _nextTimeToBuild;
        if (!isReadyToBuild || playerEntity.currentStamina < _buildCost) return;
        if (!ignoreBuildDelay) _nextTimeToBuild = Time.time + _buildDelay;

        playerEntity.currentStamina -= _buildCost;

        GameObject newBuilding = Instantiate(_buildingObject, buildPosition, transform.rotation);
        newBuilding.layer = gameObject.layer;
    }
}
