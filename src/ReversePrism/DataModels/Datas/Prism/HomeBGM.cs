using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 characterPrefix                          string IL2CPP_TYPE_STRING
    // 000 storyPrefix                              string IL2CPP_TYPE_STRING
    // 000 currentTimeOfDay                         TimeOfDay IL2CPP_TYPE_VALUETYPE
    // 004 currentWeather                           Weather IL2CPP_TYPE_VALUETYPE
    // 008 timeOfDayPrefixDict                      Dictionary`2<TimeOfDay, string> IL2CPP_TYPE_GENERICINST
    // 010 weatherPrefixDict                        Dictionary`2<Weather, string> IL2CPP_TYPE_GENERICINST
    public partial class HomeBGM : DataModel
    {

        public static HomeBGM? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeBGM() { Pointer= p0 };


            return value;
        }
    }
}
