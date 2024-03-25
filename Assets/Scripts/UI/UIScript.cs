using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private RawImage _healthBarFG;
    [SerializeField]
    private HealthBehaviour _healthBehavior;
    [SerializeField]
    private Gradient _hpGradient;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(_healthBarFG);
        Debug.Assert(_healthBehavior);
    }

    // Update is called once per frame
    void Update()
    {
        if (_healthBehavior == null || _healthBarFG == null)
            return;
        //insure the maxhealth is above 1.
        float maxHealth = Mathf.Max(1, _healthBehavior.MaxHealth);
        float healthPercentage = Mathf.Clamp01(_healthBehavior.Health / maxHealth);

        //store the scale.
        Vector3 newScale = _healthBarFG.rectTransform.localScale;
        
        //give the new size to the scale.
        newScale.x = healthPercentage;
        _healthBarFG.rectTransform.localScale = newScale;

        //evalute our new color using gradient's evaluate, and our percentage of health.
        _healthBarFG.color = _hpGradient.Evaluate(healthPercentage);

    }
}
