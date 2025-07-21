using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VitalityVariationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BeforeValueFieldNumber                   int IL2CPP_TYPE_I4
    // 018 BeforeValue                              ModelPrimitiveType int int int Int32
    // 000 AfterValueFieldNumber                    int IL2CPP_TYPE_I4
    // 01C AfterValue                               ModelPrimitiveType int int int Int32
    public partial class VitalityVariationStatus : DataModel
    {
        public int                                      BeforeValue                             { get; set; }
        public int                                      AfterValue                              { get; set; }

        public static VitalityVariationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VitalityVariationStatus() { Pointer= p0 };

            value.BeforeValue                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 BeforeValue                 ( ModelPrimitiveType int int int Int32 )
            value.AfterValue                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AfterValue                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
