using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{

    private float _speed = 1f;
    private float _witdh = 6f;

    private SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);

        if (_spriteRenderer.size.x > _witdh)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}
