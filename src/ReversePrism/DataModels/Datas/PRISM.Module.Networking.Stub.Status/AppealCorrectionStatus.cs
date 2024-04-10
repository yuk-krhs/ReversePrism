using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AppealCorrectionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 VocalFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Vocal                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DanceFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Dance                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Visual                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SpecialFieldNumber                       int IL2CPP_TYPE_I4
    // 024 Special                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AppealCorrectionStatus : DataModel
    {
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Special                                 { get; set; }

        public static AppealCorrectionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppealCorrectionStatus() { Pointer= p0 };

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x018)); // 024661036E90 0x18 Vocal                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x01C)); // 024661036ED0 0x1C Dance                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x020)); // 024661036F10 0x20 Visual                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Special                                   = GetInt32(new IntPtr(p + 0x024)); // 024661036F50 0x24 Special                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
