namespace HeatsGame.Features.Shop
{
    using DG.Tweening;
    using UnityEngine;
    using UnityEngine.EventSystems;

    public class BackButtonAnimation : MonoBehaviour, IPointerEnterHandler
    {
         
        public void OnPointerEnter(PointerEventData eventData)
        {
            var animation = transform.DORotate(new Vector3(0, 0, 360), 0.3f, RotateMode.FastBeyond360);
            if (animation.IsPlaying())
            {
                return;
            }
        }

        
    }
}

