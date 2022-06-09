using UnityEngine;

[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(Collider))]
public class MusicStagePlatform : MonoBehaviour
{
	[SerializeField] private MusicStage _musicStage;
	[SerializeField] private Material _defaultMaterial;
	[SerializeField] private Material _hoverMaterial;

	private Renderer _renderer;
	private bool _isHover;

	private void Awake()
	{
		_renderer = GetComponent<Renderer>();
	}

	private void OnHover()
	{
		_renderer.material = _hoverMaterial;
	}

	private void OnEndHover()
	{
		_renderer.material = _defaultMaterial;
	}
}