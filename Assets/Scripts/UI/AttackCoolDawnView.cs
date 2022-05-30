using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System;

[RequireComponent(typeof(Image))]
public class AttackCoolDawnView : MonoBehaviour
{
    [SerializeField] TMP_Text _label;
    [SerializeField] private PlayerStateAttack _attack;

    private float _lastAttackTime = 0;
    private Image _icon;

    private void Start()
    {
        _icon = GetComponent<Image>();
    }

    private void Update()
    {
        if (_lastAttackTime >= _attack.CoolDownAttack)
        {
            _lastAttackTime = 0;
            this.gameObject.SetActive(false);
        }
        Show();
    }

    private void Show()
    {
        _lastAttackTime += Time.deltaTime;
        Math.Round(_lastAttackTime, 1);
        _icon.fillAmount = _lastAttackTime/_attack.CoolDownAttack;
        _label.text = Math.Round(_lastAttackTime, 1).ToString();
    }
}
