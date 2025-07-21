using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TapTime                                  ModelPrimitiveType float float float Single
    // 014 TapDelay                                 ModelPrimitiveType float float float Single
    // 018 TapCount                                 ModelPrimitiveType int int int Int32
    // 01C PressPoint                               ModelPrimitiveType float float float Single
    // 020 M_CurrentTapPhase                        ModelEnumType TapPhase TapPhase TapPhase Int32
    // 024 M_CurrentTapCount                        ModelPrimitiveType int int int Int32
    // 028 M_CurrentTapStartTime                    ModelPrimitiveType double double double Double
    // 030 M_LastTapReleaseTime                     ModelPrimitiveType double double double Double
    public partial class MultiTapInteraction : DataModel
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
            var value   = new MultiTapInteraction() { Pointer= p0 };

            value.TapTime                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 TapTime                     ( ModelPrimitiveType float float float Single )
            value.TapDelay                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 TapDelay                    ( ModelPrimitiveType float float float Single )
            value.TapCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 TapCount                    ( ModelPrimitiveType int int int Int32 )
            value.PressPoint                                = GetSingle(new IntPtr(p + 0x01C)); // 0x1C PressPoint                  ( ModelPrimitiveType float float float Single )
            value.M_CurrentTapPhase                         = (TapPhase)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_CurrentTapPhase           ( ModelEnumType TapPhase TapPhase TapPhase Int32 )
            value.M_CurrentTapCount                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_CurrentTapCount           ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentTapStartTime                     = GetDouble(new IntPtr(p + 0x028)); // 0x28 M_CurrentTapStartTime       ( ModelPrimitiveType double double double Double )
            value.M_LastTapReleaseTime                      = GetDouble(new IntPtr(p + 0x030)); // 0x30 M_LastTapReleaseTime        ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
