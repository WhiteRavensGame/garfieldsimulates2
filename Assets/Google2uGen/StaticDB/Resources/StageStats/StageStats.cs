//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class StageStatsRow : IGoogle2uRow
	{
		public float _Stage;
		public float _MinionGold;
		public float _BossGold;
		public float _GoldPerStage;
		public float _Cum_GoldPerStage;
		public float _MinionHP;
		public float _BossHP;
		public StageStatsRow(string __ID, string __Stage, string __MinionGold, string __BossGold, string __GoldPerStage, string __Cum_GoldPerStage, string __MinionHP, string __BossHP) 
		{
			{
			float res;
				if(float.TryParse(__Stage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Stage = res;
				else
					Debug.LogError("Failed To Convert _Stage string: "+ __Stage +" to float");
			}
			{
			float res;
				if(float.TryParse(__MinionGold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MinionGold = res;
				else
					Debug.LogError("Failed To Convert _MinionGold string: "+ __MinionGold +" to float");
			}
			{
			float res;
				if(float.TryParse(__BossGold, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BossGold = res;
				else
					Debug.LogError("Failed To Convert _BossGold string: "+ __BossGold +" to float");
			}
			{
			float res;
				if(float.TryParse(__GoldPerStage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_GoldPerStage = res;
				else
					Debug.LogError("Failed To Convert _GoldPerStage string: "+ __GoldPerStage +" to float");
			}
			{
			float res;
				if(float.TryParse(__Cum_GoldPerStage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_Cum_GoldPerStage = res;
				else
					Debug.LogError("Failed To Convert _Cum_GoldPerStage string: "+ __Cum_GoldPerStage +" to float");
			}
			{
			float res;
				if(float.TryParse(__MinionHP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_MinionHP = res;
				else
					Debug.LogError("Failed To Convert _MinionHP string: "+ __MinionHP +" to float");
			}
			{
			float res;
				if(float.TryParse(__BossHP, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_BossHP = res;
				else
					Debug.LogError("Failed To Convert _BossHP string: "+ __BossHP +" to float");
			}
		}

		public int Length { get { return 7; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _Stage.ToString();
					break;
				case 1:
					ret = _MinionGold.ToString();
					break;
				case 2:
					ret = _BossGold.ToString();
					break;
				case 3:
					ret = _GoldPerStage.ToString();
					break;
				case 4:
					ret = _Cum_GoldPerStage.ToString();
					break;
				case 5:
					ret = _MinionHP.ToString();
					break;
				case 6:
					ret = _BossHP.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "Stage":
					ret = _Stage.ToString();
					break;
				case "MinionGold":
					ret = _MinionGold.ToString();
					break;
				case "BossGold":
					ret = _BossGold.ToString();
					break;
				case "GoldPerStage":
					ret = _GoldPerStage.ToString();
					break;
				case "Cum_GoldPerStage":
					ret = _Cum_GoldPerStage.ToString();
					break;
				case "MinionHP":
					ret = _MinionHP.ToString();
					break;
				case "BossHP":
					ret = _BossHP.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "Stage" + " : " + _Stage.ToString() + "} ";
			ret += "{" + "MinionGold" + " : " + _MinionGold.ToString() + "} ";
			ret += "{" + "BossGold" + " : " + _BossGold.ToString() + "} ";
			ret += "{" + "GoldPerStage" + " : " + _GoldPerStage.ToString() + "} ";
			ret += "{" + "Cum_GoldPerStage" + " : " + _Cum_GoldPerStage.ToString() + "} ";
			ret += "{" + "MinionHP" + " : " + _MinionHP.ToString() + "} ";
			ret += "{" + "BossHP" + " : " + _BossHP.ToString() + "} ";
			return ret;
		}
	}
	public sealed class StageStats : IGoogle2uDB
	{
		public enum rowIds {
			ID_0, ID_1, ID_2, ID_3, ID_4, ID_5, ID_6, ID_7, ID_8, ID_9, ID_10, ID_11, ID_12, ID_13, ID_14, ID_15, ID_16, ID_17
			, ID_18, ID_19, ID_20, ID_21, ID_22, ID_23, ID_24, ID_25, ID_26, ID_27, ID_28, ID_29, ID_30, ID_31, ID_32, ID_33, ID_34, ID_35, ID_36, ID_37
			, ID_38, ID_39, ID_40, ID_41, ID_42, ID_43, ID_44, ID_45, ID_46, ID_47, ID_48, ID_49, ID_50, ID_51, ID_52, ID_53, ID_54, ID_55, ID_56, ID_57
			, ID_58, ID_59, ID_60, ID_61, ID_62, ID_63, ID_64, ID_65, ID_66, ID_67, ID_68, ID_69, ID_70, ID_71, ID_72, ID_73, ID_74, ID_75, ID_76, ID_77
			, ID_78, ID_79, ID_80, ID_81
		};
		public string [] rowNames = {
			"ID_0", "ID_1", "ID_2", "ID_3", "ID_4", "ID_5", "ID_6", "ID_7", "ID_8", "ID_9", "ID_10", "ID_11", "ID_12", "ID_13", "ID_14", "ID_15", "ID_16", "ID_17"
			, "ID_18", "ID_19", "ID_20", "ID_21", "ID_22", "ID_23", "ID_24", "ID_25", "ID_26", "ID_27", "ID_28", "ID_29", "ID_30", "ID_31", "ID_32", "ID_33", "ID_34", "ID_35", "ID_36", "ID_37"
			, "ID_38", "ID_39", "ID_40", "ID_41", "ID_42", "ID_43", "ID_44", "ID_45", "ID_46", "ID_47", "ID_48", "ID_49", "ID_50", "ID_51", "ID_52", "ID_53", "ID_54", "ID_55", "ID_56", "ID_57"
			, "ID_58", "ID_59", "ID_60", "ID_61", "ID_62", "ID_63", "ID_64", "ID_65", "ID_66", "ID_67", "ID_68", "ID_69", "ID_70", "ID_71", "ID_72", "ID_73", "ID_74", "ID_75", "ID_76", "ID_77"
			, "ID_78", "ID_79", "ID_80", "ID_81"
		};
		public System.Collections.Generic.List<StageStatsRow> Rows = new System.Collections.Generic.List<StageStatsRow>();

		public static StageStats Instance
		{
			get { return NestedStageStats.instance; }
		}

		private class NestedStageStats
		{
			static NestedStageStats() { }
			internal static readonly StageStats instance = new StageStats();
		}

		private StageStats()
		{
			Rows.Add( new StageStatsRow("ID_0", "1", "2", "4", "24", "24", "30", "60"));
			Rows.Add( new StageStatsRow("ID_1", "2", "6", "12", "72", "96", "41", "82"));
			Rows.Add( new StageStatsRow("ID_2", "3", "11", "44", "154", "250", "55", "193"));
			Rows.Add( new StageStatsRow("ID_3", "4", "15", "60", "210", "460", "73", "256"));
			Rows.Add( new StageStatsRow("ID_4", "5", "20", "120", "320", "780", "98", "490"));
			Rows.Add( new StageStatsRow("ID_5", "6", "25", "50", "300", "1080", "132", "264"));
			Rows.Add( new StageStatsRow("ID_6", "7", "30", "60", "360", "1440", "177", "354"));
			Rows.Add( new StageStatsRow("ID_7", "8", "36", "144", "504", "1944", "237", "830"));
			Rows.Add( new StageStatsRow("ID_8", "9", "42", "168", "588", "2532", "318", "1113"));
			Rows.Add( new StageStatsRow("ID_9", "10", "49", "490", "980", "3512", "427", "3416"));
			Rows.Add( new StageStatsRow("ID_10", "11", "57", "114", "684", "4196", "573", "1146"));
			Rows.Add( new StageStatsRow("ID_11", "12", "66", "132", "792", "4988", "770", "1540"));
			Rows.Add( new StageStatsRow("ID_12", "13", "78", "312", "1092", "6080", "1034", "3619"));
			Rows.Add( new StageStatsRow("ID_13", "14", "92", "368", "1288", "7368", "1389", "4862"));
			Rows.Add( new StageStatsRow("ID_14", "15", "111", "666", "1776", "9144", "1865", "9325"));
			Rows.Add( new StageStatsRow("ID_15", "16", "134", "268", "1608", "10752", "2504", "5008"));
			Rows.Add( new StageStatsRow("ID_16", "17", "165", "330", "1980", "12732", "3363", "6726"));
			Rows.Add( new StageStatsRow("ID_17", "18", "205", "820", "2870", "15602", "4517", "15810"));
			Rows.Add( new StageStatsRow("ID_18", "19", "258", "1032", "3612", "19214", "6066", "21231"));
			Rows.Add( new StageStatsRow("ID_19", "20", "330", "3300", "6600", "25814", "8147", "65176"));
			Rows.Add( new StageStatsRow("ID_20", "21", "426", "852", "5112", "30926", "10942", "21884"));
			Rows.Add( new StageStatsRow("ID_21", "22", "555", "1110", "6660", "37586", "14696", "29392"));
			Rows.Add( new StageStatsRow("ID_22", "23", "731", "2924", "10234", "47820", "19737", "69080"));
			Rows.Add( new StageStatsRow("ID_23", "24", "969", "3876", "13566", "61386", "26508", "92778"));
			Rows.Add( new StageStatsRow("ID_24", "25", "1292", "7752", "20672", "82058", "35602", "178010"));
			Rows.Add( new StageStatsRow("ID_25", "26", "1732", "3464", "20784", "102842", "173779", "347558"));
			Rows.Add( new StageStatsRow("ID_26", "27", "2332", "4664", "27984", "130826", "245760", "491520"));
			Rows.Add( new StageStatsRow("ID_27", "28", "3148", "12592", "44072", "174898", "347558", "1216453"));
			Rows.Add( new StageStatsRow("ID_28", "29", "4261", "17044", "59654", "234552", "491520", "1720320"));
			Rows.Add( new StageStatsRow("ID_29", "30", "5779", "57790", "115580", "350132", "695115", "5560920"));
			Rows.Add( new StageStatsRow("ID_30", "31", "7850", "15700", "94200", "444332", "983040", "1966080"));
			Rows.Add( new StageStatsRow("ID_31", "32", "10675", "21350", "128100", "572432", "1390229", "2780458"));
			Rows.Add( new StageStatsRow("ID_32", "33", "14529", "58116", "203406", "775838", "1966080", "6881280"));
			Rows.Add( new StageStatsRow("ID_33", "34", "19789", "79156", "277046", "1052884", "2780458", "9731603"));
			Rows.Add( new StageStatsRow("ID_34", "35", "26967", "161802", "431472", "1484356", "3932160", "19660800"));
			Rows.Add( new StageStatsRow("ID_35", "36", "36764", "73528", "441168", "1925524", "5560915", "11121830"));
			Rows.Add( new StageStatsRow("ID_36", "37", "50135", "100270", "601620", "2527144", "7864320", "15728640"));
			Rows.Add( new StageStatsRow("ID_37", "38", "68385", "273540", "957390", "3484534", "11121829", "38926402"));
			Rows.Add( new StageStatsRow("ID_38", "39", "93295", "373180", "1306130", "4790664", "15728640", "55050240"));
			Rows.Add( new StageStatsRow("ID_39", "40", "127296", "1272960", "2545920", "7336584", "22243657", "177949256"));
			Rows.Add( new StageStatsRow("ID_40", "41", "173705", "347410", "2084460", "9421044", "31457280", "62914560"));
			Rows.Add( new StageStatsRow("ID_41", "42", "237053", "474106", "2844636", "12265680", "44487313", "88974626"));
			Rows.Add( new StageStatsRow("ID_42", "43", "323520", "1294080", "4529280", "16794960", "62914560", "220200960"));
			Rows.Add( new StageStatsRow("ID_43", "44", "441547", "1766188", "6181658", "22976618", "88974625", "311411188"));
			Rows.Add( new StageStatsRow("ID_44", "45", "602653", "3615918", "9642448", "32619066", "125829120", "629145600"));
			Rows.Add( new StageStatsRow("ID_45", "46", "822560", "1645120", "9870720", "42489786", "265440575", "530881150"));
			Rows.Add( new StageStatsRow("ID_46", "47", "1122733", "2245466", "13472796", "55962582", "378740428", "757480856"));
			Rows.Add( new StageStatsRow("ID_47", "48", "1532466", "6129864", "21454524", "77417106", "540400849", "1891402972"));
			Rows.Add( new StageStatsRow("ID_48", "49", "2091752", "8367008", "29284528", "106701634", "771063915", "2698723703"));
			Rows.Add( new StageStatsRow("ID_49", "50", "2855174", "28551740", "57103480", "163805114", "1100182508", "8801460064"));
			Rows.Add( new StageStatsRow("ID_50", "51", "3897245", "7794490", "46766940", "210572054", "1569781087", "3139562174"));
			Rows.Add( new StageStatsRow("ID_51", "52", "5319670", "10639340", "63836040", "274408094", "2239821706", "4479643412"));
			Rows.Add( new StageStatsRow("ID_52", "53", "7261278", "29045112", "101657892", "376065986", "3195860440", "11185511540"));
			Rows.Add( new StageStatsRow("ID_53", "54", "9911572", "39646288", "138762008", "514827994", "4559971860", "15959901510"));
			Rows.Add( new StageStatsRow("ID_54", "55", "13529222", "81175332", "216467552", "731295546", "6506336479", "32531682395"));
			Rows.Add( new StageStatsRow("ID_55", "56", "18467312", "36934624", "221607744", "952903290", "9283481494", "18566962988"));
			Rows.Add( new StageStatsRow("ID_56", "57", "25207804", "50415608", "302493648", "1255396938", "13246014703", "26492029406"));
			Rows.Add( new StageStatsRow("ID_57", "58", "34408575", "137634300", "481720050", "1737116988", "18899903621", "66149662674"));
			Rows.Add( new StageStatsRow("ID_58", "59", "46967624", "187870496", "657546736", "2394663724", "26967081413", "94384784946"));
			Rows.Add( new StageStatsRow("ID_59", "60", "64110726", "641107260", "1282214520", "3676878244", "38477629013", "307821032104"));
			Rows.Add( new StageStatsRow("ID_60", "61", "87511058", "175022116", "1050132696", "4727010940", "54901303995", "109802607990"));
			Rows.Add( new StageStatsRow("ID_61", "62", "119452511", "238905022", "1433430132", "6160441072", "78335210812", "156670421624"));
			Rows.Add( new StageStatsRow("ID_62", "63", "163052591", "652210364", "2282736274", "8443177346", "111771575655", "391200514793"));
			Rows.Add( new StageStatsRow("ID_63", "64", "222566700", "890266800", "3115933800", "11559111146", "159479817504", "558179361264"));
			Rows.Add( new StageStatsRow("ID_64", "65", "303803457", "1822820742", "4860855312", "16419966458", "227551701244", "1137758506220"));
			Rows.Add( new StageStatsRow("ID_65", "66", "414691629", "829383258", "4976299548", "21396266006", "596370075240", "1192740150480"));
			Rows.Add( new StageStatsRow("ID_66", "67", "566053983", "1132107966", "6792647796", "28188913802", "858919935956", "1717839871912"));
			Rows.Add( new StageStatsRow("ID_67", "68", "772663593", "3090654372", "10817290302", "39006204104", "1237056463783", "4329697623241"));
			Rows.Add( new StageStatsRow("ID_68", "69", "1054685710", "4218742840", "14765599940", "53771804044", "1781666288704", "6235832010464"));
			Rows.Add( new StageStatsRow("ID_69", "70", "1439645899", "14396458990", "28792917980", "82564722024", "2566038703355", "20528309626840"));
			Rows.Add( new StageStatsRow("ID_70", "71", "1965116555", "3930233110", "23581398660", "106146120684", "3695728357697", "7391456715394"));
			Rows.Add( new StageStatsRow("ID_71", "72", "2682383999", "5364767998", "32188607988", "138334728672", "5322759970857", "10645519941714"));
			Rows.Add( new StageStatsRow("ID_72", "73", "3661454058", "14645816232", "51260356812", "189595085484", "7666086618176", "26831303163616"));
			Rows.Add( new StageStatsRow("ID_73", "74", "4997884687", "19991538748", "69970385618", "259565471102", "11041054708300", "38643691479050"));
			Rows.Add( new StageStatsRow("ID_74", "75", "6822112495", "40932674970", "109153799920", "368719271022", "15901840814405", "79509204072025"));
			Rows.Add( new StageStatsRow("ID_75", "76", "9312183451", "18624366902", "111746201412", "480465472434", "22902571173439", "45805142346878"));
			Rows.Add( new StageStatsRow("ID_76", "77", "12711130304", "25422260608", "152533563648", "632999036082", "32985348833280", "65970697666560"));
			Rows.Add( new StageStatsRow("ID_77", "78", "17350692758", "69402771032", "242909698612", "875908734694", "47507034446640", "166274620563240"));
			Rows.Add( new StageStatsRow("ID_78", "79", "23683695506", "94734782024", "331571737084", "1207480471778", "68421841870508", "239476446546778"));
			Rows.Add( new StageStatsRow("ID_79", "80", "32328244255", "323282442550", "646564885100", "1854045356878", "98544320846023", "788354566768184"));
			Rows.Add( new StageStatsRow("ID_80", "81", "44128053296", "88256106592", "529536639552", "2383581996430", "141928116892593", "283856233785186"));
			Rows.Add( new StageStatsRow("ID_81", "82", "60234792636", "120469585272", "722817511632", "3106399508062", "204411478933953", "408822957867906"));
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public StageStatsRow GetRow(rowIds in_RowID)
		{
			StageStatsRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public StageStatsRow GetRow(string in_RowString)
		{
			StageStatsRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
