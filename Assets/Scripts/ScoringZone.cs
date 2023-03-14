using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    [SerializeField] EventTrigger.TriggerEvent triggerScore;
    [SerializeField] AudioSource scoreSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            scoreSFX.Play();

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            triggerScore.Invoke(eventData);
        }
    }
}
