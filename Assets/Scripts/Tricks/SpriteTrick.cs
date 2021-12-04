using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class SpriteTrick : Trick
    {
        [SerializeField]
        [Tooltip("Duration of the trick in seconds")]
        private float duration = 2f;
        [SerializeField]
        [Tooltip("Image to change during trick")]
        private Image image;
        [SerializeField]
        [Tooltip("Sprite to change the image to")]
        private Sprite sprite;

        private bool playing = false;

        override public void Perform()
        {
            if (!playing)
                StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            playing = true;
            Sprite originalSprite = image.sprite;

            // Change the sprite
            image.sprite = sprite;

            yield return new WaitForSeconds(duration);

            // If something else changed the sprite, we won't touch it anymore
            // Otherwise, we change it back to what it was before
            if (image.sprite == sprite)
                image.sprite = originalSprite;

            playing = false;
        }
    }
}
