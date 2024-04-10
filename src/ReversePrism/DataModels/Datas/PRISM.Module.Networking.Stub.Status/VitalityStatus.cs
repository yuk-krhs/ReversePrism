using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<VitalityStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CurrentVitalityFieldNumber               int IL2CPP_TYPE_I4
    // 018 CurrentVitality                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MaxVitalityFieldNumber                   int IL2CPP_TYPE_I4
    // 01C MaxVitality                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class VitalityStatus : DataModel
    {
        public int                                      CurrentVitality                         { get; set; }
        public int                                      MaxVitality                             { get; set; }

        public static VitalityStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VitalityStatus() { Pointer= p0 };

            value.CurrentVitality                           = GetInt32(new IntPtr(p + 0x018)); // 0246610D0888 0x18 CurrentVitality             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxVitality                               = GetInt32(new IntPtr(p + 0x01C)); // 0246610D08C8 0x1C MaxVitality                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
