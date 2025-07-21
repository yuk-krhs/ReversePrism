using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourOpponentStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TargetAppealPointFieldNumber             int IL2CPP_TYPE_I4
    // 018 TargetAppealPoint                        ModelPrimitiveType int int int Int32
    public partial class ChallengeTourOpponentStatus : DataModel
    {
        public int                                      TargetAppealPoint                       { get; set; }

        public static ChallengeTourOpponentStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourOpponentStatus() { Pointer= p0 };

            value.TargetAppealPoint                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 TargetAppealPoint           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
