using System.Collections;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public float velo;

    [SerializeField] private CinemachineVirtualCamera upgradeCam, gameCam;
    private CinemachineBasicMultiChannelPerlin gameCamNoise;

    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        //gameCamNoise = gameCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

  

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position, ref velocity, smoothing);
    }










    //private void OnEnable()
    //{
    //    EventManager.CameraShake += CameraShake;
    //}
    //private void OnDisable()
    //{
    //    EventManager.CameraShake -= CameraShake;
    //}
    //public void CameraZoomInUpgradeArea()
    //{
    //    upgradeCam.Priority = 5;
    //}
    //public void CameraZoomOutUpgradeArea()
    //{
    //    upgradeCam.Priority = 0;
    //}

    //public void CameraShake()
    //{
    //    StartCoroutine(ShakeForSec());
    //}

    //private IEnumerator ShakeForSec()
    //{
    //    gameCamNoise.m_AmplitudeGain = .6f;
    //    yield return new WaitForSeconds(.2f);
    //    gameCamNoise.m_AmplitudeGain = 0;
    //}
}