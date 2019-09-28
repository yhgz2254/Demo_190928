using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterAnimator : MonoBehaviour {
    public SpriteRenderer spriteRenderer;

    public Sprite[] sIdle;
    public Sprite[] sWalk;
    public Sprite[] sAttack;

    public Sprite[] curSprite;
    public float framesPerSecond;

    public int spritesIndex;

    public CharacterController myController;

    public bool onAnim;

    private void Start() {
        framesPerSecond = 8.0f;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        myController = gameObject.GetComponent<CharacterController>();
        curSprite = sIdle;
        onAnim =false;
    }

    private void Update() {
        SetAnimation();
        SetFaceDirection();
    }

    public void SetAnimation () 
    {
        if (!onAnim && myController.curState.ToString() == "Idle")
        {
           curSprite = sIdle;
        }
        else
        {
            if (myController.curState.ToString() == "Walk")
            {
                curSprite = sWalk;
                framesPerSecond = 8.0f;
            }
            else if (myController.curState.ToString() == "Attack")
            {
                StartCoroutine(SetAnimationByState(sAttack, 2));
            }
            // else
            // {
            //     curSprite = sIdle;
            //     framesPerSecond = 8.0f;
            // }
        }

         spritesIndex = (int)(Time.realtimeSinceStartup *framesPerSecond);

        spritesIndex = spritesIndex %curSprite.Length;
        spriteRenderer.sprite = curSprite[spritesIndex];
        
        
    }

    public void SetFaceDirection ()
    {
        if (myController.curDirection.ToString() == "Left")
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public IEnumerator SetAnimationByState (Sprite[] s, float animeFrames)
    {
        curSprite = s;
        yield return new WaitForSeconds(animeFrames);
        onAnim = false;
    }

}