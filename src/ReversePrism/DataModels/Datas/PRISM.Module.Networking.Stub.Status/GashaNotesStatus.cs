using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaNotesStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Body                                     ModelPrimitiveType string string string String
    // 000 StepNoFieldNumber                        int IL2CPP_TYPE_I4
    // 020 StepNo                                   ModelPrimitiveType int int int Int32
    public partial class GashaNotesStatus : DataModel
    {
        public string                                   Body                                    { get; set; }
        public int                                      StepNo                                  { get; set; }

        public static GashaNotesStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaNotesStatus() { Pointer= p0 };

            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelPrimitiveType string string string String )
            value.StepNo                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 StepNo                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
