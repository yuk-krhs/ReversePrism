using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolDearnessConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 RequiredDearnessFieldNumber              int IL2CPP_TYPE_I4
    // 01C RequiredDearness                         ModelPrimitiveType int int int Int32
    // 000 DearnessFieldNumber                      int IL2CPP_TYPE_I4
    // 020 Dearness                                 ModelPrimitiveType int int int Int32
    public partial class IdolDearnessConditionStatus : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public int                                      RequiredDearness                        { get; set; }
        public int                                      Dearness                                { get; set; }

        public static IdolDearnessConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolDearnessConditionStatus() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.RequiredDearness                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C RequiredDearness            ( ModelPrimitiveType int int int Int32 )
            value.Dearness                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 Dearness                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
