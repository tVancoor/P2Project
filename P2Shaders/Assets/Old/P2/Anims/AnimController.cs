using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimController : MonoBehaviour
{
	public Animator anim;
	// Iddle Particle
	public ParticleSystem starVeil;
	//public Transform hips;
	
	// Jump Attack Particle
	public ParticleSystem jumpStarter;
	public ParticleSystem starJump;
	public ParticleSystem starLeap;
	// Jump Attack Landing Particles
	public ParticleSystem starCrush1;
	public ParticleSystem starCrush2;
	public ParticleSystem starCrush3;
	
	// Taunt Particles
	public ParticleSystem starStomp;
	public ParticleSystem starBurst;
	public ParticleSystem starSpiral;
	
	void Awake()
	{		
		anim = GetComponent<Animator>();		
		
		starVeil = transform.Find("Starveil").GetComponent<ParticleSystem>();		
		
		jumpStarter = transform.Find("StarjumpStarter").GetComponent<ParticleSystem>();
		starJump = transform.Find("StarJump").GetComponent<ParticleSystem>();
		//hips = doll.transform.Find("hips");
		//if (hips != null{
		starLeap = transform.Find("Control_ALL/father/hips/StarLeap").GetComponent<ParticleSystem>();
		//}
		starCrush1 = transform.Find("StarCrush").GetComponent<ParticleSystem>();
		starCrush2 = transform.Find("StarCrush v2").GetComponent<ParticleSystem>();
		starCrush3 = transform.Find("StarCrush v3").GetComponent<ParticleSystem>();
		
		starStomp = transform.Find("StarStomp").GetComponent<ParticleSystem>();
		starBurst = transform.Find("StarBurst").GetComponent<ParticleSystem>();
		starSpiral = transform.Find("StarSpiral").GetComponent<ParticleSystem>();
	}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {	
        if (Input.GetKeyDown(KeyCode.A)){
			anim.SetTrigger("AttackTrigger");
			starVeil.Stop();
		}
		if (Input.GetKeyDown(KeyCode.T)){
			anim.SetTrigger("TauntTrigger");
			starVeil.Stop();
		}
    }
	// Calls in Iddle
	public void IddlePActive(){		
		starVeil.Play();
	}
	//Calls in JumpAttack
	public void JumpStartTrigger(){		
		jumpStarter.Play();
	}
	public void StarJumpTrigger(){		
		starJump.Play();
	}
	public void StarLeapTrigger(){		
		starLeap.Play();
	}
	public void StarCrushV1Trigger(){		
		starCrush1.Play();
	}
	public void StarCrushV2Trigger(){		
		starCrush2.Play();
	}
	public void StarCrushV3Trigger(){		
		starCrush3.Play();
	}
	//Calls in Taunt
	public void StarStompTrigger(){		
		starStomp.Play();
	}
	public void StarBurstTrigger(){		
		starBurst.Play();
	}
	public void StarSpiralTrigger(){		
		starSpiral.Play();
	}
}
