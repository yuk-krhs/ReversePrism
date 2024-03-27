using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TapTime                                  000186666050 ModelPrimitiveType float float float Single
    // 014 TapDelay                                 000186666050 ModelPrimitiveType float float float Single
    // 018 TapCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C PressPoint                               000186666050 ModelPrimitiveType float float float Single
    // 020 M_CurrentTapPhase                        00018675FDB0 ModelEnumType TapPhase TapPhase TapPhase Int32
    // 024 M_CurrentTapCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_CurrentTapStartTime                    0001865C2950 ModelPrimitiveType double double double Double
    // 030 M_LastTapReleaseTime                     0001865C2950 ModelPrimitiveType double double double Double
    public partial class MultiTapInteraction
    {
        public float                                    TapTime                                 { get; set; }
        public float                                    TapDelay                                { get; set; }
        public int                                      TapCount                                { get; set; }
        public float                                    PressPoint                              { get; set; }
        public TapPhase                                 M_CurrentTapPhase                       { get; set; }
        public int                                      M_CurrentTapCount                       { get; set; }
        public double                                   M_CurrentTapStartTime                   { get; set; }
        public double                                   M_LastTapReleaseTime                    { get; set; }

        public static MultiTapInteraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiTapInteraction();

            value.TapTime                                   = GetSingle(new IntPtr(p + 0x010)); // 0270D787A6C8 0x10 TapTime                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.TapDelay                                  = GetSingle(new IntPtr(p + 0x014)); // 0270D787A6E8 0x14 TapDelay                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.TapCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D787A708 0x18 TapCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PressPoint                                = GetSingle(new IntPtr(p + 0x01C)); // 0270D787A728 0x1C PressPoint                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_CurrentTapPhase                         = (TapPhase)GetInt32(new IntPtr(p + 0x020)); // 0270D787A748 0x20 M_CurrentTapPhase           ( 00018675FDB0 ModelEnumType TapPhase TapPhase TapPhase Int32 )
            value.M_CurrentTapCount                         = GetInt32(new IntPtr(p + 0x024)); // 0270D787A768 0x24 M_CurrentTapCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentTapStartTime                     = GetDouble(new IntPtr(p + 0x028)); // 0270D787A788 0x28 M_CurrentTapStartTime       ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.M_LastTapReleaseTime                      = GetDouble(new IntPtr(p + 0x030)); // 0270D787A7A8 0x30 M_LastTapReleaseTime        ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
