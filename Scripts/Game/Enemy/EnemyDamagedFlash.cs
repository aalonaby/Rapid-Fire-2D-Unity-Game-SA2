using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagedFlash : MonoBehaviour
{
    [SerializeField]
    private float _flashDuration;

    [SerializeField]
    private Color _flashColor;

    [SerializeField]
    private int _numberOfFlashes;

    private SpriteFlash _spriteFlash;

    private void Awake()
    {
        _spriteFlash = GetComponent<SpriteFlash>();
    }

    public void StartFlash()
    {
        _spriteFlash.StartFlash(_flashDuration, _flashColor, _numberOfFlashes);
    }
}
