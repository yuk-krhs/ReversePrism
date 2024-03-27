using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SwitchConditionList                      000185D2CD18 ModelClassListType List`1<SwitchObjectCondition> List`1<SwitchObjectCondition> List<SwitchObjectCondition> Pointer
    // 000 TimeOfDay_Morning                        string IL2CPP_TYPE_STRING
    // 000 TimeOfDay_Dusk                           string IL2CPP_TYPE_STRING
    // 000 TimeOfDay_Night                          string IL2CPP_TYPE_STRING
    // 000 TimeOfDay_Noon                           string IL2CPP_TYPE_STRING
    // 000 Weather_Clear                            string IL2CPP_TYPE_STRING
    // 000 Weather_FewClouds                        string IL2CPP_TYPE_STRING
    // 000 Weather_ScatteredClouds                  string IL2CPP_TYPE_STRING
    // 000 Weather_BrokenClouds                     string IL2CPP_TYPE_STRING
    // 000 Weather_OvercastClouds                   string IL2CPP_TYPE_STRING
    // 000 Weather_Cloudy                           string IL2CPP_TYPE_STRING
    // 000 Weather_Rain                             string IL2CPP_TYPE_STRING
    // 000 Weather_HeavyRain                        string IL2CPP_TYPE_STRING
    // 000 Weather_Snow                             string IL2CPP_TYPE_STRING
    // 018 ViewType                                 000186540860 ModelEnumType Home3DViewType Home3DViewType Home3DViewType Int32
    // 020 CutSceneName                             000186671910 ModelPrimitiveType string string string String
    // 028 BgmViewModel                             0001866BC1D0 ModelClassType HomeBgmViewModel HomeBgmViewModel HomeBgmViewModel Pointer
    // 030 TVScreenType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HomeBackgroundViewModel
    {
        public List<SwitchObjectCondition>?             SwitchConditionList                     { get; set; }
        public Home3DViewType                           ViewType                                { get; set; }
        public string                                   CutSceneName                            { get; set; }
        public HomeBgmViewModel?                        BgmViewModel                            { get; set; }
        public int                                      TVScreenType                            { get; set; }

        public static HomeBackgroundViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBackgroundViewModel();

            value.SwitchConditionList                       = GetObjectList<SwitchObjectCondition>(new IntPtr(p + 0x010), ReversePrism.DataModels.SwitchObjectCondition.FromPointer); // 02700367C3D0 0x10 SwitchConditionList         ( 000185D2CD18 ModelClassListType List`1<SwitchObjectCondition> List`1<SwitchObjectCondition> List<SwitchObjectCondition> Pointer )
            value.ViewType                                  = (Home3DViewType)GetInt32(new IntPtr(p + 0x018)); // 02700367C590 0x18 ViewType                    ( 000186540860 ModelEnumType Home3DViewType Home3DViewType Home3DViewType Int32 )
            value.CutSceneName                              = GetString(new IntPtr(p + 0x020)); // 02700367C5B0 0x20 CutSceneName                ( 000186671910 ModelPrimitiveType string string string String )
            value.BgmViewModel                              = GetObject<HomeBgmViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeBgmViewModel.FromPointer); // 02700367C5D0 0x28 BgmViewModel                ( 0001866BC1D0 ModelClassType HomeBgmViewModel HomeBgmViewModel HomeBgmViewModel Pointer )
            value.TVScreenType                              = GetInt32(new IntPtr(p + 0x030)); // 02700367C5F0 0x30 TVScreenType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
