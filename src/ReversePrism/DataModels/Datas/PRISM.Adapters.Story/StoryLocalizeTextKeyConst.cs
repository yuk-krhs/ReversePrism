using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 StoryPlayPopupTitle                      ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 010 CheckIfDownloadAndPlayStory              ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 020 Play                                     ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 030 DoNotShowAgain                           ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 040 CanChangeSettingsFromMenu                ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 050 RecommendDownloadOverWiFi                ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 060 Story                                    ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 070 MainTab                                  ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 080 IdolTab                                  ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 090 EventTab                                 ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 0A0 ExtraTab                                 ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 0B0 FavoriteTab                              ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 0C0 SearchTab                                ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    public partial class StoryLocalizeTextKeyConst : DataModel
    {

        public static StoryLocalizeTextKeyConst? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryLocalizeTextKeyConst() { Pointer= p0 };


            return value;
        }
    }
}
