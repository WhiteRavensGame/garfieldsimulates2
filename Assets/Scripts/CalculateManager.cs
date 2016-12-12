using UnityEngine;
using System.Collections;
using Google2u;


public class CalculateManager : MonoBehaviour {

	[Header("Game Balancing")]
	public float bossTimeLimit = 30;
	private float bossTimeLeft = 30;

	[Header("Goal")]
	public int stageGoal = 40;
	public bool endAtActionEnd = false;
	public int secsForceEnd = 10000;

	private int stageLevel = 1;
	private int minionsKilled = 0;

	[Header("Player Info/Behavior")]
	[SerializeField]private int tapPerSecond = 8;
	[SerializeField] GameActions[] gameActions;
	private GameActions currentGameAction;
	private int currentGameActionIndex = 0;

	private int ally1Level = 0;
	private float ally1Power = 0;
	private int ally2Level = 0;
	private float ally2Power = 0;
	private int ally3Level = 0;
	private float ally3Power = 0;
	private int garfieldLevel = 1;
	private float garfieldPower;

	private float currentMoney = 0;

	private float currMinionHP;
	private bool isMinion = true;

	private float secsElapsed = 0;

	private bool forceEnd = false;

	[Header("Print Logs")]
	public bool displayStageUp = true;
	public bool displayKillMinion = true;
	public bool displayKillBoss = true;
	public bool displayAllyBought = true;
	public bool displayGarfieldBought = true;
	public bool displayGameActionCompletion = true;

	// Use this for initialization
	void Start () {
		Simulate();
	}
	
	// Update is called once per frame
	void Update () {
		//testing to see sourcetree works
	}

	private void Init()
	{
		currentGameActionIndex = 0;
		secsElapsed = 0;
		stageLevel = 1;
		minionsKilled = 0;

		ally1Level = 0;
		ally1Power = 0;
		ally2Level = 0;
		ally2Power = 0;
		ally3Level = 0;
		ally3Power = 0;
		garfieldLevel = 1;
		AllyStatsRow meh = AllyStats.Instance.GetRow("ID_0");
		garfieldPower = meh._garfieldAttack;

		currentMoney = 0;

		StageStatsRow currStage = StageStats.Instance.GetRow("ID_0");
		currMinionHP = currStage._MinionHP;

		isMinion = true;
		forceEnd = false;

		if(gameActions.Length > 0)
			currentGameAction = gameActions[0];
		else
			currentGameAction = null;
	}


	public void Simulate()
	{
		//Initialization
		bool over = false;
		Init();

		while(stageLevel < stageGoal && !forceEnd)
		{
			secsElapsed += 1;
			//Process Time Limits
			if(!isMinion)
			{
				bossTimeLeft -= 1;
				if(bossTimeLeft <= 0)
				{
					ProcessBossFail();
				}
			}

			//Process damaging of Minion
			float damage = (tapPerSecond * garfieldPower) + ally1Power + ally2Power + ally3Power;
			currMinionHP -= damage;
			//print((tapPerSecond * garfieldPower) + "," + ally1Power + "," + ally2Power + "," + ally3Power + ", HP LEFT: " + currMinionHP);
			if(currMinionHP <= 0 && isMinion)
				ProcessKilledMinion();
			else if(currMinionHP <= 0 && !isMinion)
				ProcessKilledBoss();
			
			//Decide what to do next
			//1 - Buy whatever is affordable if no required action anymore.
			if(currentGameAction == null)
			{
				BuyAlly(0, garfieldLevel + 1);
				BuyAlly(1, ally1Level + 1);
				BuyAlly(2, ally2Level + 1);
				BuyAlly(3, ally3Level + 1);
			}
			else //2 - Do the current game action required.
			{
				if(currentGameAction.action == Action.BuyTapPower)
					BuyAlly(0, garfieldLevel + 1);
				else if(currentGameAction.action == Action.BuyAlly1)
					BuyAlly(1, ally1Level + 1);
				else if(currentGameAction.action == Action.BuyAlly2)
					BuyAlly(2, ally2Level + 1);
				else if(currentGameAction.action == Action.BuyAlly3)
					BuyAlly(3, ally3Level + 1);

				CheckActionCompletion();
			}

			if(secsForceEnd < secsElapsed)
			{
				print("Simulation ended, due to " + secsElapsed + " seconds elapsing...");
				forceEnd = true;
			}
			
		}

		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;

		Debug.Log("<b>===== SIMULATION COMPLETE. Time took: " + displayHr + "h " + displayMins + "m " + displaySecs + "s =====</b>");
	}

	private void CheckActionCompletion()
	{
		if(currentGameAction == null)
			return;

		bool completed = false;
		if(currentGameAction.action == Action.BuyTapPower && garfieldLevel >= currentGameAction.targetGoal 
			|| currentGameAction.action == Action.BuyAlly1 && ally1Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly2 && ally2Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly3 && ally3Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.ReachStageNumber && stageLevel >= currentGameAction.targetGoal)
			completed = true;

		if(currentGameAction.action == Action.SetTapPerSecond)
		{
			tapPerSecond = currentGameAction.targetGoal;
			completed = true;
		}
		//Move to next action if the previous is completed (and check if all are completed)

		if(completed && (currentGameActionIndex + 1) >= gameActions.Length )
		{
			currentGameAction = null;
			currentGameActionIndex += 1;
			if(displayGameActionCompletion) Debug.Log("=== ALL GAME ACTIONS DONE! Back to default levelling strategy ===");
			if(endAtActionEnd)
				forceEnd = true;
		}
		else if(completed)
		{
			currentGameActionIndex += 1;
			currentGameAction = gameActions[currentGameActionIndex];
			if(displayGameActionCompletion) Debug.Log("Game action completed! Next Target: " + currentGameAction.action + ", " + currentGameAction.targetGoal);
		}	

	}

	public void SpawnNewMinion()
	{
		//currMinionHP = StageStats.Instance.GetRow("");
		StageStatsRow currStage = StageStats.Instance.GetRow("ID_"+(stageLevel-1));
		currMinionHP = currStage._MinionHP;
		isMinion = true;
	}
	private void SpawnNewBoss()
	{
		StageStatsRow currStage = StageStats.Instance.GetRow("ID_"+(stageLevel-1));
		currMinionHP = currStage._BossHP;
		isMinion = false;
		bossTimeLeft = bossTimeLimit;
	}
	private void ProcessBossFail()
	{
		minionsKilled = 0;
		bossTimeLeft = bossTimeLimit;
		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;
		if(displayKillBoss) Debug.Log("Level " + stageLevel + " Boss didn't die, restarting stage! Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		SpawnNewMinion();

	}
	private void ProcessKilledMinion() 
	{
		minionsKilled += 1;
		currentMoney += StageStats.Instance.GetRow("ID_"+(stageLevel-1))._MinionGold;

		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;
		if(displayKillMinion) Debug.Log("KILLED MINION " + minionsKilled + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		if(minionsKilled >= 10)
			SpawnNewBoss();
		else
		{
			SpawnNewMinion();
		}
	}
	private void ProcessKilledBoss()
	{
		minionsKilled = 0;
		currentMoney += StageStats.Instance.GetRow("ID_"+(stageLevel-1))._BossGold;
		stageLevel += 1;
		bossTimeLeft = bossTimeLimit;

		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;
		if(displayKillBoss) Debug.Log("KILLED LEVEL " + (stageLevel-1) + " BOSS! Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");
		if(displayStageUp) Debug.Log("<b>STAGE UP! Entering Stage " + stageLevel + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s</b>");
		SpawnNewMinion();
	}


	public float GetAllyAttackByLevel(int allyId, int level)
	{
		if(level == 0)
			return 0;

		AllyStatsRow meh = AllyStats.Instance.GetRow("ID_"+(level-1));
		if(allyId == 1)
			return meh._ally1Damage;
		else if(allyId == 2)
			return meh._ally2Damage;
		else if(allyId == 3)
			return meh._ally3Damage;
		else 
			return -1; // ERROR
	}

	public void BuyAlly(int allyId, int targetLevel)
	{
		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;

		AllyStatsRow meh = AllyStats.Instance.GetRow("ID_" + (targetLevel-1));
		if(allyId == 1 && meh._ally1Cost <= currentMoney)
		{
			currentMoney -= meh._ally1Cost;
			ally1Level += 1;
			ally1Power = meh._ally1Damage;
			if(displayAllyBought)
				Debug.Log("Ally 1 LEVEL UP! Level: " + ally1Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");
		}
		else if(allyId == 2 && meh._ally2Cost <= currentMoney)
		{
			currentMoney -= meh._ally2Cost;
			ally2Level += 1;
			ally2Power = meh._ally2Damage;
			//Debug.Log("Ally 2 LEVEL UP! Level: " + ally2Level + " , Damage: " + Mathf.Round(ally2Power));
			if(displayAllyBought)
				Debug.Log("Ally 2 LEVEL UP! Level: " + ally2Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 3 && meh._ally3Cost <= currentMoney)
		{
			currentMoney -= meh._ally3Cost;
			ally3Level += 1;
			ally3Power = meh._ally3Damage;
			if(displayAllyBought)
				Debug.Log("Ally 3 LEVEL UP! Level: " + ally3Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");
		}
		else if(allyId == 0 && meh._garfieldCost <= currentMoney)
		{
			currentMoney -= meh._garfieldCost;
			garfieldLevel += 1;
			garfieldPower = meh._garfieldAttack;
			if(displayAllyBought)
				Debug.Log("Garfield LEVEL UP! Level: " + garfieldLevel + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");
		}
	}

	[System.Serializable]
	public class GameActions
	{
		public int targetGoal;
		public Action action;

	}

	public enum Action
	{
		BuyTapPower,
		BuyAlly1,
		BuyAlly2,
		BuyAlly3,
		SetTapPerSecond,
		ReachStageNumber
	}


}
