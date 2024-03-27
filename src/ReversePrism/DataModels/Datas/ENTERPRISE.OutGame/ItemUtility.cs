using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ItemNameKey                              string IL2CPP_TYPE_STRING
    // 000 ItemDescKey                              string IL2CPP_TYPE_STRING
    // 000 CostumeNameKey                           string IL2CPP_TYPE_STRING
    // 000 CostumeDescKey                           string IL2CPP_TYPE_STRING
    // 000 HairStyleNameKey                         string IL2CPP_TYPE_STRING
    // 000 HairStyleDescKey                         string IL2CPP_TYPE_STRING
    // 000 AccessoryNameKey                         string IL2CPP_TYPE_STRING
    // 000 AccessoryDescKey                         string IL2CPP_TYPE_STRING
    // 000 AchievementNameKey                       string IL2CPP_TYPE_STRING
    // 000 AchievementDescKey                       string IL2CPP_TYPE_STRING
    // 000 MusicProductNameKey                      ValueTuple`2<string, int> IL2CPP_TYPE_GENERICINST
    // 000 MusicNameKey                             string IL2CPP_TYPE_STRING
    // 000 EventStoryNameKey                        string IL2CPP_TYPE_STRING
    public partial class ItemUtility
    {

        public static ItemUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemUtility();


            return value;
        }
    }
}
