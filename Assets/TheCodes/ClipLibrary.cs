using UnityEngine;

[CreateAssetMenu(menuName = "Clip Library")]
public class ClipLibrary : ScriptableObject {

	[SerializeField] private AudioClip _tick;
	public AudioClip Tick { get { return _tick; } }

	[SerializeField] private AudioClip _scream;
	public AudioClip Scream { get { return _scream; } }
}
  