using System;
using System.Collections;
using UnityEngine;

namespace FMODUnity
{
    [Serializable]
    public class EmitterRef
    {
        public StudioEventEmitter Target;
        public ParamRef[] Params;
    }

    [AddComponentMenu("FMOD Studio/FMOD Studio Parameter Trigger")]
    public class StudioParameterTrigger: MonoBehaviour
    {                        
        public EmitterRef[] Emitters;
        public EmitterGameEvent TriggerEvent;
        public bool ResetAfterPlay;
        public float ResetTime;
        public string CollisionTag;
        private float[] initialValue;
        
        void Start()
        {
            initialValue = new float[Emitters[0].Params.Length];
            for (int i = 0; i < Emitters.Length; i++)
            {
                var emitterRef = Emitters[i];
                if (emitterRef.Target != null)
                {
                    for (int j = 0; j < Emitters[i].Params.Length; j++)
                    {
                        initialValue[j] = 0f;
                    }
                }
            }
            HandleGameEvent(EmitterGameEvent.ObjectStart);
            
        }

        void OnDestroy()
        {
            HandleGameEvent(EmitterGameEvent.ObjectDestroy);
        }

        void OnEnable()
        {
            HandleGameEvent(EmitterGameEvent.ObjectEnable);
        }

        void OnDisable()
        {
            HandleGameEvent(EmitterGameEvent.ObjectDisable);
        }

        void OnTriggerEnter(Collider other)
        {
            if (String.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
            {
                HandleGameEvent(EmitterGameEvent.TriggerEnter);
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (String.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
            {
                HandleGameEvent(EmitterGameEvent.TriggerExit);
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (String.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
            {
                HandleGameEvent(EmitterGameEvent.TriggerEnter2D);
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (String.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
            {
                HandleGameEvent(EmitterGameEvent.TriggerExit2D);
            }
        }

        void OnCollisionEnter()
        {
            HandleGameEvent(EmitterGameEvent.CollisionEnter);
        }

        void OnCollisionExit()
        {
            HandleGameEvent(EmitterGameEvent.CollisionExit);
        }

        void OnCollisionEnter2D()
        {
            HandleGameEvent(EmitterGameEvent.CollisionEnter2D);
        }

        void OnCollisionExit2D()
        {
            HandleGameEvent(EmitterGameEvent.CollisionExit2D);
        }

        void HandleGameEvent(EmitterGameEvent gameEvent)
        {
            if (TriggerEvent == gameEvent)
            {
                StartCoroutine(TriggerParameters());
            }
        }

        public IEnumerator TriggerParameters()
        {
            for (int i = 0; i < Emitters.Length; i++)
            {
                var emitterRef = Emitters[i];
                if (emitterRef.Target != null)
                {
                    for (int j = 0; j < Emitters[i].Params.Length; j++)
                    {
                        
                        emitterRef.Target.SetParameter(Emitters[i].Params[j].Name, Emitters[i].Params[j].Value);
                    }
                }
            }

            if (ResetAfterPlay)
                yield return new WaitForSeconds(.2f);
            else
            {
                yield break;
            }

            for (int i = 0; i < Emitters.Length; i++)
            {
                var emitterRef = Emitters[i];
                if (emitterRef.Target != null)
                {
                    for (int j = 0; j < Emitters[i].Params.Length; j++)
                    {
                        emitterRef.Target.SetParameter(Emitters[i].Params[j].Name, initialValue[j]);
                    }
                }
            }
        }
    }
}
