using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BuildUpParameterValueStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 VocalFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Vocal                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DanceFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Dance                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Visual                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MentalFieldNumber                        int IL2CPP_TYPE_I4
    // 024 Mental                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BuildUpParameterValueStatus
    {
        public int                                      Vocal                                   { get; set; }
        public int                                      Dance                                   { get; set; }
        public int                                      Visual                                  { get; set; }
        public int                                      Mental                                  { get; set; }

        public static BuildUpParameterValueStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuildUpParameterValueStatus();

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D10B1990 0x18 Vocal                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D10B19D0 0x1C Dance                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x020)); // 0270D10B1A10 0x20 Visual                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x024)); // 0270D10B1A50 0x24 Mental                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
