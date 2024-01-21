//----------------------------------------------
//            	   Koreographer                 
//    Copyright © 2014-2020 Sonic Bloom, LLC    
//----------------------------------------------

using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using DancingLineFanmade.Level;

namespace SonicBloom.Koreo.Demos
{
	public class AutoTap : MonoBehaviour
	{
		[EventID]
		public string eventID;
		public Player player;

		Rigidbody rigidbodyCom;
		void Start()
		{
			// Register for Koreography Events.  This sets up the callback.
			Koreographer.Instance.RegisterForEvents(eventID, AddImpulse);

			rigidbodyCom = GetComponent<Rigidbody>();
		}

		void OnDestroy()
		{
			// Sometimes the Koreographer Instance gets cleaned up before hand.
			//  No need to worry in that case.
			if (Koreographer.Instance != null)
			{
				Koreographer.Instance.UnregisterForAllEvents(this);
			}
		}

		void AddImpulse(KoreographyEvent evt)
		{
            // Add impulse by overriding the Vertical component of the Velocity.
            if (player.allowTurn == true)
            {
				player.Turn();
            }
		}
	}
}