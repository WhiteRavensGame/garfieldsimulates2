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
	private int ally4Level = 0;
	private float ally4Power = 0;
	private int ally5Level = 0;
	private float ally5Power = 0;
	private int ally6Level = 0;
	private float ally6Power = 0;
	private int ally7Level = 0;
	private float ally7Power = 0;
	private int ally8Level = 0;
	private float ally8Power = 0;
	private int ally9Level = 0;
	private float ally9Power = 0;
	private int ally10Level = 0;
	private float ally10Power = 0;
	private int ally11Level = 0;
	private float ally11Power = 0;
	private int ally12Level = 0;
	private float ally12Power = 0;
	private int ally13Level = 0;
	private float ally13Power = 0;
	private int ally14Level = 0;
	private float ally14Power = 0;
	private int ally15Level = 0;
	private float ally15Power = 0;
	private int ally16Level = 0;
	private float ally16Power = 0;
	private int ally17Level = 0;
	private float ally17Power = 0;
	private int ally18Level = 0;
	private float ally18Power = 0;
	private int ally19Level = 0;
	private float ally19Power = 0;
	private int ally20Level = 0;
	private float ally20Power = 0;
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

	private int bossFailCount = 0;

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
		ally4Level = 0;
		ally4Power = 0;
		ally5Level = 0;
		ally5Power = 0;
		ally6Level = 0;
		ally6Power = 0;
		ally7Level = 0;
		ally7Power = 0;
		ally8Level = 0;
		ally8Power = 0;
		ally9Level = 0;
		ally9Power = 0;
		ally10Level = 0;
		ally10Power = 0;
		ally11Level = 0;
		ally11Power = 0;
		ally12Level = 0;
		ally12Power = 0;
		ally13Level = 0;
		ally13Power = 0;
		ally14Level = 0;
		ally14Power = 0;
		ally15Level = 0;
		ally15Power = 0;
		ally16Level = 0;
		ally16Power = 0;
		ally17Level = 0;
		ally17Power = 0;
		ally18Level = 0;
		ally18Power = 0;
		ally19Level = 0;
		ally19Power = 0;
		ally20Level = 0;
		ally20Power = 0;
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

			//Damage  is defined twice in this file
			float damage = ((tapPerSecond * garfieldPower) + ally1Power + ally2Power + ally3Power + ally4Power + ally5Power + ally6Power + ally7Power + ally8Power  + ally9Power  + ally10Power  + ally11Power  + ally12Power  + ally13Power  + ally14Power  + ally15Power  + ally16Power  + ally17Power  + ally18Power  + ally19Power  + ally20Power) * 2f;
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
				BuyAlly(4, ally4Level + 1);
				BuyAlly(5, ally5Level + 1);
				BuyAlly(6, ally6Level + 1);
				BuyAlly(7, ally7Level + 1);
				BuyAlly(8, ally8Level + 1);
				BuyAlly(9, ally9Level + 1);
				BuyAlly(10, ally10Level + 1);
				BuyAlly(11, ally11Level + 1);
				BuyAlly(12, ally12Level + 1);
				BuyAlly(13, ally13Level + 1);
				BuyAlly(14, ally14Level + 1);
				BuyAlly(15, ally15Level + 1);
				BuyAlly(16, ally16Level + 1);
				BuyAlly(17, ally17Level + 1);
				BuyAlly(18, ally18Level + 1);
				BuyAlly(19, ally19Level + 1);
				BuyAlly(20, ally20Level + 1);
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
				else if(currentGameAction.action == Action.BuyAlly4)
					BuyAlly(4, ally4Level + 1);
				else if(currentGameAction.action == Action.BuyAlly5)
					BuyAlly(5, ally5Level + 1);
				else if(currentGameAction.action == Action.BuyAlly6)
					BuyAlly(6, ally6Level + 1);
				else if(currentGameAction.action == Action.BuyAlly7)
					BuyAlly(7, ally7Level + 1);
				else if(currentGameAction.action == Action.BuyAlly8)
					BuyAlly(8, ally8Level + 1);
				else if(currentGameAction.action == Action.BuyAlly9)
					BuyAlly(9, ally9Level + 1);
				else if(currentGameAction.action == Action.BuyAlly10)
					BuyAlly(10, ally10Level + 1);
				else if(currentGameAction.action == Action.BuyAlly11)
					BuyAlly(11, ally11Level + 1);
				else if(currentGameAction.action == Action.BuyAlly12)
					BuyAlly(12, ally12Level + 1);
				else if(currentGameAction.action == Action.BuyAlly13)
					BuyAlly(13, ally13Level + 1);
				else if(currentGameAction.action == Action.BuyAlly14)
					BuyAlly(14, ally14Level + 1);
				else if(currentGameAction.action == Action.BuyAlly15)
					BuyAlly(15, ally15Level + 1);
				else if(currentGameAction.action == Action.BuyAlly16)
					BuyAlly(16, ally16Level + 1);
				else if(currentGameAction.action == Action.BuyAlly17)
					BuyAlly(17, ally17Level + 1);
				else if(currentGameAction.action == Action.BuyAlly18)
					BuyAlly(18, ally18Level + 1);
				else if(currentGameAction.action == Action.BuyAlly19)
					BuyAlly(19, ally19Level + 1);
				else if(currentGameAction.action == Action.BuyAlly20)
					BuyAlly(20, ally20Level + 1);

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
			|| currentGameAction.action == Action.BuyAlly4 && ally4Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly5 && ally5Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly6 && ally6Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly7 && ally7Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly8 && ally8Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly9 && ally9Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly10 && ally10Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly11 && ally11Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly12 && ally12Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly13 && ally13Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly14 && ally14Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly15 && ally15Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly16 && ally16Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly17 && ally17Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly18 && ally18Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly19 && ally19Level >= currentGameAction.targetGoal
			|| currentGameAction.action == Action.BuyAlly20 && ally20Level >= currentGameAction.targetGoal
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
		float damage = ((tapPerSecond * garfieldPower) + ally1Power + ally2Power + ally3Power + ally4Power + ally5Power + ally6Power + ally7Power + ally8Power  + ally9Power  + ally10Power  + ally11Power  + ally12Power  + ally13Power  + ally14Power  + ally15Power  + ally16Power  + ally17Power  + ally18Power  + ally19Power  + ally20Power) * 2f;

		StageStatsRow currStage = StageStats.Instance.GetRow("ID_"+(stageLevel-1));
		currMinionHP = currStage._BossHP;
		isMinion = false;
		bossTimeLeft = bossTimeLimit;

		Debug.Log("Boss HP: " + currMinionHP);
		Debug.Log("Current DMG: " + damage);
	}
	private void ProcessBossFail()
	{
		minionsKilled = 0;
		bossTimeLeft = bossTimeLimit;
		int displayHr = Mathf.RoundToInt(secsElapsed) / 3600;
		int displayMins = Mathf.RoundToInt(secsElapsed) / 60 % 60;
		int displaySecs = Mathf.RoundToInt(secsElapsed) % 60;
		if(displayKillBoss) Debug.Log("Level " + stageLevel + " Boss didn't die, restarting stage! Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");
		if (displayKillBoss) bossFailCount++;
		if (displayKillBoss) Debug.Log ("Bosses Failed = " + bossFailCount);

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
		if (displayStageUp) Debug.Log("Minion HP: " + currMinionHP);
		if (displayStageUp) Debug.Log("Minion Gold: " + StageStats.Instance.GetRow("ID_"+(stageLevel-1))._MinionGold);

		if (displayStageUp) bossFailCount = 0;
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
		else if(allyId == 4)
			return meh._ally4Damage;
		else if(allyId == 5)
			return meh._ally5Damage;
		else if(allyId == 6)
			return meh._ally6Damage;
		else if(allyId == 7)
			return meh._ally7Damage;
		else if(allyId == 8)
			return meh._ally8Damage;
		else if(allyId == 9)
			return meh._ally9Damage;
		else if(allyId == 10)
			return meh._ally10Damage;
		else if(allyId == 11)
			return meh._ally11Damage;
		else if(allyId == 12)
			return meh._ally12Damage;
		else if(allyId == 13)
			return meh._ally13Damage;
		else if(allyId == 14)
			return meh._ally14Damage;
		else if(allyId == 15)
			return meh._ally15Damage;
		else if(allyId == 16)
			return meh._ally16Damage;
		else if(allyId == 17)
			return meh._ally17Damage;
		else if(allyId == 18)
			return meh._ally18Damage;
		else if(allyId == 19)
			return meh._ally19Damage;
		else if(allyId == 20)
			return meh._ally20Damage;
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
		else if(allyId == 4 && meh._ally4Cost <= currentMoney)
		{
			currentMoney -= meh._ally4Cost;
			ally4Level += 1;
			ally4Power = meh._ally4Damage;
			//Debug.Log("Ally 4 LEVEL UP! Level: " + ally4Level + " , Damage: " + Mathf.Round(ally4Power));
			if(displayAllyBought)
				Debug.Log("Ally 4 LEVEL UP! Level: " + ally4Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 5 && meh._ally5Cost <= currentMoney)
		{
			currentMoney -= meh._ally5Cost;
			ally5Level += 1;
			ally5Power = meh._ally5Damage;
			//Debug.Log("Ally 5 LEVEL UP! Level: " + ally5Level + " , Damage: " + Mathf.Round(ally5Power));
			if(displayAllyBought)
				Debug.Log("Ally 5 LEVEL UP! Level: " + ally5Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 6 && meh._ally6Cost <= currentMoney)
		{
			currentMoney -= meh._ally6Cost;
			ally6Level += 1;
			ally6Power = meh._ally6Damage;
			//Debug.Log("Ally 6 LEVEL UP! Level: " + ally6Level + " , Damage: " + Mathf.Round(ally6Power));
			if(displayAllyBought)
				Debug.Log("Ally 6 LEVEL UP! Level: " + ally6Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 7 && meh._ally7Cost <= currentMoney)
		{
			currentMoney -= meh._ally7Cost;
			ally7Level += 1;
			ally7Power = meh._ally7Damage;
			//Debug.Log("Ally 7 LEVEL UP! Level: " + ally7Level + " , Damage: " + Mathf.Round(ally7Power));
			if(displayAllyBought)
				Debug.Log("Ally 7 LEVEL UP! Level: " + ally7Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 8 && meh._ally8Cost <= currentMoney)
		{
			currentMoney -= meh._ally8Cost;
			ally8Level += 1;
			ally8Power = meh._ally8Damage;
			//Debug.Log("Ally 8 LEVEL UP! Level: " + ally8Level + " , Damage: " + Mathf.Round(ally8Power));
			if(displayAllyBought)
				Debug.Log("Ally 8 LEVEL UP! Level: " + ally8Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 9 && meh._ally9Cost <= currentMoney)
		{
			currentMoney -= meh._ally9Cost;
			ally9Level += 1;
			ally9Power = meh._ally9Damage;
			//Debug.Log("Ally 9 LEVEL UP! Level: " + ally9Level + " , Damage: " + Mathf.Round(ally9Power));
			if(displayAllyBought)
				Debug.Log("Ally 9 LEVEL UP! Level: " + ally9Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 10 && meh._ally10Cost <= currentMoney)
		{
			currentMoney -= meh._ally10Cost;
			ally10Level += 1;
			ally10Power = meh._ally10Damage;
			//Debug.Log("Ally 10 LEVEL UP! Level: " + ally10Level + " , Damage: " + Mathf.Round(ally10Power));
			if(displayAllyBought)
				Debug.Log("Ally 10 LEVEL UP! Level: " + ally10Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 11 && meh._ally11Cost <= currentMoney)
		{
			currentMoney -= meh._ally11Cost;
			ally11Level += 1;
			ally11Power = meh._ally11Damage;
			//Debug.Log("Ally 11 LEVEL UP! Level: " + ally11Level + " , Damage: " + Mathf.Round(ally11Power));
			if(displayAllyBought)
				Debug.Log("Ally 11 LEVEL UP! Level: " + ally11Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 12 && meh._ally12Cost <= currentMoney)
		{
			currentMoney -= meh._ally12Cost;
			ally12Level += 1;
			ally12Power = meh._ally12Damage;
			//Debug.Log("Ally 12 LEVEL UP! Level: " + ally12Level + " , Damage: " + Mathf.Round(ally12Power));
			if(displayAllyBought)
				Debug.Log("Ally 12 LEVEL UP! Level: " + ally12Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 13 && meh._ally13Cost <= currentMoney)
		{
			currentMoney -= meh._ally13Cost;
			ally13Level += 1;
			ally13Power = meh._ally13Damage;
			//Debug.Log("Ally 13 LEVEL UP! Level: " + ally13Level + " , Damage: " + Mathf.Round(ally13Power));
			if(displayAllyBought)
				Debug.Log("Ally 13 LEVEL UP! Level: " + ally13Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 14 && meh._ally14Cost <= currentMoney)
		{
			currentMoney -= meh._ally14Cost;
			ally14Level += 1;
			ally14Power = meh._ally14Damage;
			//Debug.Log("Ally 14 LEVEL UP! Level: " + ally14Level + " , Damage: " + Mathf.Round(ally14Power));
			if(displayAllyBought)
				Debug.Log("Ally 14 LEVEL UP! Level: " + ally14Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 15 && meh._ally15Cost <= currentMoney)
		{
			currentMoney -= meh._ally15Cost;
			ally15Level += 1;
			ally15Power = meh._ally15Damage;
			//Debug.Log("Ally 15 LEVEL UP! Level: " + ally15Level + " , Damage: " + Mathf.Round(ally15Power));
			if(displayAllyBought)
				Debug.Log("Ally 15 LEVEL UP! Level: " + ally15Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 16 && meh._ally16Cost <= currentMoney)
		{
			currentMoney -= meh._ally16Cost;
			ally16Level += 1;
			ally16Power = meh._ally16Damage;
			//Debug.Log("Ally 16 LEVEL UP! Level: " + ally16Level + " , Damage: " + Mathf.Round(ally16Power));
			if(displayAllyBought)
				Debug.Log("Ally 16 LEVEL UP! Level: " + ally16Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 17 && meh._ally17Cost <= currentMoney)
		{
			currentMoney -= meh._ally17Cost;
			ally17Level += 1;
			ally17Power = meh._ally17Damage;
			//Debug.Log("Ally 17 LEVEL UP! Level: " + ally17Level + " , Damage: " + Mathf.Round(ally17Power));
			if(displayAllyBought)
				Debug.Log("Ally 17 LEVEL UP! Level: " + ally17Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 18 && meh._ally18Cost <= currentMoney)
		{
			currentMoney -= meh._ally18Cost;
			ally18Level += 1;
			ally18Power = meh._ally18Damage;
			//Debug.Log("Ally 18 LEVEL UP! Level: " + ally18Level + " , Damage: " + Mathf.Round(ally18Power));
			if(displayAllyBought)
				Debug.Log("Ally 18 LEVEL UP! Level: " + ally18Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 19 && meh._ally19Cost <= currentMoney)
		{
			currentMoney -= meh._ally19Cost;
			ally19Level += 1;
			ally19Power = meh._ally19Damage;
			//Debug.Log("Ally 19 LEVEL UP! Level: " + ally19Level + " , Damage: " + Mathf.Round(ally19Power));
			if(displayAllyBought)
				Debug.Log("Ally 19 LEVEL UP! Level: " + ally19Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

		}
		else if(allyId == 20 && meh._ally20Cost <= currentMoney)
		{
			currentMoney -= meh._ally20Cost;
			ally20Level += 1;
			ally20Power = meh._ally20Damage;
			//Debug.Log("Ally 20 LEVEL UP! Level: " + ally20Level + " , Damage: " + Mathf.Round(ally20Power));
			if(displayAllyBought)
				Debug.Log("Ally 20 LEVEL UP! Level: " + ally20Level + ", Curr Time: " + displayHr + "h " + displayMins + "m " + displaySecs + "s");

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
		BuyAlly4,
		BuyAlly5,
		BuyAlly6,
		BuyAlly7,
		BuyAlly8,
		BuyAlly9,
		BuyAlly10,
		BuyAlly11,
		BuyAlly12,
		BuyAlly13,
		BuyAlly14,
		BuyAlly15,
		BuyAlly16,
		BuyAlly17,
		BuyAlly18,
		BuyAlly19,
		BuyAlly20,
		SetTapPerSecond,
		ReachStageNumber
	}


}
