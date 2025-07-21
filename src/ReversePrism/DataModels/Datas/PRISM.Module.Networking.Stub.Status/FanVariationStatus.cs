using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<FanVariationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BeforeFanFieldNumber                     int IL2CPP_TYPE_I4
    // 018 BeforeFan                                ModelPrimitiveType int int int Int32
    // 000 AfterFanFieldNumber                      int IL2CPP_TYPE_I4
    // 01C AfterFan                                 ModelPrimitiveType int int int Int32
    public partial class FanVariationStatus : DataModel
    {
        public int                                      BeforeFan                               { get; set; }
        public int                                      AfterFan                                { get; set; }

        public static FanVariationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FanVariationStatus() { Pointer= p0 };

            value.BeforeFan                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 BeforeFan                   ( ModelPrimitiveType int int int Int32 )
            value.AfterFan                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AfterFan                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
