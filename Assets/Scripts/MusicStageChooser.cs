using UnityEngine;

public class MusicStageChooser : MonoBehaviour
{
    private float _distanceToCamera;
    
    private void OnMouseDown()
    {
        if (Camera.main is null) return;
        
        _distanceToCamera = Vector3.Dot(transform.position - Camera.main.transform.position, Input.mousePosition + Vector3.forward);
    }

    private void OnMouseDrag()
    {
        if (Camera.main is null) return;

        var position = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * _distanceToCamera);
        transform.position = position;
    }
}
