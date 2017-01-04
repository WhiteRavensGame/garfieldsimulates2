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
	public class xStageStatsRow : IGoogle2uRow
	{
		public float _Stage;
		public float _MinionGold;
		public float _BossGold;
		public float _GoldPerStage;
		public float _Cum_GoldPerStage;
		public float _MinionHP;
		public float _BossHP;
		public xStageStatsRow(string __ID, string __Stage, string __MinionGold, string __BossGold, string __GoldPerStage, string __Cum_GoldPerStage, string __MinionHP, string __BossHP) 
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
	public sealed class xStageStats : IGoogle2uDB
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
		public System.Collections.Generic.List<xStageStatsRow> Rows = new System.Collections.Generic.List<xStageStatsRow>();

		public static xStageStats Instance
		{
			get { return NestedxStageStats.instance; }
		}

		private class NestedxStageStats
		{
			static NestedxStageStats() { }
			internal static readonly xStageStats instance = new xStageStats();
		}

		private xStageStats()
		{
			Rows.Add( new xStageStatsRow("ID_0", "1", "2", "4", "24", "24", "30", "60"));
			Rows.Add( new xStageStatsRow("ID_1", "2", "6", "18", "78", "102", "40", "120"));
			Rows.Add( new xStageStatsRow("ID_2", "3", "10", "40", "140", "242", "52", "260"));
			Rows.Add( new xStageStatsRow("ID_3", "4", "15", "75", "225", "467", "67", "670"));
			Rows.Add( new xStageStatsRow("ID_4", "5", "19", "114", "304", "771", "88", "1320"));
			Rows.Add( new xStageStatsRow("ID_5", "6", "23", "46", "276", "1047", "114", "228"));
			Rows.Add( new xStageStatsRow("ID_6", "7", "27", "81", "351", "1398", "149", "447"));
			Rows.Add( new xStageStatsRow("ID_7", "8", "32", "128", "448", "1846", "194", "970"));
			Rows.Add( new xStageStatsRow("ID_8", "9", "36", "180", "540", "2386", "254", "2540"));
			Rows.Add( new xStageStatsRow("ID_9", "10", "41", "246", "656", "3042", "331", "4965"));
			Rows.Add( new xStageStatsRow("ID_10", "11", "45", "90", "540", "3582", "432", "864"));
			Rows.Add( new xStageStatsRow("ID_11", "12", "50", "150", "650", "4232", "564", "1692"));
			Rows.Add( new xStageStatsRow("ID_12", "13", "55", "220", "770", "5002", "736", "3680"));
			Rows.Add( new xStageStatsRow("ID_13", "14", "60", "300", "900", "5902", "960", "9600"));
			Rows.Add( new xStageStatsRow("ID_14", "15", "65", "390", "1040", "6942", "1254", "18810"));
			Rows.Add( new xStageStatsRow("ID_15", "16", "71", "142", "852", "7794", "1637", "3274"));
			Rows.Add( new xStageStatsRow("ID_16", "17", "77", "231", "1001", "8795", "2137", "6411"));
			Rows.Add( new xStageStatsRow("ID_17", "18", "83", "332", "1162", "9957", "2789", "13945"));
			Rows.Add( new xStageStatsRow("ID_18", "19", "89", "445", "1335", "11292", "3641", "36410"));
			Rows.Add( new xStageStatsRow("ID_19", "20", "97", "582", "1552", "12844", "4753", "71295"));
			Rows.Add( new xStageStatsRow("ID_20", "21", "105", "210", "1260", "14104", "6205", "12410"));
			Rows.Add( new xStageStatsRow("ID_21", "22", "113", "339", "1469", "15573", "8101", "24303"));
			Rows.Add( new xStageStatsRow("ID_22", "23", "123", "492", "1722", "17295", "10576", "52880"));
			Rows.Add( new xStageStatsRow("ID_23", "24", "133", "665", "1995", "19290", "13807", "138070"));
			Rows.Add( new xStageStatsRow("ID_24", "25", "145", "870", "2320", "21610", "18025", "270375"));
			Rows.Add( new xStageStatsRow("ID_25", "26", "159", "318", "1908", "23518", "23532", "47064"));
			Rows.Add( new xStageStatsRow("ID_26", "27", "174", "522", "2262", "25780", "30720", "92160"));
			Rows.Add( new xStageStatsRow("ID_27", "28", "192", "768", "2688", "28468", "40106", "200530"));
			Rows.Add( new xStageStatsRow("ID_28", "29", "212", "1060", "3180", "31648", "52358", "523580"));
			Rows.Add( new xStageStatsRow("ID_29", "30", "236", "1416", "3776", "35424", "68354", "1025310"));
			Rows.Add( new xStageStatsRow("ID_30", "31", "264", "528", "3168", "38592", "89237", "178474"));
			Rows.Add( new xStageStatsRow("ID_31", "32", "296", "888", "3848", "42440", "116500", "349500"));
			Rows.Add( new xStageStatsRow("ID_32", "33", "335", "1340", "4690", "47130", "152092", "760460"));
			Rows.Add( new xStageStatsRow("ID_33", "34", "380", "1900", "5700", "52830", "198558", "1985580"));
			Rows.Add( new xStageStatsRow("ID_34", "35", "433", "2598", "6928", "59758", "259220", "3888300"));
			Rows.Add( new xStageStatsRow("ID_35", "36", "496", "992", "5952", "65710", "338414", "676828"));
			Rows.Add( new xStageStatsRow("ID_36", "37", "571", "1713", "7423", "73133", "441804", "1325412"));
			Rows.Add( new xStageStatsRow("ID_37", "38", "660", "2640", "9240", "82373", "576780", "2883900"));
			Rows.Add( new xStageStatsRow("ID_38", "39", "766", "3830", "11490", "93863", "752993", "7529930"));
			Rows.Add( new xStageStatsRow("ID_39", "40", "892", "5352", "14272", "108135", "983040", "14745600"));
			Rows.Add( new xStageStatsRow("ID_40", "41", "1043", "2086", "12516", "120651", "1283371", "2566742"));
			Rows.Add( new xStageStatsRow("ID_41", "42", "1224", "3672", "15912", "136563", "1675455", "5026365"));
			Rows.Add( new xStageStatsRow("ID_42", "43", "1439", "5756", "20146", "156709", "2187326", "10936630"));
			Rows.Add( new xStageStatsRow("ID_43", "44", "1697", "8485", "25455", "182164", "2855580", "28555800"));
			Rows.Add( new xStageStatsRow("ID_44", "45", "2006", "12036", "32096", "214260", "3727993", "55919895"));
			Rows.Add( new xStageStatsRow("ID_45", "46", "2376", "4752", "28512", "242772", "4866938", "9733876"));
			Rows.Add( new xStageStatsRow("ID_46", "47", "2819", "8457", "36647", "279419", "6353845", "19061535"));
			Rows.Add( new xStageStatsRow("ID_47", "48", "3349", "13396", "46886", "326305", "8295018", "41475090"));
			Rows.Add( new xStageStatsRow("ID_48", "49", "3985", "19925", "59775", "386080", "10800000", "108292430"));
			Rows.Add( new xStageStatsRow("ID_49", "50", "4748", "28488", "75968", "462048", "14100000", "212065560"));
			Rows.Add( new xStageStatsRow("ID_50", "51", "5662", "11324", "67944", "529992", "18500000", "36913876"));
			Rows.Add( new xStageStatsRow("ID_51", "52", "6758", "20274", "87854", "617846", "24100000", "72287244"));
			Rows.Add( new xStageStatsRow("ID_52", "53", "8072", "32288", "113008", "730854", "31500000", "157286400"));
			Rows.Add( new xStageStatsRow("ID_53", "54", "9649", "48245", "144735", "875589", "41100000", "410678480"));
			Rows.Add( new xStageStatsRow("ID_54", "55", "11540", "69240", "184640", "1060229", "53600000", "804218325"));
			Rows.Add( new xStageStatsRow("ID_55", "56", "13808", "27616", "165696", "1225925", "70000000", "139988858"));
			Rows.Add( new xStageStatsRow("ID_56", "57", "16530", "49590", "214890", "1440815", "91400000", "274135635"));
			Rows.Add( new xStageStatsRow("ID_57", "58", "19795", "79180", "277130", "1717945", "119000000", "596478800"));
			Rows.Add( new xStageStatsRow("ID_58", "59", "23712", "118560", "355680", "2073625", "156000000", "1557420100"));
			Rows.Add( new xStageStatsRow("ID_59", "60", "28411", "170466", "454576", "2528201", "203000000", "3049845225"));
			Rows.Add( new xStageStatsRow("ID_60", "61", "34050", "68100", "408600", "2936801", "265000000", "530881150"));
			Rows.Add( new xStageStatsRow("ID_61", "62", "40816", "122448", "530608", "3467409", "347000000", "1039607325"));
			Rows.Add( new xStageStatsRow("ID_62", "63", "48934", "195736", "685076", "4152485", "452000000", "2262032540"));
			Rows.Add( new xStageStatsRow("ID_63", "64", "58675", "293375", "880125", "5032610", "591000000", "5906219890"));
			Rows.Add( new xStageStatsRow("ID_64", "65", "70363", "422178", "1125808", "6158418", "771000000", "11565958725"));
			Rows.Add( new xStageStatsRow("ID_65", "66", "84388", "168776", "1012656", "7171074", "1010000000", "2013265920"));
			Rows.Add( new xStageStatsRow("ID_66", "67", "101217", "303651", "1315821", "8486895", "1310000000", "3942513315"));
			Rows.Add( new xStageStatsRow("ID_67", "68", "121411", "485644", "1699754", "10186649", "1720000000", "8578328750"));
			Rows.Add( new xStageStatsRow("ID_68", "69", "145644", "728220", "2184660", "12371309", "2240000000", "22398217060"));
			Rows.Add( new xStageStatsRow("ID_69", "70", "174722", "1048332", "2795552", "15166861", "2920000000", "43861701570"));
			Rows.Add( new xStageStatsRow("ID_70", "71", "209615", "419230", "2515380", "17682241", "3820000000", "7634928598"));
			Rows.Add( new xStageStatsRow("ID_71", "72", "251486", "754458", "3269318", "20951559", "4980000000", "14951232891"));
			Rows.Add( new xStageStatsRow("ID_72", "73", "301730", "1206920", "4224220", "25175779", "6510000000", "32531682395"));
			Rows.Add( new xStageStatsRow("ID_73", "74", "362022", "1810110", "5430330", "30606109", "8490000000", "84940983820"));
			Rows.Add( new xStageStatsRow("ID_74", "75", "434371", "2606226", "6949936", "37556045", "11100000000", "166337171985"));
			Rows.Add( new xStageStatsRow("ID_75", "76", "521190", "1042380", "6254280", "43810325", "14500000000", "28954016504"));
			Rows.Add( new xStageStatsRow("ID_76", "77", "625372", "1876116", "8129836", "51940161", "18900000000", "56699710863"));
			Rows.Add( new xStageStatsRow("ID_77", "78", "750389", "3001556", "10505446", "62445607", "24700000000", "123370226315"));
			Rows.Add( new xStageStatsRow("ID_78", "79", "900409", "4502045", "13506135", "75951742", "32200000000", "322122547200"));
			Rows.Add( new xStageStatsRow("ID_79", "80", "1080432", "6482592", "17286912", "93238654", "42100000000", "630802130205"));
			Rows.Add( new xStageStatsRow("ID_80", "81", "1296459", "2592918", "15557508", "108796162", "54900000000", "109802607990"));
			Rows.Add( new xStageStatsRow("ID_81", "82", "1555690", "4667070", "20223970", "129020132", "71700000000", "215022883755"));
			Rows.Add( new xStageStatsRow("ID_82", "83", "1866767", "7467068", "26134738", "155154870", "93600000000", "467858150025"));
			Rows.Add( new xStageStatsRow("ID_83", "84", "2240058", "11200290", "33600870", "188755740", "122000000000", "1221588575450"));
			Rows.Add( new xStageStatsRow("ID_84", "85", "2688007", "16128042", "43008112", "231763852", "159000000000", "2392197262560"));
			Rows.Add( new xStageStatsRow("ID_85", "86", "3225545", "6451090", "38706540", "270470392", "208000000000", "416405534600"));
			Rows.Add( new xStageStatsRow("ID_86", "87", "3870590", "11611770", "50317670", "320788062", "272000000000", "815433444618"));
			Rows.Add( new xStageStatsRow("ID_87", "88", "4644643", "18578572", "65025002", "385813064", "355000000000", "1774263167750"));
			Rows.Add( new xStageStatsRow("ID_88", "89", "5573506", "27867530", "83602590", "469415654", "463000000000", "4632642640630"));
			Rows.Add( new xStageStatsRow("ID_89", "90", "6688140", "40128840", "107010240", "576425894", "605000000000", "9071953737975"));
			Rows.Add( new xStageStatsRow("ID_90", "91", "8025701", "16051402", "96308412", "672734306", "790000000000", "1579138896800"));
			Rows.Add( new xStageStatsRow("ID_91", "92", "9630772", "28892316", "125200036", "797934342", "1030000000000", "3092376453120"));
			Rows.Add( new xStageStatsRow("ID_92", "93", "11556858", "46227432", "161796012", "959730354", "1350000000000", "6728556055455"));
			Rows.Add( new xStageStatsRow("ID_93", "94", "13868160", "69340800", "208022400", "1167752754", "1760000000000", "17568417278180"));
			Rows.Add( new xStageStatsRow("ID_94", "95", "16641721", "99850326", "266267536", "1434020290", "2290000000000", "34403661400365"));
			Rows.Add( new xStageStatsRow("ID_95", "96", "19969993", "39939986", "239639916", "1673660206", "2990000000000", "5988584320296"));
			Rows.Add( new xStageStatsRow("ID_96", "97", "23963920", "71891760", "311530960", "1985191166", "3910000000000", "11727250324302"));
			Rows.Add( new xStageStatsRow("ID_97", "98", "28756631", "115026524", "402592834", "2387784000", "5100000000000", "25516770800575"));
			Rows.Add( new xStageStatsRow("ID_98", "99", "34507883", "172539415", "517618245", "2905402245", "6660000000000", "66624885535870"));
			Rows.Add( new xStageStatsRow("ID_99", "100", "41409385", "248456310", "662550160", "3567952405", "8700000000000", "130469351138475"));
			Rows.Add( new xStageStatsRow("ID_100", "101", "49691186", "99382372", "596294232", "4164246637", "11400000000000", "22710568547184"));
			Rows.Add( new xStageStatsRow("ID_101", "102", "59629347", "178888041", "775181511", "4939428148", "14800000000000", "44473369349985"));
			Rows.Add( new xStageStatsRow("ID_102", "103", "71555139", "286220556", "1001771946", "5941200094", "19400000000000", "96767506538285"));
			Rows.Add( new xStageStatsRow("ID_103", "104", "85866089", "429330445", "1287991335", "7229191429", "25300000000000", "252662223487890"));
			Rows.Add( new xStageStatsRow("ID_104", "105", "103039229", "618235374", "1648627664", "8877819093", "33000000000000", "494780232499200"));
			Rows.Add( new xStageStatsRow("ID_105", "106", "123646995", "247293990", "1483763940", "10361583033", "43100000000000", "86125517509772"));
			Rows.Add( new xStageStatsRow("ID_106", "107", "148376314", "445128942", "1928892082", "12290475115", "56200000000000", "168656805870477"));
			Rows.Add( new xStageStatsRow("ID_107", "108", "178051495", "712205980", "2492720930", "14783196045", "73400000000000", "366972388270465"));
			Rows.Add( new xStageStatsRow("ID_108", "109", "213661712", "1068308560", "3204925680", "17988121725", "95800000000000", "958173491247200"));
			Rows.Add( new xStageStatsRow("ID_109", "110", "256393972", "1538363832", "4102303552", "22090425277", "125000000000000", "1.87636E+15"));
			Rows.Add( new xStageStatsRow("ID_110", "111", "307672683", "615345366", "3692072196", "25782497473", "163000000000000", "326614666247354"));
			Rows.Add( new xStageStatsRow("ID_111", "112", "369207135", "1107621405", "4799692755", "30582190228", "213000000000000", "639598901144262"));
			Rows.Add( new xStageStatsRow("ID_112", "113", "443048477", "1772193908", "6202678678", "36784868906", "278000000000000", "1.39167E+15"));
			Rows.Add( new xStageStatsRow("ID_113", "114", "531658087", "2658290435", "7974871305", "44759740211", "363000000000000", "3.63369E+15"));
			Rows.Add( new xStageStatsRow("ID_114", "115", "637989618", "3827937708", "10207833888", "54967574099", "474000000000000", "7.11574E+15"));
			Rows.Add( new xStageStatsRow("ID_115", "116", "765587454", "1531174908", "9187049448", "64154623547", "619000000000000", "1.23862E+15"));
			Rows.Add( new xStageStatsRow("ID_116", "117", "918704856", "2756114568", "11943163128", "76097786675", "809000000000000", "2.42556E+15"));
			Rows.Add( new xStageStatsRow("ID_117", "118", "1102445738", "4409782952", "15434240332", "91532027007", "1.06E+15", "5.27766E+15"));
			Rows.Add( new xStageStatsRow("ID_118", "119", "1322934796", "6614673980", "19844021940", "111376048947", "1.38E+15", "1.37801E+16"));
			Rows.Add( new xStageStatsRow("ID_119", "120", "1587521664", "9525129984", "25400346624", "136776395571", "1.8E+15", "2.69851E+16"));
			Rows.Add( new xStageStatsRow("ID_120", "121", "1905025906", "3810051812", "22860310872", "159636706443", "2.35E+15", "4.69725E+15"));
			Rows.Add( new xStageStatsRow("ID_121", "122", "2286030995", "6858092985", "29718402935", "189355109378", "3.07E+15", "9.19847E+15"));
			Rows.Add( new xStageStatsRow("ID_122", "123", "2743237100", "10972948400", "38405319400", "227760428778", "4E+15", "2.00145E+16"));
			Rows.Add( new xStageStatsRow("ID_123", "124", "3291884427", "16459422135", "49378266405", "277138695183", "5.23E+15", "5.22583E+16"));
			Rows.Add( new xStageStatsRow("ID_124", "125", "3950261217", "23701567302", "63204179472", "340342874655", "6.82E+15", "1.02336E+17"));
			Rows.Add( new xStageStatsRow("ID_125", "126", "4740313365", "9480626730", "56883760380", "397226635035", "8.91E+15", "1.78134E+16"));
			Rows.Add( new xStageStatsRow("ID_126", "127", "5688375942", "17065127826", "73948887246", "471175522281", "1.16E+16", "3.48834E+16"));
			Rows.Add( new xStageStatsRow("ID_127", "128", "6826051033", "27304204132", "95564714462", "566740236743", "1.52E+16", "7.59012E+16"));
			Rows.Add( new xStageStatsRow("ID_128", "129", "8191261142", "40956305710", "122868917130", "689609153873", "1.98E+16", "1.9818E+17"));
			Rows.Add( new xStageStatsRow("ID_129", "130", "9829513272", "58977079632", "157272212352", "846881366225", "2.59E+16", "3.88089E+17"));
			Rows.Add( new xStageStatsRow("ID_130", "131", "11795415827", "23590831654", "141544989924", "988426356149", "3.38E+16", "6.7554E+16"));
			Rows.Add( new xStageStatsRow("ID_131", "132", "14154498892", "42463496676", "184008485596", "1172434841745", "4.41E+16", "1.32289E+17"));
			Rows.Add( new xStageStatsRow("ID_132", "133", "16985398569", "67941594276", "237795579966", "1410230421711", "5.76E+16", "2.87841E+17"));
			Rows.Add( new xStageStatsRow("ID_133", "134", "20382478181", "101912390905", "305737172715", "1715967594426", "7.52E+16", "7.51559E+17"));
			Rows.Add( new xStageStatsRow("ID_134", "135", "24458973714", "146753842284", "391343579424", "2107311173850", "9.81E+16", "1.47175E+18"));
			Rows.Add( new xStageStatsRow("ID_135", "136", "29350768353", "58701536706", "352209220236", "2459520394086", "1.28E+17", "2.56186E+17"));
			Rows.Add( new xStageStatsRow("ID_136", "137", "35220921920", "105662765760", "457871984960", "2917392379046", "1.67E+17", "5.0168E+17"));
			Rows.Add( new xStageStatsRow("ID_137", "138", "42265106199", "169060424796", "591711486786", "3509103865832", "2.18E+17", "1.09158E+18"));
			Rows.Add( new xStageStatsRow("ID_138", "139", "50718127332", "253590636660", "760771909980", "4269875775812", "2.85E+17", "2.85015E+18"));
			Rows.Add( new xStageStatsRow("ID_139", "140", "60861752692", "365170516152", "973788043072", "5243663818884", "3.72E+17", "5.58135E+18"));
			Rows.Add( new xStageStatsRow("ID_140", "141", "73034103123", "146068206246", "876409237476", "6120073056360", "4.86E+17", "9.71536E+17"));
			Rows.Add( new xStageStatsRow("ID_141", "142", "87640923639", "262922770917", "1139332007307", "7259405063667", "6.34E+17", "1.90253E+18"));
			Rows.Add( new xStageStatsRow("ID_142", "143", "105169108258", "420676433032", "1472367515612", "8731772579279", "8.28E+17", "4.13962E+18"));
			Rows.Add( new xStageStatsRow("ID_143", "144", "126202929800", "631014649000", "1893043947000", "10624816526279", "1.08E+18", "1.08086E+19"));
			Rows.Add( new xStageStatsRow("ID_144", "145", "151443515649", "908661093894", "2423096250384", "13047912776663", "1.41E+18", "2.11662E+19"));
			Rows.Add( new xStageStatsRow("ID_145", "146", "181732218667", "363464437334", "2180786624004", "15228699400667", "1.84E+18", "3.68436E+18"));
			Rows.Add( new xStageStatsRow("ID_146", "147", "218078662289", "654235986867", "2835022609757", "18063722010424", "2.4E+18", "7.21497E+18"));
			Rows.Add( new xStageStatsRow("ID_147", "148", "261694394633", "1046777578532", "3663721524862", "21727443535286", "3.14E+18", "1.56987E+19"));
			Rows.Add( new xStageStatsRow("ID_148", "149", "314033273446", "1570166367230", "4710499101690", "26437942636976", "4.1E+18", "4.09897E+19"));
			Rows.Add( new xStageStatsRow("ID_149", "150", "376839928021", "2261039568126", "6029438848336", "32467381485312", "5.35E+18", "8.02688E+19"));
			Rows.Add( new xStageStatsRow("ID_150", "151", "452207913509", "904415827018", "5426494962108", "37893876447420", "6.99E+18", "1.39723E+19"));
			Rows.Add( new xStageStatsRow("ID_151", "152", "542649496095", "1627948488285", "7054443449235", "44948319896655", "9.12E+18", "2.73614E+19"));
			Rows.Add( new xStageStatsRow("ID_152", "153", "651179395196", "2604717580784", "9116511532744", "54064831429399", "1.19E+19", "5.95344E+19"));
			Rows.Add( new xStageStatsRow("ID_153", "154", "781415274118", "3907076370590", "11721229111770", "65786060541169", "1.55E+19", "1.55446E+20"));
			Rows.Add( new xStageStatsRow("ID_154", "155", "937698328823", "5626189972938", "15003173261168", "80789233802337", "2.03E+19", "3.04404E+20"));
			Rows.Add( new xStageStatsRow("ID_155", "156", "1125237994468", "2250475988936", "13502855933616", "94292089735953", "2.65E+19", "5.29871E+19"));
			Rows.Add( new xStageStatsRow("ID_156", "157", "1350285593241", "4050856779723", "17553712712133", "111845802448086", "3.46E+19", "1.03763E+20"));
			Rows.Add( new xStageStatsRow("ID_157", "158", "1620342711768", "6481370847072", "22684797964752", "134530600412838", "4.52E+19", "2.25773E+20"));
			Rows.Add( new xStageStatsRow("ID_158", "159", "1944411254000", "9722056270000", "29166168810000", "163696769222838", "5.89E+19", "5.89498E+20"));
			Rows.Add( new xStageStatsRow("ID_159", "160", "2333293504677", "13999761028062", "37332696074832", "201029465297670", "7.7E+19", "1.1544E+21"));
			Rows.Add( new xStageStatsRow("ID_160", "161", "2799952205489", "5599904410978", "33599426465868", "234628891763538", "1E+20", "2.00944E+20"));
			Rows.Add( new xStageStatsRow("ID_161", "162", "3359942646463", "10079827939389", "43679254404019", "278308146167557", "1.31E+20", "3.93501E+20"));
			Rows.Add( new xStageStatsRow("ID_162", "163", "4031931175630", "16127724702520", "56447036458820", "334755182626377", "1.71E+20", "8.56201E+20"));
			Rows.Add( new xStageStatsRow("ID_163", "164", "4838317410630", "24191587053150", "72574761159450", "407329943785827", "2.24E+20", "2.23556E+21"));
			Rows.Add( new xStageStatsRow("ID_164", "165", "5805980892630", "34835885355780", "92895694282080", "500225638067907", "2.92E+20", "4.37782E+21"));
			Rows.Add( new xStageStatsRow("ID_165", "166", "6967177071028", "13934354142056", "83606124852336", "583831762920243", "3.81E+20", "7.6204E+20"));
			Rows.Add( new xStageStatsRow("ID_166", "167", "8360612485105", "25081837455315", "108687962306365", "692519725226608", "4.97E+20", "1.49228E+21"));
			Rows.Add( new xStageStatsRow("ID_167", "168", "10032734981997", "40130939927988", "140458289747958", "832978014974566", "6.49E+20", "3.24698E+21"));
			Rows.Add( new xStageStatsRow("ID_168", "169", "12039281978267", "60196409891335", "180589229674005", "1.01E+15", "8.48E+20", "8.47794E+21"));
			Rows.Add( new xStageStatsRow("ID_169", "170", "14447138373789", "86682830242734", "231154213980624", "1.24E+15", "1.11E+21", "1.66021E+22"));
			Rows.Add( new xStageStatsRow("ID_170", "171", "17336566048416", "34673132096832", "208038792580992", "1.45E+15", "1.44E+21", "2.88989E+21"));
			Rows.Add( new xStageStatsRow("ID_171", "172", "20803879257967", "62411637773901", "270450430353571", "1.72E+15", "1.89E+21", "5.65918E+21"));
			Rows.Add( new xStageStatsRow("ID_172", "173", "24964655109427", "99858620437708", "349505171531978", "2.07E+15", "2.46E+21", "1.23136E+22"));
			Rows.Add( new xStageStatsRow("ID_173", "174", "29957586131178", "149787930655890", "449363791967670", "2.52E+15", "3.22E+21", "3.2151E+22"));
			Rows.Add( new xStageStatsRow("ID_174", "175", "35949103357279", "215694620143674", "575185653716464", "3.10E+15", "4.2E+21", "6.29602E+22"));
			Rows.Add( new xStageStatsRow("ID_175", "176", "43138924028600", "86277848057200", "517667088343200", "3.61E+15", "5.48E+21", "1.09594E+22"));
			Rows.Add( new xStageStatsRow("ID_176", "177", "51766708834183", "155300126502549", "672967214844379", "4.29E+15", "7.15E+21", "2.14614E+22"));
			Rows.Add( new xStageStatsRow("ID_177", "178", "62120050600883", "248480202403532", "869680708412362", "5.16E+15", "9.34E+21", "4.66968E+22"));
			Rows.Add( new xStageStatsRow("ID_178", "179", "74544060720922", "372720303604610", "1.12E+15", "6.28E+15", "1.22E+22", "1.21926E+23"));
			Rows.Add( new xStageStatsRow("ID_179", "180", "89452872864967", "536717237189802", "1.43E+15", "7.71E+15", "1.59E+22", "2.38765E+23"));
			Rows.Add( new xStageStatsRow("ID_180", "181", "107343447437821", "214686894875642", "1.29E+15", "9.00E+15", "2.08E+22", "4.15613E+22"));
			Rows.Add( new xStageStatsRow("ID_181", "182", "128812136925245", "386436410775735", "1.67E+15", "1.07E+16", "2.71E+22", "8.13882E+22"));
			Rows.Add( new xStageStatsRow("ID_182", "183", "154574564310153", "618298257240612", "2.16E+15", "1.28E+16", "3.54E+22", "1.77089E+23"));
			Rows.Add( new xStageStatsRow("ID_183", "184", "185489477172041", "927447385860205", "2.78E+15", "1.56E+16", "4.62E+22", "4.62383E+23"));
			Rows.Add( new xStageStatsRow("ID_184", "185", "222587372606307", "1.34E+15", "3.56E+15", "1.92E+16", "6.04E+22", "9.05469E+23"));
			Rows.Add( new xStageStatsRow("ID_185", "186", "267104847127425", "534209694254850", "3.21E+15", "2.24E+16", "7.88E+22", "1.57613E+23"));
			Rows.Add( new xStageStatsRow("ID_186", "187", "320525816552766", "961577449658298", "4.17E+15", "2.65E+16", "1.03E+23", "3.08649E+23"));
			Rows.Add( new xStageStatsRow("ID_187", "188", "384630979863174", "1.54E+15", "5.38E+15", "3.19E+16", "1.34E+23", "6.71575E+23"));
			Rows.Add( new xStageStatsRow("ID_188", "189", "461557175835663", "2.31E+15", "6.92E+15", "3.89E+16", "1.75E+23", "1.7535E+24"));
			Rows.Add( new xStageStatsRow("ID_189", "190", "553868611002649", "3.32E+15", "8.86E+15", "4.77E+16", "2.29E+23", "3.43382E+24"));
			Rows.Add( new xStageStatsRow("ID_190", "191", "664642333203031", "1.33E+15", "7.98E+15", "5.57E+16", "2.99E+23", "5.97719E+23"));
			Rows.Add( new xStageStatsRow("ID_191", "192", "797570799843489", "2.39E+15", "1.04E+16", "6.61E+16", "3.9E+23", "1.17049E+24"));
			Rows.Add( new xStageStatsRow("ID_192", "193", "957084959812037", "3.83E+15", "1.34E+16", "7.95E+16", "5.09E+23", "2.54682E+24"));
			Rows.Add( new xStageStatsRow("ID_193", "194", "1.1485E+15", "5.74E+15", "1.72E+16", "9.67E+16", "6.65E+23", "6.64981E+24"));
			Rows.Add( new xStageStatsRow("ID_194", "195", "1.3782E+15", "8.27E+15", "2.21E+16", "1.19E+17", "8.68E+23", "1.30221E+25"));
			Rows.Add( new xStageStatsRow("ID_195", "196", "1.65384E+15", "3.31E+15", "1.98E+16", "1.39E+17", "1.13E+24", "2.26674E+24"));
			Rows.Add( new xStageStatsRow("ID_196", "197", "1.98461E+15", "5.95E+15", "2.58E+16", "1.64E+17", "1.48E+24", "4.43888E+24"));
			Rows.Add( new xStageStatsRow("ID_197", "198", "2.38153E+15", "9.53E+15", "3.33E+16", "1.98E+17", "1.93E+24", "9.65834E+24"));
			Rows.Add( new xStageStatsRow("ID_198", "199", "2.85784E+15", "1.43E+16", "4.29E+16", "2.41E+17", "2.52E+24", "2.52182E+25"));
			Rows.Add( new xStageStatsRow("ID_199", "200", "3.42941E+15", "2.06E+16", "5.49E+16", "2.95E+17", "3.29E+24", "4.93839E+25"));
			Rows.Add( new xStageStatsRow("ID_200", "201", "4.11529E+15", "8.23E+15", "4.94E+16", "3.45E+17", "4.3E+24", "8.59617E+24"));
			Rows.Add( new xStageStatsRow("ID_201", "202", "4.93835E+15", "1.48E+16", "6.42E+16", "4.09E+17", "5.61E+24", "1.68336E+25"));
			Rows.Add( new xStageStatsRow("ID_202", "203", "5.92602E+15", "2.37E+16", "8.30E+16", "4.92E+17", "7.33E+24", "3.66274E+25"));
			Rows.Add( new xStageStatsRow("ID_203", "204", "7.11122E+15", "3.56E+16", "1.07E+17", "5.99E+17", "9.56E+24", "9.5635E+25"));
			Rows.Add( new xStageStatsRow("ID_204", "205", "8.53347E+15", "5.12E+16", "1.37E+17", "7.35E+17", "1.25E+25", "1.87279E+26"));
			Rows.Add( new xStageStatsRow("ID_205", "206", "1.02402E+16", "2.05E+16", "1.23E+17", "8.58E+17", "1.63E+25", "3.25993E+25"));
			Rows.Add( new xStageStatsRow("ID_206", "207", "1.22882E+16", "3.69E+16", "1.60E+17", "1.02E+18", "2.13E+25", "6.38382E+25"));
			Rows.Add( new xStageStatsRow("ID_207", "208", "1.47458E+16", "5.90E+16", "2.06E+17", "1.22E+18", "2.78E+25", "1.38903E+26"));
			Rows.Add( new xStageStatsRow("ID_208", "209", "1.7695E+16", "8.85E+16", "2.65E+17", "1.49E+18", "3.63E+25", "3.62678E+26"));
			Rows.Add( new xStageStatsRow("ID_209", "210", "2.1234E+16", "1.27E+17", "3.40E+17", "1.83E+18", "4.73E+25", "7.1022E+26"));
			Rows.Add( new xStageStatsRow("ID_210", "211", "2.54808E+16", "5.10E+16", "3.06E+17", "2.14E+18", "6.18E+25", "1.23627E+26"));
			Rows.Add( new xStageStatsRow("ID_211", "212", "3.0577E+16", "9.17E+16", "3.98E+17", "2.53E+18", "8.07E+25", "2.42094E+26"));
			Rows.Add( new xStageStatsRow("ID_212", "213", "3.66923E+16", "1.47E+17", "5.14E+17", "3.05E+18", "1.05E+26", "5.26761E+26"));
			Rows.Add( new xStageStatsRow("ID_213", "214", "4.40308E+16", "2.20E+17", "6.60E+17", "3.71E+18", "1.38E+26", "1.37539E+27"));
			Rows.Add( new xStageStatsRow("ID_214", "215", "5.2837E+16", "3.17E+17", "8.45E+17", "4.55E+18", "1.8E+26", "2.69337E+27"));
			Rows.Add( new xStageStatsRow("ID_215", "216", "6.34044E+16", "1.27E+17", "7.61E+17", "5.31E+18", "2.34E+26", "4.68831E+26"));
			Rows.Add( new xStageStatsRow("ID_216", "217", "7.60852E+16", "2.28E+17", "9.89E+17", "6.30E+18", "3.06E+26", "9.18096E+26"));
			Rows.Add( new xStageStatsRow("ID_217", "218", "9.13023E+16", "3.65E+17", "1.28E+18", "7.58E+18", "4E+26", "1.99764E+27"));
			Rows.Add( new xStageStatsRow("ID_218", "219", "1.09563E+17", "5.48E+17", "1.64E+18", "9.22E+18", "5.22E+26", "5.21589E+27"));
			Rows.Add( new xStageStatsRow("ID_219", "220", "1.31475E+17", "7.89E+17", "2.10E+18", "1.13E+19", "6.81E+26", "1.02141E+28"));
			Rows.Add( new xStageStatsRow("ID_220", "221", "1.5777E+17", "3.16E+17", "1.89E+18", "1.32E+19", "8.89E+26", "1.77795E+27"));
			Rows.Add( new xStageStatsRow("ID_221", "222", "1.89324E+17", "5.68E+17", "2.46E+18", "1.57E+19", "1.16E+27", "3.48171E+27"));
			Rows.Add( new xStageStatsRow("ID_222", "223", "2.27189E+17", "9.09E+17", "3.18E+18", "1.89E+19", "1.52E+27", "7.57568E+27"));
			Rows.Add( new xStageStatsRow("ID_223", "224", "2.72627E+17", "1.36E+18", "4.09E+18", "2.30E+19", "1.98E+27", "1.97803E+28"));
			Rows.Add( new xStageStatsRow("ID_224", "225", "3.27153E+17", "1.96E+18", "5.23E+18", "2.82E+19", "2.58E+27", "3.87351E+28"));
			Rows.Add( new xStageStatsRow("ID_225", "226", "3.92583E+17", "7.85E+17", "4.71E+18", "3.29E+19", "3.37E+27", "6.74255E+27"));
			Rows.Add( new xStageStatsRow("ID_226", "227", "4.711E+17", "1.41E+18", "6.12E+18", "3.90E+19", "4.4E+27", "1.32037E+28"));
			Rows.Add( new xStageStatsRow("ID_227", "228", "5.6532E+17", "2.26E+18", "7.91E+18", "4.69E+19", "5.75E+27", "2.87293E+28"));
			Rows.Add( new xStageStatsRow("ID_228", "229", "6.78384E+17", "3.39E+18", "1.02E+19", "5.71E+19", "7.5E+27", "7.5013E+28"));
			Rows.Add( new xStageStatsRow("ID_229", "230", "8.1406E+17", "4.88E+18", "1.30E+19", "7.01E+19", "9.79E+27", "1.46895E+29"));
			Rows.Add( new xStageStatsRow("ID_230", "231", "9.76872E+17", "1.95E+18", "1.17E+19", "8.19E+19", "1.28E+28", "2.55698E+28"));
			Rows.Add( new xStageStatsRow("ID_231", "232", "1.17225E+18", "3.52E+18", "1.52E+19", "9.71E+19", "1.67E+28", "5.00726E+28"));
			Rows.Add( new xStageStatsRow("ID_232", "233", "1.4067E+18", "5.63E+18", "1.97E+19", "1.17E+20", "2.18E+28", "1.08951E+29"));
			Rows.Add( new xStageStatsRow("ID_233", "234", "1.68804E+18", "8.44E+18", "2.53E+19", "1.42E+20", "2.84E+28", "2.84472E+29"));
			Rows.Add( new xStageStatsRow("ID_234", "235", "2.02564E+18", "1.22E+19", "3.24E+19", "1.75E+20", "3.71E+28", "5.57073E+29"));
			Rows.Add( new xStageStatsRow("ID_235", "236", "2.43077E+18", "4.86E+18", "2.92E+19", "2.04E+20", "4.85E+28", "9.69687E+28"));
			Rows.Add( new xStageStatsRow("ID_236", "237", "2.91693E+18", "8.75E+18", "3.79E+19", "2.42E+20", "6.33E+28", "1.89891E+29"));
			Rows.Add( new xStageStatsRow("ID_237", "238", "3.50031E+18", "1.40E+19", "4.90E+19", "2.91E+20", "8.26E+28", "4.13174E+29"));
			Rows.Add( new xStageStatsRow("ID_238", "239", "4.20037E+18", "2.10E+19", "6.30E+19", "3.54E+20", "1.08E+29", "1.07881E+30"));
			Rows.Add( new xStageStatsRow("ID_239", "240", "5.04045E+18", "3.02E+19", "8.06E+19", "4.34E+20", "1.41E+29", "2.11259E+30"));
			Rows.Add( new xStageStatsRow("ID_240", "241", "6.04854E+18", "1.21E+19", "7.26E+19", "5.07E+20", "1.84E+29", "3.67735E+29"));
			Rows.Add( new xStageStatsRow("ID_241", "242", "7.25824E+18", "2.18E+19", "9.44E+19", "6.01E+20", "2.4E+29", "7.20124E+29"));
			Rows.Add( new xStageStatsRow("ID_242", "243", "8.70989E+18", "3.48E+19", "1.22E+20", "7.23E+20", "3.13E+29", "1.56688E+30"));
			Rows.Add( new xStageStatsRow("ID_243", "244", "1.04519E+19", "5.23E+19", "1.57E+20", "8.80E+20", "4.09E+29", "4.09117E+30"));
			Rows.Add( new xStageStatsRow("ID_244", "245", "1.25422E+19", "7.53E+19", "2.01E+20", "1.08E+21", "5.34E+29", "8.01161E+30"));
			Rows.Add( new xStageStatsRow("ID_245", "246", "1.50507E+19", "3.01E+19", "1.81E+20", "1.26E+21", "6.97E+29", "1.39457E+30"));
			Rows.Add( new xStageStatsRow("ID_246", "247", "1.80608E+19", "5.42E+19", "2.35E+20", "1.50E+21", "9.1E+29", "2.73093E+30"));
			Rows.Add( new xStageStatsRow("ID_247", "248", "2.1673E+19", "8.67E+19", "3.03E+20", "1.80E+21", "1.19E+30", "5.94211E+30"));
			Rows.Add( new xStageStatsRow("ID_248", "249", "2.60076E+19", "1.30E+20", "3.90E+20", "2.19E+21", "1.55E+30", "1.5515E+31"));
			Rows.Add( new xStageStatsRow("ID_249", "250", "3.12091E+19", "1.87E+20", "4.99E+20", "2.69E+21", "2.03E+30", "3.03825E+31"));
			Rows.Add( new xStageStatsRow("ID_250", "251", "3.74509E+19", "7.49E+19", "4.49E+20", "3.14E+21", "2.64E+30", "5.28863E+30"));
			Rows.Add( new xStageStatsRow("ID_251", "252", "4.49411E+19", "1.35E+20", "5.84E+20", "3.72E+21", "3.45E+30", "1.03566E+31"));
			Rows.Add( new xStageStatsRow("ID_252", "253", "5.39294E+19", "2.16E+20", "7.55E+20", "4.48E+21", "4.51E+30", "2.25343E+31"));
			Rows.Add( new xStageStatsRow("ID_253", "254", "6.47152E+19", "3.24E+20", "9.71E+20", "5.45E+21", "5.88E+30", "5.88377E+31"));
			Rows.Add( new xStageStatsRow("ID_254", "255", "7.76583E+19", "4.66E+20", "1.24E+21", "6.69E+21", "7.68E+30", "1.1522E+32"));
			Rows.Add( new xStageStatsRow("ID_255", "256", "9.31899E+19", "1.86E+20", "1.12E+21", "7.81E+21", "1E+31", "2.00561E+31"));
			Rows.Add( new xStageStatsRow("ID_256", "257", "1.11828E+20", "3.35E+20", "1.45E+21", "9.26E+21", "1.31E+31", "3.92753E+31"));
			Rows.Add( new xStageStatsRow("ID_257", "258", "1.34194E+20", "5.37E+20", "1.88E+21", "1.11E+22", "1.71E+31", "8.54572E+31"));
			Rows.Add( new xStageStatsRow("ID_258", "259", "1.61032E+20", "8.05E+20", "2.42E+21", "1.36E+22", "2.23E+31", "2.23131E+32"));
			Rows.Add( new xStageStatsRow("ID_259", "260", "1.93239E+20", "1.16E+21", "3.09E+21", "1.66E+22", "2.91E+31", "4.3695E+32"));
			Rows.Add( new xStageStatsRow("ID_260", "261", "2.31886E+20", "4.64E+20", "2.78E+21", "1.94E+22", "3.8E+31", "7.6059E+31"));
			Rows.Add( new xStageStatsRow("ID_261", "262", "2.78264E+20", "8.35E+20", "3.62E+21", "2.30E+22", "4.96E+31", "1.48944E+32"));
			Rows.Add( new xStageStatsRow("ID_262", "263", "3.33916E+20", "1.34E+21", "4.67E+21", "2.77E+22", "6.48E+31", "3.2408E+32"));
			Rows.Add( new xStageStatsRow("ID_263", "264", "4.007E+20", "2.00E+21", "6.01E+21", "3.37E+22", "8.46E+31", "8.46181E+32"));
			Rows.Add( new xStageStatsRow("ID_264", "265", "4.8084E+20", "2.89E+21", "7.69E+21", "4.14E+22", "1.1E+32", "1.65705E+33"));
			Rows.Add( new xStageStatsRow("ID_265", "266", "5.77007E+20", "1.15E+21", "6.92E+21", "4.84E+22", "1.44E+32", "2.88439E+32"));
			Rows.Add( new xStageStatsRow("ID_266", "267", "6.92409E+20", "2.08E+21", "9.00E+21", "5.74E+22", "1.88E+32", "5.64842E+32"));
			Rows.Add( new xStageStatsRow("ID_267", "268", "8.30891E+20", "3.32E+21", "1.16E+22", "6.90E+22", "2.46E+32", "1.22901E+33"));
			Rows.Add( new xStageStatsRow("ID_268", "269", "9.97069E+20", "4.99E+21", "1.50E+22", "8.39E+22", "3.21E+32", "3.20898E+33"));
			Rows.Add( new xStageStatsRow("ID_269", "270", "1.19648E+21", "7.18E+21", "1.91E+22", "1.03E+23", "4.19E+32", "6.28404E+33"));
			Rows.Add( new xStageStatsRow("ID_270", "271", "1.43578E+21", "2.87E+21", "1.72E+22", "1.20E+23", "5.47E+32", "1.09385E+33"));
			Rows.Add( new xStageStatsRow("ID_271", "272", "1.72294E+21", "5.17E+21", "2.24E+22", "1.43E+23", "7.14E+32", "2.14205E+33"));
			Rows.Add( new xStageStatsRow("ID_272", "273", "2.06752E+21", "8.27E+21", "2.89E+22", "1.72E+23", "9.32E+32", "4.6608E+33"));
			Rows.Add( new xStageStatsRow("ID_273", "274", "2.48103E+21", "1.24E+22", "3.72E+22", "2.09E+23", "1.22E+33", "1.21694E+34"));
			Rows.Add( new xStageStatsRow("ID_274", "275", "2.97723E+21", "1.79E+22", "4.76E+22", "2.57E+23", "1.59E+33", "2.3831E+34"));
			Rows.Add( new xStageStatsRow("ID_275", "276", "3.57268E+21", "7.15E+21", "4.29E+22", "2.99E+23", "2.07E+33", "4.14823E+33"));
			Rows.Add( new xStageStatsRow("ID_276", "277", "4.28721E+21", "1.29E+22", "5.57E+22", "3.55E+23", "2.71E+33", "8.12333E+33"));
			Rows.Add( new xStageStatsRow("ID_277", "278", "5.14466E+21", "2.06E+22", "7.20E+22", "4.27E+23", "3.54E+33", "1.76752E+34"));
			Rows.Add( new xStageStatsRow("ID_278", "279", "6.17359E+21", "3.09E+22", "9.26E+22", "5.20E+23", "4.62E+33", "4.61503E+34"));
			Rows.Add( new xStageStatsRow("ID_279", "280", "7.40831E+21", "4.44E+22", "1.19E+23", "6.38E+23", "6.02E+33", "9.03747E+34"));
			Rows.Add( new xStageStatsRow("ID_280", "281", "8.88997E+21", "1.78E+22", "1.07E+23", "7.45E+23", "7.87E+33", "1.57314E+34"));
			Rows.Add( new xStageStatsRow("ID_281", "282", "1.0668E+22", "3.20E+22", "1.39E+23", "8.84E+23", "1.03E+34", "3.08062E+34"));
			Rows.Add( new xStageStatsRow("ID_282", "283", "1.28016E+22", "5.12E+22", "1.79E+23", "1.06E+24", "1.34E+34", "6.70298E+34"));
			Rows.Add( new xStageStatsRow("ID_283", "284", "1.53619E+22", "7.68E+22", "2.30E+23", "1.29E+24", "1.75E+34", "1.75016E+35"));
			Rows.Add( new xStageStatsRow("ID_284", "285", "1.84342E+22", "1.11E+23", "2.95E+23", "1.59E+24", "2.28E+34", "3.42729E+35"));
			Rows.Add( new xStageStatsRow("ID_285", "286", "2.21211E+22", "4.42E+22", "2.65E+23", "1.85E+24", "2.98E+34", "5.96582E+34"));
			Rows.Add( new xStageStatsRow("ID_286", "287", "2.65453E+22", "7.96E+22", "3.45E+23", "2.20E+24", "3.89E+34", "1.16827E+35"));
			Rows.Add( new xStageStatsRow("ID_287", "288", "3.18544E+22", "1.27E+23", "4.46E+23", "2.64E+24", "5.08E+34", "2.54198E+35"));
			Rows.Add( new xStageStatsRow("ID_288", "289", "3.82252E+22", "1.91E+23", "5.73E+23", "3.22E+24", "6.64E+34", "6.63716E+35"));
			Rows.Add( new xStageStatsRow("ID_289", "290", "4.58703E+22", "2.75E+23", "7.34E+23", "3.95E+24", "8.66E+34", "1.29973E+36"));
			Rows.Add( new xStageStatsRow("ID_290", "291", "5.50443E+22", "1.10E+23", "6.61E+23", "4.61E+24", "1.13E+35", "2.26242E+35"));
			Rows.Add( new xStageStatsRow("ID_291", "292", "6.60532E+22", "1.98E+23", "8.59E+23", "5.47E+24", "1.48E+35", "4.43043E+35"));
			Rows.Add( new xStageStatsRow("ID_292", "293", "7.92638E+22", "3.17E+23", "1.11E+24", "6.58E+24", "1.93E+35", "9.63996E+35"));
			Rows.Add( new xStageStatsRow("ID_293", "294", "9.51166E+22", "4.76E+23", "1.43E+24", "8.01E+24", "2.52E+35", "2.51702E+36"));
			Rows.Add( new xStageStatsRow("ID_294", "295", "1.1414E+23", "6.85E+23", "1.83E+24", "9.83E+24", "3.29E+35", "4.92899E+36"));
			Rows.Add( new xStageStatsRow("ID_295", "296", "1.36968E+23", "2.74E+23", "1.64E+24", "1.15E+25", "4.29E+35", "8.57981E+35"));
			Rows.Add( new xStageStatsRow("ID_296", "297", "1.64361E+23", "4.93E+23", "2.14E+24", "1.36E+25", "5.6E+35", "1.68016E+36"));
			Rows.Add( new xStageStatsRow("ID_297", "298", "1.97234E+23", "7.89E+23", "2.76E+24", "1.64E+25", "7.31E+35", "3.65577E+36"));
			Rows.Add( new xStageStatsRow("ID_298", "299", "2.36681E+23", "1.18E+24", "3.55E+24", "1.99E+25", "9.55E+35", "9.54531E+36"));
			Rows.Add( new xStageStatsRow("ID_299", "300", "2.84017E+23", "1.70E+24", "4.54E+24", "2.45E+25", "1.25E+36", "1.86923E+37"));
			Rows.Add( new xStageStatsRow("ID_300", "301", "3.4082E+23", "6.82E+23", "4.09E+24", "2.86E+25", "1.63E+36", "3.25373E+36"));
			Rows.Add( new xStageStatsRow("ID_301", "302", "4.08984E+23", "1.23E+24", "5.32E+24", "3.39E+25", "2.12E+36", "6.37167E+36"));
			Rows.Add( new xStageStatsRow("ID_302", "303", "4.90781E+23", "1.96E+24", "6.87E+24", "4.07E+25", "2.77E+36", "1.38638E+37"));
			Rows.Add( new xStageStatsRow("ID_303", "304", "5.88937E+23", "2.94E+24", "8.83E+24", "4.96E+25", "3.62E+36", "3.61988E+37"));
			Rows.Add( new xStageStatsRow("ID_304", "305", "7.06724E+23", "4.24E+24", "1.13E+25", "6.09E+25", "4.73E+36", "7.08869E+37"));
			Rows.Add( new xStageStatsRow("ID_305", "306", "8.48069E+23", "1.70E+24", "1.02E+25", "7.11E+25", "6.17E+36", "1.23392E+37"));
			Rows.Add( new xStageStatsRow("ID_306", "307", "1.01768E+24", "3.05E+24", "1.32E+25", "8.43E+25", "8.05E+36", "2.41634E+37"));
			Rows.Add( new xStageStatsRow("ID_307", "308", "1.22122E+24", "4.88E+24", "1.71E+25", "1.01E+26", "1.05E+37", "5.25759E+37"));
			Rows.Add( new xStageStatsRow("ID_308", "309", "1.46546E+24", "7.33E+24", "2.20E+25", "1.23E+26", "1.37E+37", "1.37277E+38"));
			Rows.Add( new xStageStatsRow("ID_309", "310", "1.75856E+24", "1.06E+25", "2.81E+25", "1.52E+26", "1.79E+37", "2.68825E+38"));
			Rows.Add( new xStageStatsRow("ID_310", "311", "2.11027E+24", "4.22E+24", "2.53E+25", "1.77E+26", "2.34E+37", "4.67939E+37"));
			Rows.Add( new xStageStatsRow("ID_311", "312", "2.53232E+24", "7.60E+24", "3.29E+25", "2.10E+26", "3.05E+37", "9.1635E+37"));
			Rows.Add( new xStageStatsRow("ID_312", "313", "3.03879E+24", "1.22E+25", "4.25E+25", "2.52E+26", "3.99E+37", "1.99384E+38"));
			Rows.Add( new xStageStatsRow("ID_313", "314", "3.64654E+24", "1.82E+25", "5.47E+25", "3.07E+26", "5.21E+37", "5.20597E+38"));
			Rows.Add( new xStageStatsRow("ID_314", "315", "4.37585E+24", "2.63E+25", "7.00E+25", "3.77E+26", "6.8E+37", "1.01947E+39"));
			Rows.Add( new xStageStatsRow("ID_315", "316", "5.25102E+24", "1.05E+25", "6.30E+25", "4.40E+26", "8.87E+37", "1.77457E+38"));
			Rows.Add( new xStageStatsRow("ID_316", "317", "6.30123E+24", "1.89E+25", "8.19E+25", "5.22E+26", "1.16E+38", "3.47508E+38"));
			Rows.Add( new xStageStatsRow("ID_317", "318", "7.56147E+24", "3.02E+25", "1.06E+26", "6.28E+26", "1.51E+38", "7.56127E+38"));
			Rows.Add( new xStageStatsRow("ID_318", "319", "9.07376E+24", "4.54E+25", "1.36E+26", "7.64E+26", "1.97E+38", "1.97426E+39"));
			Rows.Add( new xStageStatsRow("ID_319", "320", "1.08885E+25", "6.53E+25", "1.74E+26", "9.38E+26", "2.58E+38", "3.86614E+39"));
			Rows.Add( new xStageStatsRow("ID_320", "321", "1.30662E+25", "2.61E+25", "1.57E+26", "1.09E+27", "3.36E+38", "6.72972E+38"));
			Rows.Add( new xStageStatsRow("ID_321", "322", "1.56795E+25", "4.70E+25", "2.04E+26", "1.30E+27", "4.39E+38", "1.31786E+39"));
			Rows.Add( new xStageStatsRow("ID_322", "323", "1.88154E+25", "7.53E+25", "2.63E+26", "1.56E+27", "5.73E+38", "2.86747E+39"));
			Rows.Add( new xStageStatsRow("ID_323", "324", "2.25784E+25", "1.13E+26", "3.39E+26", "1.90E+27", "7.49E+38", "7.48702E+39"));
			Rows.Add( new xStageStatsRow("ID_324", "325", "2.70941E+25", "1.63E+26", "4.34E+26", "2.33E+27", "9.77E+38", "1.46616E+40"));
			Rows.Add( new xStageStatsRow("ID_325", "326", "3.25129E+25", "6.50E+25", "3.90E+26", "2.72E+27", "1.28E+39", "2.55212E+39"));
			Rows.Add( new xStageStatsRow("ID_326", "327", "3.90155E+25", "1.17E+26", "5.07E+26", "3.23E+27", "1.67E+39", "4.99773E+39"));
			Rows.Add( new xStageStatsRow("ID_327", "328", "4.68186E+25", "1.87E+26", "6.55E+26", "3.89E+27", "2.17E+39", "1.08743E+40"));
			Rows.Add( new xStageStatsRow("ID_328", "329", "5.61824E+25", "2.81E+26", "8.43E+26", "4.73E+27", "2.84E+39", "2.83931E+40"));
			Rows.Add( new xStageStatsRow("ID_329", "330", "6.74188E+25", "4.05E+26", "1.08E+27", "5.81E+27", "3.71E+39", "5.56013E+40"));
			Rows.Add( new xStageStatsRow("ID_330", "331", "8.09026E+25", "1.62E+26", "9.71E+26", "6.78E+27", "4.84E+39", "9.67842E+39"));
			Rows.Add( new xStageStatsRow("ID_331", "332", "9.70831E+25", "2.91E+26", "1.26E+27", "8.04E+27", "6.32E+39", "1.89529E+40"));
			Rows.Add( new xStageStatsRow("ID_332", "333", "1.165E+26", "4.66E+26", "1.63E+27", "9.67E+27", "8.25E+39", "4.12388E+40"));
			Rows.Add( new xStageStatsRow("ID_333", "334", "1.398E+26", "6.99E+26", "2.10E+27", "1.18E+28", "1.08E+40", "1.07675E+41"));
			Rows.Add( new xStageStatsRow("ID_334", "335", "1.6776E+26", "1.01E+27", "2.68E+27", "1.45E+28", "1.41E+40", "2.10857E+41"));
			Rows.Add( new xStageStatsRow("ID_335", "336", "2.01312E+26", "4.03E+26", "2.42E+27", "1.69E+28", "1.84E+40", "3.67036E+40"));
			Rows.Add( new xStageStatsRow("ID_336", "337", "2.41574E+26", "7.25E+26", "3.14E+27", "2.00E+28", "2.4E+40", "7.18754E+40"));
			Rows.Add( new xStageStatsRow("ID_337", "338", "2.89889E+26", "1.16E+27", "4.06E+27", "2.41E+28", "3.13E+40", "1.5639E+41"));
			Rows.Add( new xStageStatsRow("ID_338", "339", "3.47866E+26", "1.74E+27", "5.22E+27", "2.93E+28", "4.08E+40", "4.08339E+41"));
			Rows.Add( new xStageStatsRow("ID_339", "340", "4.1744E+26", "2.50E+27", "6.68E+27", "3.60E+28", "5.33E+40", "7.99637E+41"));
			Rows.Add( new xStageStatsRow("ID_340", "341", "5.00928E+26", "1.00E+27", "6.01E+27", "4.20E+28", "6.96E+40", "1.39191E+41"));
			Rows.Add( new xStageStatsRow("ID_341", "342", "6.01113E+26", "1.80E+27", "7.81E+27", "4.98E+28", "9.09E+40", "2.72574E+41"));
			Rows.Add( new xStageStatsRow("ID_342", "343", "7.21336E+26", "2.89E+27", "1.01E+28", "5.99E+28", "1.19E+41", "5.93081E+41"));
			Rows.Add( new xStageStatsRow("ID_343", "344", "8.65603E+26", "4.33E+27", "1.30E+28", "7.29E+28", "1.55E+41", "1.54855E+42"));
			Rows.Add( new xStageStatsRow("ID_344", "345", "1.03872E+27", "6.23E+27", "1.66E+28", "8.95E+28", "2.02E+41", "3.03247E+42"));
			Rows.Add( new xStageStatsRow("ID_345", "346", "1.24647E+27", "2.49E+27", "1.50E+28", "1.04E+29", "2.64E+41", "5.27857E+41"));
			Rows.Add( new xStageStatsRow("ID_346", "347", "1.49576E+27", "4.49E+27", "1.94E+28", "1.24E+29", "3.45E+41", "1.03368E+42"));
			Rows.Add( new xStageStatsRow("ID_347", "348", "1.79491E+27", "7.18E+27", "2.51E+28", "1.49E+29", "4.5E+41", "2.24915E+42"));
			Rows.Add( new xStageStatsRow("ID_348", "349", "2.1539E+27", "1.08E+28", "3.23E+28", "1.81E+29", "5.87E+41", "5.87257E+42"));
			Rows.Add( new xStageStatsRow("ID_349", "350", "2.58468E+27", "1.55E+28", "4.14E+28", "2.23E+29", "7.67E+41", "1.15001E+43"));
			Rows.Add( new xStageStatsRow("ID_350", "351", "3.10161E+27", "6.20E+27", "3.72E+28", "2.60E+29", "1E+42", "2.0018E+42"));
			Rows.Add( new xStageStatsRow("ID_351", "352", "3.72193E+27", "1.12E+28", "4.84E+28", "3.08E+29", "1.31E+42", "3.92005E+42"));
			Rows.Add( new xStageStatsRow("ID_352", "353", "4.46632E+27", "1.79E+28", "6.25E+28", "3.71E+29", "1.71E+42", "8.52946E+42"));
			Rows.Add( new xStageStatsRow("ID_353", "354", "5.35958E+27", "2.68E+28", "8.04E+28", "4.51E+29", "2.23E+42", "2.22706E+43"));
			Rows.Add( new xStageStatsRow("ID_354", "355", "6.4315E+27", "3.86E+28", "1.03E+29", "5.54E+29", "2.91E+42", "4.36118E+43"));
			Rows.Add( new xStageStatsRow("ID_355", "356", "7.7178E+27", "1.54E+28", "9.26E+28", "6.47E+29", "3.8E+42", "7.59143E+42"));
			Rows.Add( new xStageStatsRow("ID_356", "357", "9.26136E+27", "2.78E+28", "1.20E+29", "7.67E+29", "4.96E+42", "1.48661E+43"));
			Rows.Add( new xStageStatsRow("ID_357", "358", "1.11136E+28", "4.45E+28", "1.56E+29", "9.23E+29", "6.47E+42", "3.23463E+43"));
			Rows.Add( new xStageStatsRow("ID_358", "359", "1.33364E+28", "6.67E+28", "2.00E+29", "1.12E+30", "8.45E+42", "8.44571E+43"));
			Rows.Add( new xStageStatsRow("ID_359", "360", "1.60036E+28", "9.60E+28", "2.56E+29", "1.38E+30", "1.1E+43", "1.6539E+44"));
			Rows.Add( new xStageStatsRow("ID_360", "361", "1.92044E+28", "3.84E+28", "2.30E+29", "1.61E+30", "1.44E+43", "2.87891E+43"));
			Rows.Add( new xStageStatsRow("ID_361", "362", "2.30452E+28", "6.91E+28", "3.00E+29", "1.91E+30", "1.88E+43", "5.63767E+43"));
			Rows.Add( new xStageStatsRow("ID_362", "363", "2.76543E+28", "1.11E+29", "3.87E+29", "2.30E+30", "2.45E+43", "1.22667E+44"));
			Rows.Add( new xStageStatsRow("ID_363", "364", "3.31851E+28", "1.66E+29", "4.98E+29", "2.79E+30", "3.2E+43", "3.20287E+44"));
			Rows.Add( new xStageStatsRow("ID_364", "365", "3.98222E+28", "2.39E+29", "6.37E+29", "3.43E+30", "4.18E+43", "6.27208E+44"));
			Rows.Add( new xStageStatsRow("ID_365", "366", "4.77866E+28", "9.56E+28", "5.73E+29", "4.00E+30", "5.46E+43", "1.09177E+44"));
			Rows.Add( new xStageStatsRow("ID_366", "367", "5.73439E+28", "1.72E+29", "7.45E+29", "4.75E+30", "7.13E+43", "2.13798E+44"));
			Rows.Add( new xStageStatsRow("ID_367", "368", "6.88127E+28", "2.75E+29", "9.63E+29", "5.71E+30", "9.3E+43", "4.65193E+44"));
			Rows.Add( new xStageStatsRow("ID_368", "369", "8.25752E+28", "4.13E+29", "1.24E+30", "6.95E+30", "1.21E+44", "1.21463E+45"));
			Rows.Add( new xStageStatsRow("ID_369", "370", "9.90903E+28", "5.95E+29", "1.59E+30", "8.54E+30", "1.59E+44", "2.37857E+45"));
			Rows.Add( new xStageStatsRow("ID_370", "371", "1.18908E+29", "2.38E+29", "1.43E+30", "9.96E+30", "2.07E+44", "4.14033E+44"));
			Rows.Add( new xStageStatsRow("ID_371", "372", "1.4269E+29", "4.28E+29", "1.85E+30", "1.18E+31", "2.7E+44", "8.10788E+44"));
			Rows.Add( new xStageStatsRow("ID_372", "373", "1.71228E+29", "6.85E+29", "2.40E+30", "1.42E+31", "3.53E+44", "1.76416E+45"));
			Rows.Add( new xStageStatsRow("ID_373", "374", "2.05474E+29", "1.03E+30", "3.08E+30", "1.73E+31", "4.61E+44", "4.60625E+45"));
			Rows.Add( new xStageStatsRow("ID_374", "375", "2.46568E+29", "1.48E+30", "3.95E+30", "2.12E+31", "6.01E+44", "9.02027E+45"));
			Rows.Add( new xStageStatsRow("ID_375", "376", "2.95882E+29", "5.92E+29", "3.55E+30", "2.48E+31", "7.85E+44", "1.57014E+45"));
			Rows.Add( new xStageStatsRow("ID_376", "377", "3.55058E+29", "1.07E+30", "4.62E+30", "2.94E+31", "1.02E+45", "3.07476E+45"));
			Rows.Add( new xStageStatsRow("ID_377", "378", "4.2607E+29", "1.70E+30", "5.96E+30", "3.54E+31", "1.34E+45", "6.69022E+45"));
			Rows.Add( new xStageStatsRow("ID_378", "379", "5.11284E+29", "2.56E+30", "7.67E+30", "4.30E+31", "1.75E+45", "1.74683E+46"));
			Rows.Add( new xStageStatsRow("ID_379", "380", "6.13541E+29", "3.68E+30", "9.82E+30", "5.29E+31", "2.28E+45", "3.42077E+46"));
			Rows.Add( new xStageStatsRow("ID_380", "381", "7.36249E+29", "1.47E+30", "8.83E+30", "6.17E+31", "2.98E+45", "5.95447E+45"));
			Rows.Add( new xStageStatsRow("ID_381", "382", "8.83499E+29", "2.65E+30", "1.15E+31", "7.32E+31", "3.89E+45", "1.16604E+46"));
			Rows.Add( new xStageStatsRow("ID_382", "383", "1.0602E+30", "4.24E+30", "1.48E+31", "8.80E+31", "5.07E+45", "2.53714E+46"));
			Rows.Add( new xStageStatsRow("ID_383", "384", "1.27224E+30", "6.36E+30", "1.91E+31", "1.07E+32", "6.62E+45", "6.62453E+46"));
			Rows.Add( new xStageStatsRow("ID_384", "385", "1.52669E+30", "9.16E+30", "2.44E+31", "1.32E+32", "8.65E+45", "1.29726E+47"));
			Rows.Add( new xStageStatsRow("ID_385", "386", "1.83202E+30", "3.66E+30", "2.20E+31", "1.54E+32", "1.13E+46", "2.25812E+46"));
			Rows.Add( new xStageStatsRow("ID_386", "387", "2.19843E+30", "6.60E+30", "2.86E+31", "1.82E+32", "1.47E+46", "4.422E+46"));
			Rows.Add( new xStageStatsRow("ID_387", "388", "2.63811E+30", "1.06E+31", "3.69E+31", "2.19E+32", "1.92E+46", "9.62162E+46"));
			Rows.Add( new xStageStatsRow("ID_388", "389", "3.16574E+30", "1.58E+31", "4.75E+31", "2.67E+32", "2.51E+46", "2.51223E+47"));
			Rows.Add( new xStageStatsRow("ID_389", "390", "3.79888E+30", "2.28E+31", "6.08E+31", "3.27E+32", "3.28E+46", "4.91961E+47"));
			Rows.Add( new xStageStatsRow("ID_390", "391", "4.55866E+30", "9.12E+30", "5.47E+31", "3.82E+32", "4.28E+46", "8.56349E+46"));
			Rows.Add( new xStageStatsRow("ID_391", "392", "5.47039E+30", "1.64E+31", "7.11E+31", "4.53E+32", "5.59E+46", "1.67696E+47"));
			Rows.Add( new xStageStatsRow("ID_392", "393", "6.56447E+30", "2.63E+31", "9.19E+31", "5.45E+32", "7.3E+46", "3.64882E+47"));
			Rows.Add( new xStageStatsRow("ID_393", "394", "7.87736E+30", "3.94E+31", "1.18E+32", "6.63E+32", "9.53E+46", "9.52715E+47"));
			Rows.Add( new xStageStatsRow("ID_394", "395", "9.45284E+30", "5.67E+31", "1.51E+32", "8.14E+32", "1.24E+47", "1.86567E+48"));
			Rows.Add( new xStageStatsRow("ID_395", "396", "1.13434E+31", "2.27E+31", "1.36E+32", "9.51E+32", "1.62E+47", "3.24754E+47"));
			Rows.Add( new xStageStatsRow("ID_396", "397", "1.36121E+31", "4.08E+31", "1.77E+32", "1.13E+33", "2.12E+47", "6.35955E+47"));
			Rows.Add( new xStageStatsRow("ID_397", "398", "1.63345E+31", "6.53E+31", "2.29E+32", "1.36E+33", "2.77E+47", "1.38374E+48"));
			Rows.Add( new xStageStatsRow("ID_398", "399", "1.96014E+31", "9.80E+31", "2.94E+32", "1.65E+33", "3.61E+47", "3.61299E+48"));
			Rows.Add( new xStageStatsRow("ID_399", "400", "2.35217E+31", "1.41E+32", "3.76E+32", "2.03E+33", "4.72E+47", "7.0752E+48"));
			Rows.Add( new xStageStatsRow("ID_400", "401", "2.8226E+31", "5.65E+31", "3.39E+32", "2.37E+33", "6.16E+47", "1.23157E+48"));
			Rows.Add( new xStageStatsRow("ID_401", "402", "3.38712E+31", "1.02E+32", "4.40E+32", "2.81E+33", "8.04E+47", "2.41174E+48"));
			Rows.Add( new xStageStatsRow("ID_402", "403", "4.06455E+31", "1.63E+32", "5.69E+32", "3.37E+33", "1.05E+48", "5.24759E+48"));
			Rows.Add( new xStageStatsRow("ID_403", "404", "4.87746E+31", "2.44E+32", "7.32E+32", "4.11E+33", "1.37E+48", "1.37016E+49"));
			Rows.Add( new xStageStatsRow("ID_404", "405", "5.85295E+31", "3.51E+32", "9.36E+32", "5.04E+33", "1.79E+48", "2.68314E+49"));
			Rows.Add( new xStageStatsRow("ID_405", "406", "7.02354E+31", "1.40E+32", "8.43E+32", "5.89E+33", "2.34E+48", "4.67049E+48"));
			Rows.Add( new xStageStatsRow("ID_406", "407", "8.42824E+31", "2.53E+32", "1.10E+33", "6.98E+33", "3.05E+48", "9.14606E+48"));
			Rows.Add( new xStageStatsRow("ID_407", "408", "1.01139E+32", "4.05E+32", "1.42E+33", "8.40E+33", "3.98E+48", "1.99005E+49"));
			Rows.Add( new xStageStatsRow("ID_408", "409", "1.21367E+32", "6.07E+32", "1.82E+33", "1.02E+34", "5.2E+48", "5.19606E+49"));
			Rows.Add( new xStageStatsRow("ID_409", "410", "1.4564E+32", "8.74E+32", "2.33E+33", "1.25E+34", "6.78E+48", "1.01753E+50"));
			Rows.Add( new xStageStatsRow("ID_410", "411", "1.74768E+32", "3.50E+32", "2.10E+33", "1.46E+34", "8.86E+48", "1.77119E+49"));
			Rows.Add( new xStageStatsRow("ID_411", "412", "2.09722E+32", "6.29E+32", "2.73E+33", "1.74E+34", "1.16E+49", "3.46847E+49"));
			Rows.Add( new xStageStatsRow("ID_412", "413", "2.51666E+32", "1.01E+33", "3.52E+33", "2.09E+34", "1.51E+49", "7.54688E+49"));
			Rows.Add( new xStageStatsRow("ID_413", "414", "3.01999E+32", "1.51E+33", "4.53E+33", "2.54E+34", "1.97E+49", "1.97051E+50"));
			Rows.Add( new xStageStatsRow("ID_414", "415", "3.62399E+32", "2.17E+33", "5.80E+33", "3.12E+34", "2.57E+49", "3.85878E+50"));
			Rows.Add( new xStageStatsRow("ID_415", "416", "4.34879E+32", "8.70E+32", "5.22E+33", "3.64E+34", "3.36E+49", "6.71691E+49"));
			Rows.Add( new xStageStatsRow("ID_416", "417", "5.21855E+32", "1.57E+33", "6.78E+33", "4.32E+34", "4.38E+49", "1.31535E+50"));
			Rows.Add( new xStageStatsRow("ID_417", "418", "6.26226E+32", "2.50E+33", "8.77E+33", "5.20E+34", "5.72E+49", "2.86201E+50"));
			Rows.Add( new xStageStatsRow("ID_418", "419", "7.51471E+32", "3.76E+33", "1.13E+34", "6.33E+34", "7.47E+49", "7.47278E+50"));
			Rows.Add( new xStageStatsRow("ID_419", "420", "9.01765E+32", "5.41E+33", "1.44E+34", "7.77E+34", "9.76E+49", "1.46337E+51"));
			Rows.Add( new xStageStatsRow("ID_420", "421", "1.08212E+33", "2.16E+33", "1.30E+34", "9.07E+34", "1.27E+50", "2.54726E+50"));
			Rows.Add( new xStageStatsRow("ID_421", "422", "1.29854E+33", "3.90E+33", "1.69E+34", "1.08E+35", "1.66E+50", "4.98822E+50"));
			Rows.Add( new xStageStatsRow("ID_422", "423", "1.55825E+33", "6.23E+33", "2.18E+34", "1.29E+35", "2.17E+50", "1.08536E+51"));
			Rows.Add( new xStageStatsRow("ID_423", "424", "1.8699E+33", "9.35E+33", "2.80E+34", "1.57E+35", "2.83E+50", "2.83391E+51"));
			Rows.Add( new xStageStatsRow("ID_424", "425", "2.24388E+33", "1.35E+34", "3.59E+34", "1.93E+35", "3.7E+50", "5.54955E+51"));
			Rows.Add( new xStageStatsRow("ID_425", "426", "2.69266E+33", "5.39E+33", "3.23E+34", "2.26E+35", "4.83E+50", "9.66001E+50"));
			Rows.Add( new xStageStatsRow("ID_426", "427", "3.23119E+33", "9.69E+33", "4.20E+34", "2.68E+35", "6.31E+50", "1.89169E+51"));
			Rows.Add( new xStageStatsRow("ID_427", "428", "3.87742E+33", "1.55E+34", "5.43E+34", "3.22E+35", "8.23E+50", "4.11603E+51"));
			Rows.Add( new xStageStatsRow("ID_428", "429", "4.65291E+33", "2.33E+34", "6.98E+34", "3.92E+35", "1.07E+51", "1.07471E+52"));
			Rows.Add( new xStageStatsRow("ID_429", "430", "5.58349E+33", "3.35E+34", "8.93E+34", "4.81E+35", "1.4E+51", "2.10456E+52"));
			Rows.Add( new xStageStatsRow("ID_430", "431", "6.70019E+33", "1.34E+34", "8.04E+34", "5.61E+35", "1.83E+51", "3.66337E+51"));
			Rows.Add( new xStageStatsRow("ID_431", "432", "8.04023E+33", "2.41E+34", "1.05E+35", "6.66E+35", "2.39E+51", "7.17387E+51"));
			Rows.Add( new xStageStatsRow("ID_432", "433", "9.64827E+33", "3.86E+34", "1.35E+35", "8.01E+35", "3.12E+51", "1.56093E+52"));
			Rows.Add( new xStageStatsRow("ID_433", "434", "1.15779E+34", "5.79E+34", "1.74E+35", "9.75E+35", "4.08E+51", "4.07562E+52"));
			Rows.Add( new xStageStatsRow("ID_434", "435", "1.38935E+34", "8.34E+34", "2.22E+35", "1.20E+36", "5.32E+51", "7.98115E+52"));
			Rows.Add( new xStageStatsRow("ID_435", "436", "1.66722E+34", "3.33E+34", "2.00E+35", "1.40E+36", "6.95E+51", "1.38927E+52"));
			Rows.Add( new xStageStatsRow("ID_436", "437", "2.00067E+34", "6.00E+34", "2.60E+35", "1.66E+36", "9.07E+51", "2.72055E+52"));
			Rows.Add( new xStageStatsRow("ID_437", "438", "2.4008E+34", "9.60E+34", "3.36E+35", "1.99E+36", "1.18E+52", "5.91952E+52"));
			Rows.Add( new xStageStatsRow("ID_438", "439", "2.88096E+34", "1.44E+35", "4.32E+35", "2.43E+36", "1.55E+52", "1.5456E+53"));
			Rows.Add( new xStageStatsRow("ID_439", "440", "3.45715E+34", "2.07E+35", "5.53E+35", "2.98E+36", "2.02E+52", "3.0267E+53"));
			Rows.Add( new xStageStatsRow("ID_440", "441", "4.14858E+34", "8.30E+34", "4.98E+35", "3.48E+36", "2.63E+52", "5.26852E+52"));
			Rows.Add( new xStageStatsRow("ID_441", "442", "4.9783E+34", "1.49E+35", "6.47E+35", "4.12E+36", "3.44E+52", "1.03172E+53"));
			Rows.Add( new xStageStatsRow("ID_442", "443", "5.97396E+34", "2.39E+35", "8.36E+35", "4.96E+36", "4.49E+52", "2.24487E+53"));
			Rows.Add( new xStageStatsRow("ID_443", "444", "7.16875E+34", "3.58E+35", "1.08E+36", "6.04E+36", "5.86E+52", "5.8614E+53"));
			Rows.Add( new xStageStatsRow("ID_444", "445", "8.6025E+34", "5.16E+35", "1.38E+36", "7.41E+36", "7.65E+52", "1.14782E+54"));
			Rows.Add( new xStageStatsRow("ID_445", "446", "1.0323E+35", "2.06E+35", "1.24E+36", "8.65E+36", "9.99E+52", "1.99799E+53"));
			Rows.Add( new xStageStatsRow("ID_446", "447", "1.23876E+35", "3.72E+35", "1.61E+36", "1.03E+37", "1.3E+53", "3.91259E+53"));
			Rows.Add( new xStageStatsRow("ID_447", "448", "1.48651E+35", "5.95E+35", "2.08E+36", "1.23E+37", "1.7E+53", "8.51323E+53"));
			Rows.Add( new xStageStatsRow("ID_448", "449", "1.78381E+35", "8.92E+35", "2.68E+36", "1.50E+37", "2.22E+53", "2.22282E+54"));
			Rows.Add( new xStageStatsRow("ID_449", "450", "2.14058E+35", "1.28E+36", "3.42E+36", "1.84E+37", "2.9E+53", "4.35288E+54"));
			Rows.Add( new xStageStatsRow("ID_450", "451", "2.56869E+35", "5.14E+35", "3.08E+36", "2.15E+37", "3.79E+53", "7.57699E+53"));
			Rows.Add( new xStageStatsRow("ID_451", "452", "3.08243E+35", "9.25E+35", "4.01E+36", "2.55E+37", "4.95E+53", "1.48378E+54"));
			Rows.Add( new xStageStatsRow("ID_452", "453", "3.69892E+35", "1.48E+36", "5.18E+36", "3.07E+37", "6.46E+53", "3.22848E+54"));
			Rows.Add( new xStageStatsRow("ID_453", "454", "4.4387E+35", "2.22E+36", "6.66E+36", "3.74E+37", "8.43E+53", "8.42964E+54"));
			Rows.Add( new xStageStatsRow("ID_454", "455", "5.32644E+35", "3.20E+36", "8.52E+36", "4.59E+37", "1.1E+54", "1.65075E+55"));
			Rows.Add( new xStageStatsRow("ID_455", "456", "6.39173E+35", "1.28E+36", "7.67E+36", "5.36E+37", "1.44E+54", "2.87343E+54"));
			Rows.Add( new xStageStatsRow("ID_456", "457", "7.67007E+35", "2.30E+36", "9.97E+36", "6.35E+37", "1.88E+54", "5.62694E+54"));
			Rows.Add( new xStageStatsRow("ID_457", "458", "9.20409E+35", "3.68E+36", "1.29E+37", "7.64E+37", "2.45E+54", "1.22434E+55"));
			Rows.Add( new xStageStatsRow("ID_458", "459", "1.10449E+36", "5.52E+36", "1.66E+37", "9.30E+37", "3.2E+54", "3.19678E+55"));
			Rows.Add( new xStageStatsRow("ID_459", "460", "1.32539E+36", "7.95E+36", "2.12E+37", "1.14E+38", "4.17E+54", "6.26015E+55"));
			Rows.Add( new xStageStatsRow("ID_460", "461", "1.59047E+36", "3.18E+36", "1.91E+37", "1.33E+38", "5.45E+54", "1.08969E+55"));
			Rows.Add( new xStageStatsRow("ID_461", "462", "1.90856E+36", "5.73E+36", "2.48E+37", "1.58E+38", "7.11E+54", "2.13391E+55"));
			Rows.Add( new xStageStatsRow("ID_462", "463", "2.29027E+36", "9.16E+36", "3.21E+37", "1.90E+38", "9.29E+54", "4.64308E+55"));
			Rows.Add( new xStageStatsRow("ID_463", "464", "2.74833E+36", "1.37E+37", "4.12E+37", "2.31E+38", "1.21E+55", "1.21232E+56"));
			Rows.Add( new xStageStatsRow("ID_464", "465", "3.29799E+36", "1.98E+37", "5.28E+37", "2.84E+38", "1.58E+55", "2.37404E+56"));
			Rows.Add( new xStageStatsRow("ID_465", "466", "3.95759E+36", "7.92E+36", "4.75E+37", "3.32E+38", "2.07E+55", "4.13246E+55"));
			Rows.Add( new xStageStatsRow("ID_466", "467", "4.74911E+36", "1.42E+37", "6.17E+37", "3.93E+38", "2.7E+55", "8.09245E+55"));
			Rows.Add( new xStageStatsRow("ID_467", "468", "5.69893E+36", "2.28E+37", "7.98E+37", "4.73E+38", "3.52E+55", "1.7608E+56"));
			Rows.Add( new xStageStatsRow("ID_468", "469", "6.83871E+36", "3.42E+37", "1.03E+38", "5.76E+38", "4.6E+55", "4.59749E+56"));
			Rows.Add( new xStageStatsRow("ID_469", "470", "8.20646E+36", "4.92E+37", "1.31E+38", "7.07E+38", "6E+55", "9.00311E+56"));
			Rows.Add( new xStageStatsRow("ID_470", "471", "9.84775E+36", "1.97E+37", "1.18E+38", "8.25E+38", "7.84E+55", "1.56716E+56"));
			Rows.Add( new xStageStatsRow("ID_471", "472", "1.18173E+37", "3.55E+37", "1.54E+38", "9.79E+38", "1.02E+56", "3.06891E+56"));
			Rows.Add( new xStageStatsRow("ID_472", "473", "1.41808E+37", "5.67E+37", "1.99E+38", "1.18E+39", "1.34E+56", "6.67749E+56"));
			Rows.Add( new xStageStatsRow("ID_473", "474", "1.70169E+37", "8.51E+37", "2.55E+38", "1.43E+39", "1.74E+56", "1.74351E+57"));
			Rows.Add( new xStageStatsRow("ID_474", "475", "2.04203E+37", "1.23E+38", "3.27E+38", "1.76E+39", "2.28E+56", "3.41426E+57"));
			Rows.Add( new xStageStatsRow("ID_475", "476", "2.45043E+37", "4.90E+37", "2.94E+38", "2.05E+39", "2.97E+56", "5.94314E+56"));
			Rows.Add( new xStageStatsRow("ID_476", "477", "2.94052E+37", "8.82E+37", "3.82E+38", "2.44E+39", "3.88E+56", "1.16383E+57"));
			Rows.Add( new xStageStatsRow("ID_477", "478", "3.52863E+37", "1.41E+38", "4.94E+38", "2.93E+39", "5.06E+56", "2.53231E+57"));
			Rows.Add( new xStageStatsRow("ID_478", "479", "4.23435E+37", "2.12E+38", "6.35E+38", "3.56E+39", "6.61E+56", "6.61193E+57"));
			Rows.Add( new xStageStatsRow("ID_479", "480", "5.08122E+37", "3.05E+38", "8.13E+38", "4.38E+39", "8.63E+56", "1.29479E+58"));
			Rows.Add( new xStageStatsRow("ID_480", "481", "6.09747E+37", "1.22E+38", "7.32E+38", "5.11E+39", "1.13E+57", "2.25382E+57"));
			Rows.Add( new xStageStatsRow("ID_481", "482", "7.31696E+37", "2.20E+38", "9.51E+38", "6.06E+39", "1.47E+57", "4.41359E+57"));
			Rows.Add( new xStageStatsRow("ID_482", "483", "8.78035E+37", "3.51E+38", "1.23E+39", "7.29E+39", "1.92E+57", "9.60332E+57"));
			Rows.Add( new xStageStatsRow("ID_483", "484", "1.05364E+38", "5.27E+38", "1.58E+39", "8.87E+39", "2.51E+57", "2.50745E+58"));
			Rows.Add( new xStageStatsRow("ID_484", "485", "1.26437E+38", "7.59E+38", "2.02E+39", "1.09E+40", "3.27E+57", "4.91025E+58"));
			Rows.Add( new xStageStatsRow("ID_485", "486", "1.51724E+38", "3.03E+38", "1.82E+39", "1.27E+40", "4.27E+57", "8.54719E+57"));
			Rows.Add( new xStageStatsRow("ID_486", "487", "1.82069E+38", "5.46E+38", "2.37E+39", "1.51E+40", "5.58E+57", "1.67377E+58"));
			Rows.Add( new xStageStatsRow("ID_487", "488", "2.18483E+38", "8.74E+38", "3.06E+39", "1.81E+40", "7.28E+57", "3.64188E+58"));
			Rows.Add( new xStageStatsRow("ID_488", "489", "2.6218E+38", "1.31E+39", "3.93E+39", "2.21E+40", "9.51E+57", "9.50902E+58"));
			Rows.Add( new xStageStatsRow("ID_489", "490", "3.14616E+38", "1.89E+39", "5.03E+39", "2.71E+40", "1.24E+58", "1.86212E+59"));
			Rows.Add( new xStageStatsRow("ID_490", "491", "3.77539E+38", "7.55E+38", "4.53E+39", "3.16E+40", "1.62E+58", "3.24136E+58"));
			Rows.Add( new xStageStatsRow("ID_491", "492", "4.53047E+38", "1.36E+39", "5.89E+39", "3.75E+40", "2.12E+58", "6.34745E+58"));
			Rows.Add( new xStageStatsRow("ID_492", "493", "5.43656E+38", "2.17E+39", "7.61E+39", "4.51E+40", "2.76E+58", "1.38111E+59"));
			Rows.Add( new xStageStatsRow("ID_493", "494", "6.52387E+38", "3.26E+39", "9.79E+39", "5.49E+40", "3.61E+58", "3.60612E+59"));
			Rows.Add( new xStageStatsRow("ID_494", "495", "7.82865E+38", "4.70E+39", "1.25E+40", "6.74E+40", "4.71E+58", "7.06174E+59"));
			Rows.Add( new xStageStatsRow("ID_495", "496", "9.39438E+38", "1.88E+39", "1.13E+40", "7.87E+40", "6.15E+58", "1.22922E+59"));
			Rows.Add( new xStageStatsRow("ID_496", "497", "1.12733E+39", "3.38E+39", "1.47E+40", "9.34E+40", "8.02E+58", "2.40715E+59"));
			Rows.Add( new xStageStatsRow("ID_497", "498", "1.35279E+39", "5.41E+39", "1.89E+40", "1.12E+41", "1.05E+59", "5.2376E+59"));
			Rows.Add( new xStageStatsRow("ID_498", "499", "1.62335E+39", "8.12E+39", "2.44E+40", "1.37E+41", "1.37E+59", "1.36755E+60"));
			Rows.Add( new xStageStatsRow("ID_499", "500", "1.94802E+39", "1.17E+40", "3.12E+40", "1.68E+41", "1.79E+59", "2.67803E+60"));
			Rows.Add( new xStageStatsRow("ID_500", "501", "2.33762E+39", "4.68E+39", "2.81E+40", "1.96E+41", "2.33E+59", "4.6616E+59"));
			Rows.Add( new xStageStatsRow("ID_501", "502", "2.80515E+39", "8.42E+39", "3.65E+40", "2.32E+41", "3.04E+59", "9.12866E+59"));
			Rows.Add( new xStageStatsRow("ID_502", "503", "3.36618E+39", "1.35E+40", "4.71E+40", "2.79E+41", "3.97E+59", "1.98626E+60"));
			Rows.Add( new xStageStatsRow("ID_503", "504", "4.03941E+39", "2.02E+40", "6.06E+40", "3.40E+41", "5.19E+59", "5.18618E+60"));
			Rows.Add( new xStageStatsRow("ID_504", "505", "4.84729E+39", "2.91E+40", "7.76E+40", "4.18E+41", "6.77E+59", "1.01559E+61"));
			Rows.Add( new xStageStatsRow("ID_505", "506", "5.81675E+39", "1.16E+40", "6.98E+40", "4.87E+41", "8.84E+59", "1.76782E+60"));
			Rows.Add( new xStageStatsRow("ID_506", "507", "6.9801E+39", "2.09E+40", "9.07E+40", "5.78E+41", "1.15E+60", "3.46187E+60"));
			Rows.Add( new xStageStatsRow("ID_507", "508", "8.37612E+39", "3.35E+40", "1.17E+41", "6.95E+41", "1.51E+60", "7.53252E+60"));
			Rows.Add( new xStageStatsRow("ID_508", "509", "1.00513E+40", "5.03E+40", "1.51E+41", "8.46E+41", "1.97E+60", "1.96676E+61"));
			Rows.Add( new xStageStatsRow("ID_509", "510", "1.20616E+40", "7.24E+40", "1.93E+41", "1.04E+42", "2.57E+60", "3.85144E+61"));
			Rows.Add( new xStageStatsRow("ID_510", "511", "1.44739E+40", "2.89E+40", "1.74E+41", "1.21E+42", "3.35E+60", "6.70413E+60"));
			Rows.Add( new xStageStatsRow("ID_511", "512", "1.73687E+40", "5.21E+40", "2.26E+41", "1.44E+42", "4.38E+60", "1.31285E+61"));
			Rows.Add( new xStageStatsRow("ID_512", "513", "2.08425E+40", "8.34E+40", "2.92E+41", "1.73E+42", "5.71E+60", "2.85657E+61"));
			Rows.Add( new xStageStatsRow("ID_513", "514", "2.5011E+40", "1.25E+41", "3.75E+41", "2.11E+42", "7.46E+60", "7.45856E+61"));
			Rows.Add( new xStageStatsRow("ID_514", "515", "3.00132E+40", "1.80E+41", "4.80E+41", "2.59E+42", "9.74E+60", "1.46059E+62"));
			Rows.Add( new xStageStatsRow("ID_515", "516", "3.60158E+40", "7.20E+40", "4.32E+41", "3.02E+42", "1.27E+61", "2.54242E+61"));
			Rows.Add( new xStageStatsRow("ID_516", "517", "4.32189E+40", "1.30E+41", "5.62E+41", "3.58E+42", "1.66E+61", "4.97873E+61"));
			Rows.Add( new xStageStatsRow("ID_517", "518", "5.18627E+40", "2.07E+41", "7.26E+41", "4.31E+42", "2.17E+61", "1.0833E+62"));
			Rows.Add( new xStageStatsRow("ID_518", "519", "6.22353E+40", "3.11E+41", "9.34E+41", "5.24E+42", "2.83E+61", "2.82852E+62"));
			Rows.Add( new xStageStatsRow("ID_519", "520", "7.46823E+40", "4.48E+41", "1.19E+42", "6.43E+42", "3.69E+61", "5.53899E+62"));
			Rows.Add( new xStageStatsRow("ID_520", "521", "8.96188E+40", "1.79E+41", "1.08E+42", "7.51E+42", "4.82E+61", "9.64163E+61"));
			Rows.Add( new xStageStatsRow("ID_521", "522", "1.07543E+41", "3.23E+41", "1.40E+42", "8.91E+42", "6.29E+61", "1.88809E+62"));
			Rows.Add( new xStageStatsRow("ID_522", "523", "1.29051E+41", "5.16E+41", "1.81E+42", "1.07E+43", "8.22E+61", "4.1082E+62"));
			Rows.Add( new xStageStatsRow("ID_523", "524", "1.54861E+41", "7.74E+41", "2.32E+42", "1.30E+43", "1.07E+62", "1.07266E+63"));
			Rows.Add( new xStageStatsRow("ID_524", "525", "1.85834E+41", "1.12E+42", "2.97E+42", "1.60E+43", "1.4E+62", "2.10056E+63"));
			Rows.Add( new xStageStatsRow("ID_525", "526", "2.23E+41", "4.46E+41", "2.68E+42", "1.87E+43", "1.83E+62", "3.6564E+62"));
			Rows.Add( new xStageStatsRow("ID_526", "527", "2.676E+41", "8.03E+41", "3.48E+42", "2.22E+43", "2.39E+62", "7.16022E+62"));
			Rows.Add( new xStageStatsRow("ID_527", "528", "3.2112E+41", "1.28E+42", "4.50E+42", "2.67E+43", "3.12E+62", "1.55796E+63"));
			Rows.Add( new xStageStatsRow("ID_528", "529", "3.85344E+41", "1.93E+42", "5.78E+42", "3.24E+43", "4.07E+62", "4.06786E+63"));
			Rows.Add( new xStageStatsRow("ID_529", "530", "4.62413E+41", "2.77E+42", "7.40E+42", "3.98E+43", "5.31E+62", "7.96597E+63"));
			Rows.Add( new xStageStatsRow("ID_530", "531", "5.54896E+41", "1.11E+42", "6.66E+42", "4.65E+43", "6.93E+62", "1.38662E+63"));
			Rows.Add( new xStageStatsRow("ID_531", "532", "6.65875E+41", "2.00E+42", "8.66E+42", "5.52E+43", "9.05E+62", "2.71538E+63"));
			Rows.Add( new xStageStatsRow("ID_532", "533", "7.9905E+41", "3.20E+42", "1.12E+43", "6.63E+43", "1.18E+63", "5.90826E+63"));
			Rows.Add( new xStageStatsRow("ID_533", "534", "9.5886E+41", "4.79E+42", "1.44E+43", "8.07E+43", "1.54E+63", "1.54266E+64"));
			Rows.Add( new xStageStatsRow("ID_534", "535", "1.15063E+42", "6.90E+42", "1.84E+43", "9.91E+43", "2.01E+63", "3.02094E+64"));
			Rows.Add( new xStageStatsRow("ID_535", "536", "1.38076E+42", "2.76E+42", "1.66E+43", "1.16E+44", "2.63E+63", "5.2585E+63"));
			Rows.Add( new xStageStatsRow("ID_536", "537", "1.65691E+42", "4.97E+42", "2.15E+43", "1.37E+44", "3.43E+63", "1.02976E+64"));
			Rows.Add( new xStageStatsRow("ID_537", "538", "1.98829E+42", "7.95E+42", "2.78E+43", "1.65E+44", "4.48E+63", "2.2406E+64"));
			Rows.Add( new xStageStatsRow("ID_538", "539", "2.38595E+42", "1.19E+43", "3.58E+43", "2.01E+44", "5.85E+63", "5.85025E+64"));
			Rows.Add( new xStageStatsRow("ID_539", "540", "2.86314E+42", "1.72E+43", "4.58E+43", "2.47E+44", "7.64E+63", "1.14563E+65"));
			Rows.Add( new xStageStatsRow("ID_540", "541", "3.43577E+42", "6.87E+42", "4.12E+43", "2.88E+44", "9.97E+63", "1.99419E+64"));
			Rows.Add( new xStageStatsRow("ID_541", "542", "4.12292E+42", "1.24E+43", "5.36E+43", "3.42E+44", "1.3E+64", "3.90515E+64"));
			Rows.Add( new xStageStatsRow("ID_542", "543", "4.94751E+42", "1.98E+43", "6.93E+43", "4.11E+44", "1.7E+64", "8.49703E+64"));
			Rows.Add( new xStageStatsRow("ID_543", "544", "5.93701E+42", "2.97E+43", "8.91E+43", "5.00E+44", "2.22E+64", "2.2186E+65"));
			Rows.Add( new xStageStatsRow("ID_544", "545", "7.12441E+42", "4.27E+43", "1.14E+44", "6.14E+44", "2.9E+64", "4.3446E+65"));
			Rows.Add( new xStageStatsRow("ID_545", "546", "8.5493E+42", "1.71E+43", "1.03E+44", "7.16E+44", "3.78E+64", "7.56257E+64"));
			Rows.Add( new xStageStatsRow("ID_546", "547", "1.02592E+43", "3.08E+43", "1.33E+44", "8.50E+44", "4.94E+64", "1.48095E+65"));
			Rows.Add( new xStageStatsRow("ID_547", "548", "1.2311E+43", "4.92E+43", "1.72E+44", "1.02E+45", "6.44E+64", "3.22234E+65"));
			Rows.Add( new xStageStatsRow("ID_548", "549", "1.47732E+43", "7.39E+43", "2.22E+44", "1.24E+45", "8.41E+64", "8.4136E+65"));
			Rows.Add( new xStageStatsRow("ID_549", "550", "1.77278E+43", "1.06E+44", "2.84E+44", "1.53E+45", "1.1E+65", "1.64761E+66"));
			Rows.Add( new xStageStatsRow("ID_550", "551", "2.12734E+43", "4.25E+43", "2.55E+44", "1.78E+45", "1.43E+65", "2.86796E+65"));
			Rows.Add( new xStageStatsRow("ID_551", "552", "2.55281E+43", "7.66E+43", "3.32E+44", "2.11E+45", "1.87E+65", "5.61624E+65"));
			Rows.Add( new xStageStatsRow("ID_552", "553", "3.06337E+43", "1.23E+44", "4.29E+44", "2.54E+45", "2.44E+65", "1.22201E+66"));
			Rows.Add( new xStageStatsRow("ID_553", "554", "3.67604E+43", "1.84E+44", "5.51E+44", "3.09E+45", "3.19E+65", "3.1907E+66"));
			Rows.Add( new xStageStatsRow("ID_554", "555", "4.41125E+43", "2.65E+44", "7.06E+44", "3.80E+45", "4.17E+65", "6.24824E+66"));
			Rows.Add( new xStageStatsRow("ID_555", "556", "5.2935E+43", "1.06E+44", "6.35E+44", "4.44E+45", "5.44E+65", "1.08762E+66"));
			Rows.Add( new xStageStatsRow("ID_556", "557", "6.3522E+43", "1.91E+44", "8.26E+44", "5.26E+45", "7.1E+65", "2.12985E+66"));
			Rows.Add( new xStageStatsRow("ID_557", "558", "7.62264E+43", "3.05E+44", "1.07E+45", "6.33E+45", "9.27E+65", "4.63424E+66"));
			Rows.Add( new xStageStatsRow("ID_558", "559", "9.14717E+43", "4.57E+44", "1.37E+45", "7.70E+45", "1.21E+66", "1.21001E+67"));
			Rows.Add( new xStageStatsRow("ID_559", "560", "1.09766E+44", "6.59E+44", "1.76E+45", "9.46E+45", "1.58E+66", "2.36953E+67"));
			Rows.Add( new xStageStatsRow("ID_560", "561", "1.31719E+44", "2.63E+44", "1.58E+45", "1.10E+46", "2.06E+66", "4.12459E+66"));
			Rows.Add( new xStageStatsRow("ID_561", "562", "1.58063E+44", "4.74E+44", "2.05E+45", "1.31E+46", "2.69E+66", "8.07706E+66"));
			Rows.Add( new xStageStatsRow("ID_562", "563", "1.89676E+44", "7.59E+44", "2.66E+45", "1.57E+46", "3.51E+66", "1.75745E+67"));
			Rows.Add( new xStageStatsRow("ID_563", "564", "2.27611E+44", "1.14E+45", "3.41E+45", "1.92E+46", "4.59E+66", "4.58874E+67"));
			Rows.Add( new xStageStatsRow("ID_564", "565", "2.73133E+44", "1.64E+45", "4.37E+45", "2.35E+46", "5.99E+66", "8.98598E+67"));
			Rows.Add( new xStageStatsRow("ID_565", "566", "3.27759E+44", "6.56E+44", "3.93E+45", "2.75E+46", "7.82E+66", "1.56417E+67"));
			Rows.Add( new xStageStatsRow("ID_566", "567", "3.93311E+44", "1.18E+45", "5.11E+45", "3.26E+46", "1.02E+67", "3.06307E+67"));
			Rows.Add( new xStageStatsRow("ID_567", "568", "4.71974E+44", "1.89E+45", "6.61E+45", "3.92E+46", "1.33E+67", "6.66479E+67"));
			Rows.Add( new xStageStatsRow("ID_568", "569", "5.66368E+44", "2.83E+45", "8.50E+45", "4.77E+46", "1.74E+67", "1.74019E+68"));
			Rows.Add( new xStageStatsRow("ID_569", "570", "6.79642E+44", "4.08E+45", "1.09E+46", "5.86E+46", "2.27E+67", "3.40776E+68"));
			Rows.Add( new xStageStatsRow("ID_570", "571", "8.1557E+44", "1.63E+45", "9.79E+45", "6.83E+46", "2.97E+67", "5.93183E+67"));
			Rows.Add( new xStageStatsRow("ID_571", "572", "9.78685E+44", "2.94E+45", "1.27E+46", "8.11E+46", "3.87E+67", "1.16161E+68"));
			Rows.Add( new xStageStatsRow("ID_572", "573", "1.17442E+45", "4.70E+45", "1.64E+46", "9.75E+46", "5.05E+67", "2.5275E+68"));
			Rows.Add( new xStageStatsRow("ID_573", "574", "1.40931E+45", "7.05E+45", "2.11E+46", "1.19E+47", "6.6E+67", "6.59935E+68"));
			Rows.Add( new xStageStatsRow("ID_574", "575", "1.69117E+45", "1.01E+46", "2.71E+46", "1.46E+47", "8.62E+67", "1.29233E+69"));
			Rows.Add( new xStageStatsRow("ID_575", "576", "2.0294E+45", "4.06E+45", "2.44E+46", "1.70E+47", "1.12E+68", "2.24953E+68"));
			Rows.Add( new xStageStatsRow("ID_576", "577", "2.43528E+45", "7.31E+45", "3.17E+46", "2.02E+47", "1.47E+68", "4.40519E+68"));
			Rows.Add( new xStageStatsRow("ID_577", "578", "2.92234E+45", "1.17E+46", "4.09E+46", "2.43E+47", "1.92E+68", "9.58504E+68"));
			Rows.Add( new xStageStatsRow("ID_578", "579", "3.5068E+45", "1.75E+46", "5.26E+46", "2.95E+47", "2.5E+68", "2.50268E+69"));
			Rows.Add( new xStageStatsRow("ID_579", "580", "4.20816E+45", "2.52E+46", "6.73E+46", "3.63E+47", "3.27E+68", "4.90091E+69"));
			Rows.Add( new xStageStatsRow("ID_580", "581", "5.0498E+45", "1.01E+46", "6.06E+46", "4.23E+47", "4.27E+68", "8.53093E+68"));
			Rows.Add( new xStageStatsRow("ID_581", "582", "6.05976E+45", "1.82E+46", "7.88E+46", "5.02E+47", "5.57E+68", "1.67058E+69"));
			Rows.Add( new xStageStatsRow("ID_582", "583", "7.27171E+45", "2.91E+46", "1.02E+47", "6.04E+47", "7.27E+68", "3.63495E+69"));
			Rows.Add( new xStageStatsRow("ID_583", "584", "8.72605E+45", "4.36E+46", "1.31E+47", "7.35E+47", "9.49E+68", "9.49093E+69"));
			Rows.Add( new xStageStatsRow("ID_584", "585", "1.04713E+46", "6.28E+46", "1.68E+47", "9.02E+47", "1.24E+69", "1.85858E+70"));
			Rows.Add( new xStageStatsRow("ID_585", "586", "1.25655E+46", "2.51E+46", "1.51E+47", "1.05E+48", "1.62E+69", "3.23519E+69"));
			Rows.Add( new xStageStatsRow("ID_586", "587", "1.50786E+46", "4.52E+46", "1.96E+47", "1.25E+48", "2.11E+69", "6.33537E+69"));
			Rows.Add( new xStageStatsRow("ID_587", "588", "1.80943E+46", "7.24E+46", "2.53E+47", "1.50E+48", "2.76E+69", "1.37848E+70"));
			Rows.Add( new xStageStatsRow("ID_588", "589", "2.17132E+46", "1.09E+47", "3.26E+47", "1.83E+48", "3.6E+69", "3.59925E+70"));
			Rows.Add( new xStageStatsRow("ID_589", "590", "2.60558E+46", "1.56E+47", "4.17E+47", "2.24E+48", "4.7E+69", "7.0483E+70"));
			Rows.Add( new xStageStatsRow("ID_590", "591", "3.1267E+46", "6.25E+46", "3.75E+47", "2.62E+48", "6.13E+69", "1.22689E+70"));
			Rows.Add( new xStageStatsRow("ID_591", "592", "3.75204E+46", "1.13E+47", "4.88E+47", "3.11E+48", "8.01E+69", "2.40257E+70"));
			Rows.Add( new xStageStatsRow("ID_592", "593", "4.50245E+46", "1.80E+47", "6.30E+47", "3.74E+48", "1.05E+70", "5.22764E+70"));
			Rows.Add( new xStageStatsRow("ID_593", "594", "5.40294E+46", "2.70E+47", "8.10E+47", "4.55E+48", "1.36E+70", "1.36495E+71"));
			Rows.Add( new xStageStatsRow("ID_594", "595", "6.48353E+46", "3.89E+47", "1.04E+48", "5.59E+48", "1.78E+70", "2.67294E+71"));
			Rows.Add( new xStageStatsRow("ID_595", "596", "7.78023E+46", "1.56E+47", "9.34E+47", "6.52E+48", "2.33E+70", "4.65273E+70"));
			Rows.Add( new xStageStatsRow("ID_596", "597", "9.33628E+46", "2.80E+47", "1.21E+48", "7.73E+48", "3.04E+70", "9.11129E+70"));
			Rows.Add( new xStageStatsRow("ID_597", "598", "1.12035E+47", "4.48E+47", "1.57E+48", "9.30E+48", "3.96E+70", "1.98248E+71"));
			Rows.Add( new xStageStatsRow("ID_598", "599", "1.34442E+47", "6.72E+47", "2.02E+48", "1.13E+49", "5.18E+70", "5.17631E+71"));
			Rows.Add( new xStageStatsRow("ID_599", "600", "1.61331E+47", "9.68E+47", "2.58E+48", "1.39E+49", "6.76E+70", "1.01366E+72"));
			Rows.Add( new xStageStatsRow("ID_600", "601", "1.93597E+47", "3.87E+47", "2.32E+48", "1.62E+49", "8.82E+70", "1.76446E+71"));
			Rows.Add( new xStageStatsRow("ID_601", "602", "2.32317E+47", "6.97E+47", "3.02E+48", "1.92E+49", "1.15E+71", "3.45528E+71"));
			Rows.Add( new xStageStatsRow("ID_602", "603", "2.7878E+47", "1.12E+48", "3.90E+48", "2.31E+49", "1.5E+71", "7.51819E+71"));
			Rows.Add( new xStageStatsRow("ID_603", "604", "3.34536E+47", "1.67E+48", "5.02E+48", "2.82E+49", "1.96E+71", "1.96302E+72"));
			Rows.Add( new xStageStatsRow("ID_604", "605", "4.01443E+47", "2.41E+48", "6.42E+48", "3.46E+49", "2.56E+71", "3.84411E+72"));
			Rows.Add( new xStageStatsRow("ID_605", "606", "4.81732E+47", "9.63E+47", "5.78E+48", "4.04E+49", "3.35E+71", "6.69138E+71"));
			Rows.Add( new xStageStatsRow("ID_606", "607", "5.78078E+47", "1.73E+48", "7.52E+48", "4.79E+49", "4.37E+71", "1.31035E+72"));
			Rows.Add( new xStageStatsRow("ID_607", "608", "6.93693E+47", "2.77E+48", "9.71E+48", "5.76E+49", "5.7E+71", "2.85113E+72"));
			Rows.Add( new xStageStatsRow("ID_608", "609", "8.32432E+47", "4.16E+48", "1.25E+49", "7.01E+49", "7.44E+71", "7.44437E+72"));
			Rows.Add( new xStageStatsRow("ID_609", "610", "9.98919E+47", "5.99E+48", "1.60E+49", "8.61E+49", "9.72E+71", "1.45781E+73"));
			Rows.Add( new xStageStatsRow("ID_610", "611", "1.1987E+48", "2.40E+48", "1.44E+49", "1.00E+50", "1.27E+72", "2.53758E+72"));
			Rows.Add( new xStageStatsRow("ID_611", "612", "1.43844E+48", "4.32E+48", "1.87E+49", "1.19E+50", "1.66E+72", "4.96926E+72"));
			Rows.Add( new xStageStatsRow("ID_612", "613", "1.72613E+48", "6.90E+48", "2.42E+49", "1.43E+50", "2.16E+72", "1.08124E+73"));
			Rows.Add( new xStageStatsRow("ID_613", "614", "2.07136E+48", "1.04E+49", "3.11E+49", "1.74E+50", "2.82E+72", "2.82314E+73"));
			Rows.Add( new xStageStatsRow("ID_614", "615", "2.48563E+48", "1.49E+49", "3.98E+49", "2.14E+50", "3.69E+72", "5.52846E+73"));
			Rows.Add( new xStageStatsRow("ID_615", "616", "2.98275E+48", "5.97E+48", "3.58E+49", "2.50E+50", "4.81E+72", "9.62328E+72"));
			Rows.Add( new xStageStatsRow("ID_616", "617", "3.57931E+48", "1.07E+49", "4.65E+49", "2.96E+50", "6.28E+72", "1.8845E+73"));
			Rows.Add( new xStageStatsRow("ID_617", "618", "4.29517E+48", "1.72E+49", "6.01E+49", "3.57E+50", "8.2E+72", "4.10039E+73"));
			Rows.Add( new xStageStatsRow("ID_618", "619", "5.1542E+48", "2.58E+49", "7.73E+49", "4.34E+50", "1.07E+73", "1.07062E+74"));
			Rows.Add( new xStageStatsRow("ID_619", "620", "6.18504E+48", "3.71E+49", "9.90E+49", "5.33E+50", "1.4E+73", "2.09656E+74"));
			Rows.Add( new xStageStatsRow("ID_620", "621", "7.42205E+48", "1.48E+49", "8.91E+49", "6.22E+50", "1.82E+73", "3.64945E+73"));
			Rows.Add( new xStageStatsRow("ID_621", "622", "8.90646E+48", "2.67E+49", "1.16E+50", "7.38E+50", "2.38E+73", "7.14659E+73"));
			Rows.Add( new xStageStatsRow("ID_622", "623", "1.06878E+49", "4.28E+49", "1.50E+50", "8.87E+50", "3.11E+73", "1.55499E+74"));
			Rows.Add( new xStageStatsRow("ID_623", "624", "1.28253E+49", "6.41E+49", "1.92E+50", "1.08E+51", "4.06E+73", "4.06013E+74"));
			Rows.Add( new xStageStatsRow("ID_624", "625", "1.53904E+49", "9.23E+49", "2.46E+50", "1.33E+51", "5.3E+73", "7.95081E+74"));
			Rows.Add( new xStageStatsRow("ID_625", "626", "1.84684E+49", "3.69E+49", "2.22E+50", "1.55E+51", "6.92E+73", "1.38398E+74"));
			Rows.Add( new xStageStatsRow("ID_626", "627", "2.21621E+49", "6.65E+49", "2.88E+50", "1.84E+51", "9.03E+73", "2.71021E+74"));
			Rows.Add( new xStageStatsRow("ID_627", "628", "2.65945E+49", "1.06E+50", "3.72E+50", "2.21E+51", "1.18E+74", "5.89702E+74"));
			Rows.Add( new xStageStatsRow("ID_628", "629", "3.19135E+49", "1.60E+50", "4.79E+50", "2.69E+51", "1.54E+74", "1.53973E+75"));
			Rows.Add( new xStageStatsRow("ID_629", "630", "3.82961E+49", "2.30E+50", "6.13E+50", "3.30E+51", "2.01E+74", "3.01519E+75"));
			Rows.Add( new xStageStatsRow("ID_630", "631", "4.59554E+49", "9.19E+49", "5.51E+50", "3.85E+51", "2.62E+74", "5.2485E+74"));
			Rows.Add( new xStageStatsRow("ID_631", "632", "5.51464E+49", "1.65E+50", "7.17E+50", "4.57E+51", "3.43E+74", "1.0278E+75"));
			Rows.Add( new xStageStatsRow("ID_632", "633", "6.61757E+49", "2.65E+50", "9.26E+50", "5.49E+51", "4.47E+74", "2.23633E+75"));
			Rows.Add( new xStageStatsRow("ID_633", "634", "7.94109E+49", "3.97E+50", "1.19E+51", "6.69E+51", "5.84E+74", "5.83912E+75"));
			Rows.Add( new xStageStatsRow("ID_634", "635", "9.52931E+49", "5.72E+50", "1.52E+51", "8.21E+51", "7.62E+74", "1.14346E+76"));
			Rows.Add( new xStageStatsRow("ID_635", "636", "1.14352E+50", "2.29E+50", "1.37E+51", "9.58E+51", "9.95E+74", "1.99039E+75"));
			Rows.Add( new xStageStatsRow("ID_636", "637", "1.37222E+50", "4.12E+50", "1.78E+51", "1.14E+52", "1.3E+75", "3.89772E+75"));
			Rows.Add( new xStageStatsRow("ID_637", "638", "1.64666E+50", "6.59E+50", "2.31E+51", "1.37E+52", "1.7E+75", "8.48087E+75"));
			Rows.Add( new xStageStatsRow("ID_638", "639", "1.976E+50", "9.88E+50", "2.96E+51", "1.66E+52", "2.21E+75", "2.21437E+76"));
			Rows.Add( new xStageStatsRow("ID_639", "640", "2.3712E+50", "1.42E+51", "3.79E+51", "2.04E+52", "2.89E+75", "4.33634E+76"));
			Rows.Add( new xStageStatsRow("ID_640", "641", "2.84544E+50", "5.69E+50", "3.41E+51", "2.38E+52", "3.77E+75", "7.54818E+75"));
			Rows.Add( new xStageStatsRow("ID_641", "642", "3.41452E+50", "1.02E+51", "4.44E+51", "2.83E+52", "4.93E+75", "1.47814E+76"));
			Rows.Add( new xStageStatsRow("ID_642", "643", "4.09743E+50", "1.64E+51", "5.74E+51", "3.40E+52", "6.43E+75", "3.21621E+76"));
			Rows.Add( new xStageStatsRow("ID_643", "644", "4.91691E+50", "2.46E+51", "7.38E+51", "4.14E+52", "8.4E+75", "8.39759E+76"));
			Rows.Add( new xStageStatsRow("ID_644", "645", "5.90029E+50", "3.54E+51", "9.44E+51", "5.08E+52", "1.1E+76", "1.64447E+77"));
			Rows.Add( new xStageStatsRow("ID_645", "646", "7.08035E+50", "1.42E+51", "8.50E+51", "5.93E+52", "1.43E+76", "2.86251E+76"));
			Rows.Add( new xStageStatsRow("ID_646", "647", "8.49642E+50", "2.55E+51", "1.10E+52", "7.04E+52", "1.87E+76", "5.60555E+76"));
			Rows.Add( new xStageStatsRow("ID_647", "648", "1.01957E+51", "4.08E+51", "1.43E+52", "8.47E+52", "2.44E+76", "1.21969E+77"));
			Rows.Add( new xStageStatsRow("ID_648", "649", "1.22349E+51", "6.12E+51", "1.84E+52", "1.03E+53", "3.18E+76", "3.18463E+77"));
			Rows.Add( new xStageStatsRow("ID_649", "650", "1.46818E+51", "8.81E+51", "2.35E+52", "1.26E+53", "4.16E+76", "6.23635E+77"));
			Rows.Add( new xStageStatsRow("ID_650", "651", "1.76182E+51", "3.52E+51", "2.11E+52", "1.48E+53", "5.43E+76", "1.08555E+77"));
			Rows.Add( new xStageStatsRow("ID_651", "652", "2.11418E+51", "6.34E+51", "2.75E+52", "1.75E+53", "7.09E+76", "2.1258E+77"));
			Rows.Add( new xStageStatsRow("ID_652", "653", "2.53702E+51", "1.01E+52", "3.55E+52", "2.11E+53", "9.25E+76", "4.62543E+77"));
			Rows.Add( new xStageStatsRow("ID_653", "654", "3.04442E+51", "1.52E+52", "4.57E+52", "2.56E+53", "1.21E+77", "1.20771E+78"));
			Rows.Add( new xStageStatsRow("ID_654", "655", "3.65331E+51", "2.19E+52", "5.85E+52", "3.15E+53", "1.58E+77", "2.36502E+78"));
			Rows.Add( new xStageStatsRow("ID_655", "656", "4.38397E+51", "8.77E+51", "5.26E+52", "3.67E+53", "2.06E+77", "4.11675E+77"));
			Rows.Add( new xStageStatsRow("ID_656", "657", "5.26076E+51", "1.58E+52", "6.84E+52", "4.36E+53", "2.69E+77", "8.06169E+77"));
			Rows.Add( new xStageStatsRow("ID_657", "658", "6.31291E+51", "2.53E+52", "8.84E+52", "5.24E+53", "3.51E+77", "1.7541E+78"));
			Rows.Add( new xStageStatsRow("ID_658", "659", "7.5755E+51", "3.79E+52", "1.14E+53", "6.38E+53", "4.58E+77", "4.58001E+78"));
			Rows.Add( new xStageStatsRow("ID_659", "660", "9.0906E+51", "5.45E+52", "1.45E+53", "7.83E+53", "5.98E+77", "8.96888E+78"));
			Rows.Add( new xStageStatsRow("ID_660", "661", "1.09087E+52", "2.18E+52", "1.31E+53", "9.14E+53", "7.81E+77", "1.5612E+78"));
			Rows.Add( new xStageStatsRow("ID_661", "662", "1.30905E+52", "3.93E+52", "1.70E+53", "1.08E+54", "1.02E+78", "3.05724E+78"));
			Rows.Add( new xStageStatsRow("ID_662", "663", "1.57086E+52", "6.28E+52", "2.20E+53", "1.30E+54", "1.33E+78", "6.65211E+78"));
			Rows.Add( new xStageStatsRow("ID_663", "664", "1.88503E+52", "9.43E+52", "2.83E+53", "1.59E+54", "1.74E+78", "1.73688E+79"));
			Rows.Add( new xStageStatsRow("ID_664", "665", "2.26203E+52", "1.36E+53", "3.62E+53", "1.95E+54", "2.27E+78", "3.40128E+79"));
			Rows.Add( new xStageStatsRow("ID_665", "666", "2.71444E+52", "5.43E+52", "3.26E+53", "2.27E+54", "2.96E+78", "5.92054E+78"));
			Rows.Add( new xStageStatsRow("ID_666", "667", "3.25733E+52", "9.77E+52", "4.23E+53", "2.70E+54", "3.86E+78", "1.1594E+79"));
			Rows.Add( new xStageStatsRow("ID_667", "668", "3.90879E+52", "1.56E+53", "5.47E+53", "3.25E+54", "5.05E+78", "2.52269E+79"));
			Rows.Add( new xStageStatsRow("ID_668", "669", "4.69055E+52", "2.35E+53", "7.04E+53", "3.95E+54", "6.59E+78", "6.58679E+79"));
			Rows.Add( new xStageStatsRow("ID_669", "670", "5.62866E+52", "3.38E+53", "9.01E+53", "4.85E+54", "8.6E+78", "1.28987E+80"));
			Rows.Add( new xStageStatsRow("ID_670", "671", "6.75439E+52", "1.35E+53", "8.11E+53", "5.66E+54", "1.12E+79", "2.24525E+79"));
			Rows.Add( new xStageStatsRow("ID_671", "672", "8.10527E+52", "2.43E+53", "1.05E+54", "6.71E+54", "1.47E+79", "4.39681E+79"));
			Rows.Add( new xStageStatsRow("ID_672", "673", "9.72632E+52", "3.89E+53", "1.36E+54", "8.08E+54", "1.91E+79", "9.56681E+79"));
			Rows.Add( new xStageStatsRow("ID_673", "674", "1.16716E+53", "5.84E+53", "1.75E+54", "9.83E+54", "2.5E+79", "2.49792E+80"));
			Rows.Add( new xStageStatsRow("ID_674", "675", "1.40059E+53", "8.40E+53", "2.24E+54", "1.21E+55", "3.26E+79", "4.89159E+80"));
			Rows.Add( new xStageStatsRow("ID_675", "676", "1.68071E+53", "3.36E+53", "2.02E+54", "1.41E+55", "4.26E+79", "8.5147E+79"));
			Rows.Add( new xStageStatsRow("ID_676", "677", "2.01685E+53", "6.05E+53", "2.62E+54", "1.67E+55", "5.56E+79", "1.66741E+80"));
			Rows.Add( new xStageStatsRow("ID_677", "678", "2.42022E+53", "9.68E+53", "3.39E+54", "2.01E+55", "7.26E+79", "3.62803E+80"));
			Rows.Add( new xStageStatsRow("ID_678", "679", "2.90426E+53", "1.45E+54", "4.36E+54", "2.45E+55", "9.47E+79", "9.47287E+80"));
			Rows.Add( new xStageStatsRow("ID_679", "680", "3.48512E+53", "2.09E+54", "5.58E+54", "3.00E+55", "1.24E+80", "1.85504E+81"));
			Rows.Add( new xStageStatsRow("ID_680", "681", "4.18214E+53", "8.36E+53", "5.02E+54", "3.50E+55", "1.61E+80", "3.22904E+80"));
			Rows.Add( new xStageStatsRow("ID_681", "682", "5.01857E+53", "1.51E+54", "6.52E+54", "4.16E+55", "2.11E+80", "6.32332E+80"));
			Rows.Add( new xStageStatsRow("ID_682", "683", "6.02228E+53", "2.41E+54", "8.43E+54", "5.00E+55", "2.75E+80", "1.37586E+81"));
			Rows.Add( new xStageStatsRow("ID_683", "684", "7.22674E+53", "3.61E+54", "1.08E+55", "6.08E+55", "3.59E+80", "3.59241E+81"));
			Rows.Add( new xStageStatsRow("ID_684", "685", "8.67209E+53", "5.20E+54", "1.39E+55", "7.47E+55", "4.69E+80", "7.03489E+81"));
			Rows.Add( new xStageStatsRow("ID_685", "686", "1.04065E+54", "2.08E+54", "1.25E+55", "8.72E+55", "6.12E+80", "1.22455E+81"));
			Rows.Add( new xStageStatsRow("ID_686", "687", "1.24878E+54", "3.75E+54", "1.62E+55", "1.03E+56", "7.99E+80", "2.398E+81"));
			Rows.Add( new xStageStatsRow("ID_687", "688", "1.49854E+54", "5.99E+54", "2.10E+55", "1.24E+56", "1.04E+81", "5.21769E+81"));
			Rows.Add( new xStageStatsRow("ID_688", "689", "1.79824E+54", "8.99E+54", "2.70E+55", "1.51E+56", "1.36E+81", "1.36235E+82"));
			Rows.Add( new xStageStatsRow("ID_689", "690", "2.15789E+54", "1.29E+55", "3.45E+55", "1.86E+56", "1.78E+81", "2.66785E+82"));
			Rows.Add( new xStageStatsRow("ID_690", "691", "2.58947E+54", "5.18E+54", "3.11E+55", "2.17E+56", "2.32E+81", "4.64388E+81"));
			Rows.Add( new xStageStatsRow("ID_691", "692", "3.10736E+54", "9.32E+54", "4.04E+55", "2.57E+56", "3.03E+81", "9.09396E+81"));
			Rows.Add( new xStageStatsRow("ID_692", "693", "3.72884E+54", "1.49E+55", "5.22E+55", "3.10E+56", "3.96E+81", "1.97871E+82"));
			Rows.Add( new xStageStatsRow("ID_693", "694", "4.47461E+54", "2.24E+55", "6.71E+55", "3.77E+56", "5.17E+81", "5.16646E+82"));
			Rows.Add( new xStageStatsRow("ID_694", "695", "5.36953E+54", "3.22E+55", "8.59E+55", "4.63E+56", "6.74E+81", "1.01173E+83"));
			Rows.Add( new xStageStatsRow("ID_695", "696", "6.44343E+54", "1.29E+55", "7.73E+55", "5.40E+56", "8.81E+81", "1.7611E+82"));
			Rows.Add( new xStageStatsRow("ID_696", "697", "7.73212E+54", "2.32E+55", "1.01E+56", "6.40E+56", "1.15E+82", "3.44871E+82"));
			Rows.Add( new xStageStatsRow("ID_697", "698", "9.27854E+54", "3.71E+55", "1.30E+56", "7.70E+56", "1.5E+82", "7.50389E+82"));
			Rows.Add( new xStageStatsRow("ID_698", "699", "1.11343E+55", "5.57E+55", "1.67E+56", "9.37E+56", "1.96E+82", "1.95928E+83"));
			Rows.Add( new xStageStatsRow("ID_699", "700", "1.33611E+55", "8.02E+55", "2.14E+56", "1.15E+57", "2.56E+82", "3.8368E+83"));
			Rows.Add( new xStageStatsRow("ID_700", "701", "1.60333E+55", "3.21E+55", "1.92E+56", "1.34E+57", "3.34E+82", "6.67865E+82"));
			Rows.Add( new xStageStatsRow("ID_701", "702", "1.924E+55", "5.77E+55", "2.50E+56", "1.59E+57", "4.36E+82", "1.30786E+83"));
			Rows.Add( new xStageStatsRow("ID_702", "703", "2.3088E+55", "9.24E+55", "3.23E+56", "1.92E+57", "5.69E+82", "2.84571E+83"));
			Rows.Add( new xStageStatsRow("ID_703", "704", "2.77056E+55", "1.39E+56", "4.16E+56", "2.33E+57", "7.43E+82", "7.43021E+83"));
			Rows.Add( new xStageStatsRow("ID_704", "705", "3.32467E+55", "1.99E+56", "5.32E+56", "2.86E+57", "9.7E+82", "1.45503E+84"));
			Rows.Add( new xStageStatsRow("ID_705", "706", "3.9896E+55", "7.98E+55", "4.79E+56", "3.34E+57", "1.27E+83", "2.53275E+83"));
			Rows.Add( new xStageStatsRow("ID_706", "707", "4.78752E+55", "1.44E+56", "6.22E+56", "3.97E+57", "1.65E+83", "4.9598E+83"));
			Rows.Add( new xStageStatsRow("ID_707", "708", "5.74503E+55", "2.30E+56", "8.04E+56", "4.77E+57", "2.16E+83", "1.07918E+84"));
			Rows.Add( new xStageStatsRow("ID_708", "709", "6.89403E+55", "3.45E+56", "1.03E+57", "5.80E+57", "2.82E+83", "2.81776E+84"));
			Rows.Add( new xStageStatsRow("ID_709", "710", "8.27284E+55", "4.96E+56", "1.32E+57", "7.13E+57", "3.68E+83", "5.51794E+84"));
			Rows.Add( new xStageStatsRow("ID_710", "711", "9.92741E+55", "1.99E+56", "1.19E+57", "8.32E+57", "4.8E+83", "9.60497E+83"));
			Rows.Add( new xStageStatsRow("ID_711", "712", "1.19129E+56", "3.57E+56", "1.55E+57", "9.87E+57", "6.27E+83", "1.88091E+84"));
			Rows.Add( new xStageStatsRow("ID_712", "713", "1.42955E+56", "5.72E+56", "2.00E+57", "1.19E+58", "8.19E+83", "4.09259E+84"));
			Rows.Add( new xStageStatsRow("ID_713", "714", "1.71546E+56", "8.58E+56", "2.57E+57", "1.44E+58", "1.07E+84", "1.06858E+85"));
			Rows.Add( new xStageStatsRow("ID_714", "715", "2.05855E+56", "1.24E+57", "3.29E+57", "1.77E+58", "1.4E+84", "2.09257E+85"));
			Rows.Add( new xStageStatsRow("ID_715", "716", "2.47026E+56", "4.94E+56", "2.96E+57", "2.07E+58", "1.82E+84", "3.6425E+84"));
			Rows.Add( new xStageStatsRow("ID_716", "717", "2.96431E+56", "8.89E+56", "3.85E+57", "2.46E+58", "2.38E+84", "7.133E+84"));
			Rows.Add( new xStageStatsRow("ID_717", "718", "3.55717E+56", "1.42E+57", "4.98E+57", "2.95E+58", "3.1E+84", "1.55204E+85"));
			Rows.Add( new xStageStatsRow("ID_718", "719", "4.2686E+56", "2.13E+57", "6.40E+57", "3.59E+58", "4.05E+84", "4.0524E+85"));
			Rows.Add( new xStageStatsRow("ID_719", "720", "5.12233E+56", "3.07E+57", "8.20E+57", "4.41E+58", "5.29E+84", "7.93568E+85"));
			Rows.Add( new xStageStatsRow("ID_720", "721", "6.14679E+56", "1.23E+57", "7.38E+57", "5.15E+58", "6.91E+84", "1.38135E+85"));
			Rows.Add( new xStageStatsRow("ID_721", "722", "7.37615E+56", "2.21E+57", "9.59E+57", "6.11E+58", "9.02E+84", "2.70505E+85"));
			Rows.Add( new xStageStatsRow("ID_722", "723", "8.85138E+56", "3.54E+57", "1.24E+58", "7.35E+58", "1.18E+85", "5.8858E+85"));
			Rows.Add( new xStageStatsRow("ID_723", "724", "1.06217E+57", "5.31E+57", "1.59E+58", "8.94E+58", "1.54E+85", "1.5368E+86"));
			Rows.Add( new xStageStatsRow("ID_724", "725", "1.2746E+57", "7.65E+57", "2.04E+58", "1.10E+59", "2.01E+85", "3.00946E+86"));
			Rows.Add( new xStageStatsRow("ID_725", "726", "1.52952E+57", "3.06E+57", "1.84E+58", "1.28E+59", "2.62E+85", "5.23851E+85"));
			Rows.Add( new xStageStatsRow("ID_726", "727", "1.83542E+57", "5.51E+57", "2.39E+58", "1.52E+59", "3.42E+85", "1.02584E+86"));
			Rows.Add( new xStageStatsRow("ID_727", "728", "2.20251E+57", "8.81E+57", "3.08E+58", "1.83E+59", "4.46E+85", "2.23208E+86"));
			Rows.Add( new xStageStatsRow("ID_728", "729", "2.64301E+57", "1.32E+58", "3.96E+58", "2.23E+59", "5.83E+85", "5.82801E+86"));
			Rows.Add( new xStageStatsRow("ID_729", "730", "3.17161E+57", "1.90E+58", "5.07E+58", "2.73E+59", "7.61E+85", "1.14128E+87"));
			Rows.Add( new xStageStatsRow("ID_730", "731", "3.80593E+57", "7.61E+57", "4.57E+58", "3.19E+59", "9.93E+85", "1.98661E+86"));
			Rows.Add( new xStageStatsRow("ID_731", "732", "4.56712E+57", "1.37E+58", "5.94E+58", "3.78E+59", "1.3E+86", "3.8903E+86"));
			Rows.Add( new xStageStatsRow("ID_732", "733", "5.48054E+57", "2.19E+58", "7.67E+58", "4.55E+59", "1.69E+86", "8.46473E+86"));
			Rows.Add( new xStageStatsRow("ID_733", "734", "6.57665E+57", "3.29E+58", "9.86E+58", "5.54E+59", "2.21E+86", "2.21016E+87"));
			Rows.Add( new xStageStatsRow("ID_734", "735", "7.89198E+57", "4.74E+58", "1.26E+59", "6.80E+59", "2.89E+86", "4.32809E+87"));
			Rows.Add( new xStageStatsRow("ID_735", "736", "9.47037E+57", "1.89E+58", "1.14E+59", "7.94E+59", "3.77E+86", "7.53382E+86"));
			Rows.Add( new xStageStatsRow("ID_736", "737", "1.13644E+58", "3.41E+58", "1.48E+59", "9.41E+59", "4.92E+86", "1.47532E+87"));
			Rows.Add( new xStageStatsRow("ID_737", "738", "1.36373E+58", "5.45E+58", "1.91E+59", "1.13E+60", "6.42E+86", "3.21009E+87"));
			Rows.Add( new xStageStatsRow("ID_738", "739", "1.63648E+58", "8.18E+58", "2.45E+59", "1.38E+60", "8.38E+86", "8.38162E+87"));
			Rows.Add( new xStageStatsRow("ID_739", "740", "1.96378E+58", "1.18E+59", "3.14E+59", "1.69E+60", "1.09E+87", "1.64134E+88"));
			Rows.Add( new xStageStatsRow("ID_740", "741", "2.35653E+58", "4.71E+58", "2.83E+59", "1.97E+60", "1.43E+87", "2.85706E+87"));
			Rows.Add( new xStageStatsRow("ID_741", "742", "2.82784E+58", "8.48E+58", "3.68E+59", "2.34E+60", "1.86E+87", "5.59489E+87"));
			Rows.Add( new xStageStatsRow("ID_742", "743", "3.39341E+58", "1.36E+59", "4.75E+59", "2.82E+60", "2.43E+87", "1.21736E+88"));
			Rows.Add( new xStageStatsRow("ID_743", "744", "4.07209E+58", "2.04E+59", "6.11E+59", "3.43E+60", "3.18E+87", "3.17857E+88"));
			Rows.Add( new xStageStatsRow("ID_744", "745", "4.8865E+58", "2.93E+59", "7.82E+59", "4.21E+60", "4.15E+87", "6.22449E+88"));
			Rows.Add( new xStageStatsRow("ID_745", "746", "5.86381E+58", "1.17E+59", "7.04E+59", "4.91E+60", "5.42E+87", "1.08349E+88"));
			Rows.Add( new xStageStatsRow("ID_746", "747", "7.03657E+58", "2.11E+59", "9.15E+59", "5.83E+60", "7.07E+87", "2.12175E+88"));
			Rows.Add( new xStageStatsRow("ID_747", "748", "8.44388E+58", "3.38E+59", "1.18E+60", "7.01E+60", "9.23E+87", "4.61663E+88"));
			Rows.Add( new xStageStatsRow("ID_748", "749", "1.01327E+59", "5.07E+59", "1.52E+60", "8.53E+60", "1.21E+88", "1.20541E+89"));
			Rows.Add( new xStageStatsRow("ID_749", "750", "1.21592E+59", "7.30E+59", "1.95E+60", "1.05E+61", "1.57E+88", "2.36052E+89"));
			Rows.Add( new xStageStatsRow("ID_750", "751", "1.4591E+59", "2.92E+59", "1.75E+60", "1.22E+61", "2.05E+88", "4.10891E+88"));
			Rows.Add( new xStageStatsRow("ID_751", "752", "1.75092E+59", "5.25E+59", "2.28E+60", "1.45E+61", "2.68E+88", "8.04635E+88"));
			Rows.Add( new xStageStatsRow("ID_752", "753", "2.10111E+59", "8.40E+59", "2.94E+60", "1.74E+61", "3.5E+88", "1.75077E+89"));
			Rows.Add( new xStageStatsRow("ID_753", "754", "2.52133E+59", "1.26E+60", "3.78E+60", "2.12E+61", "4.57E+88", "4.57129E+89"));
			Rows.Add( new xStageStatsRow("ID_754", "755", "3.02559E+59", "1.82E+60", "4.84E+60", "2.61E+61", "5.97E+88", "8.95182E+89"));
			Rows.Add( new xStageStatsRow("ID_755", "756", "3.63071E+59", "7.26E+59", "4.36E+60", "3.04E+61", "7.79E+88", "1.55823E+89"));
			Rows.Add( new xStageStatsRow("ID_756", "757", "4.35686E+59", "1.31E+60", "5.66E+60", "3.61E+61", "1.02E+89", "3.05143E+89"));
			Rows.Add( new xStageStatsRow("ID_757", "758", "5.22823E+59", "2.09E+60", "7.32E+60", "4.34E+61", "1.33E+89", "6.63945E+89"));
			Rows.Add( new xStageStatsRow("ID_758", "759", "6.27387E+59", "3.14E+60", "9.41E+60", "5.28E+61", "1.73E+89", "1.73358E+90"));
			Rows.Add( new xStageStatsRow("ID_759", "760", "7.52865E+59", "4.52E+60", "1.20E+61", "6.49E+61", "2.26E+89", "3.39481E+90"));
			Rows.Add( new xStageStatsRow("ID_760", "761", "9.03438E+59", "1.81E+60", "1.08E+61", "7.57E+61", "2.95E+89", "5.90928E+89"));
			Rows.Add( new xStageStatsRow("ID_761", "762", "1.08413E+60", "3.25E+60", "1.41E+61", "8.98E+61", "3.86E+89", "1.1572E+90"));
			Rows.Add( new xStageStatsRow("ID_762", "763", "1.30095E+60", "5.20E+60", "1.82E+61", "1.08E+62", "5.04E+89", "2.51789E+90"));
			Rows.Add( new xStageStatsRow("ID_763", "764", "1.56114E+60", "7.81E+60", "2.34E+61", "1.31E+62", "6.57E+89", "6.57426E+90"));
			Rows.Add( new xStageStatsRow("ID_764", "765", "1.87337E+60", "1.12E+61", "3.00E+61", "1.61E+62", "8.58E+89", "1.28742E+91"));
			Rows.Add( new xStageStatsRow("ID_765", "766", "2.24804E+60", "4.50E+60", "2.70E+61", "1.88E+62", "1.12E+90", "2.24098E+90"));
			Rows.Add( new xStageStatsRow("ID_766", "767", "2.69765E+60", "8.09E+60", "3.51E+61", "2.23E+62", "1.46E+90", "4.38844E+90"));
			Rows.Add( new xStageStatsRow("ID_767", "768", "3.23718E+60", "1.29E+61", "4.53E+61", "2.69E+62", "1.91E+90", "9.54861E+90"));
			Rows.Add( new xStageStatsRow("ID_768", "769", "3.88462E+60", "1.94E+61", "5.83E+61", "3.27E+62", "2.49E+90", "2.49316E+91"));
			Rows.Add( new xStageStatsRow("ID_769", "770", "4.66154E+60", "2.80E+61", "7.46E+61", "4.02E+62", "3.25E+90", "4.88228E+91"));
			Rows.Add( new xStageStatsRow("ID_770", "771", "5.59385E+60", "1.12E+61", "6.71E+61", "4.69E+62", "4.25E+90", "8.4985E+90"));
			Rows.Add( new xStageStatsRow("ID_771", "772", "6.71262E+60", "2.01E+61", "8.73E+61", "5.56E+62", "5.55E+90", "1.66423E+91"));
			Rows.Add( new xStageStatsRow("ID_772", "773", "8.05514E+60", "3.22E+61", "1.13E+62", "6.69E+62", "7.24E+90", "3.62113E+91"));
			Rows.Add( new xStageStatsRow("ID_773", "774", "9.66617E+60", "4.83E+61", "1.45E+62", "8.14E+62", "9.45E+90", "9.45485E+91"));
			Rows.Add( new xStageStatsRow("ID_774", "775", "1.15994E+61", "6.96E+61", "1.86E+62", "9.99E+62", "1.23E+91", "1.85151E+92"));
			Rows.Add( new xStageStatsRow("ID_775", "776", "1.39193E+61", "2.78E+61", "1.67E+62", "1.17E+63", "1.61E+91", "3.22289E+91"));
			Rows.Add( new xStageStatsRow("ID_776", "777", "1.67031E+61", "5.01E+61", "2.17E+62", "1.38E+63", "2.1E+91", "6.31129E+91"));
			Rows.Add( new xStageStatsRow("ID_777", "778", "2.00438E+61", "8.02E+61", "2.81E+62", "1.66E+63", "2.75E+91", "1.37324E+92"));
			Rows.Add( new xStageStatsRow("ID_778", "779", "2.40525E+61", "1.20E+62", "3.61E+62", "2.02E+63", "3.59E+91", "3.58557E+92"));
			Rows.Add( new xStageStatsRow("ID_779", "780", "2.8863E+61", "1.73E+62", "4.62E+62", "2.49E+63", "4.68E+91", "7.02151E+92"));
			Rows.Add( new xStageStatsRow("ID_780", "781", "3.46356E+61", "6.93E+61", "4.16E+62", "2.90E+63", "6.11E+91", "1.22222E+92"));
			Rows.Add( new xStageStatsRow("ID_781", "782", "4.15628E+61", "1.25E+62", "5.40E+62", "3.44E+63", "7.98E+91", "2.39344E+92"));
			Rows.Add( new xStageStatsRow("ID_782", "783", "4.98753E+61", "2.00E+62", "6.98E+62", "4.14E+63", "1.04E+92", "5.20777E+92"));
			Rows.Add( new xStageStatsRow("ID_783", "784", "5.98504E+61", "2.99E+62", "8.98E+62", "5.04E+63", "1.36E+92", "1.35976E+93"));
			Rows.Add( new xStageStatsRow("ID_784", "785", "7.18205E+61", "4.31E+62", "1.15E+63", "6.19E+63", "1.78E+92", "2.66277E+93"));
			Rows.Add( new xStageStatsRow("ID_785", "786", "8.61845E+61", "1.72E+62", "1.03E+63", "7.22E+63", "2.32E+92", "4.63504E+92"));
			Rows.Add( new xStageStatsRow("ID_786", "787", "1.03421E+62", "3.10E+62", "1.34E+63", "8.57E+63", "3.03E+92", "9.07665E+92"));
			Rows.Add( new xStageStatsRow("ID_787", "788", "1.24106E+62", "4.96E+62", "1.74E+63", "1.03E+64", "3.95E+92", "1.97495E+93"));
			Rows.Add( new xStageStatsRow("ID_788", "789", "1.48927E+62", "7.45E+62", "2.23E+63", "1.25E+64", "5.16E+92", "5.15663E+93"));
			Rows.Add( new xStageStatsRow("ID_789", "790", "1.78712E+62", "1.07E+63", "2.86E+63", "1.54E+64", "6.73E+92", "1.00981E+94"));
			Rows.Add( new xStageStatsRow("ID_790", "791", "2.14455E+62", "4.29E+62", "2.57E+63", "1.80E+64", "8.79E+92", "1.75775E+93"));
			Rows.Add( new xStageStatsRow("ID_791", "792", "2.57346E+62", "7.72E+62", "3.35E+63", "2.13E+64", "1.15E+93", "3.44215E+93"));
			Rows.Add( new xStageStatsRow("ID_792", "793", "3.08815E+62", "1.24E+63", "4.32E+63", "2.56E+64", "1.5E+93", "7.48961E+93"));
			Rows.Add( new xStageStatsRow("ID_793", "794", "3.70578E+62", "1.85E+63", "5.56E+63", "3.12E+64", "1.96E+93", "1.95555E+94"));
			Rows.Add( new xStageStatsRow("ID_794", "795", "4.44693E+62", "2.67E+63", "7.12E+63", "3.83E+64", "2.55E+93", "3.8295E+94"));
			Rows.Add( new xStageStatsRow("ID_795", "796", "5.33632E+62", "1.07E+63", "6.40E+63", "4.47E+64", "3.33E+93", "6.66594E+93"));
			Rows.Add( new xStageStatsRow("ID_796", "797", "6.40358E+62", "1.92E+63", "8.32E+63", "5.30E+64", "4.35E+93", "1.30537E+94"));
			Rows.Add( new xStageStatsRow("ID_797", "798", "7.6843E+62", "3.07E+63", "1.08E+64", "6.38E+64", "5.68E+93", "2.84029E+94"));
			Rows.Add( new xStageStatsRow("ID_798", "799", "9.22116E+62", "4.61E+63", "1.38E+64", "7.76E+64", "7.42E+93", "7.41607E+94"));
			Rows.Add( new xStageStatsRow("ID_799", "800", "1.10654E+63", "6.64E+63", "1.77E+64", "9.53E+64", "9.68E+93", "1.45226E+95"));
			Rows.Add( new xStageStatsRow("ID_800", "801", "1.32785E+63", "2.66E+63", "1.59E+64", "1.11E+65", "1.26E+94", "2.52793E+94"));
			Rows.Add( new xStageStatsRow("ID_801", "802", "1.59342E+63", "4.78E+63", "2.07E+64", "1.32E+65", "1.65E+94", "4.95037E+94"));
			Rows.Add( new xStageStatsRow("ID_802", "803", "1.9121E+63", "7.65E+63", "2.68E+64", "1.59E+65", "2.15E+94", "1.07713E+95"));
			Rows.Add( new xStageStatsRow("ID_803", "804", "2.29452E+63", "1.15E+64", "3.44E+64", "1.93E+65", "2.81E+94", "2.8124E+95"));
			Rows.Add( new xStageStatsRow("ID_804", "805", "2.75342E+63", "1.65E+64", "4.41E+64", "2.37E+65", "3.67E+94", "5.50744E+95"));
			Rows.Add( new xStageStatsRow("ID_805", "806", "3.30411E+63", "6.61E+63", "3.96E+64", "2.77E+65", "4.79E+94", "9.5867E+94"));
			Rows.Add( new xStageStatsRow("ID_806", "807", "3.96493E+63", "1.19E+64", "5.15E+64", "3.28E+65", "6.26E+94", "1.87733E+95"));
			Rows.Add( new xStageStatsRow("ID_807", "808", "4.75792E+63", "1.90E+64", "6.66E+64", "3.95E+65", "8.17E+94", "4.0848E+95"));
			Rows.Add( new xStageStatsRow("ID_808", "809", "5.7095E+63", "2.85E+64", "8.56E+64", "4.81E+65", "1.07E+95", "1.06655E+96"));
			Rows.Add( new xStageStatsRow("ID_809", "810", "6.8514E+63", "4.11E+64", "1.10E+65", "5.90E+65", "1.39E+95", "2.08859E+96"));
			Rows.Add( new xStageStatsRow("ID_810", "811", "8.22168E+63", "1.64E+64", "9.87E+64", "6.89E+65", "1.82E+95", "3.63557E+95"));
			Rows.Add( new xStageStatsRow("ID_811", "812", "9.86602E+63", "2.96E+64", "1.28E+65", "8.17E+65", "2.37E+95", "7.11943E+95"));
			Rows.Add( new xStageStatsRow("ID_812", "813", "1.18392E+64", "4.74E+64", "1.66E+65", "9.83E+65", "3.1E+95", "1.54908E+96"));
			Rows.Add( new xStageStatsRow("ID_813", "814", "1.42071E+64", "7.10E+64", "2.13E+65", "1.20E+66", "4.04E+95", "4.04469E+96"));
			Rows.Add( new xStageStatsRow("ID_814", "815", "1.70485E+64", "1.02E+65", "2.73E+65", "1.47E+66", "5.28E+95", "7.92059E+96"));
			Rows.Add( new xStageStatsRow("ID_815", "816", "2.04582E+64", "4.09E+64", "2.45E+65", "1.71E+66", "6.89E+95", "1.37872E+96"));
			Rows.Add( new xStageStatsRow("ID_816", "817", "2.45498E+64", "7.36E+64", "3.19E+65", "2.03E+66", "9E+95", "2.69991E+96"));
			Rows.Add( new xStageStatsRow("ID_817", "818", "2.94598E+64", "1.18E+65", "4.12E+65", "2.45E+66", "1.17E+96", "5.8746E+96"));
			Rows.Add( new xStageStatsRow("ID_818", "819", "3.53517E+64", "1.77E+65", "5.30E+65", "2.98E+66", "1.53E+96", "1.53387E+97"));
			Rows.Add( new xStageStatsRow("ID_819", "820", "4.24221E+64", "2.55E+65", "6.79E+65", "3.65E+66", "2E+96", "3.00373E+97"));
			Rows.Add( new xStageStatsRow("ID_820", "821", "5.09065E+64", "1.02E+65", "6.11E+65", "4.27E+66", "2.61E+96", "5.22854E+96"));
			Rows.Add( new xStageStatsRow("ID_821", "822", "6.10878E+64", "1.83E+65", "7.94E+65", "5.06E+66", "3.41E+96", "1.02389E+97"));
			Rows.Add( new xStageStatsRow("ID_822", "823", "7.33053E+64", "2.93E+65", "1.03E+66", "6.09E+66", "4.46E+96", "2.22783E+97"));
			Rows.Add( new xStageStatsRow("ID_823", "824", "8.79664E+64", "4.40E+65", "1.32E+66", "7.41E+66", "5.82E+96", "5.81692E+97"));
			Rows.Add( new xStageStatsRow("ID_824", "825", "1.0556E+65", "6.33E+65", "1.69E+66", "9.09E+66", "7.59E+96", "1.13911E+98"));
			Rows.Add( new xStageStatsRow("ID_825", "826", "1.26672E+65", "2.53E+65", "1.52E+66", "1.06E+67", "9.91E+96", "1.98283E+97"));
			Rows.Add( new xStageStatsRow("ID_826", "827", "1.52006E+65", "4.56E+65", "1.98E+66", "1.26E+67", "1.29E+97", "3.8829E+97"));
			Rows.Add( new xStageStatsRow("ID_827", "828", "1.82407E+65", "7.30E+65", "2.55E+66", "1.51E+67", "1.69E+97", "8.44862E+97"));
			Rows.Add( new xStageStatsRow("ID_828", "829", "2.18889E+65", "1.09E+66", "3.28E+66", "1.84E+67", "2.21E+97", "2.20596E+98"));
			Rows.Add( new xStageStatsRow("ID_829", "830", "2.62666E+65", "1.58E+66", "4.20E+66", "2.26E+67", "2.88E+97", "4.31985E+98"));
			Rows.Add( new xStageStatsRow("ID_830", "831", "3.15199E+65", "6.30E+65", "3.78E+66", "2.64E+67", "3.76E+97", "7.51949E+97"));
			Rows.Add( new xStageStatsRow("ID_831", "832", "3.78239E+65", "1.13E+66", "4.92E+66", "3.13E+67", "4.91E+97", "1.47252E+98"));
			Rows.Add( new xStageStatsRow("ID_832", "833", "4.53887E+65", "1.82E+66", "6.35E+66", "3.77E+67", "6.41E+97", "3.20398E+98"));
			Rows.Add( new xStageStatsRow("ID_833", "834", "5.44665E+65", "2.72E+66", "8.17E+66", "4.59E+67", "8.37E+97", "8.36567E+98"));
			Rows.Add( new xStageStatsRow("ID_834", "835", "6.53598E+65", "3.92E+66", "1.05E+67", "5.63E+67", "1.09E+98", "1.63822E+99"));
			Rows.Add( new xStageStatsRow("ID_835", "836", "7.84317E+65", "1.57E+66", "9.41E+66", "6.57E+67", "1.43E+98", "2.85162E+98"));
			Rows.Add( new xStageStatsRow("ID_836", "837", "9.41181E+65", "2.82E+66", "1.22E+67", "7.80E+67", "1.86E+98", "5.58424E+98"));
			Rows.Add( new xStageStatsRow("ID_837", "838", "1.12942E+66", "4.52E+66", "1.58E+67", "9.38E+67", "2.43E+98", "1.21505E+99"));
			Rows.Add( new xStageStatsRow("ID_838", "839", "1.3553E+66", "6.78E+66", "2.03E+67", "1.14E+68", "3.17E+98", "3.17252E+99"));
			Rows.Add( new xStageStatsRow("ID_839", "840", "1.62636E+66", "9.76E+66", "2.60E+67", "1.40E+68", "4.14E+98", "6.21264E+99"));
			Rows.Add( new xStageStatsRow("ID_840", "841", "1.95163E+66", "3.90E+66", "2.34E+67", "1.64E+68", "5.41E+98", "1.08142E+99"));
			Rows.Add( new xStageStatsRow("ID_841", "842", "2.34196E+66", "7.03E+66", "3.04E+67", "1.94E+68", "7.06E+98", "2.11772E+99"));
			Rows.Add( new xStageStatsRow("ID_842", "843", "2.81035E+66", "1.12E+67", "3.93E+67", "2.33E+68", "9.22E+98", "4.60784E+99"));
			Rows.Add( new xStageStatsRow("ID_843", "844", "3.37242E+66", "1.69E+67", "5.06E+67", "2.84E+68", "1.2E+99", "1.20312E+100"));
			Rows.Add( new xStageStatsRow("ID_844", "845", "4.0469E+66", "2.43E+67", "6.48E+67", "3.49E+68", "1.57E+99", "2.35603E+100"));
			Rows.Add( new xStageStatsRow("ID_845", "846", "4.85628E+66", "9.71E+66", "5.83E+67", "4.07E+68", "2.05E+99", "4.1011E+99"));
			Rows.Add( new xStageStatsRow("ID_846", "847", "5.82754E+66", "1.75E+67", "7.58E+67", "4.83E+68", "2.68E+99", "8.03104E+99"));
			Rows.Add( new xStageStatsRow("ID_847", "848", "6.99305E+66", "2.80E+67", "9.79E+67", "5.81E+68", "3.49E+99", "1.74744E+100"));
			Rows.Add( new xStageStatsRow("ID_848", "849", "8.39166E+66", "4.20E+67", "1.26E+68", "7.06E+68", "4.56E+99", "4.5626E+100"));
			Rows.Add( new xStageStatsRow("ID_849", "850", "1.007E+67", "6.04E+67", "1.61E+68", "8.68E+68", "5.96E+99", "8.93479E+100"));
			Rows.Add( new xStageStatsRow("ID_850", "851", "1.2084E+67", "2.42E+67", "1.45E+68", "1.01E+69", "7.78E+99", "1.55526E+100"));
			Rows.Add( new xStageStatsRow("ID_851", "852", "1.45008E+67", "4.35E+67", "1.89E+68", "1.20E+69", "1.02E+100", "3.04562E+100"));
			Rows.Add( new xStageStatsRow("ID_852", "853", "1.74009E+67", "6.96E+67", "2.44E+68", "1.44E+69", "1.33E+100", "6.62682E+100"));
			Rows.Add( new xStageStatsRow("ID_853", "854", "2.08811E+67", "1.04E+68", "3.13E+68", "1.76E+69", "1.73E+100", "1.73028E+101"));
			Rows.Add( new xStageStatsRow("ID_854", "855", "2.50574E+67", "1.50E+68", "4.01E+68", "2.16E+69", "2.26E+100", "3.38835E+101"));
			Rows.Add( new xStageStatsRow("ID_855", "856", "3.00688E+67", "6.01E+67", "3.61E+68", "2.52E+69", "2.95E+100", "5.89804E+100"));
			Rows.Add( new xStageStatsRow("ID_856", "857", "3.60826E+67", "1.08E+68", "4.69E+68", "2.99E+69", "3.85E+100", "1.15499E+101"));
			Rows.Add( new xStageStatsRow("ID_857", "858", "4.32991E+67", "1.73E+68", "6.06E+68", "3.59E+69", "5.03E+100", "2.5131E+101"));
			Rows.Add( new xStageStatsRow("ID_858", "859", "5.19589E+67", "2.60E+68", "7.79E+68", "4.37E+69", "6.56E+100", "6.56175E+101"));
			Rows.Add( new xStageStatsRow("ID_859", "860", "6.23507E+67", "3.74E+68", "9.98E+68", "5.37E+69", "8.57E+100", "1.28497E+102"));
			Rows.Add( new xStageStatsRow("ID_860", "861", "7.48209E+67", "1.50E+68", "8.98E+68", "6.27E+69", "1.12E+101", "2.23672E+101"));
			Rows.Add( new xStageStatsRow("ID_861", "862", "8.97851E+67", "2.69E+68", "1.17E+69", "7.44E+69", "1.46E+101", "4.38009E+101"));
			Rows.Add( new xStageStatsRow("ID_862", "863", "1.07742E+68", "4.31E+68", "1.51E+69", "8.95E+69", "1.91E+101", "9.53044E+101"));
			Rows.Add( new xStageStatsRow("ID_863", "864", "1.2929E+68", "6.46E+68", "1.94E+69", "1.09E+70", "2.49E+101", "2.48842E+102"));
			Rows.Add( new xStageStatsRow("ID_864", "865", "1.55149E+68", "9.31E+68", "2.48E+69", "1.34E+70", "3.25E+101", "4.87299E+102"));
			Rows.Add( new xStageStatsRow("ID_865", "866", "1.86178E+68", "3.72E+68", "2.23E+69", "1.56E+70", "4.24E+101", "8.48233E+101"));
			Rows.Add( new xStageStatsRow("ID_866", "867", "2.23414E+68", "6.70E+68", "2.90E+69", "1.85E+70", "5.54E+101", "1.66107E+102"));
			Rows.Add( new xStageStatsRow("ID_867", "868", "2.68097E+68", "1.07E+69", "3.75E+69", "2.23E+70", "7.23E+101", "3.61424E+102"));
			Rows.Add( new xStageStatsRow("ID_868", "869", "3.21716E+68", "1.61E+69", "4.83E+69", "2.71E+70", "9.44E+101", "9.43686E+102"));
			Rows.Add( new xStageStatsRow("ID_869", "870", "3.86059E+68", "2.32E+69", "6.18E+69", "3.33E+70", "1.23E+102", "1.84799E+103"));
			Rows.Add( new xStageStatsRow("ID_870", "871", "4.63271E+68", "9.27E+68", "5.56E+69", "3.88E+70", "1.61E+102", "3.21676E+102"));
			Rows.Add( new xStageStatsRow("ID_871", "872", "5.55925E+68", "1.67E+69", "7.23E+69", "4.60E+70", "2.1E+102", "6.29928E+102"));
			Rows.Add( new xStageStatsRow("ID_872", "873", "6.67111E+68", "2.67E+69", "9.34E+69", "5.54E+70", "2.74E+102", "1.37063E+103"));
			Rows.Add( new xStageStatsRow("ID_873", "874", "8.00533E+68", "4.00E+69", "1.20E+70", "6.74E+70", "3.58E+102", "3.57875E+103"));
			Rows.Add( new xStageStatsRow("ID_874", "875", "9.60639E+68", "5.76E+69", "1.54E+70", "8.28E+70", "4.67E+102", "7.00815E+103"));
			Rows.Add( new xStageStatsRow("ID_875", "876", "1.15277E+69", "2.31E+69", "1.38E+70", "9.66E+70", "6.1E+102", "1.2199E+103"));
			Rows.Add( new xStageStatsRow("ID_876", "877", "1.38332E+69", "4.15E+69", "1.80E+70", "1.15E+71", "7.96E+102", "2.38888E+103"));
			Rows.Add( new xStageStatsRow("ID_877", "878", "1.65998E+69", "6.64E+69", "2.32E+70", "1.38E+71", "1.04E+103", "5.19786E+103"));
			Rows.Add( new xStageStatsRow("ID_878", "879", "1.99198E+69", "9.96E+69", "2.99E+70", "1.68E+71", "1.36E+103", "1.35717E+104"));
			Rows.Add( new xStageStatsRow("ID_879", "880", "2.39038E+69", "1.43E+70", "3.82E+70", "2.06E+71", "1.77E+103", "2.65771E+104"));
			Rows.Add( new xStageStatsRow("ID_880", "881", "2.86845E+69", "5.74E+69", "3.44E+70", "2.40E+71", "2.31E+103", "4.62622E+103"));
			Rows.Add( new xStageStatsRow("ID_881", "882", "3.44214E+69", "1.03E+70", "4.47E+70", "2.85E+71", "3.02E+103", "9.05939E+103"));
			Rows.Add( new xStageStatsRow("ID_882", "883", "4.13057E+69", "1.65E+70", "5.78E+70", "3.43E+71", "3.94E+103", "1.97119E+104"));
			Rows.Add( new xStageStatsRow("ID_883", "884", "4.95669E+69", "2.48E+70", "7.44E+70", "4.17E+71", "5.15E+103", "5.14682E+104"));
			Rows.Add( new xStageStatsRow("ID_884", "885", "5.94802E+69", "3.57E+70", "9.52E+70", "5.12E+71", "6.72E+103", "1.00789E+105"));
			Rows.Add( new xStageStatsRow("ID_885", "886", "7.13763E+69", "1.43E+70", "8.57E+70", "5.98E+71", "8.77E+103", "1.75441E+104"));
			Rows.Add( new xStageStatsRow("ID_886", "887", "8.56516E+69", "2.57E+70", "1.11E+71", "7.09E+71", "1.15E+104", "3.4356E+104"));
			Rows.Add( new xStageStatsRow("ID_887", "888", "1.02782E+70", "4.11E+70", "1.44E+71", "8.53E+71", "1.5E+104", "7.47536E+104"));
			Rows.Add( new xStageStatsRow("ID_888", "889", "1.23338E+70", "6.17E+70", "1.85E+71", "1.04E+72", "1.95E+104", "1.95183E+105"));
			Rows.Add( new xStageStatsRow("ID_889", "890", "1.48006E+70", "8.88E+70", "2.37E+71", "1.28E+72", "2.55E+104", "3.82221E+105"));
			Rows.Add( new xStageStatsRow("ID_890", "891", "1.77607E+70", "3.55E+70", "2.13E+71", "1.49E+72", "3.33E+104", "6.65326E+104"));
			Rows.Add( new xStageStatsRow("ID_891", "892", "2.13128E+70", "6.39E+70", "2.77E+71", "1.77E+72", "4.34E+104", "1.30289E+105"));
			Rows.Add( new xStageStatsRow("ID_892", "893", "2.55754E+70", "1.02E+71", "3.58E+71", "2.12E+72", "5.67E+104", "2.83489E+105"));
			Rows.Add( new xStageStatsRow("ID_893", "894", "3.06905E+70", "1.53E+71", "4.60E+71", "2.58E+72", "7.4E+104", "7.40196E+105"));
			Rows.Add( new xStageStatsRow("ID_894", "895", "3.68286E+70", "2.21E+71", "5.89E+71", "3.17E+72", "9.66E+104", "1.4495E+106"));
			Rows.Add( new xStageStatsRow("ID_895", "896", "4.41943E+70", "8.84E+70", "5.30E+71", "3.70E+72", "1.26E+105", "2.52312E+105"));
			Rows.Add( new xStageStatsRow("ID_896", "897", "5.30332E+70", "1.59E+71", "6.89E+71", "4.39E+72", "1.65E+105", "4.94095E+105"));
			Rows.Add( new xStageStatsRow("ID_897", "898", "6.36398E+70", "2.55E+71", "8.91E+71", "5.28E+72", "2.15E+105", "1.07508E+106"));
			Rows.Add( new xStageStatsRow("ID_898", "899", "7.63678E+70", "3.82E+71", "1.15E+72", "6.43E+72", "2.81E+105", "2.80705E+106"));
			Rows.Add( new xStageStatsRow("ID_899", "900", "9.16413E+70", "5.50E+71", "1.47E+72", "7.90E+72", "3.66E+105", "5.49696E+106"));
			Rows.Add( new xStageStatsRow("ID_900", "901", "1.0997E+71", "2.20E+71", "1.32E+72", "9.22E+72", "4.78E+105", "9.56846E+105"));
			Rows.Add( new xStageStatsRow("ID_901", "902", "1.31964E+71", "3.96E+71", "1.72E+72", "1.09E+73", "6.25E+105", "1.87376E+106"));
			Rows.Add( new xStageStatsRow("ID_902", "903", "1.58356E+71", "6.33E+71", "2.22E+72", "1.31E+73", "8.15E+105", "4.07703E+106"));
			Rows.Add( new xStageStatsRow("ID_903", "904", "1.90027E+71", "9.50E+71", "2.85E+72", "1.60E+73", "1.06E+106", "1.06452E+107"));
			Rows.Add( new xStageStatsRow("ID_904", "905", "2.28033E+71", "1.37E+72", "3.65E+72", "1.96E+73", "1.39E+106", "2.08462E+107"));
			Rows.Add( new xStageStatsRow("ID_905", "906", "2.7364E+71", "5.47E+71", "3.28E+72", "2.29E+73", "1.81E+106", "3.62866E+106"));
			Rows.Add( new xStageStatsRow("ID_906", "907", "3.28368E+71", "9.85E+71", "4.27E+72", "2.72E+73", "2.37E+106", "7.10588E+106"));
			Rows.Add( new xStageStatsRow("ID_907", "908", "3.94041E+71", "1.58E+72", "5.52E+72", "3.27E+73", "3.09E+106", "1.54614E+107"));
			Rows.Add( new xStageStatsRow("ID_908", "909", "4.72849E+71", "2.36E+72", "7.09E+72", "3.98E+73", "4.04E+106", "4.03699E+107"));
			Rows.Add( new xStageStatsRow("ID_909", "910", "5.67419E+71", "3.40E+72", "9.08E+72", "4.89E+73", "5.27E+106", "7.90552E+107"));
			Rows.Add( new xStageStatsRow("ID_910", "911", "6.80903E+71", "1.36E+72", "8.17E+72", "5.71E+73", "6.88E+106", "1.3761E+107"));
			Rows.Add( new xStageStatsRow("ID_911", "912", "8.17083E+71", "2.45E+72", "1.06E+73", "6.77E+73", "8.98E+106", "2.69477E+107"));
			Rows.Add( new xStageStatsRow("ID_912", "913", "9.805E+71", "3.92E+72", "1.37E+73", "8.14E+73", "1.17E+107", "5.86342E+107"));
			Rows.Add( new xStageStatsRow("ID_913", "914", "1.1766E+72", "5.88E+72", "1.76E+73", "9.91E+73", "1.53E+107", "1.53095E+108"));
			Rows.Add( new xStageStatsRow("ID_914", "915", "1.41192E+72", "8.47E+72", "2.26E+73", "1.22E+74", "2E+107", "2.99802E+108"));
			Rows.Add( new xStageStatsRow("ID_915", "916", "1.6943E+72", "3.39E+72", "2.03E+73", "1.42E+74", "2.61E+107", "5.21859E+107"));
			Rows.Add( new xStageStatsRow("ID_916", "917", "2.03317E+72", "6.10E+72", "2.64E+73", "1.68E+74", "3.41E+107", "1.02194E+108"));
			Rows.Add( new xStageStatsRow("ID_917", "918", "2.4398E+72", "9.76E+72", "3.42E+73", "2.03E+74", "4.45E+107", "2.22359E+108"));
			Rows.Add( new xStageStatsRow("ID_918", "919", "2.92776E+72", "1.46E+73", "4.39E+73", "2.46E+74", "5.81E+107", "5.80585E+108"));
			Rows.Add( new xStageStatsRow("ID_919", "920", "3.51331E+72", "2.11E+73", "5.62E+73", "3.03E+74", "7.58E+107", "1.13694E+109"));
			Rows.Add( new xStageStatsRow("ID_920", "921", "4.21597E+72", "8.43E+72", "5.06E+73", "3.53E+74", "9.9E+107", "1.97905E+108"));
			Rows.Add( new xStageStatsRow("ID_921", "922", "5.05917E+72", "1.52E+73", "6.58E+73", "4.19E+74", "1.29E+108", "3.87552E+108"));
			Rows.Add( new xStageStatsRow("ID_922", "923", "6.071E+72", "2.43E+73", "8.50E+73", "5.04E+74", "1.69E+108", "8.43255E+108"));
			Rows.Add( new xStageStatsRow("ID_923", "924", "7.2852E+72", "3.64E+73", "1.09E+74", "6.13E+74", "2.2E+108", "2.20176E+109"));
			Rows.Add( new xStageStatsRow("ID_924", "925", "8.74224E+72", "5.25E+73", "1.40E+74", "7.53E+74", "2.87E+108", "4.31163E+109"));
			Rows.Add( new xStageStatsRow("ID_925", "926", "1.04907E+73", "2.10E+73", "1.26E+74", "8.79E+74", "3.75E+108", "7.50518E+108"));
			Rows.Add( new xStageStatsRow("ID_926", "927", "1.25888E+73", "3.78E+73", "1.64E+74", "1.04E+75", "4.9E+108", "1.46972E+109"));
			Rows.Add( new xStageStatsRow("ID_927", "928", "1.51066E+73", "6.04E+73", "2.11E+74", "1.25E+75", "6.4E+108", "3.19788E+109"));
			Rows.Add( new xStageStatsRow("ID_928", "929", "1.81279E+73", "9.06E+73", "2.72E+74", "1.53E+75", "8.35E+108", "8.34975E+109"));
			Rows.Add( new xStageStatsRow("ID_929", "930", "2.17535E+73", "1.31E+74", "3.48E+74", "1.87E+75", "1.09E+109", "1.6351E+110"));
			Rows.Add( new xStageStatsRow("ID_930", "931", "2.61042E+73", "5.22E+73", "3.13E+74", "2.19E+75", "1.42E+109", "2.8462E+109"));
			Rows.Add( new xStageStatsRow("ID_931", "932", "3.1325E+73", "9.40E+73", "4.07E+74", "2.59E+75", "1.86E+109", "5.57362E+109"));
			Rows.Add( new xStageStatsRow("ID_932", "933", "3.759E+73", "1.50E+74", "5.26E+74", "3.12E+75", "2.43E+109", "1.21274E+110"));
			Rows.Add( new xStageStatsRow("ID_933", "934", "4.5108E+73", "2.26E+74", "6.77E+74", "3.80E+75", "3.17E+109", "3.16648E+110"));
			Rows.Add( new xStageStatsRow("ID_934", "935", "5.41296E+73", "3.25E+74", "8.66E+74", "4.66E+75", "4.13E+109", "6.20082E+110"));
			Rows.Add( new xStageStatsRow("ID_935", "936", "6.49556E+73", "1.30E+74", "7.79E+74", "5.44E+75", "5.4E+109", "1.07937E+110"));
			Rows.Add( new xStageStatsRow("ID_936", "937", "7.79467E+73", "2.34E+74", "1.01E+75", "6.46E+75", "7.05E+109", "2.11369E+110"));
			Rows.Add( new xStageStatsRow("ID_937", "938", "9.3536E+73", "3.74E+74", "1.31E+75", "7.77E+75", "9.2E+109", "4.59907E+110"));
			Rows.Add( new xStageStatsRow("ID_938", "939", "1.12243E+74", "5.61E+74", "1.68E+75", "9.45E+75", "1.2E+110", "1.20083E+111"));
			Rows.Add( new xStageStatsRow("ID_939", "940", "1.34692E+74", "8.08E+74", "2.16E+75", "1.16E+76", "1.57E+110", "2.35154E+111"));
			Rows.Add( new xStageStatsRow("ID_940", "941", "1.6163E+74", "3.23E+74", "1.94E+75", "1.35E+76", "2.05E+110", "4.09329E+110"));
			Rows.Add( new xStageStatsRow("ID_941", "942", "1.93956E+74", "5.82E+74", "2.52E+75", "1.61E+76", "2.67E+110", "8.01576E+110"));
			Rows.Add( new xStageStatsRow("ID_942", "943", "2.32748E+74", "9.31E+74", "3.26E+75", "1.93E+76", "3.49E+110", "1.74411E+111"));
			Rows.Add( new xStageStatsRow("ID_943", "944", "2.79297E+74", "1.40E+75", "4.19E+75", "2.35E+76", "4.55E+110", "4.55392E+111"));
			Rows.Add( new xStageStatsRow("ID_944", "945", "3.35156E+74", "2.01E+75", "5.36E+75", "2.89E+76", "5.95E+110", "8.91779E+111"));
			Rows.Add( new xStageStatsRow("ID_945", "946", "4.02188E+74", "8.04E+74", "4.83E+75", "3.37E+76", "7.76E+110", "1.5523E+111"));
			Rows.Add( new xStageStatsRow("ID_946", "947", "4.82625E+74", "1.45E+75", "6.27E+75", "4.00E+76", "1.01E+111", "3.03983E+111"));
			Rows.Add( new xStageStatsRow("ID_947", "948", "5.7915E+74", "2.32E+75", "8.11E+75", "4.81E+76", "1.32E+111", "6.61421E+111"));
			Rows.Add( new xStageStatsRow("ID_948", "949", "6.9498E+74", "3.47E+75", "1.04E+76", "5.85E+76", "1.73E+111", "1.72699E+112"));
			Rows.Add( new xStageStatsRow("ID_949", "950", "8.33976E+74", "5.00E+75", "1.33E+76", "7.19E+76", "2.25E+111", "3.3819E+112"));
			Rows.Add( new xStageStatsRow("ID_950", "951", "1.00077E+75", "2.00E+75", "1.20E+76", "8.39E+76", "2.94E+111", "5.88682E+111"));
			Rows.Add( new xStageStatsRow("ID_951", "952", "1.20093E+75", "3.60E+75", "1.56E+76", "9.95E+76", "3.84E+111", "1.1528E+112"));
			Rows.Add( new xStageStatsRow("ID_952", "953", "1.44111E+75", "5.76E+75", "2.02E+76", "1.20E+77", "5.02E+111", "2.50831E+112"));
			Rows.Add( new xStageStatsRow("ID_953", "954", "1.72933E+75", "8.65E+75", "2.59E+76", "1.46E+77", "6.55E+111", "6.54927E+112"));
			Rows.Add( new xStageStatsRow("ID_954", "955", "2.0752E+75", "1.25E+76", "3.32E+76", "1.79E+77", "8.55E+111", "1.28252E+113"));
			Rows.Add( new xStageStatsRow("ID_955", "956", "2.49024E+75", "4.98E+75", "2.99E+76", "2.09E+77", "1.12E+112", "2.23246E+112"));
			Rows.Add( new xStageStatsRow("ID_956", "957", "2.98829E+75", "8.96E+75", "3.88E+76", "2.48E+77", "1.46E+112", "4.37176E+112"));
			Rows.Add( new xStageStatsRow("ID_957", "958", "3.58595E+75", "1.43E+76", "5.02E+76", "2.98E+77", "1.9E+112", "9.51231E+112"));
			Rows.Add( new xStageStatsRow("ID_958", "959", "4.30313E+75", "2.15E+76", "6.45E+76", "3.62E+77", "2.48E+112", "2.48369E+113"));
			Rows.Add( new xStageStatsRow("ID_959", "960", "5.16376E+75", "3.10E+76", "8.26E+76", "4.45E+77", "3.24E+112", "4.86372E+113"));
			Rows.Add( new xStageStatsRow("ID_960", "961", "6.19651E+75", "1.24E+76", "7.44E+76", "5.19E+77", "4.23E+112", "8.46619E+112"));
			Rows.Add( new xStageStatsRow("ID_961", "962", "7.43582E+75", "2.23E+76", "9.67E+76", "6.16E+77", "5.53E+112", "1.65791E+113"));
			Rows.Add( new xStageStatsRow("ID_962", "963", "8.92298E+75", "3.57E+76", "1.25E+77", "7.41E+77", "7.21E+112", "3.60736E+113"));
			Rows.Add( new xStageStatsRow("ID_963", "964", "1.07076E+76", "5.35E+76", "1.61E+77", "9.01E+77", "9.42E+112", "9.41891E+113"));
			Rows.Add( new xStageStatsRow("ID_964", "965", "1.28491E+76", "7.71E+76", "2.06E+77", "1.11E+78", "1.23E+113", "1.84447E+114"));
			Rows.Add( new xStageStatsRow("ID_965", "966", "1.54189E+76", "3.08E+76", "1.85E+77", "1.29E+78", "1.61E+113", "3.21064E+113"));
			Rows.Add( new xStageStatsRow("ID_966", "967", "1.85027E+76", "5.55E+76", "2.41E+77", "1.53E+78", "2.1E+113", "6.2873E+113"));
			Rows.Add( new xStageStatsRow("ID_967", "968", "2.22032E+76", "8.88E+76", "3.11E+77", "1.84E+78", "2.74E+113", "1.36802E+114"));
			Rows.Add( new xStageStatsRow("ID_968", "969", "2.66439E+76", "1.33E+77", "4.00E+77", "2.24E+78", "3.57E+113", "3.57194E+114"));
			Rows.Add( new xStageStatsRow("ID_969", "970", "3.19727E+76", "1.92E+77", "5.12E+77", "2.75E+78", "4.66E+113", "6.99482E+114"));
			Rows.Add( new xStageStatsRow("ID_970", "971", "3.83672E+76", "7.67E+76", "4.60E+77", "3.22E+78", "6.09E+113", "1.21758E+114"));
			Rows.Add( new xStageStatsRow("ID_971", "972", "4.60406E+76", "1.38E+77", "5.99E+77", "3.81E+78", "7.95E+113", "2.38434E+114"));
			Rows.Add( new xStageStatsRow("ID_972", "973", "5.52487E+76", "2.21E+77", "7.73E+77", "4.59E+78", "1.04E+114", "5.18797E+114"));
			Rows.Add( new xStageStatsRow("ID_973", "974", "6.62985E+76", "3.31E+77", "9.94E+77", "5.58E+78", "1.35E+114", "1.35459E+115"));
			Rows.Add( new xStageStatsRow("ID_974", "975", "7.95582E+76", "4.77E+77", "1.27E+78", "6.85E+78", "1.77E+114", "2.65265E+115"));
			Rows.Add( new xStageStatsRow("ID_975", "976", "9.54698E+76", "1.91E+77", "1.15E+78", "8.00E+78", "2.31E+114", "4.61742E+114"));
			Rows.Add( new xStageStatsRow("ID_976", "977", "1.14564E+77", "3.44E+77", "1.49E+78", "9.49E+78", "3.01E+114", "9.04215E+114"));
			Rows.Add( new xStageStatsRow("ID_977", "978", "1.37477E+77", "5.50E+77", "1.92E+78", "1.14E+79", "3.93E+114", "1.96744E+115"));
			Rows.Add( new xStageStatsRow("ID_978", "979", "1.64972E+77", "8.25E+77", "2.47E+78", "1.39E+79", "5.14E+114", "5.13703E+115"));
			Rows.Add( new xStageStatsRow("ID_979", "980", "1.97966E+77", "1.19E+78", "3.17E+78", "1.71E+79", "6.71E+114", "1.00597E+116"));
			Rows.Add( new xStageStatsRow("ID_980", "981", "2.37559E+77", "4.75E+77", "2.85E+78", "1.99E+79", "8.76E+114", "1.75107E+115"));
			Rows.Add( new xStageStatsRow("ID_981", "982", "2.85071E+77", "8.55E+77", "3.71E+78", "2.36E+79", "1.14E+115", "3.42906E+115"));
			Rows.Add( new xStageStatsRow("ID_982", "983", "3.42086E+77", "1.37E+78", "4.79E+78", "2.84E+79", "1.49E+115", "7.46114E+115"));
			Rows.Add( new xStageStatsRow("ID_983", "984", "4.10503E+77", "2.05E+78", "6.16E+78", "3.46E+79", "1.95E+115", "1.94812E+116"));
			Rows.Add( new xStageStatsRow("ID_984", "985", "4.92603E+77", "2.96E+78", "7.88E+78", "4.24E+79", "2.54E+115", "3.81494E+116"));
			Rows.Add( new xStageStatsRow("ID_985", "986", "5.91124E+77", "1.18E+78", "7.09E+78", "4.95E+79", "3.32E+115", "6.6406E+115"));
			Rows.Add( new xStageStatsRow("ID_986", "987", "7.09349E+77", "2.13E+78", "9.22E+78", "5.88E+79", "4.33E+115", "1.30041E+116"));
			Rows.Add( new xStageStatsRow("ID_987", "988", "8.51219E+77", "3.40E+78", "1.19E+79", "7.07E+79", "5.66E+115", "2.82949E+116"));
			Rows.Add( new xStageStatsRow("ID_988", "989", "1.02146E+78", "5.11E+78", "1.53E+79", "8.60E+79", "7.39E+115", "7.38788E+116"));
			Rows.Add( new xStageStatsRow("ID_989", "990", "1.22575E+78", "7.35E+78", "1.96E+79", "1.06E+80", "9.64E+115", "1.44674E+117"));
			Rows.Add( new xStageStatsRow("ID_990", "991", "1.47091E+78", "2.94E+78", "1.77E+79", "1.23E+80", "1.26E+116", "2.51832E+116"));
			Rows.Add( new xStageStatsRow("ID_991", "992", "1.76509E+78", "5.30E+78", "2.29E+79", "1.46E+80", "1.64E+116", "4.93155E+116"));
			Rows.Add( new xStageStatsRow("ID_992", "993", "2.1181E+78", "8.47E+78", "2.97E+79", "1.76E+80", "2.15E+116", "1.07303E+117"));
			Rows.Add( new xStageStatsRow("ID_993", "994", "2.54173E+78", "1.27E+79", "3.81E+79", "2.14E+80", "2.8E+116", "2.80171E+117"));
			Rows.Add( new xStageStatsRow("ID_994", "995", "3.05007E+78", "1.83E+79", "4.88E+79", "2.63E+80", "3.66E+116", "5.4865E+117"));
			Rows.Add( new xStageStatsRow("ID_995", "996", "3.66008E+78", "7.32E+78", "4.39E+79", "3.07E+80", "4.78E+116", "9.55026E+116"));
			Rows.Add( new xStageStatsRow("ID_996", "997", "4.3921E+78", "1.32E+79", "5.71E+79", "3.64E+80", "6.23E+116", "1.8702E+117"));
			Rows.Add( new xStageStatsRow("ID_997", "998", "5.27052E+78", "2.11E+79", "7.38E+79", "4.38E+80", "8.14E+116", "4.06927E+117"));
			Rows.Add( new xStageStatsRow("ID_998", "999", "6.32463E+78", "3.16E+79", "9.49E+79", "5.32E+80", "1.06E+117", "1.0625E+118"));
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
		public xStageStatsRow GetRow(rowIds in_RowID)
		{
			xStageStatsRow ret = null;
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
		public xStageStatsRow GetRow(string in_RowString)
		{
			xStageStatsRow ret = null;
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
