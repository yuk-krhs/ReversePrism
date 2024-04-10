using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 __ServiceName                            string IL2CPP_TYPE_STRING
    // 008 __Marshaller_api_GetPvpTopArgs           Marshaller`1<GetPvpTopArgs> IL2CPP_TYPE_GENERICINST
    // 010 __Marshaller_api_GetPvpTopReply          Marshaller`1<GetPvpTopReply> IL2CPP_TYPE_GENERICINST
    // 018 __Marshaller_api_SetPvpUnitArgs          Marshaller`1<SetPvpUnitArgs> IL2CPP_TYPE_GENERICINST
    // 020 __Marshaller_api_SetPvpUnitReply         Marshaller`1<SetPvpUnitReply> IL2CPP_TYPE_GENERICINST
    // 028 __Marshaller_api_GetPvpEventRewardListArgs Marshaller`1<GetPvpEventRewardListArgs> IL2CPP_TYPE_GENERICINST
    // 030 __Marshaller_api_GetPvpEventRewardListReply Marshaller`1<GetPvpEventRewardListReply> IL2CPP_TYPE_GENERICINST
    // 038 __Marshaller_api_PreparePvpOpponentListArgs Marshaller`1<PreparePvpOpponentListArgs> IL2CPP_TYPE_GENERICINST
    // 040 __Marshaller_api_PreparePvpOpponentListReply Marshaller`1<PreparePvpOpponentListReply> IL2CPP_TYPE_GENERICINST
    // 048 __Marshaller_api_StartPvpMatchArgs       Marshaller`1<StartPvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 050 __Marshaller_api_StartPvpMatchReply      Marshaller`1<StartPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 058 __Marshaller_api_ResumePvpMatchArgs      Marshaller`1<ResumePvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 060 __Marshaller_api_ResumePvpMatchReply     Marshaller`1<ResumePvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 068 __Marshaller_api_FinishPvpMatchArgs      Marshaller`1<FinishPvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 070 __Marshaller_api_FinishPvpMatchReply     Marshaller`1<FinishPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 078 __Marshaller_api_BreakPvpMatchArgs       Marshaller`1<BreakPvpMatchArgs> IL2CPP_TYPE_GENERICINST
    // 080 __Marshaller_api_BreakPvpMatchReply      Marshaller`1<BreakPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 088 __Method_GetPvpTop                       Method`2<GetPvpTopArgs, GetPvpTopReply> IL2CPP_TYPE_GENERICINST
    // 090 __Method_SetPvpUnit                      Method`2<SetPvpUnitArgs, SetPvpUnitReply> IL2CPP_TYPE_GENERICINST
    // 098 __Method_GetPvpEventRewardList           Method`2<GetPvpEventRewardListArgs, GetPvpEventRewardListReply> IL2CPP_TYPE_GENERICINST
    // 0A0 __Method_PreparePvpOpponentList          Method`2<PreparePvpOpponentListArgs, PreparePvpOpponentListReply> IL2CPP_TYPE_GENERICINST
    // 0A8 __Method_StartPvpMatch                   Method`2<StartPvpMatchArgs, StartPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 0B0 __Method_ResumePvpMatch                  Method`2<ResumePvpMatchArgs, ResumePvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 0B8 __Method_FinishPvpMatch                  Method`2<FinishPvpMatchArgs, FinishPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 0C0 __Method_BreakPvpMatch                   Method`2<BreakPvpMatchArgs, BreakPvpMatchReply> IL2CPP_TYPE_GENERICINST
    public partial class PvpService : DataModel
    {

        public static PvpService? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpService() { Pointer= p0 };


            return value;
        }
    }
}
