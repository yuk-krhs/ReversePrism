using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetSettingArgs          Marshaller`1<GetSettingArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetSettingReply         Marshaller`1<GetSettingReply> IL2CPP_TYPE_GENERICINST
    // 018 __Method_GetSetting                      Method`2<GetSettingArgs, GetSettingReply> IL2CPP_TYPE_GENERICINST
    public partial class GameSettingService
    {

        public static GameSettingService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameSettingService();


            return value;
        }
    }
}
