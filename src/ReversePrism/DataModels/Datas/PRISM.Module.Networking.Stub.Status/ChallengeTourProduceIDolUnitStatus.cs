using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourProduceIDolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChallengeTourIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 ChallengeTourId                          ModelPrimitiveType int int int Int32
    // 000 MstProduceIdolIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstProduceIdolIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstProduceIdolIdList                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class ChallengeTourProduceIDolUnitStatus : DataModel
    {
        public int                                      ChallengeTourId                         { get; set; }
        public List<int>?                               MstProduceIdolIdList                    { get; set; }

        public static ChallengeTourProduceIDolUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourProduceIDolUnitStatus() { Pointer= p0 };

            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 ChallengeTourId             ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolIdList                      = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstProduceIdolIdList        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}
