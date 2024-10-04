using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public string AnimasiJaring;
    public Animator ObjectGeometry;
    private bool playJaring = false;

    public void PlayAnimasiJaring()
    {
        if (!playJaring)
        {
            ObjectGeometry.Play(AnimasiJaring, -1, 0f);
            ObjectGeometry.speed = 1f;
            playJaring = true;
        }
        else
        {
            ObjectGeometry.Play(AnimasiJaring, -1, 0f);
            ObjectGeometry.speed = 0f;
            playJaring = false;
        }
    }
}
