using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BlendState0                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 018 M_BlendState1                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 020 M_BlendState2                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 028 M_BlendState3                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 030 M_BlendState4                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 038 M_BlendState5                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 040 M_BlendState6                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 048 M_BlendState7                            ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32
    // 050 M_SeparateMRTBlendStates                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 051 M_AlphaToMask                            ModelPrimitiveType sbyte sbyte sbyte SByte
    // 052 M_Padding                                ModelPrimitiveType short short short Int16
    public partial class BlendState : DataModel
    {
        public RenderTargetBlendState                   M_BlendState0                           { get; set; }
        public RenderTargetBlendState                   M_BlendState1                           { get; set; }
        public RenderTargetBlendState                   M_BlendState2                           { get; set; }
        public RenderTargetBlendState                   M_BlendState3                           { get; set; }
        public RenderTargetBlendState                   M_BlendState4                           { get; set; }
        public RenderTargetBlendState                   M_BlendState5                           { get; set; }
        public RenderTargetBlendState                   M_BlendState6                           { get; set; }
        public RenderTargetBlendState                   M_BlendState7                           { get; set; }
        public sbyte                                    M_SeparateMRTBlendStates                { get; set; }
        public sbyte                                    M_AlphaToMask                           { get; set; }
        public short                                    M_Padding                               { get; set; }

        public static BlendState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BlendState() { Pointer= p0 };

            value.M_BlendState0                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_BlendState0               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState1                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_BlendState1               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState2                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_BlendState2               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState3                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_BlendState3               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState4                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_BlendState4               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState5                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_BlendState5               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState6                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_BlendState6               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_BlendState7                             = (RenderTargetBlendState)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_BlendState7               ( ModelEnumType RenderTargetBlendState RenderTargetBlendState RenderTargetBlendState Int32 )
            value.M_SeparateMRTBlendStates                  = GetSByte(new IntPtr(p + 0x050)); // 0x50 M_SeparateMRTBlendStates    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_AlphaToMask                             = GetSByte(new IntPtr(p + 0x051)); // 0x51 M_AlphaToMask               ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Padding                                 = GetInt16(new IntPtr(p + 0x052)); // 0x52 M_Padding                   ( ModelPrimitiveType short short short Int16 )

            return value;
        }
    }
}
