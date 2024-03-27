using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 All                                      MatchTargetFields IL2CPP_TYPE_VALUETYPE
    // 004 None                                     MatchTargetFields IL2CPP_TYPE_VALUETYPE
    // 008 Position                                 MatchTargetFields IL2CPP_TYPE_VALUETYPE
    // 00C Rotation                                 MatchTargetFields IL2CPP_TYPE_VALUETYPE
    public partial class MatchTargetFieldConstants
    {

        public static MatchTargetFieldConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchTargetFieldConstants();


            return value;
        }
    }
}
