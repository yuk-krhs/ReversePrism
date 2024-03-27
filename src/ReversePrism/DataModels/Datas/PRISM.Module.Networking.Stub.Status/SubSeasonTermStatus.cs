using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonTermStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstSubSeasonId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 WeekFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Week                                     00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    public partial class SubSeasonTermStatus
    {
        public int                                      MstSubSeasonId                          { get; set; }
        public LimitedValueStatus?                      Week                                    { get; set; }

        public static SubSeasonTermStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonTermStatus();

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0270D11582E8 0x18 MstSubSeasonId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Week                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0270D1158328 0x20 Week                        ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )

            return value;
        }
    }
}
