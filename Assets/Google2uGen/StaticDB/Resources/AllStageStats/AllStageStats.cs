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
	public class AllStageStatsRow : IGoogle2uRow
	{
		public float _Stage;
		public float _MinionGold;
		public float _BossGold;
		public float _GoldPerStage;
		public float _Cum_GoldPerStage;
		public float _MinionHP;
		public float _BossHP;
		public AllStageStatsRow(string __ID, string __Stage, string __MinionGold, string __BossGold, string __GoldPerStage, string __Cum_GoldPerStage, string __MinionHP, string __BossHP) 
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
	public sealed class AllStageStats : IGoogle2uDB
	{
		public enum rowIds {
			ID_0, ID_1, ID_2, ID_3, ID_4, ID_5, ID_6, ID_7, ID_8, ID_9, ID_10, ID_11, ID_12, ID_13, ID_14, ID_15, ID_16, ID_17
			, ID_18, ID_19, ID_20, ID_21, ID_22, ID_23, ID_24, ID_25, ID_26, ID_27, ID_28, ID_29, ID_30, ID_31, ID_32, ID_33, ID_34, ID_35, ID_36, ID_37
			, ID_38, ID_39, ID_40, ID_41, ID_42, ID_43, ID_44, ID_45, ID_46, ID_47, ID_48, ID_49, ID_50, ID_51, ID_52, ID_53, ID_54, ID_55, ID_56, ID_57
			, ID_58, ID_59, ID_60, ID_61, ID_62, ID_63, ID_64, ID_65, ID_66, ID_67, ID_68, ID_69, ID_70, ID_71, ID_72, ID_73, ID_74, ID_75, ID_76, ID_77
			, ID_78, ID_79, ID_80, ID_81, ID_82, ID_83, ID_84, ID_85, ID_86, ID_87, ID_88, ID_89, ID_90, ID_91, ID_92, ID_93, ID_94, ID_95, ID_96, ID_97
			, ID_98, ID_99, ID_100, ID_101, ID_102, ID_103, ID_104, ID_105, ID_106, ID_107, ID_108, ID_109, ID_110, ID_111, ID_112, ID_113, ID_114, ID_115, ID_116, ID_117
			, ID_118, ID_119, ID_120, ID_121, ID_122, ID_123, ID_124, ID_125, ID_126, ID_127, ID_128, ID_129, ID_130, ID_131, ID_132, ID_133, ID_134, ID_135, ID_136, ID_137
			, ID_138, ID_139, ID_140, ID_141, ID_142, ID_143, ID_144, ID_145, ID_146, ID_147, ID_148, ID_149, ID_150, ID_151, ID_152, ID_153, ID_154, ID_155, ID_156, ID_157
			, ID_158, ID_159, ID_160, ID_161, ID_162, ID_163, ID_164, ID_165, ID_166, ID_167, ID_168, ID_169, ID_170, ID_171, ID_172, ID_173, ID_174, ID_175, ID_176, ID_177
			, ID_178, ID_179, ID_180, ID_181, ID_182, ID_183, ID_184, ID_185, ID_186, ID_187, ID_188, ID_189, ID_190, ID_191, ID_192, ID_193, ID_194, ID_195, ID_196, ID_197
			, ID_198, ID_199, ID_200, ID_201, ID_202, ID_203, ID_204, ID_205, ID_206, ID_207, ID_208, ID_209, ID_210, ID_211, ID_212, ID_213, ID_214, ID_215, ID_216, ID_217
			, ID_218, ID_219, ID_220, ID_221, ID_222, ID_223, ID_224, ID_225, ID_226, ID_227, ID_228, ID_229, ID_230, ID_231, ID_232, ID_233, ID_234, ID_235, ID_236, ID_237
			, ID_238, ID_239, ID_240, ID_241, ID_242, ID_243, ID_244, ID_245, ID_246, ID_247, ID_248, ID_249, ID_250, ID_251, ID_252, ID_253, ID_254, ID_255, ID_256, ID_257
			, ID_258, ID_259, ID_260, ID_261, ID_262, ID_263, ID_264, ID_265, ID_266, ID_267, ID_268, ID_269, ID_270, ID_271, ID_272, ID_273, ID_274, ID_275, ID_276, ID_277
			, ID_278, ID_279, ID_280, ID_281, ID_282, ID_283, ID_284, ID_285, ID_286, ID_287, ID_288, ID_289, ID_290, ID_291, ID_292, ID_293, ID_294, ID_295, ID_296, ID_297
			, ID_298, ID_299, ID_300, ID_301, ID_302, ID_303, ID_304, ID_305, ID_306, ID_307, ID_308, ID_309, ID_310, ID_311, ID_312, ID_313, ID_314, ID_315, ID_316, ID_317
			, ID_318, ID_319, ID_320, ID_321, ID_322, ID_323, ID_324, ID_325, ID_326, ID_327, ID_328, ID_329, ID_330, ID_331, ID_332, ID_333, ID_334, ID_335, ID_336, ID_337
			, ID_338, ID_339, ID_340, ID_341, ID_342, ID_343, ID_344, ID_345, ID_346, ID_347, ID_348, ID_349, ID_350, ID_351, ID_352, ID_353, ID_354, ID_355, ID_356, ID_357
			, ID_358, ID_359, ID_360, ID_361, ID_362, ID_363, ID_364, ID_365, ID_366, ID_367, ID_368, ID_369, ID_370, ID_371, ID_372, ID_373, ID_374, ID_375, ID_376, ID_377
			, ID_378, ID_379, ID_380, ID_381, ID_382, ID_383, ID_384, ID_385, ID_386, ID_387, ID_388, ID_389, ID_390, ID_391, ID_392, ID_393, ID_394, ID_395, ID_396, ID_397
			, ID_398, ID_399, ID_400, ID_401, ID_402, ID_403, ID_404, ID_405, ID_406, ID_407, ID_408, ID_409, ID_410, ID_411, ID_412, ID_413, ID_414, ID_415, ID_416, ID_417
			, ID_418, ID_419, ID_420, ID_421, ID_422, ID_423, ID_424, ID_425, ID_426, ID_427, ID_428, ID_429, ID_430, ID_431, ID_432, ID_433, ID_434, ID_435, ID_436, ID_437
			, ID_438, ID_439, ID_440, ID_441, ID_442, ID_443, ID_444, ID_445, ID_446, ID_447, ID_448, ID_449, ID_450, ID_451, ID_452, ID_453, ID_454, ID_455, ID_456, ID_457
			, ID_458, ID_459, ID_460, ID_461, ID_462, ID_463, ID_464, ID_465, ID_466, ID_467, ID_468, ID_469, ID_470, ID_471, ID_472, ID_473, ID_474, ID_475, ID_476, ID_477
			, ID_478, ID_479, ID_480, ID_481, ID_482, ID_483, ID_484, ID_485, ID_486, ID_487, ID_488, ID_489, ID_490, ID_491, ID_492, ID_493, ID_494, ID_495, ID_496, ID_497
			, ID_498, ID_499, ID_500, ID_501, ID_502, ID_503, ID_504, ID_505, ID_506, ID_507, ID_508, ID_509, ID_510, ID_511, ID_512, ID_513, ID_514, ID_515, ID_516, ID_517
			, ID_518, ID_519, ID_520, ID_521, ID_522, ID_523, ID_524, ID_525, ID_526, ID_527, ID_528, ID_529, ID_530, ID_531, ID_532, ID_533, ID_534, ID_535, ID_536, ID_537
			, ID_538, ID_539, ID_540, ID_541, ID_542, ID_543, ID_544, ID_545, ID_546, ID_547, ID_548, ID_549, ID_550, ID_551, ID_552, ID_553, ID_554, ID_555, ID_556, ID_557
			, ID_558, ID_559, ID_560, ID_561, ID_562, ID_563, ID_564, ID_565, ID_566, ID_567, ID_568, ID_569, ID_570, ID_571, ID_572, ID_573, ID_574, ID_575, ID_576, ID_577
			, ID_578, ID_579, ID_580, ID_581, ID_582, ID_583, ID_584, ID_585, ID_586, ID_587, ID_588, ID_589, ID_590, ID_591, ID_592, ID_593, ID_594, ID_595, ID_596, ID_597
			, ID_598, ID_599, ID_600, ID_601, ID_602, ID_603, ID_604, ID_605, ID_606, ID_607, ID_608, ID_609, ID_610, ID_611, ID_612, ID_613, ID_614, ID_615, ID_616, ID_617
			, ID_618, ID_619, ID_620, ID_621, ID_622, ID_623, ID_624, ID_625, ID_626, ID_627, ID_628, ID_629, ID_630, ID_631, ID_632, ID_633, ID_634, ID_635, ID_636, ID_637
			, ID_638, ID_639, ID_640, ID_641, ID_642, ID_643, ID_644, ID_645, ID_646, ID_647, ID_648, ID_649, ID_650, ID_651, ID_652, ID_653, ID_654, ID_655, ID_656, ID_657
			, ID_658, ID_659, ID_660, ID_661, ID_662, ID_663, ID_664, ID_665, ID_666, ID_667, ID_668, ID_669, ID_670, ID_671, ID_672, ID_673, ID_674, ID_675, ID_676, ID_677
			, ID_678, ID_679, ID_680, ID_681, ID_682, ID_683, ID_684, ID_685, ID_686, ID_687, ID_688, ID_689, ID_690, ID_691, ID_692, ID_693, ID_694, ID_695, ID_696, ID_697
			, ID_698, ID_699, ID_700, ID_701, ID_702, ID_703, ID_704, ID_705, ID_706, ID_707, ID_708, ID_709, ID_710, ID_711, ID_712, ID_713, ID_714, ID_715, ID_716, ID_717
			, ID_718, ID_719, ID_720, ID_721, ID_722, ID_723, ID_724, ID_725, ID_726, ID_727, ID_728, ID_729, ID_730, ID_731, ID_732, ID_733, ID_734, ID_735, ID_736, ID_737
			, ID_738, ID_739, ID_740, ID_741, ID_742, ID_743, ID_744, ID_745, ID_746, ID_747, ID_748, ID_749, ID_750, ID_751, ID_752, ID_753, ID_754, ID_755, ID_756, ID_757
			, ID_758, ID_759, ID_760, ID_761, ID_762, ID_763, ID_764, ID_765, ID_766, ID_767, ID_768, ID_769, ID_770, ID_771, ID_772, ID_773, ID_774, ID_775, ID_776, ID_777
			, ID_778, ID_779, ID_780, ID_781, ID_782, ID_783, ID_784, ID_785, ID_786, ID_787, ID_788, ID_789, ID_790, ID_791, ID_792, ID_793, ID_794, ID_795, ID_796, ID_797
			, ID_798, ID_799, ID_800, ID_801, ID_802, ID_803, ID_804, ID_805, ID_806, ID_807, ID_808, ID_809, ID_810, ID_811, ID_812, ID_813, ID_814, ID_815, ID_816, ID_817
			, ID_818, ID_819, ID_820, ID_821, ID_822, ID_823, ID_824, ID_825, ID_826, ID_827, ID_828, ID_829, ID_830, ID_831, ID_832, ID_833, ID_834, ID_835, ID_836, ID_837
			, ID_838, ID_839, ID_840, ID_841, ID_842, ID_843, ID_844, ID_845, ID_846, ID_847, ID_848, ID_849, ID_850, ID_851, ID_852, ID_853, ID_854, ID_855, ID_856, ID_857
			, ID_858, ID_859, ID_860, ID_861, ID_862, ID_863, ID_864, ID_865, ID_866, ID_867, ID_868, ID_869, ID_870, ID_871, ID_872, ID_873, ID_874, ID_875, ID_876, ID_877
			, ID_878, ID_879, ID_880, ID_881, ID_882, ID_883, ID_884, ID_885, ID_886, ID_887, ID_888, ID_889, ID_890, ID_891, ID_892, ID_893, ID_894, ID_895, ID_896, ID_897
			, ID_898, ID_899, ID_900, ID_901, ID_902, ID_903, ID_904, ID_905, ID_906, ID_907, ID_908, ID_909, ID_910, ID_911, ID_912, ID_913, ID_914, ID_915, ID_916, ID_917
			, ID_918, ID_919, ID_920, ID_921, ID_922, ID_923, ID_924, ID_925, ID_926, ID_927, ID_928, ID_929, ID_930, ID_931, ID_932, ID_933, ID_934, ID_935, ID_936, ID_937
			, ID_938, ID_939, ID_940, ID_941, ID_942, ID_943, ID_944, ID_945, ID_946, ID_947, ID_948, ID_949, ID_950, ID_951, ID_952, ID_953, ID_954, ID_955, ID_956, ID_957
			, ID_958, ID_959, ID_960, ID_961, ID_962, ID_963, ID_964, ID_965, ID_966, ID_967, ID_968, ID_969, ID_970, ID_971, ID_972, ID_973, ID_974, ID_975, ID_976, ID_977
			, ID_978, ID_979, ID_980, ID_981, ID_982, ID_983, ID_984, ID_985, ID_986, ID_987, ID_988, ID_989, ID_990, ID_991, ID_992, ID_993, ID_994, ID_995, ID_996, ID_997
			, ID_998
		};
		public string [] rowNames = {
			"ID_0", "ID_1", "ID_2", "ID_3", "ID_4", "ID_5", "ID_6", "ID_7", "ID_8", "ID_9", "ID_10", "ID_11", "ID_12", "ID_13", "ID_14", "ID_15", "ID_16", "ID_17"
			, "ID_18", "ID_19", "ID_20", "ID_21", "ID_22", "ID_23", "ID_24", "ID_25", "ID_26", "ID_27", "ID_28", "ID_29", "ID_30", "ID_31", "ID_32", "ID_33", "ID_34", "ID_35", "ID_36", "ID_37"
			, "ID_38", "ID_39", "ID_40", "ID_41", "ID_42", "ID_43", "ID_44", "ID_45", "ID_46", "ID_47", "ID_48", "ID_49", "ID_50", "ID_51", "ID_52", "ID_53", "ID_54", "ID_55", "ID_56", "ID_57"
			, "ID_58", "ID_59", "ID_60", "ID_61", "ID_62", "ID_63", "ID_64", "ID_65", "ID_66", "ID_67", "ID_68", "ID_69", "ID_70", "ID_71", "ID_72", "ID_73", "ID_74", "ID_75", "ID_76", "ID_77"
			, "ID_78", "ID_79", "ID_80", "ID_81", "ID_82", "ID_83", "ID_84", "ID_85", "ID_86", "ID_87", "ID_88", "ID_89", "ID_90", "ID_91", "ID_92", "ID_93", "ID_94", "ID_95", "ID_96", "ID_97"
			, "ID_98", "ID_99", "ID_100", "ID_101", "ID_102", "ID_103", "ID_104", "ID_105", "ID_106", "ID_107", "ID_108", "ID_109", "ID_110", "ID_111", "ID_112", "ID_113", "ID_114", "ID_115", "ID_116", "ID_117"
			, "ID_118", "ID_119", "ID_120", "ID_121", "ID_122", "ID_123", "ID_124", "ID_125", "ID_126", "ID_127", "ID_128", "ID_129", "ID_130", "ID_131", "ID_132", "ID_133", "ID_134", "ID_135", "ID_136", "ID_137"
			, "ID_138", "ID_139", "ID_140", "ID_141", "ID_142", "ID_143", "ID_144", "ID_145", "ID_146", "ID_147", "ID_148", "ID_149", "ID_150", "ID_151", "ID_152", "ID_153", "ID_154", "ID_155", "ID_156", "ID_157"
			, "ID_158", "ID_159", "ID_160", "ID_161", "ID_162", "ID_163", "ID_164", "ID_165", "ID_166", "ID_167", "ID_168", "ID_169", "ID_170", "ID_171", "ID_172", "ID_173", "ID_174", "ID_175", "ID_176", "ID_177"
			, "ID_178", "ID_179", "ID_180", "ID_181", "ID_182", "ID_183", "ID_184", "ID_185", "ID_186", "ID_187", "ID_188", "ID_189", "ID_190", "ID_191", "ID_192", "ID_193", "ID_194", "ID_195", "ID_196", "ID_197"
			, "ID_198", "ID_199", "ID_200", "ID_201", "ID_202", "ID_203", "ID_204", "ID_205", "ID_206", "ID_207", "ID_208", "ID_209", "ID_210", "ID_211", "ID_212", "ID_213", "ID_214", "ID_215", "ID_216", "ID_217"
			, "ID_218", "ID_219", "ID_220", "ID_221", "ID_222", "ID_223", "ID_224", "ID_225", "ID_226", "ID_227", "ID_228", "ID_229", "ID_230", "ID_231", "ID_232", "ID_233", "ID_234", "ID_235", "ID_236", "ID_237"
			, "ID_238", "ID_239", "ID_240", "ID_241", "ID_242", "ID_243", "ID_244", "ID_245", "ID_246", "ID_247", "ID_248", "ID_249", "ID_250", "ID_251", "ID_252", "ID_253", "ID_254", "ID_255", "ID_256", "ID_257"
			, "ID_258", "ID_259", "ID_260", "ID_261", "ID_262", "ID_263", "ID_264", "ID_265", "ID_266", "ID_267", "ID_268", "ID_269", "ID_270", "ID_271", "ID_272", "ID_273", "ID_274", "ID_275", "ID_276", "ID_277"
			, "ID_278", "ID_279", "ID_280", "ID_281", "ID_282", "ID_283", "ID_284", "ID_285", "ID_286", "ID_287", "ID_288", "ID_289", "ID_290", "ID_291", "ID_292", "ID_293", "ID_294", "ID_295", "ID_296", "ID_297"
			, "ID_298", "ID_299", "ID_300", "ID_301", "ID_302", "ID_303", "ID_304", "ID_305", "ID_306", "ID_307", "ID_308", "ID_309", "ID_310", "ID_311", "ID_312", "ID_313", "ID_314", "ID_315", "ID_316", "ID_317"
			, "ID_318", "ID_319", "ID_320", "ID_321", "ID_322", "ID_323", "ID_324", "ID_325", "ID_326", "ID_327", "ID_328", "ID_329", "ID_330", "ID_331", "ID_332", "ID_333", "ID_334", "ID_335", "ID_336", "ID_337"
			, "ID_338", "ID_339", "ID_340", "ID_341", "ID_342", "ID_343", "ID_344", "ID_345", "ID_346", "ID_347", "ID_348", "ID_349", "ID_350", "ID_351", "ID_352", "ID_353", "ID_354", "ID_355", "ID_356", "ID_357"
			, "ID_358", "ID_359", "ID_360", "ID_361", "ID_362", "ID_363", "ID_364", "ID_365", "ID_366", "ID_367", "ID_368", "ID_369", "ID_370", "ID_371", "ID_372", "ID_373", "ID_374", "ID_375", "ID_376", "ID_377"
			, "ID_378", "ID_379", "ID_380", "ID_381", "ID_382", "ID_383", "ID_384", "ID_385", "ID_386", "ID_387", "ID_388", "ID_389", "ID_390", "ID_391", "ID_392", "ID_393", "ID_394", "ID_395", "ID_396", "ID_397"
			, "ID_398", "ID_399", "ID_400", "ID_401", "ID_402", "ID_403", "ID_404", "ID_405", "ID_406", "ID_407", "ID_408", "ID_409", "ID_410", "ID_411", "ID_412", "ID_413", "ID_414", "ID_415", "ID_416", "ID_417"
			, "ID_418", "ID_419", "ID_420", "ID_421", "ID_422", "ID_423", "ID_424", "ID_425", "ID_426", "ID_427", "ID_428", "ID_429", "ID_430", "ID_431", "ID_432", "ID_433", "ID_434", "ID_435", "ID_436", "ID_437"
			, "ID_438", "ID_439", "ID_440", "ID_441", "ID_442", "ID_443", "ID_444", "ID_445", "ID_446", "ID_447", "ID_448", "ID_449", "ID_450", "ID_451", "ID_452", "ID_453", "ID_454", "ID_455", "ID_456", "ID_457"
			, "ID_458", "ID_459", "ID_460", "ID_461", "ID_462", "ID_463", "ID_464", "ID_465", "ID_466", "ID_467", "ID_468", "ID_469", "ID_470", "ID_471", "ID_472", "ID_473", "ID_474", "ID_475", "ID_476", "ID_477"
			, "ID_478", "ID_479", "ID_480", "ID_481", "ID_482", "ID_483", "ID_484", "ID_485", "ID_486", "ID_487", "ID_488", "ID_489", "ID_490", "ID_491", "ID_492", "ID_493", "ID_494", "ID_495", "ID_496", "ID_497"
			, "ID_498", "ID_499", "ID_500", "ID_501", "ID_502", "ID_503", "ID_504", "ID_505", "ID_506", "ID_507", "ID_508", "ID_509", "ID_510", "ID_511", "ID_512", "ID_513", "ID_514", "ID_515", "ID_516", "ID_517"
			, "ID_518", "ID_519", "ID_520", "ID_521", "ID_522", "ID_523", "ID_524", "ID_525", "ID_526", "ID_527", "ID_528", "ID_529", "ID_530", "ID_531", "ID_532", "ID_533", "ID_534", "ID_535", "ID_536", "ID_537"
			, "ID_538", "ID_539", "ID_540", "ID_541", "ID_542", "ID_543", "ID_544", "ID_545", "ID_546", "ID_547", "ID_548", "ID_549", "ID_550", "ID_551", "ID_552", "ID_553", "ID_554", "ID_555", "ID_556", "ID_557"
			, "ID_558", "ID_559", "ID_560", "ID_561", "ID_562", "ID_563", "ID_564", "ID_565", "ID_566", "ID_567", "ID_568", "ID_569", "ID_570", "ID_571", "ID_572", "ID_573", "ID_574", "ID_575", "ID_576", "ID_577"
			, "ID_578", "ID_579", "ID_580", "ID_581", "ID_582", "ID_583", "ID_584", "ID_585", "ID_586", "ID_587", "ID_588", "ID_589", "ID_590", "ID_591", "ID_592", "ID_593", "ID_594", "ID_595", "ID_596", "ID_597"
			, "ID_598", "ID_599", "ID_600", "ID_601", "ID_602", "ID_603", "ID_604", "ID_605", "ID_606", "ID_607", "ID_608", "ID_609", "ID_610", "ID_611", "ID_612", "ID_613", "ID_614", "ID_615", "ID_616", "ID_617"
			, "ID_618", "ID_619", "ID_620", "ID_621", "ID_622", "ID_623", "ID_624", "ID_625", "ID_626", "ID_627", "ID_628", "ID_629", "ID_630", "ID_631", "ID_632", "ID_633", "ID_634", "ID_635", "ID_636", "ID_637"
			, "ID_638", "ID_639", "ID_640", "ID_641", "ID_642", "ID_643", "ID_644", "ID_645", "ID_646", "ID_647", "ID_648", "ID_649", "ID_650", "ID_651", "ID_652", "ID_653", "ID_654", "ID_655", "ID_656", "ID_657"
			, "ID_658", "ID_659", "ID_660", "ID_661", "ID_662", "ID_663", "ID_664", "ID_665", "ID_666", "ID_667", "ID_668", "ID_669", "ID_670", "ID_671", "ID_672", "ID_673", "ID_674", "ID_675", "ID_676", "ID_677"
			, "ID_678", "ID_679", "ID_680", "ID_681", "ID_682", "ID_683", "ID_684", "ID_685", "ID_686", "ID_687", "ID_688", "ID_689", "ID_690", "ID_691", "ID_692", "ID_693", "ID_694", "ID_695", "ID_696", "ID_697"
			, "ID_698", "ID_699", "ID_700", "ID_701", "ID_702", "ID_703", "ID_704", "ID_705", "ID_706", "ID_707", "ID_708", "ID_709", "ID_710", "ID_711", "ID_712", "ID_713", "ID_714", "ID_715", "ID_716", "ID_717"
			, "ID_718", "ID_719", "ID_720", "ID_721", "ID_722", "ID_723", "ID_724", "ID_725", "ID_726", "ID_727", "ID_728", "ID_729", "ID_730", "ID_731", "ID_732", "ID_733", "ID_734", "ID_735", "ID_736", "ID_737"
			, "ID_738", "ID_739", "ID_740", "ID_741", "ID_742", "ID_743", "ID_744", "ID_745", "ID_746", "ID_747", "ID_748", "ID_749", "ID_750", "ID_751", "ID_752", "ID_753", "ID_754", "ID_755", "ID_756", "ID_757"
			, "ID_758", "ID_759", "ID_760", "ID_761", "ID_762", "ID_763", "ID_764", "ID_765", "ID_766", "ID_767", "ID_768", "ID_769", "ID_770", "ID_771", "ID_772", "ID_773", "ID_774", "ID_775", "ID_776", "ID_777"
			, "ID_778", "ID_779", "ID_780", "ID_781", "ID_782", "ID_783", "ID_784", "ID_785", "ID_786", "ID_787", "ID_788", "ID_789", "ID_790", "ID_791", "ID_792", "ID_793", "ID_794", "ID_795", "ID_796", "ID_797"
			, "ID_798", "ID_799", "ID_800", "ID_801", "ID_802", "ID_803", "ID_804", "ID_805", "ID_806", "ID_807", "ID_808", "ID_809", "ID_810", "ID_811", "ID_812", "ID_813", "ID_814", "ID_815", "ID_816", "ID_817"
			, "ID_818", "ID_819", "ID_820", "ID_821", "ID_822", "ID_823", "ID_824", "ID_825", "ID_826", "ID_827", "ID_828", "ID_829", "ID_830", "ID_831", "ID_832", "ID_833", "ID_834", "ID_835", "ID_836", "ID_837"
			, "ID_838", "ID_839", "ID_840", "ID_841", "ID_842", "ID_843", "ID_844", "ID_845", "ID_846", "ID_847", "ID_848", "ID_849", "ID_850", "ID_851", "ID_852", "ID_853", "ID_854", "ID_855", "ID_856", "ID_857"
			, "ID_858", "ID_859", "ID_860", "ID_861", "ID_862", "ID_863", "ID_864", "ID_865", "ID_866", "ID_867", "ID_868", "ID_869", "ID_870", "ID_871", "ID_872", "ID_873", "ID_874", "ID_875", "ID_876", "ID_877"
			, "ID_878", "ID_879", "ID_880", "ID_881", "ID_882", "ID_883", "ID_884", "ID_885", "ID_886", "ID_887", "ID_888", "ID_889", "ID_890", "ID_891", "ID_892", "ID_893", "ID_894", "ID_895", "ID_896", "ID_897"
			, "ID_898", "ID_899", "ID_900", "ID_901", "ID_902", "ID_903", "ID_904", "ID_905", "ID_906", "ID_907", "ID_908", "ID_909", "ID_910", "ID_911", "ID_912", "ID_913", "ID_914", "ID_915", "ID_916", "ID_917"
			, "ID_918", "ID_919", "ID_920", "ID_921", "ID_922", "ID_923", "ID_924", "ID_925", "ID_926", "ID_927", "ID_928", "ID_929", "ID_930", "ID_931", "ID_932", "ID_933", "ID_934", "ID_935", "ID_936", "ID_937"
			, "ID_938", "ID_939", "ID_940", "ID_941", "ID_942", "ID_943", "ID_944", "ID_945", "ID_946", "ID_947", "ID_948", "ID_949", "ID_950", "ID_951", "ID_952", "ID_953", "ID_954", "ID_955", "ID_956", "ID_957"
			, "ID_958", "ID_959", "ID_960", "ID_961", "ID_962", "ID_963", "ID_964", "ID_965", "ID_966", "ID_967", "ID_968", "ID_969", "ID_970", "ID_971", "ID_972", "ID_973", "ID_974", "ID_975", "ID_976", "ID_977"
			, "ID_978", "ID_979", "ID_980", "ID_981", "ID_982", "ID_983", "ID_984", "ID_985", "ID_986", "ID_987", "ID_988", "ID_989", "ID_990", "ID_991", "ID_992", "ID_993", "ID_994", "ID_995", "ID_996", "ID_997"
			, "ID_998"
		};
		public System.Collections.Generic.List<AllStageStatsRow> Rows = new System.Collections.Generic.List<AllStageStatsRow>();

		public static AllStageStats Instance
		{
			get { return NestedAllStageStats.instance; }
		}

		private class NestedAllStageStats
		{
			static NestedAllStageStats() { }
			internal static readonly AllStageStats instance = new AllStageStats();
		}

		private AllStageStats()
		{
			Rows.Add( new AllStageStatsRow("ID_0", "1", "2", "4", "24", "24", "30", "60"));
			Rows.Add( new AllStageStatsRow("ID_1", "2", "6", "18", "78", "102", "40", "120"));
			Rows.Add( new AllStageStatsRow("ID_2", "3", "11", "44", "154", "256", "52", "260"));
			Rows.Add( new AllStageStatsRow("ID_3", "4", "15", "75", "225", "481", "67", "670"));
			Rows.Add( new AllStageStatsRow("ID_4", "5", "20", "120", "320", "801", "88", "1320"));
			Rows.Add( new AllStageStatsRow("ID_5", "6", "25", "50", "300", "1101", "114", "228"));
			Rows.Add( new AllStageStatsRow("ID_6", "7", "30", "90", "390", "1491", "149", "447"));
			Rows.Add( new AllStageStatsRow("ID_7", "8", "36", "144", "504", "1995", "194", "970"));
			Rows.Add( new AllStageStatsRow("ID_8", "9", "42", "210", "630", "2625", "254", "2540"));
			Rows.Add( new AllStageStatsRow("ID_9", "10", "49", "294", "784", "3409", "331", "4965"));
			Rows.Add( new AllStageStatsRow("ID_10", "11", "57", "114", "684", "4093", "432", "864"));
			Rows.Add( new AllStageStatsRow("ID_11", "12", "66", "198", "858", "4951", "564", "1692"));
			Rows.Add( new AllStageStatsRow("ID_12", "13", "78", "312", "1092", "6043", "736", "3680"));
			Rows.Add( new AllStageStatsRow("ID_13", "14", "92", "460", "1380", "7423", "960", "9600"));
			Rows.Add( new AllStageStatsRow("ID_14", "15", "111", "666", "1776", "9199", "1254", "18810"));
			Rows.Add( new AllStageStatsRow("ID_15", "16", "134", "268", "1608", "10807", "1637", "3274"));
			Rows.Add( new AllStageStatsRow("ID_16", "17", "165", "495", "2145", "12952", "2137", "6411"));
			Rows.Add( new AllStageStatsRow("ID_17", "18", "205", "820", "2870", "15822", "2789", "13945"));
			Rows.Add( new AllStageStatsRow("ID_18", "19", "258", "1290", "3870", "19692", "3641", "36410"));
			Rows.Add( new AllStageStatsRow("ID_19", "20", "330", "1980", "5280", "24972", "4753", "71295"));
			Rows.Add( new AllStageStatsRow("ID_20", "21", "426", "852", "5112", "30084", "6205", "12410"));
			Rows.Add( new AllStageStatsRow("ID_21", "22", "555", "1665", "7215", "37299", "8101", "24303"));
			Rows.Add( new AllStageStatsRow("ID_22", "23", "731", "2924", "10234", "47533", "10576", "52880"));
			Rows.Add( new AllStageStatsRow("ID_23", "24", "969", "4845", "14535", "62068", "13807", "138070"));
			Rows.Add( new AllStageStatsRow("ID_24", "25", "1292", "7752", "20672", "82740", "18025", "270375"));
			Rows.Add( new AllStageStatsRow("ID_25", "26", "1732", "3464", "20784", "103524", "23532", "47064"));
			Rows.Add( new AllStageStatsRow("ID_26", "27", "2332", "6996", "30316", "133840", "30720", "92160"));
			Rows.Add( new AllStageStatsRow("ID_27", "28", "3148", "12592", "44072", "177912", "40106", "200530"));
			Rows.Add( new AllStageStatsRow("ID_28", "29", "4261", "21305", "63915", "241827", "52358", "523580"));
			Rows.Add( new AllStageStatsRow("ID_29", "30", "5779", "34674", "92464", "334291", "68354", "1025310"));
			Rows.Add( new AllStageStatsRow("ID_30", "31", "7850", "15700", "94200", "428491", "89237", "178474"));
			Rows.Add( new AllStageStatsRow("ID_31", "32", "10675", "32025", "138775", "567266", "116500", "349500"));
			Rows.Add( new AllStageStatsRow("ID_32", "33", "14529", "58116", "203406", "770672", "152092", "760460"));
			Rows.Add( new AllStageStatsRow("ID_33", "34", "19789", "98945", "296835", "1067507", "198558", "1985580"));
			Rows.Add( new AllStageStatsRow("ID_34", "35", "26967", "161802", "431472", "1498979", "259220", "3888300"));
			Rows.Add( new AllStageStatsRow("ID_35", "36", "36764", "73528", "441168", "1940147", "338414", "676828"));
			Rows.Add( new AllStageStatsRow("ID_36", "37", "50135", "150405", "651755", "2591902", "441804", "1325412"));
			Rows.Add( new AllStageStatsRow("ID_37", "38", "68385", "273540", "957390", "3549292", "576780", "2883900"));
			Rows.Add( new AllStageStatsRow("ID_38", "39", "93295", "466475", "1399425", "4948717", "752993", "7529930"));
			Rows.Add( new AllStageStatsRow("ID_39", "40", "127296", "763776", "2036736", "6985453", "983040", "14745600"));
			Rows.Add( new AllStageStatsRow("ID_40", "41", "173705", "347410", "2084460", "9069913", "1283371", "2566742"));
			Rows.Add( new AllStageStatsRow("ID_41", "42", "237053", "711159", "3081689", "12151602", "1675455", "5026365"));
			Rows.Add( new AllStageStatsRow("ID_42", "43", "323520", "1294080", "4529280", "16680882", "2187326", "10936630"));
			Rows.Add( new AllStageStatsRow("ID_43", "44", "441547", "2207735", "6623205", "23304087", "2855580", "28555800"));
			Rows.Add( new AllStageStatsRow("ID_44", "45", "602653", "3615918", "9642448", "32946535", "3727993", "55919895"));
			Rows.Add( new AllStageStatsRow("ID_45", "46", "822560", "1645120", "9870720", "42817255", "4866938", "9733876"));
			Rows.Add( new AllStageStatsRow("ID_46", "47", "1122733", "3368199", "14595529", "57412784", "6353845", "19061535"));
			Rows.Add( new AllStageStatsRow("ID_47", "48", "1532466", "6129864", "21454524", "78867308", "8295018", "41475090"));
			Rows.Add( new AllStageStatsRow("ID_48", "49", "2091752", "10458760", "31376280", "110243588", "10800000", "108292430"));
			Rows.Add( new AllStageStatsRow("ID_49", "50", "2855174", "17131044", "45682784", "155926372", "14100000", "212065560"));
			Rows.Add( new AllStageStatsRow("ID_50", "51", "3897245", "7794490", "46766940", "202693312", "18500000", "36913876"));
			Rows.Add( new AllStageStatsRow("ID_51", "52", "5319670", "15959010", "69155710", "271849022", "24100000", "72287244"));
			Rows.Add( new AllStageStatsRow("ID_52", "53", "7261278", "29045112", "101657892", "373506914", "31500000", "157286400"));
			Rows.Add( new AllStageStatsRow("ID_53", "54", "9911572", "49557860", "148673580", "522180494", "41100000", "410678480"));
			Rows.Add( new AllStageStatsRow("ID_54", "55", "13529222", "81175332", "216467552", "738648046", "53600000", "804218325"));
			Rows.Add( new AllStageStatsRow("ID_55", "56", "18467312", "36934624", "221607744", "960255790", "70000000", "139988858"));
			Rows.Add( new AllStageStatsRow("ID_56", "57", "25207804", "75623412", "327701452", "1287957242", "91400000", "274135635"));
			Rows.Add( new AllStageStatsRow("ID_57", "58", "34408575", "137634300", "481720050", "1769677292", "119000000", "596478800"));
			Rows.Add( new AllStageStatsRow("ID_58", "59", "46967624", "234838120", "704514360", "2474191652", "156000000", "1557420100"));
			Rows.Add( new AllStageStatsRow("ID_59", "60", "64110726", "384664356", "1025771616", "3499963268", "203000000", "3049845225"));
			Rows.Add( new AllStageStatsRow("ID_60", "61", "87511058", "175022116", "1050132696", "4550095964", "265000000", "530881150"));
			Rows.Add( new AllStageStatsRow("ID_61", "62", "119452511", "358357533", "1552882643", "6102978607", "347000000", "1039607325"));
			Rows.Add( new AllStageStatsRow("ID_62", "63", "163052591", "652210364", "2282736274", "8385714881", "452000000", "2262032540"));
			Rows.Add( new AllStageStatsRow("ID_63", "64", "222566700", "1112833500", "3338500500", "11724215381", "591000000", "5906219890"));
			Rows.Add( new AllStageStatsRow("ID_64", "65", "303803457", "1822820742", "4860855312", "16585070693", "771000000", "11565958725"));
			Rows.Add( new AllStageStatsRow("ID_65", "66", "414691629", "829383258", "4976299548", "21561370241", "1010000000", "2013265920"));
			Rows.Add( new AllStageStatsRow("ID_66", "67", "566053983", "1698161949", "7358701779", "28920072020", "1310000000", "3942513315"));
			Rows.Add( new AllStageStatsRow("ID_67", "68", "772663593", "3090654372", "10817290302", "39737362322", "1720000000", "8578328750"));
			Rows.Add( new AllStageStatsRow("ID_68", "69", "1054685710", "5273428550", "15820285650", "55557647972", "2240000000", "22398217060"));
			Rows.Add( new AllStageStatsRow("ID_69", "70", "1439645899", "8637875394", "23034334384", "78591982356", "2920000000", "43861701570"));
			Rows.Add( new AllStageStatsRow("ID_70", "71", "1965116555", "3930233110", "23581398660", "102173381016", "3820000000", "7634928598"));
			Rows.Add( new AllStageStatsRow("ID_71", "72", "2682383999", "8047151997", "34870991987", "137044373003", "4980000000", "14951232891"));
			Rows.Add( new AllStageStatsRow("ID_72", "73", "3661454058", "14645816232", "51260356812", "188304729815", "6510000000", "32531682395"));
			Rows.Add( new AllStageStatsRow("ID_73", "74", "4997884687", "24989423435", "74968270305", "263273000120", "8490000000", "84940983820"));
			Rows.Add( new AllStageStatsRow("ID_74", "75", "6822112495", "40932674970", "109153799920", "372426800040", "11100000000", "166337171985"));
			Rows.Add( new AllStageStatsRow("ID_75", "76", "9312183451", "18624366902", "111746201412", "484173001452", "14500000000", "28954016504"));
			Rows.Add( new AllStageStatsRow("ID_76", "77", "12711130304", "38133390912", "165244693952", "649417695404", "18900000000", "56699710863"));
			Rows.Add( new AllStageStatsRow("ID_77", "78", "17350692758", "69402771032", "242909698612", "892327394016", "24700000000", "123370226315"));
			Rows.Add( new AllStageStatsRow("ID_78", "79", "23683695506", "118418477530", "355255432590", "1247582826606", "32200000000", "322122547200"));
			Rows.Add( new AllStageStatsRow("ID_79", "80", "32328244255", "193969465530", "517251908080", "1764834734686", "42100000000", "630802130205"));
			Rows.Add( new AllStageStatsRow("ID_80", "81", "44128053296", "88256106592", "529536639552", "2294371374238", "54900000000", "109802607990"));
			Rows.Add( new AllStageStatsRow("ID_81", "82", "60234792636", "180704377908", "783052304268", "3077423678506", "71700000000", "215022883755"));
			Rows.Add( new AllStageStatsRow("ID_82", "83", "82220491833", "328881967332", "1151086885662", "4228510564168", "93600000000", "467858150025"));
			Rows.Add( new AllStageStatsRow("ID_83", "84", "112230971236", "561154856180", "1683464568540", "5911975132708", "122000000000", "1221588575450"));
			Rows.Add( new AllStageStatsRow("ID_84", "85", "153195275619", "919171653714", "2451124409904", "8363099542612", "159000000000", "2392197262560"));
			Rows.Add( new AllStageStatsRow("ID_85", "86", "209111551101", "418223102202", "2509338613212", "10872438155824", "208000000000", "416405534600"));
			Rows.Add( new AllStageStatsRow("ID_86", "87", "285437267132", "856311801396", "3710684472716", "14583122628540", "272000000000", "815433444618"));
			Rows.Add( new AllStageStatsRow("ID_87", "88", "389621869513", "1558487478052", "5454706173182", "20037828801722", "355000000000", "1774263167750"));
			Rows.Add( new AllStageStatsRow("ID_88", "89", "531833851762", "2659169258810", "7977507776430", "28015336578152", "463000000000", "4632642640630"));
			Rows.Add( new AllStageStatsRow("ID_89", "90", "725953207530", "4355719245180", "11615251320480", "39630587898632", "605000000000", "9071953737975"));
			Rows.Add( new AllStageStatsRow("ID_90", "91", "990926128152", "1981852256304", "11891113537824", "51521701436456", "790000000000", "1579138896800"));
			Rows.Add( new AllStageStatsRow("ID_91", "92", "1352614164799", "4057842494397", "17583984142387", "69105685578843", "1030000000000", "3092376453120"));
			Rows.Add( new AllStageStatsRow("ID_92", "93", "1846318334821", "7385273339284", "25848456687494", "94954142266337", "1350000000000", "6728556055455"));
			Rows.Add( new AllStageStatsRow("ID_93", "94", "2520224526900", "12601122634500", "37803367903500", "132757510169837", "1760000000000", "17568417278180"));
			Rows.Add( new AllStageStatsRow("ID_94", "95", "3440106479086", "20640638874516", "55041703665376", "187799213835213", "2290000000000", "34403661400365"));
			Rows.Add( new AllStageStatsRow("ID_95", "96", "4695745343819", "9391490687638", "56348944125828", "244148157961041", "2990000000000", "5988584320296"));
			Rows.Add( new AllStageStatsRow("ID_96", "97", "6409692394177", "19229077182531", "83326001124301", "327474159085342", "3910000000000", "11727250324302"));
			Rows.Add( new AllStageStatsRow("ID_97", "98", "8749230117915", "34996920471660", "122489221650810", "449963380736152", "5100000000000", "25516770800575"));
			Rows.Add( new AllStageStatsRow("ID_98", "99", "11942699110816", "59713495554080", "179140486662240", "629103867398392", "6660000000000", "66624885535870"));
			Rows.Add( new AllStageStatsRow("ID_99", "100", "16301784286124", "97810705716744", "260828548577984", "889932415976376", "8700000000000", "130469351138475"));
			Rows.Add( new AllStageStatsRow("ID_100", "101", "22251935550418", "44503871100836", "267023226605016", "1.15696E+15", "11400000000000", "22710568547184"));
			Rows.Add( new AllStageStatsRow("ID_101", "102", "30373892026178", "91121676078534", "394860596340314", "1.55182E+15", "14800000000000", "44473369349985"));
			Rows.Add( new AllStageStatsRow("ID_102", "103", "41460362615589", "165841450462356", "580445076618246", "2.13226E+15", "19400000000000", "96767506538285"));
			Rows.Add( new AllStageStatsRow("ID_103", "104", "56593394970134", "282966974850670", "848900924552010", "2.98116E+15", "25300000000000", "252662223487890"));
			Rows.Add( new AllStageStatsRow("ID_104", "105", "77249984134086", "463499904804516", "1.236E+15", "4.21716E+15", "33000000000000", "494780232499200"));
			Rows.Add( new AllStageStatsRow("ID_105", "106", "105446228342878", "210892456685756", "1.26535E+15", "5.48252E+15", "43100000000000", "86125517509772"));
			Rows.Add( new AllStageStatsRow("ID_106", "107", "143934101687879", "431802305063637", "1.87114E+15", "7.35366E+15", "56200000000000", "168656805870477"));
			Rows.Add( new AllStageStatsRow("ID_107", "108", "196470048803804", "785880195215216", "2.75058E+15", "1.01042E+16", "73400000000000", "366972388270465"));
			Rows.Add( new AllStageStatsRow("ID_108", "109", "268181616617040", "1.34091E+15", "4.02272E+15", "1.4127E+16", "95800000000000", "958173491247200"));
			Rows.Add( new AllStageStatsRow("ID_109", "110", "366067906682105", "2.19641E+15", "5.85709E+15", "1.99841E+16", "125000000000000", "1.87636E+15"));
			Rows.Add( new AllStageStatsRow("ID_110", "111", "499682692620918", "999365385241836", "5.99619E+15", "2.59802E+16", "163000000000000", "326614666247354"));
			Rows.Add( new AllStageStatsRow("ID_111", "112", "682066875427396", "2.0462E+15", "8.86687E+15", "3.48471E+16", "213000000000000", "639598901144262"));
			Rows.Add( new AllStageStatsRow("ID_112", "113", "931021284958237", "3.72409E+15", "1.30343E+16", "4.78814E+16", "278000000000000", "1.39167E+15"));
			Rows.Add( new AllStageStatsRow("ID_113", "114", "1.27084E+15", "6.35422E+15", "1.90627E+16", "6.69441E+16", "363000000000000", "3.63369E+15"));
			Rows.Add( new AllStageStatsRow("ID_114", "115", "1.7347E+15", "1.04082E+16", "2.77552E+16", "9.46993E+16", "474000000000000", "7.11574E+15"));
			Rows.Add( new AllStageStatsRow("ID_115", "116", "2.36787E+15", "4.73574E+15", "2.84144E+16", "1.23114E+17", "619000000000000", "1.23862E+15"));
			Rows.Add( new AllStageStatsRow("ID_116", "117", "3.23214E+15", "9.69642E+15", "4.20178E+16", "1.65132E+17", "809000000000000", "2.42556E+15"));
			Rows.Add( new AllStageStatsRow("ID_117", "118", "4.41187E+15", "1.76475E+16", "6.17662E+16", "2.26898E+17", "1.06E+15", "5.27766E+15"));
			Rows.Add( new AllStageStatsRow("ID_118", "119", "6.0222E+15", "3.0111E+16", "9.03331E+16", "3.17231E+17", "1.38E+15", "1.37801E+16"));
			Rows.Add( new AllStageStatsRow("ID_119", "120", "8.22031E+15", "4.93219E+16", "1.31525E+17", "4.48756E+17", "1.8E+15", "2.69851E+16"));
			Rows.Add( new AllStageStatsRow("ID_120", "121", "1.12207E+16", "2.24414E+16", "1.34649E+17", "5.83404E+17", "2.35E+15", "4.69725E+15"));
			Rows.Add( new AllStageStatsRow("ID_121", "122", "1.53163E+16", "4.59489E+16", "1.99112E+17", "7.82516E+17", "3.07E+15", "9.19847E+15"));
			Rows.Add( new AllStageStatsRow("ID_122", "123", "2.09067E+16", "8.36269E+16", "2.92694E+17", "1.07521E+18", "4E+15", "2.00145E+16"));
			Rows.Add( new AllStageStatsRow("ID_123", "124", "2.85377E+16", "1.42688E+17", "4.28065E+17", "1.50328E+18", "5.23E+15", "5.22583E+16"));
			Rows.Add( new AllStageStatsRow("ID_124", "125", "3.89539E+16", "2.33724E+17", "6.23263E+17", "2.12654E+18", "6.82E+15", "1.02336E+17"));
			Rows.Add( new AllStageStatsRow("ID_125", "126", "5.31721E+16", "1.06344E+17", "6.38066E+17", "2.7646E+18", "8.91E+15", "1.78134E+16"));
			Rows.Add( new AllStageStatsRow("ID_126", "127", "7.258E+16", "2.1774E+17", "9.43539E+17", "3.70814E+18", "1.16E+16", "3.48834E+16"));
			Rows.Add( new AllStageStatsRow("ID_127", "128", "9.90716E+16", "3.96287E+17", "1.387E+18", "5.09515E+18", "1.52E+16", "7.59012E+16"));
			Rows.Add( new AllStageStatsRow("ID_128", "129", "1.35233E+17", "6.76164E+17", "2.02849E+18", "7.12364E+18", "1.98E+16", "1.9818E+17"));
			Rows.Add( new AllStageStatsRow("ID_129", "130", "1.84593E+17", "1.10756E+18", "2.95348E+18", "1.00771E+19", "2.59E+16", "3.88089E+17"));
			Rows.Add( new AllStageStatsRow("ID_130", "131", "2.51969E+17", "5.03938E+17", "3.02363E+18", "1.31008E+19", "3.38E+16", "6.7554E+16"));
			Rows.Add( new AllStageStatsRow("ID_131", "132", "3.43938E+17", "1.03181E+18", "4.47119E+18", "1.75719E+19", "4.41E+16", "1.32289E+17"));
			Rows.Add( new AllStageStatsRow("ID_132", "133", "4.69475E+17", "1.8779E+18", "6.57265E+18", "2.41446E+19", "5.76E+16", "2.87841E+17"));
			Rows.Add( new AllStageStatsRow("ID_133", "134", "6.40834E+17", "3.20417E+18", "9.6125E+18", "3.37571E+19", "7.52E+16", "7.51559E+17"));
			Rows.Add( new AllStageStatsRow("ID_134", "135", "8.74738E+17", "5.24843E+18", "1.39958E+19", "4.77529E+19", "9.81E+16", "1.47175E+18"));
			Rows.Add( new AllStageStatsRow("ID_135", "136", "1.19402E+18", "2.38803E+18", "1.43282E+19", "6.20811E+19", "1.28E+17", "2.56186E+17"));
			Rows.Add( new AllStageStatsRow("ID_136", "137", "1.62983E+18", "4.8895E+18", "2.11878E+19", "8.3269E+19", "1.67E+17", "5.0168E+17"));
			Rows.Add( new AllStageStatsRow("ID_137", "138", "2.22472E+18", "8.89889E+18", "3.11461E+19", "1.14415E+20", "2.18E+17", "1.09158E+18"));
			Rows.Add( new AllStageStatsRow("ID_138", "139", "3.03675E+18", "1.51837E+19", "4.55512E+19", "1.59966E+20", "2.85E+17", "2.85015E+18"));
			Rows.Add( new AllStageStatsRow("ID_139", "140", "4.14516E+18", "2.4871E+19", "6.63225E+19", "2.26289E+20", "3.72E+17", "5.58135E+18"));
			Rows.Add( new AllStageStatsRow("ID_140", "141", "5.65814E+18", "1.13163E+19", "6.78977E+19", "2.94187E+20", "4.86E+17", "9.71536E+17"));
			Rows.Add( new AllStageStatsRow("ID_141", "142", "7.72336E+18", "2.31701E+19", "1.00404E+20", "3.9459E+20", "6.34E+17", "1.90253E+18"));
			Rows.Add( new AllStageStatsRow("ID_142", "143", "1.05424E+19", "4.21696E+19", "1.47593E+20", "5.42184E+20", "8.28E+17", "4.13962E+18"));
			Rows.Add( new AllStageStatsRow("ID_143", "144", "1.43904E+19", "7.19518E+19", "2.15855E+20", "7.58039E+20", "1.08E+18", "1.08086E+19"));
			Rows.Add( new AllStageStatsRow("ID_144", "145", "1.96428E+19", "1.17857E+20", "3.14286E+20", "1.07232E+21", "1.41E+18", "2.11662E+19"));
			Rows.Add( new AllStageStatsRow("ID_145", "146", "2.68125E+19", "5.3625E+19", "3.2175E+20", "1.39407E+21", "1.84E+18", "3.68436E+18"));
			Rows.Add( new AllStageStatsRow("ID_146", "147", "3.6599E+19", "1.09797E+20", "4.75788E+20", "1.86986E+21", "2.4E+18", "7.21497E+18"));
			Rows.Add( new AllStageStatsRow("ID_147", "148", "4.99577E+19", "1.99831E+20", "6.99408E+20", "2.56927E+21", "3.14E+18", "1.56987E+19"));
			Rows.Add( new AllStageStatsRow("ID_148", "149", "6.81923E+19", "3.40961E+20", "1.02288E+21", "3.59215E+21", "4.1E+18", "4.09897E+19"));
			Rows.Add( new AllStageStatsRow("ID_149", "150", "9.30824E+19", "5.58495E+20", "1.48932E+21", "5.08147E+21", "5.35E+18", "8.02688E+19"));
			Rows.Add( new AllStageStatsRow("ID_150", "151", "1.27058E+20", "2.54115E+20", "1.52469E+21", "6.60616E+21", "6.99E+18", "1.39723E+19"));
			Rows.Add( new AllStageStatsRow("ID_151", "152", "1.73434E+20", "5.20301E+20", "2.25464E+21", "8.8608E+21", "9.12E+18", "2.73614E+19"));
			Rows.Add( new AllStageStatsRow("ID_152", "153", "2.36737E+20", "9.46947E+20", "3.31431E+21", "1.21751E+22", "1.19E+19", "5.95344E+19"));
			Rows.Add( new AllStageStatsRow("ID_153", "154", "3.23146E+20", "1.61573E+21", "4.84718E+21", "1.70223E+22", "1.55E+19", "1.55446E+20"));
			Rows.Add( new AllStageStatsRow("ID_154", "155", "4.41094E+20", "2.64656E+21", "7.0575E+21", "2.40798E+22", "2.03E+19", "3.04404E+20"));
			Rows.Add( new AllStageStatsRow("ID_155", "156", "6.02093E+20", "1.20419E+21", "7.22512E+21", "3.13049E+22", "2.65E+19", "5.29871E+19"));
			Rows.Add( new AllStageStatsRow("ID_156", "157", "8.21857E+20", "2.46557E+21", "1.06841E+22", "4.19891E+22", "3.46E+19", "1.03763E+20"));
			Rows.Add( new AllStageStatsRow("ID_157", "158", "1.12183E+21", "4.48734E+21", "1.57057E+22", "5.76947E+22", "4.52E+19", "2.25773E+20"));
			Rows.Add( new AllStageStatsRow("ID_158", "159", "1.5313E+21", "7.65652E+21", "2.29696E+22", "8.06643E+22", "5.89E+19", "5.89498E+20"));
			Rows.Add( new AllStageStatsRow("ID_159", "160", "2.09023E+21", "1.25414E+22", "3.34437E+22", "1.14108E+23", "7.7E+19", "1.1544E+21"));
			Rows.Add( new AllStageStatsRow("ID_160", "161", "2.85316E+21", "5.70633E+21", "3.4238E+22", "1.48346E+23", "1E+20", "2.00944E+20"));
			Rows.Add( new AllStageStatsRow("ID_161", "162", "3.89457E+21", "1.16837E+22", "5.06294E+22", "1.98975E+23", "1.31E+20", "3.93501E+20"));
			Rows.Add( new AllStageStatsRow("ID_162", "163", "5.31609E+21", "2.12644E+22", "7.44252E+22", "2.73401E+23", "1.71E+20", "8.56201E+20"));
			Rows.Add( new AllStageStatsRow("ID_163", "164", "7.25646E+21", "3.62823E+22", "1.08847E+23", "3.82248E+23", "2.24E+20", "2.23556E+21"));
			Rows.Add( new AllStageStatsRow("ID_164", "165", "9.90507E+21", "5.94304E+22", "1.58481E+23", "5.40729E+23", "2.92E+20", "4.37782E+21"));
			Rows.Add( new AllStageStatsRow("ID_165", "166", "1.35204E+22", "2.70408E+22", "1.62245E+23", "7.02974E+23", "3.81E+20", "7.6204E+20"));
			Rows.Add( new AllStageStatsRow("ID_166", "167", "1.84554E+22", "5.53661E+22", "2.3992E+23", "9.42893E+23", "4.97E+20", "1.49228E+21"));
			Rows.Add( new AllStageStatsRow("ID_167", "168", "2.51916E+22", "1.00766E+23", "3.52682E+23", "1.29558E+24", "6.49E+20", "3.24698E+21"));
			Rows.Add( new AllStageStatsRow("ID_168", "169", "3.43865E+22", "1.71933E+23", "5.15798E+23", "1.81137E+24", "8.48E+20", "8.47794E+21"));
			Rows.Add( new AllStageStatsRow("ID_169", "170", "4.69376E+22", "2.81626E+23", "7.51001E+23", "2.56237E+24", "1.11E+21", "1.66021E+22"));
			Rows.Add( new AllStageStatsRow("ID_170", "171", "6.40698E+22", "1.2814E+23", "7.68838E+23", "3.33121E+24", "1.44E+21", "2.88989E+21"));
			Rows.Add( new AllStageStatsRow("ID_171", "172", "8.74553E+22", "2.62366E+23", "1.13692E+24", "4.46813E+24", "1.89E+21", "5.65918E+21"));
			Rows.Add( new AllStageStatsRow("ID_172", "173", "1.19376E+23", "4.77506E+23", "1.67127E+24", "6.1394E+24", "2.46E+21", "1.23136E+22"));
			Rows.Add( new AllStageStatsRow("ID_173", "174", "1.62949E+23", "8.14744E+23", "2.44423E+24", "8.58363E+24", "3.22E+21", "3.2151E+22"));
			Rows.Add( new AllStageStatsRow("ID_174", "175", "2.22425E+23", "1.33455E+24", "3.5588E+24", "1.21424E+25", "4.2E+21", "6.29602E+22"));
			Rows.Add( new AllStageStatsRow("ID_175", "176", "3.0361E+23", "6.07221E+23", "3.64332E+24", "1.57858E+25", "5.48E+21", "1.09594E+22"));
			Rows.Add( new AllStageStatsRow("ID_176", "177", "4.14428E+23", "1.24328E+24", "5.38757E+24", "2.11733E+25", "7.15E+21", "2.14614E+22"));
			Rows.Add( new AllStageStatsRow("ID_177", "178", "5.65694E+23", "2.26278E+24", "7.91972E+24", "2.90931E+25", "9.34E+21", "4.66968E+22"));
			Rows.Add( new AllStageStatsRow("ID_178", "179", "7.72173E+23", "3.86086E+24", "1.15826E+25", "4.06756E+25", "1.22E+22", "1.21926E+23"));
			Rows.Add( new AllStageStatsRow("ID_179", "180", "1.05402E+24", "6.3241E+24", "1.68643E+25", "5.75399E+25", "1.59E+22", "2.38765E+23"));
			Rows.Add( new AllStageStatsRow("ID_180", "181", "1.43873E+24", "2.87746E+24", "1.72648E+25", "7.48047E+25", "2.08E+22", "4.15613E+22"));
			Rows.Add( new AllStageStatsRow("ID_181", "182", "1.96387E+24", "5.89161E+24", "2.55303E+25", "1.00335E+26", "2.71E+22", "8.13882E+22"));
			Rows.Add( new AllStageStatsRow("ID_182", "183", "2.68068E+24", "1.07227E+25", "3.75295E+25", "1.37865E+26", "3.54E+22", "1.77089E+23"));
			Rows.Add( new AllStageStatsRow("ID_183", "184", "3.65913E+24", "1.82957E+25", "5.4887E+25", "1.92751E+26", "4.62E+22", "4.62383E+23"));
			Rows.Add( new AllStageStatsRow("ID_184", "185", "4.99471E+24", "2.99683E+25", "7.99154E+25", "2.72667E+26", "6.04E+22", "9.05469E+23"));
			Rows.Add( new AllStageStatsRow("ID_185", "186", "6.81778E+24", "1.36356E+25", "8.18134E+25", "3.5448E+26", "7.88E+22", "1.57613E+23"));
			Rows.Add( new AllStageStatsRow("ID_186", "187", "9.30627E+24", "2.79188E+25", "1.20982E+26", "4.75462E+26", "1.03E+23", "3.08649E+23"));
			Rows.Add( new AllStageStatsRow("ID_187", "188", "1.27031E+25", "5.08123E+25", "1.77843E+26", "6.53305E+26", "1.34E+23", "6.71575E+23"));
			Rows.Add( new AllStageStatsRow("ID_188", "189", "1.73397E+25", "8.66984E+25", "2.60095E+26", "9.134E+26", "1.75E+23", "1.7535E+24"));
			Rows.Add( new AllStageStatsRow("ID_189", "190", "2.36687E+25", "1.42012E+26", "3.78699E+26", "1.2921E+27", "2.29E+23", "3.43382E+24"));
			Rows.Add( new AllStageStatsRow("ID_190", "191", "3.23077E+25", "6.46155E+25", "3.87693E+26", "1.67979E+27", "2.99E+23", "5.97719E+23"));
			Rows.Add( new AllStageStatsRow("ID_191", "192", "4.41E+25", "1.323E+26", "5.73301E+26", "2.25309E+27", "3.9E+23", "1.17049E+24"));
			Rows.Add( new AllStageStatsRow("ID_192", "193", "6.01966E+25", "2.40786E+26", "8.42752E+26", "3.09584E+27", "5.09E+23", "2.54682E+24"));
			Rows.Add( new AllStageStatsRow("ID_193", "194", "8.21683E+25", "4.10842E+26", "1.23252E+27", "4.32837E+27", "6.65E+23", "6.64981E+24"));
			Rows.Add( new AllStageStatsRow("ID_194", "195", "1.1216E+26", "6.72958E+26", "1.79456E+27", "6.12292E+27", "8.68E+23", "1.30221E+25"));
			Rows.Add( new AllStageStatsRow("ID_195", "196", "1.53098E+26", "3.06196E+26", "1.83718E+27", "7.9601E+27", "1.13E+24", "2.26674E+24"));
			Rows.Add( new AllStageStatsRow("ID_196", "197", "2.08979E+26", "6.26937E+26", "2.71672E+27", "1.06768E+28", "1.48E+24", "4.43888E+24"));
			Rows.Add( new AllStageStatsRow("ID_197", "198", "2.85256E+26", "1.14102E+27", "3.99359E+27", "1.46704E+28", "1.93E+24", "9.65834E+24"));
			Rows.Add( new AllStageStatsRow("ID_198", "199", "3.89375E+26", "1.94687E+27", "5.84062E+27", "2.0511E+28", "2.52E+24", "2.52182E+25"));
			Rows.Add( new AllStageStatsRow("ID_199", "200", "5.31496E+26", "3.18898E+27", "8.50394E+27", "2.9015E+28", "3.29E+24", "4.93839E+25"));
			Rows.Add( new AllStageStatsRow("ID_200", "201", "7.25493E+26", "1.45099E+27", "8.70591E+27", "3.77209E+28", "4.3E+24", "8.59617E+24"));
			Rows.Add( new AllStageStatsRow("ID_201", "202", "9.90297E+26", "2.97089E+27", "1.28739E+28", "5.05947E+28", "5.61E+24", "1.68336E+25"));
			Rows.Add( new AllStageStatsRow("ID_202", "203", "1.35176E+27", "5.40702E+27", "1.89246E+28", "6.95193E+28", "7.33E+24", "3.66274E+25"));
			Rows.Add( new AllStageStatsRow("ID_203", "204", "1.84515E+27", "9.22573E+27", "2.76772E+28", "9.71965E+28", "9.56E+24", "9.5635E+25"));
			Rows.Add( new AllStageStatsRow("ID_204", "205", "2.51863E+27", "1.51118E+28", "4.0298E+28", "1.37495E+29", "1.25E+25", "1.87279E+26"));
			Rows.Add( new AllStageStatsRow("ID_205", "206", "3.43792E+27", "6.87585E+27", "4.12551E+28", "1.7875E+29", "1.63E+25", "3.25993E+25"));
			Rows.Add( new AllStageStatsRow("ID_206", "207", "4.69277E+27", "1.40783E+28", "6.10059E+28", "2.39756E+29", "2.13E+25", "6.38382E+25"));
			Rows.Add( new AllStageStatsRow("ID_207", "208", "6.40562E+27", "2.56225E+28", "8.96787E+28", "3.29434E+29", "2.78E+25", "1.38903E+26"));
			Rows.Add( new AllStageStatsRow("ID_208", "209", "8.74368E+27", "4.37184E+28", "1.31155E+29", "4.60589E+29", "3.63E+25", "3.62678E+26"));
			Rows.Add( new AllStageStatsRow("ID_209", "210", "1.19351E+28", "7.16107E+28", "1.90962E+29", "6.51551E+29", "4.73E+25", "7.1022E+26"));
			Rows.Add( new AllStageStatsRow("ID_210", "211", "1.62914E+28", "3.25829E+28", "1.95497E+29", "8.47049E+29", "6.18E+25", "1.23627E+26"));
			Rows.Add( new AllStageStatsRow("ID_211", "212", "2.22378E+28", "6.67134E+28", "2.89092E+29", "1.13614E+30", "8.07E+25", "2.42094E+26"));
			Rows.Add( new AllStageStatsRow("ID_212", "213", "3.03546E+28", "1.21418E+29", "4.24965E+29", "1.5611E+30", "1.05E+26", "5.26761E+26"));
			Rows.Add( new AllStageStatsRow("ID_213", "214", "4.14341E+28", "2.0717E+29", "6.21511E+29", "2.18262E+30", "1.38E+26", "1.37539E+27"));
			Rows.Add( new AllStageStatsRow("ID_214", "215", "5.65575E+28", "3.39345E+29", "9.0492E+29", "3.08754E+30", "1.8E+26", "2.69337E+27"));
			Rows.Add( new AllStageStatsRow("ID_215", "216", "7.7201E+28", "1.54402E+29", "9.26412E+29", "4.01395E+30", "2.34E+26", "4.68831E+26"));
			Rows.Add( new AllStageStatsRow("ID_216", "217", "1.05379E+29", "3.16138E+29", "1.36993E+30", "5.38388E+30", "3.06E+26", "9.18096E+26"));
			Rows.Add( new AllStageStatsRow("ID_217", "218", "1.43843E+29", "5.75371E+29", "2.0138E+30", "7.39768E+30", "4E+26", "1.99764E+27"));
			Rows.Add( new AllStageStatsRow("ID_218", "219", "1.96345E+29", "9.81727E+29", "2.94518E+30", "1.03429E+31", "5.22E+26", "5.21589E+27"));
			Rows.Add( new AllStageStatsRow("ID_219", "220", "2.68011E+29", "1.60807E+30", "4.28818E+30", "1.4631E+31", "6.81E+26", "1.02141E+28"));
			Rows.Add( new AllStageStatsRow("ID_220", "221", "3.65836E+29", "7.31671E+29", "4.39003E+30", "1.90211E+31", "8.89E+26", "1.77795E+27"));
			Rows.Add( new AllStageStatsRow("ID_221", "222", "4.99366E+29", "1.4981E+30", "6.49175E+30", "2.55128E+31", "1.16E+27", "3.48171E+27"));
			Rows.Add( new AllStageStatsRow("ID_222", "223", "6.81634E+29", "2.72654E+30", "9.54288E+30", "3.50557E+31", "1.52E+27", "7.57568E+27"));
			Rows.Add( new AllStageStatsRow("ID_223", "224", "9.3043E+29", "4.65215E+30", "1.39565E+31", "4.90122E+31", "1.98E+27", "1.97803E+28"));
			Rows.Add( new AllStageStatsRow("ID_224", "225", "1.27004E+30", "7.62023E+30", "2.03206E+31", "6.93328E+31", "2.58E+27", "3.87351E+28"));
			Rows.Add( new AllStageStatsRow("ID_225", "226", "1.7336E+30", "3.4672E+30", "2.08032E+31", "9.0136E+31", "3.37E+27", "6.74255E+27"));
			Rows.Add( new AllStageStatsRow("ID_226", "227", "2.36637E+30", "7.0991E+30", "3.07628E+31", "1.20899E+32", "4.4E+27", "1.32037E+28"));
			Rows.Add( new AllStageStatsRow("ID_227", "228", "3.23009E+30", "1.29204E+31", "4.52212E+31", "1.6612E+32", "5.75E+27", "2.87293E+28"));
			Rows.Add( new AllStageStatsRow("ID_228", "229", "4.40907E+30", "2.20454E+31", "6.61361E+31", "2.32256E+32", "7.5E+27", "7.5013E+28"));
			Rows.Add( new AllStageStatsRow("ID_229", "230", "6.01838E+30", "3.61103E+31", "9.62941E+31", "3.2855E+32", "9.79E+27", "1.46895E+29"));
			Rows.Add( new AllStageStatsRow("ID_230", "231", "8.21509E+30", "1.64302E+31", "9.85811E+31", "4.27131E+32", "1.28E+28", "2.55698E+28"));
			Rows.Add( new AllStageStatsRow("ID_231", "232", "1.12136E+31", "3.36408E+31", "1.45777E+32", "5.72908E+32", "1.67E+28", "5.00726E+28"));
			Rows.Add( new AllStageStatsRow("ID_232", "233", "1.53066E+31", "6.12263E+31", "2.14292E+32", "7.872E+32", "2.18E+28", "1.08951E+29"));
			Rows.Add( new AllStageStatsRow("ID_233", "234", "2.08935E+31", "1.04467E+32", "3.13402E+32", "1.1006E+33", "2.84E+28", "2.84472E+29"));
			Rows.Add( new AllStageStatsRow("ID_234", "235", "2.85196E+31", "1.71117E+32", "4.56313E+32", "1.55692E+33", "3.71E+28", "5.57073E+29"));
			Rows.Add( new AllStageStatsRow("ID_235", "236", "3.89292E+31", "7.78584E+31", "4.67151E+32", "2.02407E+33", "4.85E+28", "9.69687E+28"));
			Rows.Add( new AllStageStatsRow("ID_236", "237", "5.31384E+31", "1.59415E+32", "6.90799E+32", "2.71486E+33", "6.33E+28", "1.89891E+29"));
			Rows.Add( new AllStageStatsRow("ID_237", "238", "7.25339E+31", "2.90136E+32", "1.01547E+33", "3.73034E+33", "8.26E+28", "4.13174E+29"));
			Rows.Add( new AllStageStatsRow("ID_238", "239", "9.90088E+31", "4.95044E+32", "1.48513E+33", "5.21547E+33", "1.08E+29", "1.07881E+30"));
			Rows.Add( new AllStageStatsRow("ID_239", "240", "1.35147E+32", "8.10882E+32", "2.16235E+33", "7.37782E+33", "1.41E+29", "2.11259E+30"));
			Rows.Add( new AllStageStatsRow("ID_240", "241", "1.84476E+32", "3.68951E+32", "2.21371E+33", "9.59153E+33", "1.84E+29", "3.67735E+29"));
			Rows.Add( new AllStageStatsRow("ID_241", "242", "2.51809E+32", "7.55428E+32", "3.27352E+33", "1.28651E+34", "2.4E+29", "7.20124E+29"));
			Rows.Add( new AllStageStatsRow("ID_242", "243", "3.4372E+32", "1.37488E+33", "4.81207E+33", "1.76771E+34", "3.13E+29", "1.56688E+30"));
			Rows.Add( new AllStageStatsRow("ID_243", "244", "4.69177E+32", "2.34589E+33", "7.03766E+33", "2.47148E+34", "4.09E+29", "4.09117E+30"));
			Rows.Add( new AllStageStatsRow("ID_244", "245", "6.40427E+32", "3.84256E+33", "1.02468E+34", "3.49616E+34", "5.34E+29", "8.01161E+30"));
			Rows.Add( new AllStageStatsRow("ID_245", "246", "8.74183E+32", "1.74837E+33", "1.04902E+34", "4.54518E+34", "6.97E+29", "1.39457E+30"));
			Rows.Add( new AllStageStatsRow("ID_246", "247", "1.19326E+33", "3.57978E+33", "1.55124E+34", "6.09642E+34", "9.1E+29", "2.73093E+30"));
			Rows.Add( new AllStageStatsRow("ID_247", "248", "1.6288E+33", "6.5152E+33", "2.28032E+34", "8.37674E+34", "1.19E+30", "5.94211E+30"));
			Rows.Add( new AllStageStatsRow("ID_248", "249", "2.22331E+33", "1.11166E+34", "3.33497E+34", "1.17117E+35", "1.55E+30", "1.5515E+31"));
			Rows.Add( new AllStageStatsRow("ID_249", "250", "3.03482E+33", "1.82089E+34", "4.85571E+34", "1.65674E+35", "2.03E+30", "3.03825E+31"));
			Rows.Add( new AllStageStatsRow("ID_250", "251", "4.14253E+33", "8.28506E+33", "4.97103E+34", "2.15384E+35", "2.64E+30", "5.28863E+30"));
			Rows.Add( new AllStageStatsRow("ID_251", "252", "5.65455E+33", "1.69637E+34", "7.35092E+34", "2.88894E+35", "3.45E+30", "1.03566E+31"));
			Rows.Add( new AllStageStatsRow("ID_252", "253", "7.71846E+33", "3.08739E+34", "1.08058E+35", "3.96952E+35", "4.51E+30", "2.25343E+31"));
			Rows.Add( new AllStageStatsRow("ID_253", "254", "1.05357E+34", "5.26785E+34", "1.58036E+35", "5.54988E+35", "5.88E+30", "5.88377E+31"));
			Rows.Add( new AllStageStatsRow("ID_254", "255", "1.43812E+34", "8.62874E+34", "2.301E+35", "7.85087E+35", "7.68E+30", "1.1522E+32"));
			Rows.Add( new AllStageStatsRow("ID_255", "256", "1.96304E+34", "3.92608E+34", "2.35565E+35", "1.02065E+36", "1E+31", "2.00561E+31"));
			Rows.Add( new AllStageStatsRow("ID_256", "257", "2.67955E+34", "8.03864E+34", "3.48341E+35", "1.36899E+36", "1.31E+31", "3.92753E+31"));
			Rows.Add( new AllStageStatsRow("ID_257", "258", "3.65758E+34", "1.46303E+35", "5.12061E+35", "1.88105E+36", "1.71E+31", "8.54572E+31"));
			Rows.Add( new AllStageStatsRow("ID_258", "259", "4.9926E+34", "2.4963E+35", "7.4889E+35", "2.62994E+36", "2.23E+31", "2.23131E+32"));
			Rows.Add( new AllStageStatsRow("ID_259", "260", "6.8149E+34", "4.08894E+35", "1.09038E+36", "3.72033E+36", "2.91E+31", "4.3695E+32"));
			Rows.Add( new AllStageStatsRow("ID_260", "261", "9.30234E+34", "1.86047E+35", "1.11628E+36", "4.83661E+36", "3.8E+31", "7.6059E+31"));
			Rows.Add( new AllStageStatsRow("ID_261", "262", "1.26977E+35", "3.80931E+35", "1.6507E+36", "6.48731E+36", "4.96E+31", "1.48944E+32"));
			Rows.Add( new AllStageStatsRow("ID_262", "263", "1.73323E+35", "6.93294E+35", "2.42653E+36", "8.91384E+36", "6.48E+31", "3.2408E+32"));
			Rows.Add( new AllStageStatsRow("ID_263", "264", "2.36587E+35", "1.18293E+36", "3.5488E+36", "1.24626E+37", "8.46E+31", "8.46181E+32"));
			Rows.Add( new AllStageStatsRow("ID_264", "265", "3.22941E+35", "1.93764E+36", "5.16705E+36", "1.76297E+37", "1.1E+32", "1.65705E+33"));
			Rows.Add( new AllStageStatsRow("ID_265", "266", "4.40814E+35", "8.81628E+35", "5.28977E+36", "2.29194E+37", "1.44E+32", "2.88439E+32"));
			Rows.Add( new AllStageStatsRow("ID_266", "267", "6.01711E+35", "1.80513E+36", "7.82224E+36", "3.07417E+37", "1.88E+32", "5.64842E+32"));
			Rows.Add( new AllStageStatsRow("ID_267", "268", "8.21335E+35", "3.28534E+36", "1.14987E+37", "4.22404E+37", "2.46E+32", "1.22901E+33"));
			Rows.Add( new AllStageStatsRow("ID_268", "269", "1.12112E+36", "5.60561E+36", "1.68168E+37", "5.90572E+37", "3.21E+32", "3.20898E+33"));
			Rows.Add( new AllStageStatsRow("ID_269", "270", "1.53033E+36", "9.182E+36", "2.44853E+37", "8.35426E+37", "4.19E+32", "6.28404E+33"));
			Rows.Add( new AllStageStatsRow("ID_270", "271", "2.0889E+36", "4.17781E+36", "2.50669E+37", "1.08609E+38", "5.47E+32", "1.09385E+33"));
			Rows.Add( new AllStageStatsRow("ID_271", "272", "2.85135E+36", "8.55406E+36", "3.70676E+37", "1.45677E+38", "7.14E+32", "2.14205E+33"));
			Rows.Add( new AllStageStatsRow("ID_272", "273", "3.8921E+36", "1.55684E+37", "5.44894E+37", "2.00166E+38", "9.32E+32", "4.6608E+33"));
			Rows.Add( new AllStageStatsRow("ID_273", "274", "5.31271E+36", "2.65636E+37", "7.96907E+37", "2.79857E+38", "1.22E+33", "1.21694E+34"));
			Rows.Add( new AllStageStatsRow("ID_274", "275", "7.25186E+36", "4.35111E+37", "1.1603E+38", "3.95887E+38", "1.59E+33", "2.3831E+34"));
			Rows.Add( new AllStageStatsRow("ID_275", "276", "9.89878E+36", "1.97976E+37", "1.18785E+38", "5.14672E+38", "2.07E+33", "4.14823E+33"));
			Rows.Add( new AllStageStatsRow("ID_276", "277", "1.35118E+37", "4.05355E+37", "1.75654E+38", "6.90326E+38", "2.71E+33", "8.12333E+33"));
			Rows.Add( new AllStageStatsRow("ID_277", "278", "1.84437E+37", "7.37746E+37", "2.58211E+38", "9.48537E+38", "3.54E+33", "1.76752E+34"));
			Rows.Add( new AllStageStatsRow("ID_278", "279", "2.51756E+37", "1.25878E+38", "3.77634E+38", "1.32617E+39", "4.62E+33", "4.61503E+34"));
			Rows.Add( new AllStageStatsRow("ID_279", "280", "3.43647E+37", "2.06188E+38", "5.49835E+38", "1.87601E+39", "6.02E+33", "9.03747E+34"));
			Rows.Add( new AllStageStatsRow("ID_280", "281", "4.69078E+37", "9.38156E+37", "5.62894E+38", "2.4389E+39", "7.87E+33", "1.57314E+34"));
			Rows.Add( new AllStageStatsRow("ID_281", "282", "6.40291E+37", "1.92087E+38", "8.32379E+38", "3.27128E+39", "1.03E+34", "3.08062E+34"));
			Rows.Add( new AllStageStatsRow("ID_282", "283", "8.73998E+37", "3.49599E+38", "1.2236E+39", "4.49488E+39", "1.34E+34", "6.70298E+34"));
			Rows.Add( new AllStageStatsRow("ID_283", "284", "1.19301E+38", "5.96504E+38", "1.78951E+39", "6.28439E+39", "1.75E+34", "1.75016E+35"));
			Rows.Add( new AllStageStatsRow("ID_284", "285", "1.62845E+38", "9.77073E+38", "2.60553E+39", "8.88991E+39", "2.28E+34", "3.42729E+35"));
			Rows.Add( new AllStageStatsRow("ID_285", "286", "2.22284E+38", "4.44568E+38", "2.66741E+39", "1.15573E+40", "2.98E+34", "5.96582E+34"));
			Rows.Add( new AllStageStatsRow("ID_286", "287", "3.03418E+38", "9.10253E+38", "3.94443E+39", "1.55018E+40", "3.89E+34", "1.16827E+35"));
			Rows.Add( new AllStageStatsRow("ID_287", "288", "4.14165E+38", "1.65666E+39", "5.79831E+39", "2.13001E+40", "5.08E+34", "2.54198E+35"));
			Rows.Add( new AllStageStatsRow("ID_288", "289", "5.65335E+38", "2.82668E+39", "8.48003E+39", "2.97801E+40", "6.64E+34", "6.63716E+35"));
			Rows.Add( new AllStageStatsRow("ID_289", "290", "7.71683E+38", "4.6301E+39", "1.23469E+40", "4.2127E+40", "8.66E+34", "1.29973E+36"));
			Rows.Add( new AllStageStatsRow("ID_290", "291", "1.05335E+39", "2.10669E+39", "1.26402E+40", "5.47672E+40", "1.13E+35", "2.26242E+35"));
			Rows.Add( new AllStageStatsRow("ID_291", "292", "1.43782E+39", "4.31346E+39", "1.86916E+40", "7.34588E+40", "1.48E+35", "4.43043E+35"));
			Rows.Add( new AllStageStatsRow("ID_292", "293", "1.96262E+39", "7.85049E+39", "2.74767E+40", "1.00936E+41", "1.93E+35", "9.63996E+35"));
			Rows.Add( new AllStageStatsRow("ID_293", "294", "2.67898E+39", "1.33949E+40", "4.01847E+40", "1.4112E+41", "2.52E+35", "2.51702E+36"));
			Rows.Add( new AllStageStatsRow("ID_294", "295", "3.65681E+39", "2.19408E+40", "5.85089E+40", "1.99629E+41", "3.29E+35", "4.92899E+36"));
			Rows.Add( new AllStageStatsRow("ID_295", "296", "4.99154E+39", "9.98309E+39", "5.98985E+40", "2.59528E+41", "4.29E+35", "8.57981E+35"));
			Rows.Add( new AllStageStatsRow("ID_296", "297", "6.81346E+39", "2.04404E+40", "8.85749E+40", "3.48103E+41", "5.6E+35", "1.68016E+36"));
			Rows.Add( new AllStageStatsRow("ID_297", "298", "9.30037E+39", "3.72015E+40", "1.30205E+41", "4.78308E+41", "7.31E+35", "3.65577E+36"));
			Rows.Add( new AllStageStatsRow("ID_298", "299", "1.2695E+40", "6.3475E+40", "1.90425E+41", "6.68733E+41", "9.55E+35", "9.54531E+36"));
			Rows.Add( new AllStageStatsRow("ID_299", "300", "1.73287E+40", "1.03972E+41", "2.77259E+41", "9.45992E+41", "1.25E+36", "1.86923E+37"));
			Rows.Add( new AllStageStatsRow("ID_300", "301", "2.36536E+40", "4.73073E+40", "2.83844E+41", "1.22984E+42", "1.63E+36", "3.25373E+36"));
			Rows.Add( new AllStageStatsRow("ID_301", "302", "3.22872E+40", "9.68617E+40", "4.19734E+41", "1.64957E+42", "2.12E+36", "6.37167E+36"));
			Rows.Add( new AllStageStatsRow("ID_302", "303", "4.40721E+40", "1.76288E+41", "6.17009E+41", "2.26658E+42", "2.77E+36", "1.38638E+37"));
			Rows.Add( new AllStageStatsRow("ID_303", "304", "6.01584E+40", "3.00792E+41", "9.02375E+41", "3.16895E+42", "3.62E+36", "3.61988E+37"));
			Rows.Add( new AllStageStatsRow("ID_304", "305", "8.21162E+40", "4.92697E+41", "1.31386E+42", "4.48281E+42", "4.73E+36", "7.08869E+37"));
			Rows.Add( new AllStageStatsRow("ID_305", "306", "1.12089E+41", "2.24177E+41", "1.34506E+42", "5.82788E+42", "6.17E+36", "1.23392E+37"));
			Rows.Add( new AllStageStatsRow("ID_306", "307", "1.53001E+41", "4.59003E+41", "1.98901E+42", "7.81689E+42", "8.05E+36", "2.41634E+37"));
			Rows.Add( new AllStageStatsRow("ID_307", "308", "2.08846E+41", "8.35385E+41", "2.92385E+42", "1.07407E+43", "1.05E+37", "5.25759E+37"));
			Rows.Add( new AllStageStatsRow("ID_308", "309", "2.85075E+41", "1.42538E+42", "4.27613E+42", "1.50169E+43", "1.37E+37", "1.37277E+38"));
			Rows.Add( new AllStageStatsRow("ID_309", "310", "3.89128E+41", "2.33477E+42", "6.22604E+42", "2.12429E+43", "1.79E+37", "2.68825E+38"));
			Rows.Add( new AllStageStatsRow("ID_310", "311", "5.31159E+41", "1.06232E+42", "6.37391E+42", "2.76168E+43", "2.34E+37", "4.67939E+37"));
			Rows.Add( new AllStageStatsRow("ID_311", "312", "7.25032E+41", "2.1751E+42", "9.42542E+42", "3.70422E+43", "3.05E+37", "9.1635E+37"));
			Rows.Add( new AllStageStatsRow("ID_312", "313", "9.89669E+41", "3.95868E+42", "1.38554E+43", "5.08976E+43", "3.99E+37", "1.99384E+38"));
			Rows.Add( new AllStageStatsRow("ID_313", "314", "1.3509E+42", "6.75449E+42", "2.02635E+43", "7.11611E+43", "5.21E+37", "5.20597E+38"));
			Rows.Add( new AllStageStatsRow("ID_314", "315", "1.84398E+42", "1.10639E+43", "2.95036E+43", "1.00665E+44", "6.8E+37", "1.01947E+39"));
			Rows.Add( new AllStageStatsRow("ID_315", "316", "2.51703E+42", "5.03405E+42", "3.02043E+43", "1.30869E+44", "8.87E+37", "1.77457E+38"));
			Rows.Add( new AllStageStatsRow("ID_316", "317", "3.43574E+42", "1.03072E+43", "4.46646E+43", "1.75534E+44", "1.16E+38", "3.47508E+38"));
			Rows.Add( new AllStageStatsRow("ID_317", "318", "4.68979E+42", "1.87591E+43", "6.5657E+43", "2.41191E+44", "1.51E+38", "7.56127E+38"));
			Rows.Add( new AllStageStatsRow("ID_318", "319", "6.40156E+42", "3.20078E+43", "9.60234E+43", "3.37214E+44", "1.97E+38", "1.97426E+39"));
			Rows.Add( new AllStageStatsRow("ID_319", "320", "8.73813E+42", "5.24288E+43", "1.3981E+44", "4.77024E+44", "2.58E+38", "3.86614E+39"));
			Rows.Add( new AllStageStatsRow("ID_320", "321", "1.19275E+43", "2.38551E+43", "1.43131E+44", "6.20155E+44", "3.36E+38", "6.72972E+38"));
			Rows.Add( new AllStageStatsRow("ID_321", "322", "1.62811E+43", "4.88433E+43", "2.11654E+44", "8.31809E+44", "4.39E+38", "1.31786E+39"));
			Rows.Add( new AllStageStatsRow("ID_322", "323", "2.22237E+43", "8.88948E+43", "3.11132E+44", "1.14294E+45", "5.73E+38", "2.86747E+39"));
			Rows.Add( new AllStageStatsRow("ID_323", "324", "3.03354E+43", "1.51677E+44", "4.5503E+44", "1.59797E+45", "7.49E+38", "7.48702E+39"));
			Rows.Add( new AllStageStatsRow("ID_324", "325", "4.14078E+43", "2.48447E+44", "6.62524E+44", "2.2605E+45", "9.77E+38", "1.46616E+40"));
			Rows.Add( new AllStageStatsRow("ID_325", "326", "5.65216E+43", "1.13043E+44", "6.78259E+44", "2.93875E+45", "1.28E+39", "2.55212E+39"));
			Rows.Add( new AllStageStatsRow("ID_326", "327", "7.7152E+43", "2.31456E+44", "1.00298E+45", "3.94173E+45", "1.67E+39", "4.99773E+39"));
			Rows.Add( new AllStageStatsRow("ID_327", "328", "1.05312E+44", "4.2125E+44", "1.47437E+45", "5.4161E+45", "2.17E+39", "1.08743E+40"));
			Rows.Add( new AllStageStatsRow("ID_328", "329", "1.43751E+44", "7.18757E+44", "2.15627E+45", "7.57238E+45", "2.84E+39", "2.83931E+40"));
			Rows.Add( new AllStageStatsRow("ID_329", "330", "1.96221E+44", "1.17732E+45", "3.13953E+45", "1.07119E+46", "3.71E+39", "5.56013E+40"));
			Rows.Add( new AllStageStatsRow("ID_330", "331", "2.67841E+44", "5.35683E+44", "3.2141E+45", "1.3926E+46", "4.84E+39", "9.67842E+39"));
			Rows.Add( new AllStageStatsRow("ID_331", "332", "3.65603E+44", "1.09681E+45", "4.75284E+45", "1.86788E+46", "6.32E+39", "1.89529E+40"));
			Rows.Add( new AllStageStatsRow("ID_332", "333", "4.99049E+44", "1.99619E+45", "6.98668E+45", "2.56655E+46", "8.25E+39", "4.12388E+40"));
			Rows.Add( new AllStageStatsRow("ID_333", "334", "6.81201E+44", "3.40601E+45", "1.0218E+46", "3.58836E+46", "1.08E+40", "1.07675E+41"));
			Rows.Add( new AllStageStatsRow("ID_334", "335", "9.2984E+44", "5.57904E+45", "1.48774E+46", "5.0761E+46", "1.41E+40", "2.10857E+41"));
			Rows.Add( new AllStageStatsRow("ID_335", "336", "1.26923E+45", "2.53846E+45", "1.52308E+46", "6.59918E+46", "1.84E+40", "3.67036E+40"));
			Rows.Add( new AllStageStatsRow("ID_336", "337", "1.7325E+45", "5.1975E+45", "2.25225E+46", "8.85143E+46", "2.4E+40", "7.18754E+40"));
			Rows.Add( new AllStageStatsRow("ID_337", "338", "2.36486E+45", "9.45946E+45", "3.31081E+46", "1.21622E+47", "3.13E+40", "1.5639E+41"));
			Rows.Add( new AllStageStatsRow("ID_338", "339", "3.22804E+45", "1.61402E+46", "4.84206E+46", "1.70043E+47", "4.08E+40", "4.08339E+41"));
			Rows.Add( new AllStageStatsRow("ID_339", "340", "4.40627E+45", "2.64376E+46", "7.05004E+46", "2.40543E+47", "5.33E+40", "7.99637E+41"));
			Rows.Add( new AllStageStatsRow("ID_340", "341", "6.01456E+45", "1.20291E+46", "7.21748E+46", "3.12718E+47", "6.96E+40", "1.39191E+41"));
			Rows.Add( new AllStageStatsRow("ID_341", "342", "8.20988E+45", "2.46296E+46", "1.06728E+47", "4.19447E+47", "9.09E+40", "2.72574E+41"));
			Rows.Add( new AllStageStatsRow("ID_342", "343", "1.12065E+46", "4.48259E+46", "1.56891E+47", "5.76337E+47", "1.19E+41", "5.93081E+41"));
			Rows.Add( new AllStageStatsRow("ID_343", "344", "1.52969E+46", "7.64843E+46", "2.29453E+47", "8.0579E+47", "1.55E+41", "1.54855E+42"));
			Rows.Add( new AllStageStatsRow("ID_344", "345", "2.08802E+46", "1.25281E+47", "3.34083E+47", "1.13987E+48", "2.02E+41", "3.03247E+42"));
			Rows.Add( new AllStageStatsRow("ID_345", "346", "2.85015E+46", "5.7003E+46", "3.42018E+47", "1.48189E+48", "2.64E+41", "5.27857E+41"));
			Rows.Add( new AllStageStatsRow("ID_346", "347", "3.89045E+46", "1.16714E+47", "5.05759E+47", "1.98765E+48", "3.45E+41", "1.03368E+42"));
			Rows.Add( new AllStageStatsRow("ID_347", "348", "5.31047E+46", "2.12419E+47", "7.43465E+47", "2.73112E+48", "4.5E+41", "2.24915E+42"));
			Rows.Add( new AllStageStatsRow("ID_348", "349", "7.24879E+46", "3.62439E+47", "1.08732E+48", "3.81843E+48", "5.87E+41", "5.87257E+42"));
			Rows.Add( new AllStageStatsRow("ID_349", "350", "9.89459E+46", "5.93676E+47", "1.58314E+48", "5.40157E+48", "7.67E+41", "1.15001E+43"));
			Rows.Add( new AllStageStatsRow("ID_350", "351", "1.35061E+47", "2.70122E+47", "1.62073E+48", "7.0223E+48", "1E+42", "2.0018E+42"));
			Rows.Add( new AllStageStatsRow("ID_351", "352", "1.84359E+47", "5.53076E+47", "2.39666E+48", "9.41896E+48", "1.31E+42", "3.92005E+42"));
			Rows.Add( new AllStageStatsRow("ID_352", "353", "2.51649E+47", "1.0066E+48", "3.52309E+48", "1.29421E+49", "1.71E+42", "8.52946E+42"));
			Rows.Add( new AllStageStatsRow("ID_353", "354", "3.43501E+47", "1.71751E+48", "5.15252E+48", "1.80946E+49", "2.23E+42", "2.22706E+43"));
			Rows.Add( new AllStageStatsRow("ID_354", "355", "4.68879E+47", "2.81328E+48", "7.50207E+48", "2.55966E+49", "2.91E+42", "4.36118E+43"));
			Rows.Add( new AllStageStatsRow("ID_355", "356", "6.40021E+47", "1.28004E+48", "7.68025E+48", "3.32769E+49", "3.8E+42", "7.59143E+42"));
			Rows.Add( new AllStageStatsRow("ID_356", "357", "8.73628E+47", "2.62088E+48", "1.13572E+49", "4.46341E+49", "4.96E+42", "1.48661E+43"));
			Rows.Add( new AllStageStatsRow("ID_357", "358", "1.1925E+48", "4.77001E+48", "1.6695E+49", "6.13291E+49", "6.47E+42", "3.23463E+43"));
			Rows.Add( new AllStageStatsRow("ID_358", "359", "1.62777E+48", "8.13883E+48", "2.44165E+49", "8.57456E+49", "8.45E+42", "8.44571E+43"));
			Rows.Add( new AllStageStatsRow("ID_359", "360", "2.2219E+48", "1.33314E+49", "3.55504E+49", "1.21296E+50", "1.1E+43", "1.6539E+44"));
			Rows.Add( new AllStageStatsRow("ID_360", "361", "3.03289E+48", "6.06579E+48", "3.63947E+49", "1.57691E+50", "1.44E+43", "2.87891E+43"));
			Rows.Add( new AllStageStatsRow("ID_361", "362", "4.1399E+48", "1.24197E+49", "5.38187E+49", "2.11509E+50", "1.88E+43", "5.63767E+43"));
			Rows.Add( new AllStageStatsRow("ID_362", "363", "5.65096E+48", "2.26039E+49", "7.91135E+49", "2.90623E+50", "2.45E+43", "1.22667E+44"));
			Rows.Add( new AllStageStatsRow("ID_363", "364", "7.71356E+48", "3.85678E+49", "1.15703E+50", "4.06326E+50", "3.2E+43", "3.20287E+44"));
			Rows.Add( new AllStageStatsRow("ID_364", "365", "1.0529E+49", "6.31741E+49", "1.68464E+50", "5.74791E+50", "4.18E+43", "6.27208E+44"));
			Rows.Add( new AllStageStatsRow("ID_365", "366", "1.43721E+49", "2.87442E+49", "1.72465E+50", "7.47256E+50", "5.46E+43", "1.09177E+44"));
			Rows.Add( new AllStageStatsRow("ID_366", "367", "1.96179E+49", "5.88538E+49", "2.55033E+50", "1.00229E+51", "7.13E+43", "2.13798E+44"));
			Rows.Add( new AllStageStatsRow("ID_367", "368", "2.67785E+49", "1.07114E+50", "3.74899E+50", "1.37719E+51", "9.3E+43", "4.65193E+44"));
			Rows.Add( new AllStageStatsRow("ID_368", "369", "3.65526E+49", "1.82763E+50", "5.48289E+50", "1.92548E+51", "1.21E+44", "1.21463E+45"));
			Rows.Add( new AllStageStatsRow("ID_369", "370", "4.98943E+49", "2.99366E+50", "7.98309E+50", "2.72379E+51", "1.59E+44", "2.37857E+45"));
			Rows.Add( new AllStageStatsRow("ID_370", "371", "6.81057E+49", "1.36211E+50", "8.17269E+50", "3.54105E+51", "2.07E+44", "4.14033E+44"));
			Rows.Add( new AllStageStatsRow("ID_371", "372", "9.29643E+49", "2.78893E+50", "1.20854E+51", "4.74959E+51", "2.7E+44", "8.10788E+44"));
			Rows.Add( new AllStageStatsRow("ID_372", "373", "1.26896E+50", "5.07585E+50", "1.77655E+51", "6.52614E+51", "3.53E+44", "1.76416E+45"));
			Rows.Add( new AllStageStatsRow("ID_373", "374", "1.73213E+50", "8.66067E+50", "2.5982E+51", "9.12434E+51", "4.61E+44", "4.60625E+45"));
			Rows.Add( new AllStageStatsRow("ID_374", "375", "2.36436E+50", "1.41862E+51", "3.78298E+51", "1.29073E+52", "6.01E+44", "9.02027E+45"));
			Rows.Add( new AllStageStatsRow("ID_375", "376", "3.22736E+50", "6.45471E+50", "3.87283E+51", "1.67801E+52", "7.85E+44", "1.57014E+45"));
			Rows.Add( new AllStageStatsRow("ID_376", "377", "4.40534E+50", "1.3216E+51", "5.72694E+51", "2.25071E+52", "1.02E+45", "3.07476E+45"));
			Rows.Add( new AllStageStatsRow("ID_377", "378", "6.01329E+50", "2.40532E+51", "8.41861E+51", "3.09257E+52", "1.34E+45", "6.69022E+45"));
			Rows.Add( new AllStageStatsRow("ID_378", "379", "8.20814E+50", "4.10407E+51", "1.23122E+52", "4.32379E+52", "1.75E+45", "1.74683E+46"));
			Rows.Add( new AllStageStatsRow("ID_379", "380", "1.12041E+51", "6.72247E+51", "1.79266E+52", "6.11645E+52", "2.28E+45", "3.42077E+46"));
			Rows.Add( new AllStageStatsRow("ID_380", "381", "1.52936E+51", "3.05872E+51", "1.83523E+52", "7.95168E+52", "2.98E+45", "5.95447E+45"));
			Rows.Add( new AllStageStatsRow("ID_381", "382", "2.08758E+51", "6.26274E+51", "2.71385E+52", "1.06655E+53", "3.89E+45", "1.16604E+46"));
			Rows.Add( new AllStageStatsRow("ID_382", "383", "2.84954E+51", "1.13982E+52", "3.98936E+52", "1.46549E+53", "5.07E+45", "2.53714E+46"));
			Rows.Add( new AllStageStatsRow("ID_383", "384", "3.88963E+51", "1.94481E+52", "5.83444E+52", "2.04893E+53", "6.62E+45", "6.62453E+46"));
			Rows.Add( new AllStageStatsRow("ID_384", "385", "5.30934E+51", "3.18561E+52", "8.49495E+52", "2.89843E+53", "8.65E+45", "1.29726E+47"));
			Rows.Add( new AllStageStatsRow("ID_385", "386", "7.24725E+51", "1.44945E+52", "8.6967E+52", "3.7681E+53", "1.13E+46", "2.25812E+46"));
			Rows.Add( new AllStageStatsRow("ID_386", "387", "9.8925E+51", "2.96775E+52", "1.28603E+53", "5.05412E+53", "1.47E+46", "4.422E+46"));
			Rows.Add( new AllStageStatsRow("ID_387", "388", "1.35033E+52", "5.40131E+52", "1.89046E+53", "6.94458E+53", "1.92E+46", "9.62162E+46"));
			Rows.Add( new AllStageStatsRow("ID_388", "389", "1.8432E+52", "9.21598E+52", "2.76479E+53", "9.70937E+53", "2.51E+46", "2.51223E+47"));
			Rows.Add( new AllStageStatsRow("ID_389", "390", "2.51596E+52", "1.50958E+53", "4.02554E+53", "1.37349E+54", "3.28E+46", "4.91961E+47"));
			Rows.Add( new AllStageStatsRow("ID_390", "391", "3.43429E+52", "6.86858E+52", "4.12115E+53", "1.78561E+54", "4.28E+46", "8.56349E+46"));
			Rows.Add( new AllStageStatsRow("ID_391", "392", "4.6878E+52", "1.40634E+53", "6.09414E+53", "2.39502E+54", "5.59E+46", "1.67696E+47"));
			Rows.Add( new AllStageStatsRow("ID_392", "393", "6.39885E+52", "2.55954E+53", "8.95839E+53", "3.29086E+54", "7.3E+46", "3.64882E+47"));
			Rows.Add( new AllStageStatsRow("ID_393", "394", "8.73443E+52", "4.36722E+53", "1.31016E+54", "4.60102E+54", "9.53E+46", "9.52715E+47"));
			Rows.Add( new AllStageStatsRow("ID_394", "395", "1.19225E+53", "7.1535E+53", "1.9076E+54", "6.50862E+54", "1.24E+47", "1.86567E+48"));
			Rows.Add( new AllStageStatsRow("ID_395", "396", "1.62742E+53", "3.25484E+53", "1.95291E+54", "8.46153E+54", "1.62E+47", "3.24754E+47"));
			Rows.Add( new AllStageStatsRow("ID_396", "397", "2.22143E+53", "6.66429E+53", "2.88786E+54", "1.13494E+55", "2.12E+47", "6.35955E+47"));
			Rows.Add( new AllStageStatsRow("ID_397", "398", "3.03225E+53", "1.2129E+54", "4.24515E+54", "1.55945E+55", "2.77E+47", "1.38374E+48"));
			Rows.Add( new AllStageStatsRow("ID_398", "399", "4.13902E+53", "2.06951E+54", "6.20854E+54", "2.18031E+55", "3.61E+47", "3.61299E+48"));
			Rows.Add( new AllStageStatsRow("ID_399", "400", "5.64977E+53", "3.38986E+54", "9.03963E+54", "3.08427E+55", "4.72E+47", "7.0752E+48"));
			Rows.Add( new AllStageStatsRow("ID_400", "401", "7.71193E+53", "1.54239E+54", "9.25432E+54", "4.0097E+55", "6.16E+47", "1.23157E+48"));
			Rows.Add( new AllStageStatsRow("ID_401", "402", "1.05268E+54", "3.15804E+54", "1.36848E+55", "5.37818E+55", "8.04E+47", "2.41174E+48"));
			Rows.Add( new AllStageStatsRow("ID_402", "403", "1.43691E+54", "5.74763E+54", "2.01167E+55", "7.38985E+55", "1.05E+48", "5.24759E+48"));
			Rows.Add( new AllStageStatsRow("ID_403", "404", "1.96138E+54", "9.80689E+54", "2.94207E+55", "1.03319E+56", "1.37E+48", "1.37016E+49"));
			Rows.Add( new AllStageStatsRow("ID_404", "405", "2.67728E+54", "1.60637E+55", "4.28365E+55", "1.46156E+56", "1.79E+48", "2.68314E+49"));
			Rows.Add( new AllStageStatsRow("ID_405", "406", "3.65449E+54", "7.30897E+54", "4.38538E+55", "1.9001E+56", "2.34E+48", "4.67049E+48"));
			Rows.Add( new AllStageStatsRow("ID_406", "407", "4.98838E+54", "1.49651E+55", "6.48489E+55", "2.54858E+56", "3.05E+48", "9.14606E+48"));
			Rows.Add( new AllStageStatsRow("ID_407", "408", "6.80913E+54", "2.72365E+55", "9.53279E+55", "3.50186E+56", "3.98E+48", "1.99005E+49"));
			Rows.Add( new AllStageStatsRow("ID_408", "409", "9.29447E+54", "4.64723E+55", "1.39417E+56", "4.89603E+56", "5.2E+48", "5.19606E+49"));
			Rows.Add( new AllStageStatsRow("ID_409", "410", "1.26869E+55", "7.61217E+55", "2.02991E+56", "6.92594E+56", "6.78E+48", "1.01753E+50"));
			Rows.Add( new AllStageStatsRow("ID_410", "411", "1.73177E+55", "3.46354E+55", "2.07812E+56", "9.00407E+56", "8.86E+48", "1.77119E+49"));
			Rows.Add( new AllStageStatsRow("ID_411", "412", "2.36386E+55", "7.09159E+55", "3.07302E+56", "1.20771E+57", "1.16E+49", "3.46847E+49"));
			Rows.Add( new AllStageStatsRow("ID_412", "413", "3.22667E+55", "1.29067E+56", "4.51734E+56", "1.65944E+57", "1.51E+49", "7.54688E+49"));
			Rows.Add( new AllStageStatsRow("ID_413", "414", "4.40441E+55", "2.2022E+56", "6.60661E+56", "2.3201E+57", "1.97E+49", "1.97051E+50"));
			Rows.Add( new AllStageStatsRow("ID_414", "415", "6.01202E+55", "3.60721E+56", "9.61923E+56", "3.28203E+57", "2.57E+49", "3.85878E+50"));
			Rows.Add( new AllStageStatsRow("ID_415", "416", "8.20641E+55", "1.64128E+56", "9.84769E+56", "4.2668E+57", "3.36E+49", "6.71691E+49"));
			Rows.Add( new AllStageStatsRow("ID_416", "417", "1.12017E+56", "3.36052E+56", "1.45623E+57", "5.72302E+57", "4.38E+49", "1.31535E+50"));
			Rows.Add( new AllStageStatsRow("ID_417", "418", "1.52904E+56", "6.11615E+56", "2.14065E+57", "7.86368E+57", "5.72E+49", "2.86201E+50"));
			Rows.Add( new AllStageStatsRow("ID_418", "419", "2.08714E+56", "1.04357E+57", "3.13071E+57", "1.09944E+58", "7.47E+49", "7.47278E+50"));
			Rows.Add( new AllStageStatsRow("ID_419", "420", "2.84894E+56", "1.70937E+57", "4.55831E+57", "1.55527E+58", "9.76E+49", "1.46337E+51"));
			Rows.Add( new AllStageStatsRow("ID_420", "421", "3.88881E+56", "7.77761E+56", "4.66657E+57", "2.02193E+58", "1.27E+50", "2.54726E+50"));
			Rows.Add( new AllStageStatsRow("ID_421", "422", "5.30822E+56", "1.59247E+57", "6.90069E+57", "2.71199E+58", "1.66E+50", "4.98822E+50"));
			Rows.Add( new AllStageStatsRow("ID_422", "423", "7.24572E+56", "2.89829E+57", "1.0144E+58", "3.72639E+58", "2.17E+50", "1.08536E+51"));
			Rows.Add( new AllStageStatsRow("ID_423", "424", "9.89041E+56", "4.9452E+57", "1.48356E+58", "5.20996E+58", "2.83E+50", "2.83391E+51"));
			Rows.Add( new AllStageStatsRow("ID_424", "425", "1.35004E+57", "8.10024E+57", "2.16007E+58", "7.37002E+58", "3.7E+50", "5.54955E+51"));
			Rows.Add( new AllStageStatsRow("ID_425", "426", "1.84281E+57", "3.68561E+57", "2.21137E+58", "9.58139E+58", "4.83E+50", "9.66001E+50"));
			Rows.Add( new AllStageStatsRow("ID_426", "427", "2.51543E+57", "7.54629E+57", "3.27006E+58", "1.28514E+59", "6.31E+50", "1.89169E+51"));
			Rows.Add( new AllStageStatsRow("ID_427", "428", "3.43356E+57", "1.37342E+58", "4.80699E+58", "1.76584E+59", "8.23E+50", "4.11603E+51"));
			Rows.Add( new AllStageStatsRow("ID_428", "429", "4.68681E+57", "2.34341E+58", "7.03022E+58", "2.46886E+59", "1.07E+51", "1.07471E+52"));
			Rows.Add( new AllStageStatsRow("ID_429", "430", "6.3975E+57", "3.8385E+58", "1.0236E+59", "3.49246E+59", "1.4E+51", "2.10456E+52"));
			Rows.Add( new AllStageStatsRow("ID_430", "431", "8.73258E+57", "1.74652E+58", "1.04791E+59", "4.54037E+59", "1.83E+51", "3.66337E+51"));
			Rows.Add( new AllStageStatsRow("ID_431", "432", "1.192E+58", "3.57599E+58", "1.5496E+59", "6.08997E+59", "2.39E+51", "7.17387E+51"));
			Rows.Add( new AllStageStatsRow("ID_432", "433", "1.62708E+58", "6.50831E+58", "2.27791E+59", "8.36788E+59", "3.12E+51", "1.56093E+52"));
			Rows.Add( new AllStageStatsRow("ID_433", "434", "2.22096E+58", "1.11048E+59", "3.33144E+59", "1.16993E+60", "4.08E+51", "4.07562E+52"));
			Rows.Add( new AllStageStatsRow("ID_434", "435", "3.03161E+58", "1.81897E+59", "4.85058E+59", "1.65499E+60", "5.32E+51", "7.98115E+52"));
			Rows.Add( new AllStageStatsRow("ID_435", "436", "4.13815E+58", "8.2763E+58", "4.96578E+59", "2.15157E+60", "6.95E+51", "1.38927E+52"));
			Rows.Add( new AllStageStatsRow("ID_436", "437", "5.64857E+58", "1.69457E+59", "7.34314E+59", "2.88588E+60", "9.07E+51", "2.72055E+52"));
			Rows.Add( new AllStageStatsRow("ID_437", "438", "7.7103E+58", "3.08412E+59", "1.07944E+60", "3.96532E+60", "1.18E+52", "5.91952E+52"));
			Rows.Add( new AllStageStatsRow("ID_438", "439", "1.05246E+59", "5.26228E+59", "1.57868E+60", "5.54401E+60", "1.55E+52", "1.5456E+53"));
			Rows.Add( new AllStageStatsRow("ID_439", "440", "1.4366E+59", "8.61961E+59", "2.29856E+60", "7.84257E+60", "2.02E+52", "3.0267E+53"));
			Rows.Add( new AllStageStatsRow("ID_440", "441", "1.96096E+59", "3.92192E+59", "2.35315E+60", "1.01957E+61", "2.63E+52", "5.26852E+52"));
			Rows.Add( new AllStageStatsRow("ID_441", "442", "2.67671E+59", "8.03014E+59", "3.47973E+60", "1.36755E+61", "3.44E+52", "1.03172E+53"));
			Rows.Add( new AllStageStatsRow("ID_442", "443", "3.65371E+59", "1.46149E+60", "5.1152E+60", "1.87907E+61", "4.49E+52", "2.24487E+53"));
			Rows.Add( new AllStageStatsRow("ID_443", "444", "4.98732E+59", "2.49366E+60", "7.48098E+60", "2.62716E+61", "5.86E+52", "5.8614E+53"));
			Rows.Add( new AllStageStatsRow("ID_444", "445", "6.80769E+59", "4.08461E+60", "1.08923E+61", "3.71639E+61", "7.65E+52", "1.14782E+54"));
			Rows.Add( new AllStageStatsRow("ID_445", "446", "9.2925E+59", "1.8585E+60", "1.1151E+61", "4.83149E+61", "9.99E+52", "1.99799E+53"));
			Rows.Add( new AllStageStatsRow("ID_446", "447", "1.26843E+60", "3.80528E+60", "1.64895E+61", "6.48045E+61", "1.3E+53", "3.91259E+53"));
			Rows.Add( new AllStageStatsRow("ID_447", "448", "1.7314E+60", "6.92561E+60", "2.42396E+61", "8.90441E+61", "1.7E+53", "8.51323E+53"));
			Rows.Add( new AllStageStatsRow("ID_448", "449", "2.36336E+60", "1.18168E+61", "3.54504E+61", "1.24495E+62", "2.22E+53", "2.22282E+54"));
			Rows.Add( new AllStageStatsRow("ID_449", "450", "3.22599E+60", "1.93559E+61", "5.16159E+61", "1.7611E+62", "2.9E+53", "4.35288E+54"));
			Rows.Add( new AllStageStatsRow("ID_450", "451", "4.40348E+60", "8.80695E+60", "5.28417E+61", "2.28952E+62", "3.79E+53", "7.57699E+53"));
			Rows.Add( new AllStageStatsRow("ID_451", "452", "6.01075E+60", "1.80322E+61", "7.81397E+61", "3.07092E+62", "4.95E+53", "1.48378E+54"));
			Rows.Add( new AllStageStatsRow("ID_452", "453", "8.20467E+60", "3.28187E+61", "1.14865E+62", "4.21957E+62", "6.46E+53", "3.22848E+54"));
			Rows.Add( new AllStageStatsRow("ID_453", "454", "1.11994E+61", "5.59969E+61", "1.67991E+62", "5.89948E+62", "8.43E+53", "8.42964E+54"));
			Rows.Add( new AllStageStatsRow("ID_454", "455", "1.52871E+61", "9.17229E+61", "2.44594E+62", "8.34542E+62", "1.1E+54", "1.65075E+55"));
			Rows.Add( new AllStageStatsRow("ID_455", "456", "2.0867E+61", "4.17339E+61", "2.50403E+62", "1.08495E+63", "1.44E+54", "2.87343E+54"));
			Rows.Add( new AllStageStatsRow("ID_456", "457", "2.84834E+61", "8.54502E+61", "3.70284E+62", "1.45523E+63", "1.88E+54", "5.62694E+54"));
			Rows.Add( new AllStageStatsRow("ID_457", "458", "3.88798E+61", "1.55519E+62", "5.44318E+62", "1.99955E+63", "2.45E+54", "1.22434E+55"));
			Rows.Add( new AllStageStatsRow("ID_458", "459", "5.3071E+61", "2.65355E+62", "7.96064E+62", "2.79561E+63", "3.2E+54", "3.19678E+55"));
			Rows.Add( new AllStageStatsRow("ID_459", "460", "7.24419E+61", "4.34651E+62", "1.15907E+63", "3.95468E+63", "4.17E+54", "6.26015E+55"));
			Rows.Add( new AllStageStatsRow("ID_460", "461", "9.88831E+61", "1.97766E+62", "1.1866E+63", "5.14128E+63", "5.45E+54", "1.08969E+55"));
			Rows.Add( new AllStageStatsRow("ID_461", "462", "1.34975E+62", "4.04926E+62", "1.75468E+63", "6.89596E+63", "7.11E+54", "2.13391E+55"));
			Rows.Add( new AllStageStatsRow("ID_462", "463", "1.84242E+62", "7.36966E+62", "2.57938E+63", "9.47534E+63", "9.29E+54", "4.64308E+55"));
			Rows.Add( new AllStageStatsRow("ID_463", "464", "2.5149E+62", "1.25745E+63", "3.77235E+63", "1.32477E+64", "1.21E+55", "1.21232E+56"));
			Rows.Add( new AllStageStatsRow("ID_464", "465", "3.43283E+62", "2.0597E+63", "5.49254E+63", "1.87402E+64", "1.58E+55", "2.37404E+56"));
			Rows.Add( new AllStageStatsRow("ID_465", "466", "4.68582E+62", "9.37164E+62", "5.62298E+63", "2.43632E+64", "2.07E+55", "4.13246E+55"));
			Rows.Add( new AllStageStatsRow("ID_466", "467", "6.39614E+62", "1.91884E+63", "8.31499E+63", "3.26782E+64", "2.7E+55", "8.09245E+55"));
			Rows.Add( new AllStageStatsRow("ID_467", "468", "8.73074E+62", "3.49229E+63", "1.2223E+64", "4.49012E+64", "3.52E+55", "1.7608E+56"));
			Rows.Add( new AllStageStatsRow("ID_468", "469", "1.19175E+63", "5.95873E+63", "1.78762E+64", "6.27774E+64", "4.6E+55", "4.59749E+56"));
			Rows.Add( new AllStageStatsRow("ID_469", "470", "1.62673E+63", "9.7604E+63", "2.60277E+64", "8.88051E+64", "6E+55", "9.00311E+56"));
			Rows.Add( new AllStageStatsRow("ID_470", "471", "2.22049E+63", "4.44098E+63", "2.66459E+64", "1.15451E+65", "7.84E+55", "1.56716E+56"));
			Rows.Add( new AllStageStatsRow("ID_471", "472", "3.03097E+63", "9.09291E+63", "3.94026E+64", "1.54854E+65", "1.02E+56", "3.06891E+56"));
			Rows.Add( new AllStageStatsRow("ID_472", "473", "4.13727E+63", "1.65491E+64", "5.79218E+64", "2.12775E+65", "1.34E+56", "6.67749E+56"));
			Rows.Add( new AllStageStatsRow("ID_473", "474", "5.64738E+63", "2.82369E+64", "8.47107E+64", "2.97486E+65", "1.74E+56", "1.74351E+57"));
			Rows.Add( new AllStageStatsRow("ID_474", "475", "7.70867E+63", "4.6252E+64", "1.23339E+65", "4.20825E+65", "2.28E+56", "3.41426E+57"));
			Rows.Add( new AllStageStatsRow("ID_475", "476", "1.05223E+64", "2.10447E+64", "1.26268E+65", "5.47093E+65", "2.97E+56", "5.94314E+56"));
			Rows.Add( new AllStageStatsRow("ID_476", "477", "1.4363E+64", "4.3089E+64", "1.86719E+65", "7.33812E+65", "3.88E+56", "1.16383E+57"));
			Rows.Add( new AllStageStatsRow("ID_477", "478", "1.96055E+64", "7.84219E+64", "2.74477E+65", "1.00829E+66", "5.06E+56", "2.53231E+57"));
			Rows.Add( new AllStageStatsRow("ID_478", "479", "2.67615E+64", "1.33807E+65", "4.01422E+65", "1.40971E+66", "6.61E+56", "6.61193E+57"));
			Rows.Add( new AllStageStatsRow("ID_479", "480", "3.65294E+64", "2.19176E+65", "5.84471E+65", "1.99418E+66", "8.63E+56", "1.29479E+58"));
			Rows.Add( new AllStageStatsRow("ID_480", "481", "4.98626E+64", "9.97253E+64", "5.98352E+65", "2.59253E+66", "1.13E+57", "2.25382E+57"));
			Rows.Add( new AllStageStatsRow("ID_481", "482", "6.80625E+64", "2.04188E+65", "8.84813E+65", "3.47735E+66", "1.47E+57", "4.41359E+57"));
			Rows.Add( new AllStageStatsRow("ID_482", "483", "9.29053E+64", "3.71621E+65", "1.30067E+66", "4.77802E+66", "1.92E+57", "9.60332E+57"));
			Rows.Add( new AllStageStatsRow("ID_483", "484", "1.26816E+65", "6.34079E+65", "1.90224E+66", "6.68026E+66", "2.51E+57", "2.50745E+58"));
			Rows.Add( new AllStageStatsRow("ID_484", "485", "1.73104E+65", "1.03862E+66", "2.76966E+66", "9.44991E+66", "3.27E+57", "4.91025E+58"));
			Rows.Add( new AllStageStatsRow("ID_485", "486", "2.36286E+65", "4.72573E+65", "2.83544E+66", "1.22853E+67", "4.27E+57", "8.54719E+57"));
			Rows.Add( new AllStageStatsRow("ID_486", "487", "3.22531E+65", "9.67592E+65", "4.1929E+66", "1.64782E+67", "5.58E+57", "1.67377E+58"));
			Rows.Add( new AllStageStatsRow("ID_487", "488", "4.40255E+65", "1.76102E+66", "6.16356E+66", "2.26418E+67", "7.28E+57", "3.64188E+58"));
			Rows.Add( new AllStageStatsRow("ID_488", "489", "6.00947E+65", "3.00474E+66", "9.01421E+66", "3.1656E+67", "9.51E+57", "9.50902E+58"));
			Rows.Add( new AllStageStatsRow("ID_489", "490", "8.20293E+65", "4.92176E+66", "1.31247E+67", "4.47807E+67", "1.24E+58", "1.86212E+59"));
			Rows.Add( new AllStageStatsRow("ID_490", "491", "1.1197E+66", "2.2394E+66", "1.34364E+67", "5.82171E+67", "1.62E+58", "3.24136E+58"));
			Rows.Add( new AllStageStatsRow("ID_491", "492", "1.52839E+66", "4.58517E+66", "1.98691E+67", "7.80862E+67", "2.12E+58", "6.34745E+58"));
			Rows.Add( new AllStageStatsRow("ID_492", "493", "2.08625E+66", "8.34502E+66", "2.92076E+67", "1.07294E+68", "2.76E+58", "1.38111E+59"));
			Rows.Add( new AllStageStatsRow("ID_493", "494", "2.84774E+66", "1.42387E+67", "4.2716E+67", "1.5001E+68", "3.61E+58", "3.60612E+59"));
			Rows.Add( new AllStageStatsRow("ID_494", "495", "3.88716E+66", "2.3323E+67", "6.21946E+67", "2.12204E+68", "4.71E+58", "7.06174E+59"));
			Rows.Add( new AllStageStatsRow("ID_495", "496", "5.30597E+66", "1.06119E+67", "6.36717E+67", "2.75876E+68", "6.15E+58", "1.22922E+59"));
			Rows.Add( new AllStageStatsRow("ID_496", "497", "7.24265E+66", "2.1728E+67", "9.41545E+67", "3.70031E+68", "8.02E+58", "2.40715E+59"));
			Rows.Add( new AllStageStatsRow("ID_497", "498", "9.88622E+66", "3.95449E+67", "1.38407E+68", "5.08438E+68", "1.05E+59", "5.2376E+59"));
			Rows.Add( new AllStageStatsRow("ID_498", "499", "1.34947E+67", "6.74735E+67", "2.0242E+68", "7.10858E+68", "1.37E+59", "1.36755E+60"));
			Rows.Add( new AllStageStatsRow("ID_499", "500", "1.84203E+67", "1.10522E+68", "2.94724E+68", "1.00558E+69", "1.79E+59", "2.67803E+60"));
			Rows.Add( new AllStageStatsRow("ID_500", "501", "2.51437E+67", "5.02873E+67", "3.01724E+68", "1.30731E+69", "2.33E+59", "4.6616E+59"));
			Rows.Add( new AllStageStatsRow("ID_501", "502", "3.43211E+67", "1.02963E+68", "4.46174E+68", "1.75348E+69", "3.04E+59", "9.12866E+59"));
			Rows.Add( new AllStageStatsRow("ID_502", "503", "4.68483E+67", "1.87393E+68", "6.55876E+68", "2.40936E+69", "3.97E+59", "1.98626E+60"));
			Rows.Add( new AllStageStatsRow("ID_503", "504", "6.39479E+67", "3.1974E+68", "9.59219E+68", "3.36857E+69", "5.19E+59", "5.18618E+60"));
			Rows.Add( new AllStageStatsRow("ID_504", "505", "8.72889E+67", "5.23733E+68", "1.39662E+69", "4.7652E+69", "6.77E+59", "1.01559E+61"));
			Rows.Add( new AllStageStatsRow("ID_505", "506", "1.19149E+68", "2.38299E+68", "1.42979E+69", "6.19499E+69", "8.84E+59", "1.76782E+60"));
			Rows.Add( new AllStageStatsRow("ID_506", "507", "1.62639E+68", "4.87917E+68", "2.1143E+69", "8.30929E+69", "1.15E+60", "3.46187E+60"));
			Rows.Add( new AllStageStatsRow("ID_507", "508", "2.22002E+68", "8.88008E+68", "3.10803E+69", "1.14173E+70", "1.51E+60", "7.53252E+60"));
			Rows.Add( new AllStageStatsRow("ID_508", "509", "3.03033E+68", "1.51516E+69", "4.54549E+69", "1.59628E+70", "1.97E+60", "1.96676E+61"));
			Rows.Add( new AllStageStatsRow("ID_509", "510", "4.1364E+68", "2.48184E+69", "6.61824E+69", "2.2581E+70", "2.57E+60", "3.85144E+61"));
			Rows.Add( new AllStageStatsRow("ID_510", "511", "5.64618E+68", "1.12924E+69", "6.77542E+69", "2.93565E+70", "3.35E+60", "6.70413E+60"));
			Rows.Add( new AllStageStatsRow("ID_511", "512", "7.70704E+68", "2.31211E+69", "1.00191E+70", "3.93756E+70", "4.38E+60", "1.31285E+61"));
			Rows.Add( new AllStageStatsRow("ID_512", "513", "1.05201E+69", "4.20804E+69", "1.47281E+70", "5.41038E+70", "5.71E+60", "2.85657E+61"));
			Rows.Add( new AllStageStatsRow("ID_513", "514", "1.43599E+69", "7.17997E+69", "2.15399E+70", "7.56437E+70", "7.46E+60", "7.45856E+61"));
			Rows.Add( new AllStageStatsRow("ID_514", "515", "1.96013E+69", "1.17608E+70", "3.13621E+70", "1.07006E+71", "9.74E+60", "1.46059E+62"));
			Rows.Add( new AllStageStatsRow("ID_515", "516", "2.67558E+69", "5.35116E+69", "3.2107E+70", "1.39113E+71", "1.27E+61", "2.54242E+61"));
			Rows.Add( new AllStageStatsRow("ID_516", "517", "3.65217E+69", "1.09565E+70", "4.74782E+70", "1.86591E+71", "1.66E+61", "4.97873E+61"));
			Rows.Add( new AllStageStatsRow("ID_517", "518", "4.98521E+69", "1.99408E+70", "6.97929E+70", "2.56384E+71", "2.17E+61", "1.0833E+62"));
			Rows.Add( new AllStageStatsRow("ID_518", "519", "6.80481E+69", "3.40241E+70", "1.02072E+71", "3.58456E+71", "2.83E+61", "2.82852E+62"));
			Rows.Add( new AllStageStatsRow("ID_519", "520", "9.28857E+69", "5.57314E+70", "1.48617E+71", "5.07073E+71", "3.69E+61", "5.53899E+62"));
			Rows.Add( new AllStageStatsRow("ID_520", "521", "1.26789E+70", "2.53578E+70", "1.52147E+71", "6.5922E+71", "4.82E+61", "9.64163E+61"));
			Rows.Add( new AllStageStatsRow("ID_521", "522", "1.73067E+70", "5.19201E+70", "2.24987E+71", "8.84207E+71", "6.29E+61", "1.88809E+62"));
			Rows.Add( new AllStageStatsRow("ID_522", "523", "2.36236E+70", "9.44945E+70", "3.30731E+71", "1.21494E+72", "8.22E+61", "4.1082E+62"));
			Rows.Add( new AllStageStatsRow("ID_523", "524", "3.22463E+70", "1.61231E+71", "4.83694E+71", "1.69863E+72", "1.07E+62", "1.07266E+63"));
			Rows.Add( new AllStageStatsRow("ID_524", "525", "4.40161E+70", "2.64097E+71", "7.04258E+71", "2.40289E+72", "1.4E+62", "2.10056E+63"));
			Rows.Add( new AllStageStatsRow("ID_525", "526", "6.0082E+70", "1.20164E+71", "7.20984E+71", "3.12387E+72", "1.83E+62", "3.6564E+62"));
			Rows.Add( new AllStageStatsRow("ID_526", "527", "8.2012E+70", "2.46036E+71", "1.06616E+72", "4.19003E+72", "2.39E+62", "7.16022E+62"));
			Rows.Add( new AllStageStatsRow("ID_527", "528", "1.11946E+71", "4.47785E+71", "1.56725E+72", "5.75728E+72", "3.12E+62", "1.55796E+63"));
			Rows.Add( new AllStageStatsRow("ID_528", "529", "1.52807E+71", "7.64034E+71", "2.2921E+72", "8.04938E+72", "4.07E+62", "4.06786E+63"));
			Rows.Add( new AllStageStatsRow("ID_529", "530", "2.08581E+71", "1.25149E+72", "3.3373E+72", "1.13867E+73", "5.31E+62", "7.96597E+63"));
			Rows.Add( new AllStageStatsRow("ID_530", "531", "2.84713E+71", "5.69427E+71", "3.41656E+72", "1.48032E+73", "6.93E+62", "1.38662E+63"));
			Rows.Add( new AllStageStatsRow("ID_531", "532", "3.88634E+71", "1.1659E+72", "5.05224E+72", "1.98555E+73", "9.05E+62", "2.71538E+63"));
			Rows.Add( new AllStageStatsRow("ID_532", "533", "5.30485E+71", "2.12194E+72", "7.42679E+72", "2.72823E+73", "1.18E+63", "5.90826E+63"));
			Rows.Add( new AllStageStatsRow("ID_533", "534", "7.24112E+71", "3.62056E+72", "1.08617E+73", "3.8144E+73", "1.54E+63", "1.54266E+64"));
			Rows.Add( new AllStageStatsRow("ID_534", "535", "9.88413E+71", "5.93048E+72", "1.58146E+73", "5.39586E+73", "2.01E+63", "3.02094E+64"));
			Rows.Add( new AllStageStatsRow("ID_535", "536", "1.34918E+72", "2.69837E+72", "1.61902E+73", "7.01488E+73", "2.63E+63", "5.2585E+63"));
			Rows.Add( new AllStageStatsRow("ID_536", "537", "1.84164E+72", "5.52491E+72", "2.39413E+73", "9.409E+73", "3.43E+63", "1.02976E+64"));
			Rows.Add( new AllStageStatsRow("ID_537", "538", "2.51383E+72", "1.00553E+73", "3.51937E+73", "1.29284E+74", "4.48E+63", "2.2406E+64"));
			Rows.Add( new AllStageStatsRow("ID_538", "539", "3.43138E+72", "1.71569E+73", "5.14707E+73", "1.80754E+74", "5.85E+63", "5.85025E+64"));
			Rows.Add( new AllStageStatsRow("ID_539", "540", "4.68384E+72", "2.8103E+73", "7.49414E+73", "2.55696E+74", "7.64E+63", "1.14563E+65"));
			Rows.Add( new AllStageStatsRow("ID_540", "541", "6.39344E+72", "1.27869E+73", "7.67212E+73", "3.32417E+74", "9.97E+63", "1.99419E+64"));
			Rows.Add( new AllStageStatsRow("ID_541", "542", "8.72704E+72", "2.61811E+73", "1.13452E+74", "4.45869E+74", "1.3E+64", "3.90515E+64"));
			Rows.Add( new AllStageStatsRow("ID_542", "543", "1.19124E+73", "4.76496E+73", "1.66774E+74", "6.12642E+74", "1.7E+64", "8.49703E+64"));
			Rows.Add( new AllStageStatsRow("ID_543", "544", "1.62604E+73", "8.13022E+73", "2.43907E+74", "8.56549E+74", "2.22E+64", "2.2186E+65"));
			Rows.Add( new AllStageStatsRow("ID_544", "545", "2.21955E+73", "1.33173E+74", "3.55128E+74", "1.21168E+75", "2.9E+64", "4.3446E+65"));
			Rows.Add( new AllStageStatsRow("ID_545", "546", "3.02969E+73", "6.05937E+73", "3.63562E+74", "1.57524E+75", "3.78E+64", "7.56257E+64"));
			Rows.Add( new AllStageStatsRow("ID_546", "547", "4.13552E+73", "1.24066E+74", "5.37618E+74", "2.11286E+75", "4.94E+64", "1.48095E+65"));
			Rows.Add( new AllStageStatsRow("ID_547", "548", "5.64499E+73", "2.25799E+74", "7.90298E+74", "2.90316E+75", "6.44E+64", "3.22234E+65"));
			Rows.Add( new AllStageStatsRow("ID_548", "549", "7.70541E+73", "3.8527E+74", "1.15581E+75", "4.05897E+75", "8.41E+64", "8.4136E+65"));
			Rows.Add( new AllStageStatsRow("ID_549", "550", "1.05179E+74", "6.31073E+74", "1.68286E+75", "5.74183E+75", "1.1E+65", "1.64761E+66"));
			Rows.Add( new AllStageStatsRow("ID_550", "551", "1.43569E+74", "2.87138E+74", "1.72283E+75", "7.46466E+75", "1.43E+65", "2.86796E+65"));
			Rows.Add( new AllStageStatsRow("ID_551", "552", "1.95972E+74", "5.87915E+74", "2.54763E+75", "1.00123E+76", "1.87E+65", "5.61624E+65"));
			Rows.Add( new AllStageStatsRow("ID_552", "553", "2.67501E+74", "1.07001E+75", "3.74502E+75", "1.37573E+76", "2.44E+65", "1.22201E+66"));
			Rows.Add( new AllStageStatsRow("ID_553", "554", "3.6514E+74", "1.8257E+75", "5.47709E+75", "1.92344E+76", "3.19E+65", "3.1907E+66"));
			Rows.Add( new AllStageStatsRow("ID_554", "555", "4.98415E+74", "2.99049E+75", "7.97465E+75", "2.72091E+76", "4.17E+65", "6.24824E+66"));
			Rows.Add( new AllStageStatsRow("ID_555", "556", "6.80337E+74", "1.36067E+75", "8.16405E+75", "3.53731E+76", "5.44E+65", "1.08762E+66"));
			Rows.Add( new AllStageStatsRow("ID_556", "557", "9.2866E+74", "2.78598E+75", "1.20726E+76", "4.74457E+76", "7.1E+65", "2.12985E+66"));
			Rows.Add( new AllStageStatsRow("ID_557", "558", "1.26762E+75", "5.07048E+75", "1.77467E+76", "6.51924E+76", "9.27E+65", "4.63424E+66"));
			Rows.Add( new AllStageStatsRow("ID_558", "559", "1.7303E+75", "8.65151E+75", "2.59545E+76", "9.11469E+76", "1.21E+66", "1.21001E+67"));
			Rows.Add( new AllStageStatsRow("ID_559", "560", "2.36186E+75", "1.41712E+76", "3.77898E+76", "1.28937E+77", "1.58E+66", "2.36953E+67"));
			Rows.Add( new AllStageStatsRow("ID_560", "561", "3.22394E+75", "6.44789E+75", "3.86873E+76", "1.67624E+77", "2.06E+66", "4.12459E+66"));
			Rows.Add( new AllStageStatsRow("ID_561", "562", "4.40068E+75", "1.3202E+76", "5.72089E+76", "2.24833E+77", "2.69E+66", "8.07706E+66"));
			Rows.Add( new AllStageStatsRow("ID_562", "563", "6.00693E+75", "2.40277E+76", "8.40971E+76", "3.0893E+77", "3.51E+66", "1.75745E+67"));
			Rows.Add( new AllStageStatsRow("ID_563", "564", "8.19946E+75", "4.09973E+76", "1.22992E+77", "4.31922E+77", "4.59E+66", "4.58874E+67"));
			Rows.Add( new AllStageStatsRow("ID_564", "565", "1.11923E+76", "6.71536E+76", "1.79076E+77", "6.10998E+77", "5.99E+66", "8.98598E+67"));
			Rows.Add( new AllStageStatsRow("ID_565", "566", "1.52774E+76", "3.05549E+76", "1.83329E+77", "7.94328E+77", "7.82E+66", "1.56417E+67"));
			Rows.Add( new AllStageStatsRow("ID_566", "567", "2.08537E+76", "6.25611E+76", "2.71098E+77", "1.06543E+78", "1.02E+67", "3.06307E+67"));
			Rows.Add( new AllStageStatsRow("ID_567", "568", "2.84653E+76", "1.13861E+77", "3.98514E+77", "1.46394E+78", "1.33E+67", "6.66479E+67"));
			Rows.Add( new AllStageStatsRow("ID_568", "569", "3.88552E+76", "1.94276E+77", "5.82827E+77", "2.04677E+78", "1.74E+67", "1.74019E+68"));
			Rows.Add( new AllStageStatsRow("ID_569", "570", "5.30373E+76", "3.18224E+77", "8.48597E+77", "2.89536E+78", "2.27E+67", "3.40776E+68"));
			Rows.Add( new AllStageStatsRow("ID_570", "571", "7.23959E+76", "1.44792E+77", "8.68751E+77", "3.76411E+78", "2.97E+67", "5.93183E+67"));
			Rows.Add( new AllStageStatsRow("ID_571", "572", "9.88204E+76", "2.96461E+77", "1.28467E+78", "5.04878E+78", "3.87E+67", "1.16161E+68"));
			Rows.Add( new AllStageStatsRow("ID_572", "573", "1.3489E+77", "5.39559E+77", "1.88846E+78", "6.93724E+78", "5.05E+67", "2.5275E+68"));
			Rows.Add( new AllStageStatsRow("ID_573", "574", "1.84125E+77", "9.20623E+77", "2.76187E+78", "9.69911E+78", "6.6E+67", "6.59935E+68"));
			Rows.Add( new AllStageStatsRow("ID_574", "575", "2.5133E+77", "1.50798E+78", "4.02128E+78", "1.37204E+79", "8.62E+67", "1.29233E+69"));
			Rows.Add( new AllStageStatsRow("ID_575", "576", "3.43066E+77", "6.86131E+77", "4.11679E+78", "1.78372E+79", "1.12E+68", "2.24953E+68"));
			Rows.Add( new AllStageStatsRow("ID_576", "577", "4.68285E+77", "1.40485E+78", "6.0877E+78", "2.39249E+79", "1.47E+68", "4.40519E+68"));
			Rows.Add( new AllStageStatsRow("ID_577", "578", "6.39208E+77", "2.55683E+78", "8.94892E+78", "3.28738E+79", "1.92E+68", "9.58504E+68"));
			Rows.Add( new AllStageStatsRow("ID_578", "579", "8.7252E+77", "4.3626E+78", "1.30878E+79", "4.59616E+79", "2.5E+68", "2.50268E+69"));
			Rows.Add( new AllStageStatsRow("ID_579", "580", "1.19099E+78", "7.14593E+78", "1.90558E+79", "6.50174E+79", "3.27E+68", "4.90091E+69"));
			Rows.Add( new AllStageStatsRow("ID_580", "581", "1.6257E+78", "3.2514E+78", "1.95084E+79", "8.45258E+79", "4.27E+68", "8.53093E+68"));
			Rows.Add( new AllStageStatsRow("ID_581", "582", "2.21908E+78", "6.65724E+78", "2.8848E+79", "1.13374E+80", "5.57E+68", "1.67058E+69"));
			Rows.Add( new AllStageStatsRow("ID_582", "583", "3.02905E+78", "1.21162E+79", "4.24066E+79", "1.5578E+80", "7.27E+68", "3.63495E+69"));
			Rows.Add( new AllStageStatsRow("ID_583", "584", "4.13465E+78", "2.06732E+79", "6.20197E+79", "2.178E+80", "9.49E+68", "9.49093E+69"));
			Rows.Add( new AllStageStatsRow("ID_584", "585", "5.64379E+78", "3.38628E+79", "9.03007E+79", "3.08101E+80", "1.24E+69", "1.85858E+70"));
			Rows.Add( new AllStageStatsRow("ID_585", "586", "7.70378E+78", "1.54076E+79", "9.24453E+79", "4.00546E+80", "1.62E+69", "3.23519E+69"));
			Rows.Add( new AllStageStatsRow("ID_586", "587", "1.05157E+79", "3.1547E+79", "1.36704E+80", "5.3725E+80", "2.11E+69", "6.33537E+69"));
			Rows.Add( new AllStageStatsRow("ID_587", "588", "1.43539E+79", "5.74155E+79", "2.00954E+80", "7.38204E+80", "2.76E+69", "1.37848E+70"));
			Rows.Add( new AllStageStatsRow("ID_588", "589", "1.9593E+79", "9.79652E+79", "2.93895E+80", "1.0321E+81", "3.6E+69", "3.59925E+70"));
			Rows.Add( new AllStageStatsRow("ID_589", "590", "2.67445E+79", "1.60467E+80", "4.27912E+80", "1.46001E+81", "4.7E+69", "7.0483E+70"));
			Rows.Add( new AllStageStatsRow("ID_590", "591", "3.65062E+79", "7.30125E+79", "4.38075E+80", "1.89809E+81", "6.13E+69", "1.22689E+70"));
			Rows.Add( new AllStageStatsRow("ID_591", "592", "4.9831E+79", "1.49493E+80", "6.47803E+80", "2.54589E+81", "8.01E+69", "2.40257E+70"));
			Rows.Add( new AllStageStatsRow("ID_592", "593", "6.80193E+79", "2.72077E+80", "9.5227E+80", "3.49816E+81", "1.05E+70", "5.22764E+70"));
			Rows.Add( new AllStageStatsRow("ID_593", "594", "9.28464E+79", "4.64232E+80", "1.3927E+81", "4.89085E+81", "1.36E+70", "1.36495E+71"));
			Rows.Add( new AllStageStatsRow("ID_594", "595", "1.26735E+80", "7.60412E+80", "2.02776E+81", "6.91862E+81", "1.78E+70", "2.67294E+71"));
			Rows.Add( new AllStageStatsRow("ID_595", "596", "1.72994E+80", "3.45987E+80", "2.07592E+81", "8.99454E+81", "2.33E+70", "4.65273E+70"));
			Rows.Add( new AllStageStatsRow("ID_596", "597", "2.36136E+80", "7.08409E+80", "3.06977E+81", "1.20643E+82", "3.04E+70", "9.11129E+70"));
			Rows.Add( new AllStageStatsRow("ID_597", "598", "3.22326E+80", "1.2893E+81", "4.51257E+81", "1.65769E+82", "3.96E+70", "1.98248E+71"));
			Rows.Add( new AllStageStatsRow("ID_598", "599", "4.39975E+80", "2.19988E+81", "6.59963E+81", "2.31765E+82", "5.18E+70", "5.17631E+71"));
			Rows.Add( new AllStageStatsRow("ID_599", "600", "6.00566E+80", "3.6034E+81", "9.60906E+81", "3.27856E+82", "6.76E+70", "1.01366E+72"));
			Rows.Add( new AllStageStatsRow("ID_600", "601", "8.19773E+80", "1.63955E+81", "9.83727E+81", "4.26228E+82", "8.82E+70", "1.76446E+71"));
			Rows.Add( new AllStageStatsRow("ID_601", "602", "1.11899E+81", "3.35697E+81", "1.45469E+82", "5.71697E+82", "1.15E+71", "3.45528E+71"));
			Rows.Add( new AllStageStatsRow("ID_602", "603", "1.52742E+81", "6.10968E+81", "2.13839E+82", "7.85536E+82", "1.5E+71", "7.51819E+71"));
			Rows.Add( new AllStageStatsRow("ID_603", "604", "2.08493E+81", "1.04246E+82", "3.12739E+82", "1.09828E+83", "1.96E+71", "1.96302E+72"));
			Rows.Add( new AllStageStatsRow("ID_604", "605", "2.84593E+81", "1.70756E+82", "4.55349E+82", "1.55362E+83", "2.56E+71", "3.84411E+72"));
			Rows.Add( new AllStageStatsRow("ID_605", "606", "3.88469E+81", "7.76939E+81", "4.66163E+82", "2.01979E+83", "3.35E+71", "6.69138E+71"));
			Rows.Add( new AllStageStatsRow("ID_606", "607", "5.30261E+81", "1.59078E+82", "6.89339E+82", "2.70913E+83", "4.37E+71", "1.31035E+72"));
			Rows.Add( new AllStageStatsRow("ID_607", "608", "7.23806E+81", "2.89522E+82", "1.01333E+83", "3.72245E+83", "5.7E+71", "2.85113E+72"));
			Rows.Add( new AllStageStatsRow("ID_608", "609", "9.87995E+81", "4.93997E+82", "1.48199E+83", "5.20445E+83", "7.44E+71", "7.44437E+72"));
			Rows.Add( new AllStageStatsRow("ID_609", "610", "1.34861E+82", "8.09168E+82", "2.15778E+83", "7.36223E+83", "9.72E+71", "1.45781E+73"));
			Rows.Add( new AllStageStatsRow("ID_610", "611", "1.84086E+82", "3.68171E+82", "2.20903E+83", "9.57126E+83", "1.27E+72", "2.53758E+72"));
			Rows.Add( new AllStageStatsRow("ID_611", "612", "2.51277E+82", "7.53831E+82", "3.2666E+83", "1.28379E+84", "1.66E+72", "4.96926E+72"));
			Rows.Add( new AllStageStatsRow("ID_612", "613", "3.42993E+82", "1.37197E+83", "4.8019E+83", "1.76398E+84", "2.16E+72", "1.08124E+73"));
			Rows.Add( new AllStageStatsRow("ID_613", "614", "4.68185E+82", "2.34093E+83", "7.02278E+83", "2.46625E+84", "2.82E+72", "2.82314E+73"));
			Rows.Add( new AllStageStatsRow("ID_614", "615", "6.39073E+82", "3.83444E+83", "1.02252E+84", "3.48877E+84", "3.69E+72", "5.52846E+73"));
			Rows.Add( new AllStageStatsRow("ID_615", "616", "8.72335E+82", "1.74467E+83", "1.0468E+84", "4.53557E+84", "4.81E+72", "9.62328E+72"));
			Rows.Add( new AllStageStatsRow("ID_616", "617", "1.19074E+83", "3.57221E+83", "1.54796E+84", "6.08353E+84", "6.28E+72", "1.8845E+73"));
			Rows.Add( new AllStageStatsRow("ID_617", "618", "1.62536E+83", "6.50142E+83", "2.2755E+84", "8.35903E+84", "8.2E+72", "4.10039E+73"));
			Rows.Add( new AllStageStatsRow("ID_618", "619", "2.21861E+83", "1.10931E+84", "3.32792E+84", "1.16869E+85", "1.07E+73", "1.07062E+74"));
			Rows.Add( new AllStageStatsRow("ID_619", "620", "3.0284E+83", "1.81704E+84", "4.84545E+84", "1.65324E+85", "1.4E+73", "2.09656E+74"));
			Rows.Add( new AllStageStatsRow("ID_620", "621", "4.13377E+83", "8.26754E+83", "4.96053E+84", "2.14929E+85", "1.82E+73", "3.64945E+73"));
			Rows.Add( new AllStageStatsRow("ID_621", "622", "5.6426E+83", "1.69278E+84", "7.33538E+84", "2.88283E+85", "2.38E+73", "7.14659E+73"));
			Rows.Add( new AllStageStatsRow("ID_622", "623", "7.70215E+83", "3.08086E+84", "1.0783E+85", "3.96113E+85", "3.11E+73", "1.55499E+74"));
			Rows.Add( new AllStageStatsRow("ID_623", "624", "1.05134E+84", "5.25672E+84", "1.57701E+85", "5.53815E+85", "4.06E+73", "4.06013E+74"));
			Rows.Add( new AllStageStatsRow("ID_624", "625", "1.43508E+84", "8.6105E+84", "2.29613E+85", "7.83428E+85", "5.3E+73", "7.95081E+74"));
			Rows.Add( new AllStageStatsRow("ID_625", "626", "1.95889E+84", "3.91778E+84", "2.35067E+85", "1.01849E+86", "6.92E+73", "1.38398E+74"));
			Rows.Add( new AllStageStatsRow("ID_626", "627", "2.67388E+84", "8.02165E+84", "3.47605E+85", "1.3661E+86", "9.03E+73", "2.71021E+74"));
			Rows.Add( new AllStageStatsRow("ID_627", "628", "3.64985E+84", "1.45994E+85", "5.10979E+85", "1.87708E+86", "1.18E+74", "5.89702E+74"));
			Rows.Add( new AllStageStatsRow("ID_628", "629", "4.98205E+84", "2.49102E+85", "7.47307E+85", "2.62439E+86", "1.54E+74", "1.53973E+75"));
			Rows.Add( new AllStageStatsRow("ID_629", "630", "6.80049E+84", "4.0803E+85", "1.08808E+86", "3.71246E+86", "2.01E+74", "3.01519E+75"));
			Rows.Add( new AllStageStatsRow("ID_630", "631", "9.28267E+84", "1.85653E+85", "1.11392E+86", "4.82638E+86", "2.62E+74", "5.2485E+74"));
			Rows.Add( new AllStageStatsRow("ID_631", "632", "1.26708E+85", "3.80125E+85", "1.64721E+86", "6.47359E+86", "3.43E+74", "1.0278E+75"));
			Rows.Add( new AllStageStatsRow("ID_632", "633", "1.72957E+85", "6.91828E+85", "2.4214E+86", "8.89499E+86", "4.47E+74", "2.23633E+75"));
			Rows.Add( new AllStageStatsRow("ID_633", "634", "2.36086E+85", "1.18043E+86", "3.5413E+86", "1.24363E+87", "5.84E+74", "5.83912E+75"));
			Rows.Add( new AllStageStatsRow("ID_634", "635", "3.22258E+85", "1.93355E+86", "5.15613E+86", "1.75924E+87", "7.62E+74", "1.14346E+76"));
			Rows.Add( new AllStageStatsRow("ID_635", "636", "4.39882E+85", "8.79764E+85", "5.27859E+86", "2.2871E+87", "9.95E+74", "1.99039E+75"));
			Rows.Add( new AllStageStatsRow("ID_636", "637", "6.00439E+85", "1.80132E+86", "7.80571E+86", "3.06767E+87", "1.3E+75", "3.89772E+75"));
			Rows.Add( new AllStageStatsRow("ID_637", "638", "8.19599E+85", "3.2784E+86", "1.14744E+87", "4.21511E+87", "1.7E+75", "8.48087E+75"));
			Rows.Add( new AllStageStatsRow("ID_638", "639", "1.11875E+86", "5.59377E+86", "1.67813E+87", "5.89324E+87", "2.21E+75", "2.21437E+76"));
			Rows.Add( new AllStageStatsRow("ID_639", "640", "1.5271E+86", "9.16259E+86", "2.44336E+87", "8.3366E+87", "2.89E+75", "4.33634E+76"));
			Rows.Add( new AllStageStatsRow("ID_640", "641", "2.08449E+86", "4.16898E+86", "2.50139E+87", "1.0838E+88", "3.77E+75", "7.54818E+75"));
			Rows.Add( new AllStageStatsRow("ID_641", "642", "2.84533E+86", "8.53598E+86", "3.69893E+87", "1.45369E+88", "4.93E+75", "1.47814E+76"));
			Rows.Add( new AllStageStatsRow("ID_642", "643", "3.88387E+86", "1.55355E+87", "5.43742E+87", "1.99743E+88", "6.43E+75", "3.21621E+76"));
			Rows.Add( new AllStageStatsRow("ID_643", "644", "5.30148E+86", "2.65074E+87", "7.95223E+87", "2.79266E+88", "8.4E+75", "8.39759E+76"));
			Rows.Add( new AllStageStatsRow("ID_644", "645", "7.23653E+86", "4.34192E+87", "1.15784E+88", "3.9505E+88", "1.1E+76", "1.64447E+77"));
			Rows.Add( new AllStageStatsRow("ID_645", "646", "9.87786E+86", "1.97557E+87", "1.18534E+88", "5.13584E+88", "1.43E+76", "2.86251E+76"));
			Rows.Add( new AllStageStatsRow("ID_646", "647", "1.34833E+87", "4.04498E+87", "1.75283E+88", "6.88867E+88", "1.87E+76", "5.60555E+76"));
			Rows.Add( new AllStageStatsRow("ID_647", "648", "1.84047E+87", "7.36187E+87", "2.57665E+88", "9.46532E+88", "2.44E+76", "1.21969E+77"));
			Rows.Add( new AllStageStatsRow("ID_648", "649", "2.51224E+87", "1.25612E+88", "3.76836E+88", "1.32337E+89", "3.18E+76", "3.18463E+77"));
			Rows.Add( new AllStageStatsRow("ID_649", "650", "3.4292E+87", "2.05752E+88", "5.48673E+88", "1.87204E+89", "4.16E+76", "6.23635E+77"));
			Rows.Add( new AllStageStatsRow("ID_650", "651", "4.68086E+87", "9.36173E+87", "5.61704E+88", "2.43374E+89", "5.43E+76", "1.08555E+77"));
			Rows.Add( new AllStageStatsRow("ID_651", "652", "6.38938E+87", "1.91681E+88", "8.30619E+88", "3.26436E+89", "7.09E+76", "2.1258E+77"));
			Rows.Add( new AllStageStatsRow("ID_652", "653", "8.7215E+87", "3.4886E+88", "1.22101E+89", "4.48537E+89", "9.25E+76", "4.62543E+77"));
			Rows.Add( new AllStageStatsRow("ID_653", "654", "1.19049E+88", "5.95243E+88", "1.78573E+89", "6.2711E+89", "1.21E+77", "1.20771E+78"));
			Rows.Add( new AllStageStatsRow("ID_654", "655", "1.62501E+88", "9.75007E+88", "2.60002E+89", "8.87112E+89", "1.58E+77", "2.36502E+78"));
			Rows.Add( new AllStageStatsRow("ID_655", "656", "2.21814E+88", "4.43628E+88", "2.66177E+89", "1.15329E+90", "2.06E+77", "4.11675E+77"));
			Rows.Add( new AllStageStatsRow("ID_656", "657", "3.02776E+88", "9.08329E+88", "3.93609E+89", "1.5469E+90", "2.69E+77", "8.06169E+77"));
			Rows.Add( new AllStageStatsRow("ID_657", "658", "4.1329E+88", "1.65316E+89", "5.78606E+89", "2.1255E+90", "3.51E+77", "1.7541E+78"));
			Rows.Add( new AllStageStatsRow("ID_658", "659", "5.6414E+88", "2.8207E+89", "8.46211E+89", "2.97171E+90", "4.58E+77", "4.58001E+78"));
			Rows.Add( new AllStageStatsRow("ID_659", "660", "7.70052E+88", "4.62031E+89", "1.23208E+90", "4.2038E+90", "5.98E+77", "8.96888E+78"));
			Rows.Add( new AllStageStatsRow("ID_660", "661", "1.05112E+89", "2.10224E+89", "1.26134E+90", "5.46514E+90", "7.81E+77", "1.5612E+78"));
			Rows.Add( new AllStageStatsRow("ID_661", "662", "1.43478E+89", "4.30434E+89", "1.86521E+90", "7.33036E+90", "1.02E+78", "3.05724E+78"));
			Rows.Add( new AllStageStatsRow("ID_662", "663", "1.95847E+89", "7.8339E+89", "2.74186E+90", "1.00722E+91", "1.33E+78", "6.65211E+78"));
			Rows.Add( new AllStageStatsRow("ID_663", "664", "2.67332E+89", "1.33666E+90", "4.00998E+90", "1.40822E+91", "1.74E+78", "1.73688E+79"));
			Rows.Add( new AllStageStatsRow("ID_664", "665", "3.64908E+89", "2.18945E+90", "5.83853E+90", "1.99207E+91", "2.27E+78", "3.40128E+79"));
			Rows.Add( new AllStageStatsRow("ID_665", "666", "4.98099E+89", "9.96198E+89", "5.97719E+90", "2.58979E+91", "2.96E+78", "5.92054E+78"));
			Rows.Add( new AllStageStatsRow("ID_666", "667", "6.79905E+89", "2.03972E+90", "8.83877E+90", "3.47367E+91", "3.86E+78", "1.1594E+79"));
			Rows.Add( new AllStageStatsRow("ID_667", "668", "9.28071E+89", "3.71228E+90", "1.2993E+91", "4.77297E+91", "5.05E+78", "2.52269E+79"));
			Rows.Add( new AllStageStatsRow("ID_668", "669", "1.26682E+90", "6.33408E+90", "1.90023E+91", "6.67319E+91", "6.59E+78", "6.58679E+79"));
			Rows.Add( new AllStageStatsRow("ID_669", "670", "1.7292E+90", "1.03752E+91", "2.76673E+91", "9.43992E+91", "8.6E+78", "1.28987E+80"));
			Rows.Add( new AllStageStatsRow("ID_670", "671", "2.36036E+90", "4.72073E+90", "2.83244E+91", "1.22724E+92", "1.12E+79", "2.24525E+79"));
			Rows.Add( new AllStageStatsRow("ID_671", "672", "3.2219E+90", "9.66569E+90", "4.18847E+91", "1.64608E+92", "1.47E+79", "4.39681E+79"));
			Rows.Add( new AllStageStatsRow("ID_672", "673", "4.39789E+90", "1.75916E+91", "6.15705E+91", "2.26179E+92", "1.91E+79", "9.56681E+79"));
			Rows.Add( new AllStageStatsRow("ID_673", "674", "6.00312E+90", "3.00156E+91", "9.00468E+91", "3.16226E+92", "2.5E+79", "2.49792E+80"));
			Rows.Add( new AllStageStatsRow("ID_674", "675", "8.19426E+90", "4.91656E+91", "1.31108E+92", "4.47334E+92", "3.26E+79", "4.89159E+80"));
			Rows.Add( new AllStageStatsRow("ID_675", "676", "1.11852E+91", "2.23703E+91", "1.34222E+92", "5.81556E+92", "4.26E+79", "8.5147E+79"));
			Rows.Add( new AllStageStatsRow("ID_676", "677", "1.52677E+91", "4.58032E+91", "1.98481E+92", "7.80036E+92", "5.56E+79", "1.66741E+80"));
			Rows.Add( new AllStageStatsRow("ID_677", "678", "2.08405E+91", "8.33619E+91", "2.91767E+92", "1.0718E+93", "7.26E+79", "3.62803E+80"));
			Rows.Add( new AllStageStatsRow("ID_678", "679", "2.84472E+91", "1.42236E+92", "4.26709E+92", "1.49851E+93", "9.47E+79", "9.47287E+80"));
			Rows.Add( new AllStageStatsRow("ID_679", "680", "3.88305E+91", "2.32983E+92", "6.21288E+92", "2.1198E+93", "1.24E+80", "1.85504E+81"));
			Rows.Add( new AllStageStatsRow("ID_680", "681", "5.30036E+91", "1.06007E+92", "6.36044E+92", "2.75584E+93", "1.61E+80", "3.22904E+80"));
			Rows.Add( new AllStageStatsRow("ID_681", "682", "7.235E+91", "2.1705E+92", "9.40549E+92", "3.69639E+93", "2.11E+80", "6.32332E+80"));
			Rows.Add( new AllStageStatsRow("ID_682", "683", "9.87577E+91", "3.95031E+92", "1.38261E+93", "5.079E+93", "2.75E+80", "1.37586E+81"));
			Rows.Add( new AllStageStatsRow("ID_683", "684", "1.34804E+92", "6.74021E+92", "2.02206E+93", "7.10106E+93", "3.59E+80", "3.59241E+81"));
			Rows.Add( new AllStageStatsRow("ID_684", "685", "1.84008E+92", "1.10405E+93", "2.94412E+93", "1.00452E+94", "4.69E+80", "7.03489E+81"));
			Rows.Add( new AllStageStatsRow("ID_685", "686", "2.51171E+92", "5.02341E+92", "3.01405E+93", "1.30592E+94", "6.12E+80", "1.22455E+81"));
			Rows.Add( new AllStageStatsRow("ID_686", "687", "3.42848E+92", "1.02854E+93", "4.45702E+93", "1.75163E+94", "7.99E+80", "2.398E+81"));
			Rows.Add( new AllStageStatsRow("ID_687", "688", "4.67987E+92", "1.87195E+93", "6.55182E+93", "2.40681E+94", "1.04E+81", "5.21769E+81"));
			Rows.Add( new AllStageStatsRow("ID_688", "689", "6.38803E+92", "3.19401E+93", "9.58204E+93", "3.36501E+94", "1.36E+81", "1.36235E+82"));
			Rows.Add( new AllStageStatsRow("ID_689", "690", "8.71966E+92", "5.23179E+93", "1.39515E+94", "4.76016E+94", "1.78E+81", "2.66785E+82"));
			Rows.Add( new AllStageStatsRow("ID_690", "691", "1.19023E+93", "2.38047E+93", "1.42828E+94", "6.18844E+94", "2.32E+81", "4.64388E+81"));
			Rows.Add( new AllStageStatsRow("ID_691", "692", "1.62467E+93", "4.87401E+93", "2.11207E+94", "8.30051E+94", "3.03E+81", "9.09396E+81"));
			Rows.Add( new AllStageStatsRow("ID_692", "693", "2.21767E+93", "8.87069E+93", "3.10474E+94", "1.14052E+95", "3.96E+81", "1.97871E+82"));
			Rows.Add( new AllStageStatsRow("ID_693", "694", "3.02712E+93", "1.51356E+94", "4.54068E+94", "1.59459E+95", "5.17E+81", "5.16646E+82"));
			Rows.Add( new AllStageStatsRow("ID_694", "695", "4.13202E+93", "2.47921E+94", "6.61124E+94", "2.25572E+95", "6.74E+81", "1.01173E+83"));
			Rows.Add( new AllStageStatsRow("ID_695", "696", "5.64021E+93", "1.12804E+94", "6.76825E+94", "2.93254E+95", "8.81E+81", "1.7611E+82"));
			Rows.Add( new AllStageStatsRow("ID_696", "697", "7.69889E+93", "2.30967E+94", "1.00086E+95", "3.9334E+95", "1.15E+82", "3.44871E+82"));
			Rows.Add( new AllStageStatsRow("ID_697", "698", "1.0509E+94", "4.20359E+94", "1.47126E+95", "5.40466E+95", "1.5E+82", "7.50389E+82"));
			Rows.Add( new AllStageStatsRow("ID_698", "699", "1.43448E+94", "7.17238E+94", "2.15171E+95", "7.55637E+95", "1.96E+82", "1.95928E+83"));
			Rows.Add( new AllStageStatsRow("ID_699", "700", "1.95806E+94", "1.17484E+95", "3.1329E+95", "1.06893E+96", "2.56E+82", "3.8368E+83"));
			Rows.Add( new AllStageStatsRow("ID_700", "701", "2.67275E+94", "5.3455E+94", "3.2073E+95", "1.38966E+96", "3.34E+82", "6.67865E+82"));
			Rows.Add( new AllStageStatsRow("ID_701", "702", "3.64831E+94", "1.09449E+95", "4.7428E+95", "1.86394E+96", "4.36E+82", "1.30786E+83"));
			Rows.Add( new AllStageStatsRow("ID_702", "703", "4.97994E+94", "1.99198E+95", "6.97191E+95", "2.56113E+96", "5.69E+82", "2.84571E+83"));
			Rows.Add( new AllStageStatsRow("ID_703", "704", "6.79762E+94", "3.39881E+95", "1.01964E+96", "3.58077E+96", "7.43E+82", "7.43021E+83"));
			Rows.Add( new AllStageStatsRow("ID_704", "705", "9.27874E+94", "5.56725E+95", "1.4846E+96", "5.06537E+96", "9.7E+82", "1.45503E+84"));
			Rows.Add( new AllStageStatsRow("ID_705", "706", "1.26655E+95", "2.5331E+95", "1.51986E+96", "6.58523E+96", "1.27E+83", "2.53275E+83"));
			Rows.Add( new AllStageStatsRow("ID_706", "707", "1.72884E+95", "5.18652E+95", "2.24749E+96", "8.83272E+96", "1.65E+83", "4.9598E+83"));
			Rows.Add( new AllStageStatsRow("ID_707", "708", "2.35987E+95", "9.43946E+95", "3.30381E+96", "1.21365E+97", "2.16E+83", "1.07918E+84"));
			Rows.Add( new AllStageStatsRow("ID_708", "709", "3.22122E+95", "1.61061E+96", "4.83182E+96", "1.69684E+97", "2.82E+83", "2.81776E+84"));
			Rows.Add( new AllStageStatsRow("ID_709", "710", "4.39696E+95", "2.63818E+96", "7.03514E+96", "2.40035E+97", "3.68E+83", "5.51794E+84"));
			Rows.Add( new AllStageStatsRow("ID_710", "711", "6.00185E+95", "1.20037E+96", "7.20222E+96", "3.12057E+97", "4.8E+83", "9.60497E+83"));
			Rows.Add( new AllStageStatsRow("ID_711", "712", "8.19253E+95", "2.45776E+96", "1.06503E+97", "4.1856E+97", "6.27E+83", "1.88091E+84"));
			Rows.Add( new AllStageStatsRow("ID_712", "713", "1.11828E+96", "4.47312E+96", "1.56559E+97", "5.75119E+97", "8.19E+83", "4.09259E+84"));
			Rows.Add( new AllStageStatsRow("ID_713", "714", "1.52645E+96", "7.63226E+96", "2.28968E+97", "8.04087E+97", "1.07E+84", "1.06858E+85"));
			Rows.Add( new AllStageStatsRow("ID_714", "715", "2.08361E+96", "1.25016E+97", "3.33377E+97", "1.13746E+98", "1.4E+84", "2.09257E+85"));
			Rows.Add( new AllStageStatsRow("ID_715", "716", "2.84412E+96", "5.68825E+96", "3.41295E+97", "1.47876E+98", "1.82E+84", "3.6425E+84"));
			Rows.Add( new AllStageStatsRow("ID_716", "717", "3.88223E+96", "1.16467E+97", "5.0469E+97", "1.98345E+98", "2.38E+84", "7.133E+84"));
			Rows.Add( new AllStageStatsRow("ID_717", "718", "5.29924E+96", "2.1197E+97", "7.41894E+97", "2.72534E+98", "3.1E+84", "1.55204E+85"));
			Rows.Add( new AllStageStatsRow("ID_718", "719", "7.23346E+96", "3.61673E+97", "1.08502E+98", "3.81036E+98", "4.05E+84", "4.0524E+85"));
			Rows.Add( new AllStageStatsRow("ID_719", "720", "9.87368E+96", "5.92421E+97", "1.57979E+98", "5.39015E+98", "5.29E+84", "7.93568E+85"));
			Rows.Add( new AllStageStatsRow("ID_720", "721", "1.34776E+97", "2.69551E+97", "1.61731E+98", "7.00746E+98", "6.91E+84", "1.38135E+85"));
			Rows.Add( new AllStageStatsRow("ID_721", "722", "1.83969E+97", "5.51907E+97", "2.3916E+98", "9.39905E+98", "9.02E+84", "2.70505E+85"));
			Rows.Add( new AllStageStatsRow("ID_722", "723", "2.51117E+97", "1.00447E+98", "3.51564E+98", "1.29147E+99", "1.18E+85", "5.8858E+85"));
			Rows.Add( new AllStageStatsRow("ID_723", "724", "3.42775E+97", "1.71388E+98", "5.14163E+98", "1.80563E+99", "1.54E+85", "1.5368E+86"));
			Rows.Add( new AllStageStatsRow("ID_724", "725", "4.67888E+97", "2.80733E+98", "7.48621E+98", "2.55425E+99", "2.01E+85", "3.00946E+86"));
			Rows.Add( new AllStageStatsRow("ID_725", "726", "6.38668E+97", "1.27734E+98", "7.66401E+98", "3.32066E+99", "2.62E+85", "5.23851E+85"));
			Rows.Add( new AllStageStatsRow("ID_726", "727", "8.71781E+97", "2.61534E+98", "1.13332E+99", "4.45397E+99", "3.42E+85", "1.02584E+86"));
			Rows.Add( new AllStageStatsRow("ID_727", "728", "1.18998E+98", "4.75993E+98", "1.66597E+99", "6.11995E+99", "4.46E+85", "2.23208E+86"));
			Rows.Add( new AllStageStatsRow("ID_728", "729", "1.62432E+98", "8.12162E+98", "2.43649E+99", "8.55643E+99", "5.83E+85", "5.82801E+86"));
			Rows.Add( new AllStageStatsRow("ID_729", "730", "2.2172E+98", "1.33032E+99", "3.54753E+99", "1.2104E+100", "7.61E+85", "1.14128E+87"));
			Rows.Add( new AllStageStatsRow("ID_730", "731", "3.02648E+98", "6.05296E+98", "3.63178E+99", "1.57357E+100", "9.93E+85", "1.98661E+86"));
			Rows.Add( new AllStageStatsRow("ID_731", "732", "4.13115E+98", "1.23934E+99", "5.37049E+99", "2.11062E+100", "1.3E+86", "3.8903E+86"));
			Rows.Add( new AllStageStatsRow("ID_732", "733", "5.63902E+98", "2.25561E+99", "7.89462E+99", "2.90009E+100", "1.69E+86", "8.46473E+86"));
			Rows.Add( new AllStageStatsRow("ID_733", "734", "7.69726E+98", "3.84863E+99", "1.15459E+100", "4.05467E+100", "2.21E+86", "2.21016E+87"));
			Rows.Add( new AllStageStatsRow("ID_734", "735", "1.05068E+99", "6.30406E+99", "1.68108E+100", "5.73576E+100", "2.89E+86", "4.32809E+87"));
			Rows.Add( new AllStageStatsRow("ID_735", "736", "1.43417E+99", "2.86835E+99", "1.72101E+100", "7.45676E+100", "3.77E+86", "7.53382E+86"));
			Rows.Add( new AllStageStatsRow("ID_736", "737", "1.95765E+99", "5.87294E+99", "2.54494E+100", "1.00017E+101", "4.92E+86", "1.47532E+87"));
			Rows.Add( new AllStageStatsRow("ID_737", "738", "2.67219E+99", "1.06887E+100", "3.74106E+100", "1.37428E+101", "6.42E+86", "3.21009E+87"));
			Rows.Add( new AllStageStatsRow("ID_738", "739", "3.64753E+99", "1.82377E+100", "5.4713E+100", "1.92141E+101", "8.38E+86", "8.38162E+87"));
			Rows.Add( new AllStageStatsRow("ID_739", "740", "4.97888E+99", "2.98733E+100", "7.96621E+100", "2.71803E+101", "1.09E+87", "1.64134E+88"));
			Rows.Add( new AllStageStatsRow("ID_740", "741", "6.79618E+99", "1.35924E+100", "8.15541E+100", "3.53357E+101", "1.43E+87", "2.85706E+87"));
			Rows.Add( new AllStageStatsRow("ID_741", "742", "9.27678E+99", "2.78303E+100", "1.20598E+101", "4.73955E+101", "1.86E+87", "5.59489E+87"));
			Rows.Add( new AllStageStatsRow("ID_742", "743", "1.26628E+100", "5.06512E+100", "1.77279E+101", "6.51234E+101", "2.43E+87", "1.21736E+88"));
			Rows.Add( new AllStageStatsRow("ID_743", "744", "1.72847E+100", "8.64237E+100", "2.59271E+101", "9.10505E+101", "3.18E+87", "3.17857E+88"));
			Rows.Add( new AllStageStatsRow("ID_744", "745", "2.35937E+100", "1.41562E+101", "3.77499E+101", "1.288E+102", "4.15E+87", "6.22449E+88"));
			Rows.Add( new AllStageStatsRow("ID_745", "746", "3.22053E+100", "6.44107E+100", "3.86464E+101", "1.67447E+102", "5.42E+87", "1.08349E+88"));
			Rows.Add( new AllStageStatsRow("ID_746", "747", "4.39603E+100", "1.31881E+101", "5.71484E+101", "2.24595E+102", "7.07E+87", "2.12175E+88"));
			Rows.Add( new AllStageStatsRow("ID_747", "748", "6.00058E+100", "2.40023E+101", "8.40081E+101", "3.08603E+102", "9.23E+87", "4.61663E+88"));
			Rows.Add( new AllStageStatsRow("ID_748", "749", "8.19079E+100", "4.0954E+101", "1.22862E+102", "4.31465E+102", "1.21E+88", "1.20541E+89"));
			Rows.Add( new AllStageStatsRow("ID_749", "750", "1.11804E+101", "6.70826E+101", "1.78887E+102", "6.10352E+102", "1.57E+88", "2.36052E+89"));
			Rows.Add( new AllStageStatsRow("ID_750", "751", "1.52613E+101", "3.05226E+101", "1.83135E+102", "7.93488E+102", "2.05E+88", "4.10891E+88"));
			Rows.Add( new AllStageStatsRow("ID_751", "752", "2.08317E+101", "6.2495E+101", "2.70812E+102", "1.0643E+103", "2.68E+88", "8.04635E+88"));
			Rows.Add( new AllStageStatsRow("ID_752", "753", "2.84352E+101", "1.13741E+102", "3.98093E+102", "1.46239E+103", "3.5E+88", "1.75077E+89"));
			Rows.Add( new AllStageStatsRow("ID_753", "754", "3.88141E+101", "1.9407E+102", "5.82211E+102", "2.0446E+103", "4.57E+88", "4.57129E+89"));
			Rows.Add( new AllStageStatsRow("ID_754", "755", "5.29812E+101", "3.17887E+102", "8.47699E+102", "2.8923E+103", "5.97E+88", "8.95182E+89"));
			Rows.Add( new AllStageStatsRow("ID_755", "756", "7.23193E+101", "1.44639E+102", "8.67832E+102", "3.76013E+103", "7.79E+88", "1.55823E+89"));
			Rows.Add( new AllStageStatsRow("ID_756", "757", "9.87159E+101", "2.96148E+102", "1.28331E+103", "5.04344E+103", "1.02E+89", "3.05143E+89"));
			Rows.Add( new AllStageStatsRow("ID_757", "758", "1.34747E+102", "5.38989E+102", "1.88646E+103", "6.9299E+103", "1.33E+89", "6.63945E+89"));
			Rows.Add( new AllStageStatsRow("ID_758", "759", "1.8393E+102", "9.1965E+102", "2.75895E+103", "9.68885E+103", "1.73E+89", "1.73358E+90"));
			Rows.Add( new AllStageStatsRow("ID_759", "760", "2.51064E+102", "1.50639E+103", "4.01703E+103", "1.37059E+104", "2.26E+89", "3.39481E+90"));
			Rows.Add( new AllStageStatsRow("ID_760", "761", "3.42703E+102", "6.85406E+102", "4.11243E+103", "1.78183E+104", "2.95E+89", "5.90928E+89"));
			Rows.Add( new AllStageStatsRow("ID_761", "762", "4.67789E+102", "1.40337E+103", "6.08126E+103", "2.38996E+104", "3.86E+89", "1.1572E+90"));
			Rows.Add( new AllStageStatsRow("ID_762", "763", "6.38532E+102", "2.55413E+103", "8.93945E+103", "3.2839E+104", "5.04E+89", "2.51789E+90"));
			Rows.Add( new AllStageStatsRow("ID_763", "764", "8.71597E+102", "4.35798E+103", "1.3074E+104", "4.5913E+104", "6.57E+89", "6.57426E+90"));
			Rows.Add( new AllStageStatsRow("ID_764", "765", "1.18973E+103", "7.13838E+103", "1.90357E+104", "6.49487E+104", "8.58E+89", "1.28742E+91"));
			Rows.Add( new AllStageStatsRow("ID_765", "766", "1.62398E+103", "3.24796E+103", "1.94878E+104", "8.44364E+104", "1.12E+90", "2.24098E+90"));
			Rows.Add( new AllStageStatsRow("ID_766", "767", "2.21673E+103", "6.6502E+103", "2.88175E+104", "1.13254E+105", "1.46E+90", "4.38844E+90"));
			Rows.Add( new AllStageStatsRow("ID_767", "768", "3.02584E+103", "1.21034E+104", "4.23618E+104", "1.55616E+105", "1.91E+90", "9.54861E+90"));
			Rows.Add( new AllStageStatsRow("ID_768", "769", "4.13027E+103", "2.06514E+104", "6.19541E+104", "2.1757E+105", "2.49E+90", "2.49316E+91"));
			Rows.Add( new AllStageStatsRow("ID_769", "770", "5.63782E+103", "3.38269E+104", "9.02052E+104", "3.07775E+105", "3.25E+90", "4.88228E+91"));
			Rows.Add( new AllStageStatsRow("ID_770", "771", "7.69563E+103", "1.53913E+104", "9.23476E+104", "4.00123E+105", "4.25E+90", "8.4985E+90"));
			Rows.Add( new AllStageStatsRow("ID_771", "772", "1.05045E+104", "3.15136E+104", "1.36559E+105", "5.36682E+105", "5.55E+90", "1.66423E+91"));
			Rows.Add( new AllStageStatsRow("ID_772", "773", "1.43387E+104", "5.73548E+104", "2.00742E+105", "7.37423E+105", "7.24E+90", "3.62113E+91"));
			Rows.Add( new AllStageStatsRow("ID_773", "774", "1.95723E+104", "9.78616E+104", "2.93585E+105", "1.03101E+106", "9.45E+90", "9.45485E+91"));
			Rows.Add( new AllStageStatsRow("ID_774", "775", "2.67162E+104", "1.60297E+105", "4.27459E+105", "1.45847E+106", "1.23E+91", "1.85151E+92"));
			Rows.Add( new AllStageStatsRow("ID_775", "776", "3.64676E+104", "7.29352E+104", "4.37611E+105", "1.89608E+106", "1.61E+91", "3.22289E+91"));
			Rows.Add( new AllStageStatsRow("ID_776", "777", "4.97783E+104", "1.49335E+105", "6.47118E+105", "2.5432E+106", "2.1E+91", "6.31129E+91"));
			Rows.Add( new AllStageStatsRow("ID_777", "778", "6.79474E+104", "2.7179E+105", "9.51263E+105", "3.49446E+106", "2.75E+91", "1.37324E+92"));
			Rows.Add( new AllStageStatsRow("ID_778", "779", "9.27482E+104", "4.63741E+105", "1.39122E+106", "4.88568E+106", "3.59E+91", "3.58557E+92"));
			Rows.Add( new AllStageStatsRow("ID_779", "780", "1.26601E+105", "7.59608E+105", "2.02562E+106", "6.9113E+106", "4.68E+91", "7.02151E+92"));
			Rows.Add( new AllStageStatsRow("ID_780", "781", "1.72811E+105", "3.45621E+105", "2.07373E+106", "8.98503E+106", "6.11E+91", "1.22222E+92"));
			Rows.Add( new AllStageStatsRow("ID_781", "782", "2.35887E+105", "7.0766E+105", "3.06653E+106", "1.20516E+107", "7.98E+91", "2.39344E+92"));
			Rows.Add( new AllStageStatsRow("ID_782", "783", "3.21985E+105", "1.28794E+106", "4.50779E+106", "1.65594E+107", "1.04E+92", "5.20777E+92"));
			Rows.Add( new AllStageStatsRow("ID_783", "784", "4.3951E+105", "2.19755E+106", "6.59265E+106", "2.3152E+107", "1.36E+92", "1.35976E+93"));
			Rows.Add( new AllStageStatsRow("ID_784", "785", "5.99931E+105", "3.59959E+106", "9.5989E+106", "3.27509E+107", "1.78E+92", "2.66277E+93"));
			Rows.Add( new AllStageStatsRow("ID_785", "786", "8.18906E+105", "1.63781E+106", "9.82687E+106", "4.25778E+107", "2.32E+92", "4.63504E+92"));
			Rows.Add( new AllStageStatsRow("ID_786", "787", "1.11781E+106", "3.35342E+106", "1.45315E+107", "5.71093E+107", "3.03E+92", "9.07665E+92"));
			Rows.Add( new AllStageStatsRow("ID_787", "788", "1.52581E+106", "6.10322E+106", "2.13613E+107", "7.84705E+107", "3.95E+92", "1.97495E+93"));
			Rows.Add( new AllStageStatsRow("ID_788", "789", "2.08273E+106", "1.04136E+107", "3.12409E+107", "1.09711E+108", "5.16E+92", "5.15663E+93"));
			Rows.Add( new AllStageStatsRow("ID_789", "790", "2.84292E+106", "1.70575E+107", "4.54867E+107", "1.55198E+108", "6.73E+92", "1.00981E+94"));
			Rows.Add( new AllStageStatsRow("ID_790", "791", "3.88059E+106", "7.76117E+106", "4.6567E+107", "2.01765E+108", "8.79E+92", "1.75775E+93"));
			Rows.Add( new AllStageStatsRow("ID_791", "792", "5.297E+106", "1.5891E+107", "6.8861E+107", "2.70626E+108", "1.15E+93", "3.44215E+93"));
			Rows.Add( new AllStageStatsRow("ID_792", "793", "7.2304E+106", "2.89216E+107", "1.01226E+108", "3.71852E+108", "1.5E+93", "7.48961E+93"));
			Rows.Add( new AllStageStatsRow("ID_793", "794", "9.8695E+106", "4.93475E+107", "1.48043E+108", "5.19894E+108", "1.96E+93", "1.95555E+94"));
			Rows.Add( new AllStageStatsRow("ID_794", "795", "1.34719E+107", "8.08312E+107", "2.1555E+108", "7.35444E+108", "2.55E+93", "3.8295E+94"));
			Rows.Add( new AllStageStatsRow("ID_795", "796", "1.83891E+107", "3.67782E+107", "2.20669E+108", "9.56113E+108", "3.33E+93", "6.66594E+93"));
			Rows.Add( new AllStageStatsRow("ID_796", "797", "2.51011E+107", "7.53034E+107", "3.26315E+108", "1.28243E+109", "4.35E+93", "1.30537E+94"));
			Rows.Add( new AllStageStatsRow("ID_797", "798", "3.4263E+107", "1.37052E+108", "4.79682E+108", "1.76211E+109", "5.68E+93", "2.84029E+94"));
			Rows.Add( new AllStageStatsRow("ID_798", "799", "4.6769E+107", "2.33845E+108", "7.01536E+108", "2.46365E+109", "7.42E+93", "7.41607E+94"));
			Rows.Add( new AllStageStatsRow("ID_799", "800", "6.38397E+107", "3.83038E+108", "1.02144E+109", "3.48508E+109", "9.68E+93", "1.45226E+95"));
			Rows.Add( new AllStageStatsRow("ID_800", "801", "8.71412E+107", "1.74282E+108", "1.04569E+109", "4.53078E+109", "1.26E+94", "2.52793E+94"));
			Rows.Add( new AllStageStatsRow("ID_801", "802", "1.18948E+108", "3.56843E+108", "1.54632E+109", "6.0771E+109", "1.65E+94", "4.95037E+94"));
			Rows.Add( new AllStageStatsRow("ID_802", "803", "1.62364E+108", "6.49455E+108", "2.27309E+109", "8.35019E+109", "2.15E+94", "1.07713E+95"));
			Rows.Add( new AllStageStatsRow("ID_803", "804", "2.21627E+108", "1.10813E+109", "3.3244E+109", "1.16746E+110", "2.81E+94", "2.8124E+95"));
			Rows.Add( new AllStageStatsRow("ID_804", "805", "3.0252E+108", "1.81512E+109", "4.84032E+109", "1.65149E+110", "3.67E+94", "5.50744E+95"));
			Rows.Add( new AllStageStatsRow("ID_805", "806", "4.1294E+108", "8.2588E+108", "4.95528E+109", "2.14702E+110", "4.79E+94", "9.5867E+94"));
			Rows.Add( new AllStageStatsRow("ID_806", "807", "5.63663E+108", "1.69099E+109", "7.32762E+109", "2.87978E+110", "6.26E+94", "1.87733E+95"));
			Rows.Add( new AllStageStatsRow("ID_807", "808", "7.694E+108", "3.0776E+109", "1.07716E+110", "3.95694E+110", "8.17E+94", "4.0848E+95"));
			Rows.Add( new AllStageStatsRow("ID_808", "809", "1.05023E+109", "5.25116E+109", "1.57535E+110", "5.53229E+110", "1.07E+95", "1.06655E+96"));
			Rows.Add( new AllStageStatsRow("ID_809", "810", "1.43357E+109", "8.60139E+109", "2.29371E+110", "7.82599E+110", "1.39E+95", "2.08859E+96"));
			Rows.Add( new AllStageStatsRow("ID_810", "811", "1.95682E+109", "3.91363E+109", "2.34818E+110", "1.01742E+111", "1.82E+95", "3.63557E+95"));
			Rows.Add( new AllStageStatsRow("ID_811", "812", "2.67106E+109", "8.01317E+109", "3.47237E+110", "1.36465E+111", "2.37E+95", "7.11943E+95"));
			Rows.Add( new AllStageStatsRow("ID_812", "813", "3.64599E+109", "1.4584E+110", "5.10439E+110", "1.87509E+111", "3.1E+95", "1.54908E+96"));
			Rows.Add( new AllStageStatsRow("ID_813", "814", "4.97678E+109", "2.48839E+110", "7.46517E+110", "2.62161E+111", "4.04E+95", "4.04469E+96"));
			Rows.Add( new AllStageStatsRow("ID_814", "815", "6.7933E+109", "4.07598E+110", "1.08693E+111", "3.70854E+111", "5.28E+95", "7.92059E+96"));
			Rows.Add( new AllStageStatsRow("ID_815", "816", "9.27286E+109", "1.85457E+110", "1.11274E+111", "4.82128E+111", "6.89E+95", "1.37872E+96"));
			Rows.Add( new AllStageStatsRow("ID_816", "817", "1.26574E+110", "3.79723E+110", "1.64547E+111", "6.46675E+111", "9E+95", "2.69991E+96"));
			Rows.Add( new AllStageStatsRow("ID_817", "818", "1.72774E+110", "6.91097E+110", "2.41884E+111", "8.88559E+111", "1.17E+96", "5.8746E+96"));
			Rows.Add( new AllStageStatsRow("ID_818", "819", "2.35837E+110", "1.17918E+111", "3.53755E+111", "1.24231E+112", "1.53E+96", "1.53387E+97"));
			Rows.Add( new AllStageStatsRow("ID_819", "820", "3.21917E+110", "1.9315E+111", "5.15067E+111", "1.75738E+112", "2E+96", "3.00373E+97"));
			Rows.Add( new AllStageStatsRow("ID_820", "821", "4.39417E+110", "8.78834E+110", "5.273E+111", "2.28468E+112", "2.61E+96", "5.22854E+96"));
			Rows.Add( new AllStageStatsRow("ID_821", "822", "5.99804E+110", "1.79941E+111", "7.79745E+111", "3.06443E+112", "3.41E+96", "1.02389E+97"));
			Rows.Add( new AllStageStatsRow("ID_822", "823", "8.18733E+110", "3.27493E+111", "1.14623E+112", "4.21065E+112", "4.46E+96", "2.22783E+97"));
			Rows.Add( new AllStageStatsRow("ID_823", "824", "1.11757E+111", "5.58785E+111", "1.67636E+112", "5.88701E+112", "5.82E+96", "5.81692E+97"));
			Rows.Add( new AllStageStatsRow("ID_824", "825", "1.52548E+111", "9.1529E+111", "2.44077E+112", "8.32778E+112", "7.59E+96", "1.13911E+98"));
			Rows.Add( new AllStageStatsRow("ID_825", "826", "2.08228E+111", "4.16457E+111", "2.49874E+112", "1.08265E+113", "9.91E+96", "1.98283E+97"));
			Rows.Add( new AllStageStatsRow("ID_826", "827", "2.84232E+111", "8.52695E+111", "3.69501E+112", "1.45215E+113", "1.29E+97", "3.8829E+97"));
			Rows.Add( new AllStageStatsRow("ID_827", "828", "3.87976E+111", "1.55191E+112", "5.43167E+112", "1.99532E+113", "1.69E+97", "8.44862E+97"));
			Rows.Add( new AllStageStatsRow("ID_828", "829", "5.29588E+111", "2.64794E+112", "7.94382E+112", "2.7897E+113", "2.21E+97", "2.20596E+98"));
			Rows.Add( new AllStageStatsRow("ID_829", "830", "7.22887E+111", "4.33732E+112", "1.15662E+113", "3.94632E+113", "2.88E+97", "4.31985E+98"));
			Rows.Add( new AllStageStatsRow("ID_830", "831", "9.86741E+111", "1.97348E+112", "1.18409E+113", "5.13041E+113", "3.76E+97", "7.51949E+97"));
			Rows.Add( new AllStageStatsRow("ID_831", "832", "1.3469E+112", "4.04071E+112", "1.75097E+113", "6.88138E+113", "4.91E+97", "1.47252E+98"));
			Rows.Add( new AllStageStatsRow("ID_832", "833", "1.83852E+112", "7.35408E+112", "2.57393E+113", "9.45531E+113", "6.41E+97", "3.20398E+98"));
			Rows.Add( new AllStageStatsRow("ID_833", "834", "2.50958E+112", "1.25479E+113", "3.76437E+113", "1.32197E+114", "8.37E+97", "8.36567E+98"));
			Rows.Add( new AllStageStatsRow("ID_834", "835", "3.42558E+112", "2.05535E+113", "5.48093E+113", "1.87006E+114", "1.09E+98", "1.63822E+99"));
			Rows.Add( new AllStageStatsRow("ID_835", "836", "4.67591E+112", "9.35183E+112", "5.6111E+113", "2.43117E+114", "1.43E+98", "2.85162E+98"));
			Rows.Add( new AllStageStatsRow("ID_836", "837", "6.38262E+112", "1.91479E+113", "8.29741E+113", "3.26091E+114", "1.86E+98", "5.58424E+98"));
			Rows.Add( new AllStageStatsRow("ID_837", "838", "8.71228E+112", "3.48491E+113", "1.21972E+114", "4.48063E+114", "2.43E+98", "1.21505E+99"));
			Rows.Add( new AllStageStatsRow("ID_838", "839", "1.18923E+113", "5.94613E+113", "1.78384E+114", "6.26447E+114", "3.17E+98", "3.17252E+99"));
			Rows.Add( new AllStageStatsRow("ID_839", "840", "1.62329E+113", "9.73976E+113", "2.59727E+114", "8.86174E+114", "4.14E+98", "6.21264E+99"));
			Rows.Add( new AllStageStatsRow("ID_840", "841", "2.2158E+113", "4.43159E+113", "2.65896E+114", "1.15207E+115", "5.41E+98", "1.08142E+99"));
			Rows.Add( new AllStageStatsRow("ID_841", "842", "3.02456E+113", "9.07369E+113", "3.93193E+114", "1.54526E+115", "7.06E+98", "2.11772E+99"));
			Rows.Add( new AllStageStatsRow("ID_842", "843", "4.12853E+113", "1.65141E+114", "5.77994E+114", "2.12326E+115", "9.22E+98", "4.60784E+99"));
			Rows.Add( new AllStageStatsRow("ID_843", "844", "5.63544E+113", "2.81772E+114", "8.45316E+114", "2.96857E+115", "1.2E+99", "1.20312E+100"));
			Rows.Add( new AllStageStatsRow("ID_844", "845", "7.69237E+113", "4.61542E+114", "1.23078E+115", "4.19935E+115", "1.57E+99", "2.35603E+100"));
			Rows.Add( new AllStageStatsRow("ID_845", "846", "1.05001E+114", "2.10002E+114", "1.26001E+115", "5.45936E+115", "2.05E+99", "4.1011E+99"));
			Rows.Add( new AllStageStatsRow("ID_846", "847", "1.43326E+114", "4.29979E+114", "1.86324E+115", "7.3226E+115", "2.68E+99", "8.03104E+99"));
			Rows.Add( new AllStageStatsRow("ID_847", "848", "1.9564E+114", "7.82561E+114", "2.73896E+115", "1.00616E+116", "3.49E+99", "1.74744E+100"));
			Rows.Add( new AllStageStatsRow("ID_848", "849", "2.67049E+114", "1.33525E+115", "4.00574E+115", "1.40673E+116", "4.56E+99", "4.5626E+100"));
			Rows.Add( new AllStageStatsRow("ID_849", "850", "3.64522E+114", "2.18713E+115", "5.83235E+115", "1.98997E+116", "5.96E+99", "8.93479E+100"));
			Rows.Add( new AllStageStatsRow("ID_850", "851", "4.97572E+114", "9.95145E+114", "5.97087E+115", "2.58705E+116", "7.78E+99", "1.55526E+100"));
			Rows.Add( new AllStageStatsRow("ID_851", "852", "6.79186E+114", "2.03756E+115", "8.82942E+115", "3.46999E+116", "1.02E+100", "3.04562E+100"));
			Rows.Add( new AllStageStatsRow("ID_852", "853", "9.27089E+114", "3.70836E+115", "1.29793E+116", "4.76792E+116", "1.33E+100", "6.62682E+100"));
			Rows.Add( new AllStageStatsRow("ID_853", "854", "1.26548E+115", "6.32739E+115", "1.89822E+116", "6.66614E+116", "1.73E+100", "1.73028E+101"));
			Rows.Add( new AllStageStatsRow("ID_854", "855", "1.72738E+115", "1.03643E+116", "2.7638E+116", "9.42994E+116", "2.26E+100", "3.38835E+101"));
			Rows.Add( new AllStageStatsRow("ID_855", "856", "2.35787E+115", "4.71574E+115", "2.82944E+116", "1.22594E+117", "2.95E+100", "5.89804E+100"));
			Rows.Add( new AllStageStatsRow("ID_856", "857", "3.21849E+115", "9.65547E+115", "4.18404E+116", "1.64434E+117", "3.85E+100", "1.15499E+101"));
			Rows.Add( new AllStageStatsRow("ID_857", "858", "4.39324E+115", "1.7573E+116", "6.15054E+116", "2.2594E+117", "5.03E+100", "2.5131E+101"));
			Rows.Add( new AllStageStatsRow("ID_858", "859", "5.99677E+115", "2.99839E+116", "8.99516E+116", "3.15891E+117", "6.56E+100", "6.56175E+101"));
			Rows.Add( new AllStageStatsRow("ID_859", "860", "8.18559E+115", "4.91136E+116", "1.3097E+117", "4.46861E+117", "8.57E+100", "1.28497E+102"));
			Rows.Add( new AllStageStatsRow("ID_860", "861", "1.11733E+116", "2.23467E+116", "1.3408E+117", "5.80941E+117", "1.12E+101", "2.23672E+101"));
			Rows.Add( new AllStageStatsRow("ID_861", "862", "1.52516E+116", "4.57548E+116", "1.98271E+117", "7.79211E+117", "1.46E+101", "4.38009E+101"));
			Rows.Add( new AllStageStatsRow("ID_862", "863", "2.08184E+116", "8.32738E+116", "2.91458E+117", "1.07067E+118", "1.91E+101", "9.53044E+101"));
			Rows.Add( new AllStageStatsRow("ID_863", "864", "2.84172E+116", "1.42086E+117", "4.26258E+117", "1.49693E+118", "2.49E+101", "2.48842E+102"));
			Rows.Add( new AllStageStatsRow("ID_864", "865", "3.87894E+116", "2.32737E+117", "6.20631E+117", "2.11756E+118", "3.25E+101", "4.87299E+102"));
			Rows.Add( new AllStageStatsRow("ID_865", "866", "5.29476E+116", "1.05895E+117", "6.35371E+117", "2.75293E+118", "4.24E+101", "8.48233E+101"));
			Rows.Add( new AllStageStatsRow("ID_866", "867", "7.22734E+116", "2.1682E+117", "9.39555E+117", "3.69248E+118", "5.54E+101", "1.66107E+102"));
			Rows.Add( new AllStageStatsRow("ID_867", "868", "9.86533E+116", "3.94613E+117", "1.38115E+118", "5.07363E+118", "7.23E+101", "3.61424E+102"));
			Rows.Add( new AllStageStatsRow("ID_868", "869", "1.34662E+117", "6.73308E+117", "2.01993E+118", "7.09355E+118", "9.44E+101", "9.43686E+102"));
			Rows.Add( new AllStageStatsRow("ID_869", "870", "1.83813E+117", "1.10288E+118", "2.94101E+118", "1.00346E+119", "1.23E+102", "1.84799E+103"));
			Rows.Add( new AllStageStatsRow("ID_870", "871", "2.50905E+117", "5.0181E+117", "3.01086E+118", "1.30454E+119", "1.61E+102", "3.21676E+102"));
			Rows.Add( new AllStageStatsRow("ID_871", "872", "3.42485E+117", "1.02746E+118", "4.45231E+118", "1.74977E+119", "2.1E+102", "6.29928E+102"));
			Rows.Add( new AllStageStatsRow("ID_872", "873", "4.67493E+117", "1.86997E+118", "6.5449E+118", "2.40426E+119", "2.74E+102", "1.37063E+103"));
			Rows.Add( new AllStageStatsRow("ID_873", "874", "6.38127E+117", "3.19064E+118", "9.57191E+118", "3.36145E+119", "3.58E+102", "3.57875E+103"));
			Rows.Add( new AllStageStatsRow("ID_874", "875", "8.71044E+117", "5.22626E+118", "1.39367E+119", "4.75512E+119", "4.67E+102", "7.00815E+103"));
			Rows.Add( new AllStageStatsRow("ID_875", "876", "1.18897E+118", "2.37795E+118", "1.42677E+119", "6.18189E+119", "6.1E+102", "1.2199E+103"));
			Rows.Add( new AllStageStatsRow("ID_876", "877", "1.62295E+118", "4.86885E+118", "2.10984E+119", "8.29173E+119", "7.96E+102", "2.38888E+103"));
			Rows.Add( new AllStageStatsRow("ID_877", "878", "2.21533E+118", "8.86131E+118", "3.10146E+119", "1.13932E+120", "1.04E+103", "5.19786E+103"));
			Rows.Add( new AllStageStatsRow("ID_878", "879", "3.02392E+118", "1.51196E+119", "4.53588E+119", "1.59291E+120", "1.36E+103", "1.35717E+104"));
			Rows.Add( new AllStageStatsRow("ID_879", "880", "4.12765E+118", "2.47659E+119", "6.60425E+119", "2.25333E+120", "1.77E+103", "2.65771E+104"));
			Rows.Add( new AllStageStatsRow("ID_880", "881", "5.63425E+118", "1.12685E+119", "6.7611E+119", "2.92944E+120", "2.31E+103", "4.62622E+103"));
			Rows.Add( new AllStageStatsRow("ID_881", "882", "7.69075E+118", "2.30722E+119", "9.99797E+119", "3.92924E+120", "3.02E+103", "9.05939E+103"));
			Rows.Add( new AllStageStatsRow("ID_882", "883", "1.04979E+119", "4.19915E+119", "1.4697E+120", "5.39894E+120", "3.94E+103", "1.97119E+104"));
			Rows.Add( new AllStageStatsRow("ID_883", "884", "1.43296E+119", "7.1648E+119", "2.14944E+120", "7.54838E+120", "5.15E+103", "5.14682E+104"));
			Rows.Add( new AllStageStatsRow("ID_884", "885", "1.95599E+119", "1.17359E+120", "3.12958E+120", "1.0678E+121", "6.72E+103", "1.00789E+105"));
			Rows.Add( new AllStageStatsRow("ID_885", "886", "2.66993E+119", "5.33985E+119", "3.20391E+120", "1.38819E+121", "8.77E+103", "1.75441E+104"));
			Rows.Add( new AllStageStatsRow("ID_886", "887", "3.64445E+119", "1.09333E+120", "4.73778E+120", "1.86197E+121", "1.15E+104", "3.4356E+104"));
			Rows.Add( new AllStageStatsRow("ID_887", "888", "4.97467E+119", "1.98987E+120", "6.96454E+120", "2.55842E+121", "1.5E+104", "7.47536E+104"));
			Rows.Add( new AllStageStatsRow("ID_888", "889", "6.79043E+119", "3.39521E+120", "1.01856E+121", "3.57698E+121", "1.95E+104", "1.95183E+105"));
			Rows.Add( new AllStageStatsRow("ID_889", "890", "9.26893E+119", "5.56136E+120", "1.48303E+121", "5.06001E+121", "2.55E+104", "3.82221E+105"));
			Rows.Add( new AllStageStatsRow("ID_890", "891", "1.26521E+120", "2.53042E+120", "1.51825E+121", "6.57826E+121", "3.33E+104", "6.65326E+104"));
			Rows.Add( new AllStageStatsRow("ID_891", "892", "1.72701E+120", "5.18103E+120", "2.24511E+121", "8.82338E+121", "4.34E+104", "1.30289E+105"));
			Rows.Add( new AllStageStatsRow("ID_892", "893", "2.35737E+120", "9.42948E+120", "3.30032E+121", "1.21237E+122", "5.67E+104", "2.83489E+105"));
			Rows.Add( new AllStageStatsRow("ID_893", "894", "3.21781E+120", "1.6089E+121", "4.82671E+121", "1.69504E+122", "7.4E+104", "7.40196E+105"));
			Rows.Add( new AllStageStatsRow("ID_894", "895", "4.39231E+120", "2.63539E+121", "7.0277E+121", "2.39781E+122", "9.66E+104", "1.4495E+106"));
			Rows.Add( new AllStageStatsRow("ID_895", "896", "5.9955E+120", "1.1991E+121", "7.1946E+121", "3.11727E+122", "1.26E+105", "2.52312E+105"));
			Rows.Add( new AllStageStatsRow("ID_896", "897", "8.18386E+120", "2.45516E+121", "1.0639E+122", "4.18117E+122", "1.65E+105", "4.94095E+105"));
			Rows.Add( new AllStageStatsRow("ID_897", "898", "1.1171E+121", "4.46839E+121", "1.56394E+122", "5.74511E+122", "2.15E+105", "1.07508E+106"));
			Rows.Add( new AllStageStatsRow("ID_898", "899", "1.52484E+121", "7.62419E+121", "2.28726E+122", "8.03237E+122", "2.81E+105", "2.80705E+106"));
			Rows.Add( new AllStageStatsRow("ID_899", "900", "2.0814E+121", "1.24884E+122", "3.33025E+122", "1.13626E+123", "3.66E+105", "5.49696E+106"));
			Rows.Add( new AllStageStatsRow("ID_900", "901", "2.84112E+121", "5.68223E+121", "3.40934E+122", "1.47719E+123", "4.78E+105", "9.56846E+105"));
			Rows.Add( new AllStageStatsRow("ID_901", "902", "3.87812E+121", "1.16344E+122", "5.04156E+122", "1.98135E+123", "6.25E+105", "1.87376E+106"));
			Rows.Add( new AllStageStatsRow("ID_902", "903", "5.29364E+121", "2.11745E+122", "7.41109E+122", "2.72246E+123", "8.15E+105", "4.07703E+106"));
			Rows.Add( new AllStageStatsRow("ID_903", "904", "7.22582E+121", "3.61291E+122", "1.08387E+123", "3.80633E+123", "1.06E+106", "1.06452E+107"));
			Rows.Add( new AllStageStatsRow("ID_904", "905", "9.86324E+121", "5.91794E+122", "1.57812E+123", "5.38445E+123", "1.39E+106", "2.08462E+107"));
			Rows.Add( new AllStageStatsRow("ID_905", "906", "1.34633E+122", "2.69266E+122", "1.6156E+123", "7.00005E+123", "1.81E+106", "3.62866E+106"));
			Rows.Add( new AllStageStatsRow("ID_906", "907", "1.83774E+122", "5.51323E+122", "2.38907E+123", "9.38911E+123", "2.37E+106", "7.10588E+106"));
			Rows.Add( new AllStageStatsRow("ID_907", "908", "2.50852E+122", "1.00341E+123", "3.51193E+123", "1.2901E+124", "3.09E+106", "1.54614E+107"));
			Rows.Add( new AllStageStatsRow("ID_908", "909", "3.42413E+122", "1.71206E+123", "5.13619E+123", "1.80372E+124", "4.04E+106", "4.03699E+107"));
			Rows.Add( new AllStageStatsRow("ID_909", "910", "4.67394E+122", "2.80436E+123", "7.4783E+123", "2.55155E+124", "5.27E+106", "7.90552E+107"));
			Rows.Add( new AllStageStatsRow("ID_910", "911", "6.37992E+122", "1.27598E+123", "7.65591E+123", "3.31714E+124", "6.88E+106", "1.3761E+107"));
			Rows.Add( new AllStageStatsRow("ID_911", "912", "8.70859E+122", "2.61258E+123", "1.13212E+124", "4.44926E+124", "8.98E+106", "2.69477E+107"));
			Rows.Add( new AllStageStatsRow("ID_912", "913", "1.18872E+123", "4.75489E+123", "1.66421E+124", "6.11347E+124", "1.17E+107", "5.86342E+107"));
			Rows.Add( new AllStageStatsRow("ID_913", "914", "1.62261E+123", "8.11304E+123", "2.43391E+124", "8.54738E+124", "1.53E+107", "1.53095E+108"));
			Rows.Add( new AllStageStatsRow("ID_914", "915", "2.21486E+123", "1.32892E+124", "3.54377E+124", "1.20912E+125", "2E+107", "2.99802E+108"));
			Rows.Add( new AllStageStatsRow("ID_915", "916", "3.02328E+123", "6.04656E+123", "3.62794E+124", "1.57191E+125", "2.61E+107", "5.21859E+107"));
			Rows.Add( new AllStageStatsRow("ID_916", "917", "4.12678E+123", "1.23803E+124", "5.36481E+124", "2.10839E+125", "3.41E+107", "1.02194E+108"));
			Rows.Add( new AllStageStatsRow("ID_917", "918", "5.63305E+123", "2.25322E+124", "7.88628E+124", "2.89702E+125", "4.45E+107", "2.22359E+108"));
			Rows.Add( new AllStageStatsRow("ID_918", "919", "7.68912E+123", "3.84456E+124", "1.15337E+125", "4.05039E+125", "5.81E+107", "5.80585E+108"));
			Rows.Add( new AllStageStatsRow("ID_919", "920", "1.04956E+124", "6.29739E+124", "1.6793E+125", "5.72969E+125", "7.58E+107", "1.13694E+109"));
			Rows.Add( new AllStageStatsRow("ID_920", "921", "1.43266E+124", "2.86531E+124", "1.71919E+125", "7.44888E+125", "9.9E+107", "1.97905E+108"));
			Rows.Add( new AllStageStatsRow("ID_921", "922", "1.95558E+124", "5.86673E+124", "2.54225E+125", "9.99113E+125", "1.29E+108", "3.87552E+108"));
			Rows.Add( new AllStageStatsRow("ID_922", "923", "2.66936E+124", "1.06774E+125", "3.7371E+125", "1.37282E+126", "1.69E+108", "8.43255E+108"));
			Rows.Add( new AllStageStatsRow("ID_923", "924", "3.64368E+124", "1.82184E+125", "5.46552E+125", "1.91937E+126", "2.2E+108", "2.20176E+109"));
			Rows.Add( new AllStageStatsRow("ID_924", "925", "4.97362E+124", "2.98417E+125", "7.95779E+125", "2.71515E+126", "2.87E+108", "4.31163E+109"));
			Rows.Add( new AllStageStatsRow("ID_925", "926", "6.78899E+124", "1.3578E+125", "8.14679E+125", "3.52983E+126", "3.75E+108", "7.50518E+108"));
			Rows.Add( new AllStageStatsRow("ID_926", "927", "9.26697E+124", "2.78009E+125", "1.20471E+126", "4.73454E+126", "4.9E+108", "1.46972E+109"));
			Rows.Add( new AllStageStatsRow("ID_927", "928", "1.26494E+125", "5.05977E+125", "1.77092E+126", "6.50546E+126", "6.4E+108", "3.19788E+109"));
			Rows.Add( new AllStageStatsRow("ID_928", "929", "1.72665E+125", "8.63323E+125", "2.58997E+126", "9.09543E+126", "8.35E+108", "8.34975E+109"));
			Rows.Add( new AllStageStatsRow("ID_929", "930", "2.35687E+125", "1.41412E+126", "3.77099E+126", "1.28664E+127", "1.09E+109", "1.6351E+110"));
			Rows.Add( new AllStageStatsRow("ID_930", "931", "3.21713E+125", "6.43426E+125", "3.86055E+126", "1.6727E+127", "1.42E+109", "2.8462E+109"));
			Rows.Add( new AllStageStatsRow("ID_931", "932", "4.39138E+125", "1.31741E+126", "5.70879E+126", "2.24358E+127", "1.86E+109", "5.57362E+109"));
			Rows.Add( new AllStageStatsRow("ID_932", "933", "5.99423E+125", "2.39769E+126", "8.39193E+126", "3.08277E+127", "2.43E+109", "1.21274E+110"));
			Rows.Add( new AllStageStatsRow("ID_933", "934", "8.18213E+125", "4.09107E+126", "1.22732E+127", "4.31009E+127", "3.17E+109", "3.16648E+110"));
			Rows.Add( new AllStageStatsRow("ID_934", "935", "1.11686E+126", "6.70116E+126", "1.78698E+127", "6.09707E+127", "4.13E+109", "6.20082E+110"));
			Rows.Add( new AllStageStatsRow("ID_935", "936", "1.52451E+126", "3.04903E+126", "1.82942E+127", "7.92648E+127", "5.4E+109", "1.07937E+110"));
			Rows.Add( new AllStageStatsRow("ID_936", "937", "2.08096E+126", "6.24289E+126", "2.70525E+127", "1.06317E+128", "7.05E+109", "2.11369E+110"));
			Rows.Add( new AllStageStatsRow("ID_937", "938", "2.84051E+126", "1.13621E+127", "3.97672E+127", "1.46085E+128", "9.2E+109", "4.59907E+110"));
			Rows.Add( new AllStageStatsRow("ID_938", "939", "3.8773E+126", "1.93865E+127", "5.81595E+127", "2.04244E+128", "1.2E+110", "1.20083E+111"));
			Rows.Add( new AllStageStatsRow("ID_939", "940", "5.29252E+126", "3.17551E+127", "8.46803E+127", "2.88924E+128", "1.57E+110", "2.35154E+111"));
			Rows.Add( new AllStageStatsRow("ID_940", "941", "7.22429E+126", "1.44486E+127", "8.66914E+127", "3.75616E+128", "2.05E+110", "4.09329E+110"));
			Rows.Add( new AllStageStatsRow("ID_941", "942", "9.86115E+126", "2.95835E+127", "1.28195E+128", "5.03811E+128", "2.67E+110", "8.01576E+110"));
			Rows.Add( new AllStageStatsRow("ID_942", "943", "1.34605E+127", "5.38419E+127", "1.88447E+128", "6.92257E+128", "3.49E+110", "1.74411E+111"));
			Rows.Add( new AllStageStatsRow("ID_943", "944", "1.83735E+127", "9.18677E+127", "2.75603E+128", "9.67861E+128", "4.55E+110", "4.55392E+111"));
			Rows.Add( new AllStageStatsRow("ID_944", "945", "2.50799E+127", "1.50479E+128", "4.01278E+128", "1.36914E+129", "5.95E+110", "8.91779E+111"));
			Rows.Add( new AllStageStatsRow("ID_945", "946", "3.4234E+127", "6.84681E+127", "4.10809E+128", "1.77995E+129", "7.76E+110", "1.5523E+111"));
			Rows.Add( new AllStageStatsRow("ID_946", "947", "4.67295E+127", "1.40188E+128", "6.07483E+128", "2.38743E+129", "1.01E+111", "3.03983E+111"));
			Rows.Add( new AllStageStatsRow("ID_947", "948", "6.37857E+127", "2.55143E+128", "8.93E+128", "3.28043E+129", "1.32E+111", "6.61421E+111"));
			Rows.Add( new AllStageStatsRow("ID_948", "949", "8.70675E+127", "4.35338E+128", "1.30601E+129", "4.58644E+129", "1.73E+111", "1.72699E+112"));
			Rows.Add( new AllStageStatsRow("ID_949", "950", "1.18847E+128", "7.13083E+128", "1.90155E+129", "6.488E+129", "2.25E+111", "3.3819E+112"));
			Rows.Add( new AllStageStatsRow("ID_950", "951", "1.62226E+128", "3.24453E+128", "1.94672E+129", "8.43471E+129", "2.94E+111", "5.88682E+111"));
			Rows.Add( new AllStageStatsRow("ID_951", "952", "2.21439E+128", "6.64317E+128", "2.87871E+129", "1.13134E+130", "3.84E+111", "1.1528E+112"));
			Rows.Add( new AllStageStatsRow("ID_952", "953", "3.02264E+128", "1.20906E+129", "4.2317E+129", "1.55451E+130", "5.02E+111", "2.50831E+112"));
			Rows.Add( new AllStageStatsRow("ID_953", "954", "4.12591E+128", "2.06295E+129", "6.18886E+129", "2.1734E+130", "6.55E+111", "6.54927E+112"));
			Rows.Add( new AllStageStatsRow("ID_954", "955", "5.63186E+128", "3.37912E+129", "9.01098E+129", "3.0745E+130", "8.55E+111", "1.28252E+113"));
			Rows.Add( new AllStageStatsRow("ID_955", "956", "7.68749E+128", "1.5375E+129", "9.22499E+129", "3.997E+130", "1.12E+112", "2.23246E+112"));
			Rows.Add( new AllStageStatsRow("ID_956", "957", "1.04934E+129", "3.14803E+129", "1.36415E+130", "5.36114E+130", "1.46E+112", "4.37176E+112"));
			Rows.Add( new AllStageStatsRow("ID_957", "958", "1.43235E+129", "5.72941E+129", "2.00529E+130", "7.36643E+130", "1.9E+112", "9.51231E+112"));
			Rows.Add( new AllStageStatsRow("ID_958", "959", "1.95516E+129", "9.77581E+129", "2.93274E+130", "1.02992E+131", "2.48E+112", "2.48369E+113"));
			Rows.Add( new AllStageStatsRow("ID_959", "960", "2.6688E+129", "1.60128E+130", "4.27007E+130", "1.45693E+131", "3.24E+112", "4.86372E+113"));
			Rows.Add( new AllStageStatsRow("ID_960", "961", "3.64291E+129", "7.28581E+129", "4.37149E+130", "1.89407E+131", "4.23E+112", "8.46619E+112"));
			Rows.Add( new AllStageStatsRow("ID_961", "962", "4.97257E+129", "1.49177E+130", "6.46434E+130", "2.54051E+131", "5.53E+112", "1.65791E+113"));
			Rows.Add( new AllStageStatsRow("ID_962", "963", "6.78755E+129", "2.71502E+130", "9.50258E+130", "3.49076E+131", "7.21E+112", "3.60736E+113"));
			Rows.Add( new AllStageStatsRow("ID_963", "964", "9.26501E+129", "4.63251E+130", "1.38975E+131", "4.88052E+131", "9.42E+112", "9.41891E+113"));
			Rows.Add( new AllStageStatsRow("ID_964", "965", "1.26467E+130", "7.58804E+130", "2.02348E+131", "6.90399E+131", "1.23E+113", "1.84447E+114"));
			Rows.Add( new AllStageStatsRow("ID_965", "966", "1.72628E+130", "3.45256E+130", "2.07154E+131", "8.97553E+131", "1.61E+113", "3.21064E+113"));
			Rows.Add( new AllStageStatsRow("ID_966", "967", "2.35637E+130", "7.06912E+130", "3.06328E+131", "1.20388E+132", "2.1E+113", "6.2873E+113"));
			Rows.Add( new AllStageStatsRow("ID_967", "968", "3.21645E+130", "1.28658E+131", "4.50303E+131", "1.65418E+132", "2.74E+113", "1.36802E+114"));
			Rows.Add( new AllStageStatsRow("ID_968", "969", "4.39045E+130", "2.19523E+131", "6.58568E+131", "2.31275E+132", "3.57E+113", "3.57194E+114"));
			Rows.Add( new AllStageStatsRow("ID_969", "970", "5.99297E+130", "3.59578E+131", "9.58875E+131", "3.27163E+132", "4.66E+113", "6.99482E+114"));
			Rows.Add( new AllStageStatsRow("ID_970", "971", "8.1804E+130", "1.63608E+131", "9.81648E+131", "4.25327E+132", "6.09E+113", "1.21758E+114"));
			Rows.Add( new AllStageStatsRow("ID_971", "972", "1.11662E+131", "3.34987E+131", "1.45161E+132", "5.70489E+132", "7.95E+113", "2.38434E+114"));
			Rows.Add( new AllStageStatsRow("ID_972", "973", "1.52419E+131", "6.09677E+131", "2.13387E+132", "7.83876E+132", "1.04E+114", "5.18797E+114"));
			Rows.Add( new AllStageStatsRow("ID_973", "974", "2.08052E+131", "1.04026E+132", "3.12078E+132", "1.09595E+133", "1.35E+114", "1.35459E+115"));
			Rows.Add( new AllStageStatsRow("ID_974", "975", "2.83991E+131", "1.70395E+132", "4.54386E+132", "1.55034E+133", "1.77E+114", "2.65265E+115"));
			Rows.Add( new AllStageStatsRow("ID_975", "976", "3.87648E+131", "7.75296E+131", "4.65178E+132", "2.01552E+133", "2.31E+114", "4.61742E+114"));
			Rows.Add( new AllStageStatsRow("ID_976", "977", "5.2914E+131", "1.58742E+132", "6.87882E+132", "2.7034E+133", "3.01E+114", "9.04215E+114"));
			Rows.Add( new AllStageStatsRow("ID_977", "978", "7.22276E+131", "2.8891E+132", "1.01119E+133", "3.71459E+133", "3.93E+114", "1.96744E+115"));
			Rows.Add( new AllStageStatsRow("ID_978", "979", "9.85906E+131", "4.92953E+132", "1.47886E+133", "5.19345E+133", "5.14E+114", "5.13703E+115"));
			Rows.Add( new AllStageStatsRow("ID_979", "980", "1.34576E+132", "8.07457E+132", "2.15322E+133", "7.34667E+133", "6.71E+114", "1.00597E+116"));
			Rows.Add( new AllStageStatsRow("ID_980", "981", "1.83697E+132", "3.67393E+132", "2.20436E+133", "9.55102E+133", "8.76E+114", "1.75107E+115"));
			Rows.Add( new AllStageStatsRow("ID_981", "982", "2.50746E+132", "7.52237E+132", "3.2597E+133", "1.28107E+134", "1.14E+115", "3.42906E+115"));
			Rows.Add( new AllStageStatsRow("ID_982", "983", "3.42268E+132", "1.36907E+133", "4.79175E+133", "1.76025E+134", "1.49E+115", "7.46114E+115"));
			Rows.Add( new AllStageStatsRow("ID_983", "984", "4.67196E+132", "2.33598E+133", "7.00794E+133", "2.46104E+134", "1.95E+115", "1.94812E+116"));
			Rows.Add( new AllStageStatsRow("ID_984", "985", "6.37722E+132", "3.82633E+133", "1.02036E+134", "3.4814E+134", "2.54E+115", "3.81494E+116"));
			Rows.Add( new AllStageStatsRow("ID_985", "986", "8.70491E+132", "1.74098E+133", "1.04459E+134", "4.52599E+134", "3.32E+115", "6.6406E+115"));
			Rows.Add( new AllStageStatsRow("ID_986", "987", "1.18822E+133", "3.56466E+133", "1.54469E+134", "6.07067E+134", "4.33E+115", "1.30041E+116"));
			Rows.Add( new AllStageStatsRow("ID_987", "988", "1.62192E+133", "6.48768E+133", "2.27069E+134", "8.34136E+134", "5.66E+115", "2.82949E+116"));
			Rows.Add( new AllStageStatsRow("ID_988", "989", "2.21392E+133", "1.10696E+134", "3.32088E+134", "1.16622E+135", "7.39E+115", "7.38788E+116"));
			Rows.Add( new AllStageStatsRow("ID_989", "990", "3.022E+133", "1.8132E+134", "4.8352E+134", "1.64974E+135", "9.64E+115", "1.44674E+117"));
			Rows.Add( new AllStageStatsRow("ID_990", "991", "4.12503E+133", "8.25007E+133", "4.95004E+134", "2.14475E+135", "1.26E+116", "2.51832E+116"));
			Rows.Add( new AllStageStatsRow("ID_991", "992", "5.63067E+133", "1.6892E+134", "7.31987E+134", "2.87674E+135", "1.64E+116", "4.93155E+116"));
			Rows.Add( new AllStageStatsRow("ID_992", "993", "7.68587E+133", "3.07435E+134", "1.07602E+135", "3.95276E+135", "2.15E+116", "1.07303E+117"));
			Rows.Add( new AllStageStatsRow("ID_993", "994", "1.04912E+134", "5.2456E+134", "1.57368E+135", "5.52644E+135", "2.8E+116", "2.80171E+117"));
			Rows.Add( new AllStageStatsRow("ID_994", "995", "1.43205E+134", "8.5923E+134", "2.29128E+135", "7.81772E+135", "3.66E+116", "5.4865E+117"));
			Rows.Add( new AllStageStatsRow("ID_995", "996", "1.95475E+134", "3.9095E+134", "2.3457E+135", "1.01634E+136", "4.78E+116", "9.55026E+116"));
			Rows.Add( new AllStageStatsRow("ID_996", "997", "2.66823E+134", "8.00469E+134", "3.4687E+135", "1.36321E+136", "6.23E+116", "1.8702E+117"));
			Rows.Add( new AllStageStatsRow("ID_997", "998", "3.64214E+134", "1.45685E+135", "5.09899E+135", "1.87311E+136", "8.14E+116", "4.06927E+117"));
			Rows.Add( new AllStageStatsRow("ID_998", "999", "4.97151E+134", "2.48576E+135", "7.45727E+135", "2.61884E+136", "1.06E+117", "1.0625E+118"));
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
		public AllStageStatsRow GetRow(rowIds in_RowID)
		{
			AllStageStatsRow ret = null;
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
		public AllStageStatsRow GetRow(string in_RowString)
		{
			AllStageStatsRow ret = null;
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
