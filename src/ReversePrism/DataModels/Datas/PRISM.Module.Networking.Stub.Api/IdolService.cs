using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetIdolBaseListArgs     Marshaller`1<GetIdolBaseListArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetIdolBaseListReply    Marshaller`1<GetIdolBaseListReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetIdolBaseCostumeArgs  Marshaller`1<SetIdolBaseCostumeArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetIdolBaseCostumeReply Marshaller`1<SetIdolBaseCostumeReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetIdolLevelRewardListArgs Marshaller`1<GetIdolLevelRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetIdolLevelRewardListReply Marshaller`1<GetIdolLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_GetDearnessLevelRewardListArgs Marshaller`1<GetDearnessLevelRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_GetDearnessLevelRewardListReply Marshaller`1<GetDearnessLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Method_GetIdolBaseList                 Method`2<GetIdolBaseListArgs, GetIdolBaseListReply> IL2CPP_TYPE_GENERICINST
    // 050 __Method_SetIdolBaseCostume              Method`2<SetIdolBaseCostumeArgs, SetIdolBaseCostumeReply> IL2CPP_TYPE_GENERICINST
    // 058 __Method_GetIdolLevelRewardList          Method`2<GetIdolLevelRewardListArgs, GetIdolLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    // 060 __Method_GetDearnessLevelRewardList      Method`2<GetDearnessLevelRewardListArgs, GetDearnessLevelRewardListReply> IL2CPP_TYPE_GENERICINST
    public partial class IdolService
    {

        public static IdolService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolService();


            return value;
        }
    }
}
