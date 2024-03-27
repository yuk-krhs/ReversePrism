using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetMedalGashaArgs       Marshaller`1<GetMedalGashaArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetMedalGashaReply      Marshaller`1<GetMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_DrawMedalGashaArgs      Marshaller`1<DrawMedalGashaArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_DrawMedalGashaReply     Marshaller`1<DrawMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_NextMedalGashaBoxArgs   Marshaller`1<NextMedalGashaBoxArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_NextMedalGashaBoxReply  Marshaller`1<NextMedalGashaBoxReply> IL2CPP_TYPE_GENERICINST
    // 038 __Method_GetMedalGasha                   Method`2<GetMedalGashaArgs, GetMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 040 __Method_DrawMedalGasha                  Method`2<DrawMedalGashaArgs, DrawMedalGashaReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_NextMedalGashaBox               Method`2<NextMedalGashaBoxArgs, NextMedalGashaBoxReply> IL2CPP_TYPE_GENERICINST
    public partial class MedalGashaService
    {

        public static MedalGashaService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaService();


            return value;
        }
    }
}
