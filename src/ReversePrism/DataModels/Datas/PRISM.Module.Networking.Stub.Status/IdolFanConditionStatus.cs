using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolFanConditionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RequiredFanFieldNumber                   int IL2CPP_TYPE_I4
    // 01C RequiredFan                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FanFieldNumber                           int IL2CPP_TYPE_I4
    // 020 Fan                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class IdolFanConditionStatus : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public int                                      RequiredFan                             { get; set; }
        public int                                      Fan                                     { get; set; }

        public static IdolFanConditionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolFanConditionStatus() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 024661056498 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RequiredFan                               = GetInt32(new IntPtr(p + 0x01C)); // 0246610564D8 0x1C RequiredFan                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Fan                                       = GetInt32(new IntPtr(p + 0x020)); // 024661056518 0x20 Fan                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
