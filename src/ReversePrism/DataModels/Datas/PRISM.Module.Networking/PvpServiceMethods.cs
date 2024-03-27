using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetPvpTop                                Method`2<IGetPvpTopArgs, IGetPvpTopReply> IL2CPP_TYPE_GENERICINST
    // 018 SetPvpUnit                               Method`2<ISetPvpUnitArgs, ISetPvpUnitReply> IL2CPP_TYPE_GENERICINST
    // 030 GetPvpEventRewardList                    Method`2<IGetPvpEventRewardListArgs, IGetPvpEventRewardListReply> IL2CPP_TYPE_GENERICINST
    // 048 PreparePvpOpponentList                   Method`2<IPreparePvpOpponentListArgs, IPreparePvpOpponentListReply> IL2CPP_TYPE_GENERICINST
    // 060 StartPvpMatch                            Method`2<IStartPvpMatchArgs, IStartPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 078 ResumePvpMatch                           Method`2<IResumePvpMatchArgs, IResumePvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 090 FinishPvpMatch                           Method`2<IFinishPvpMatchArgs, IFinishPvpMatchReply> IL2CPP_TYPE_GENERICINST
    // 0A8 BreakPvpMatch                            Method`2<IBreakPvpMatchArgs, IBreakPvpMatchReply> IL2CPP_TYPE_GENERICINST
    public partial class PvpServiceMethods
    {

        public static PvpServiceMethods? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpServiceMethods();


            return value;
        }
    }
}
