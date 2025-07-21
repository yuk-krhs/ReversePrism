using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WriteMask                              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_SourceColorBlendMode                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 M_DestinationColorBlendMode              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 013 M_SourceAlphaBlendMode                   ModelPrimitiveType sbyte sbyte sbyte SByte
    // 014 M_DestinationAlphaBlendMode              ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_ColorBlendOperation                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_AlphaBlendOperation                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 M_Padding                                ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class RenderTargetBlendState : DataModel
    {
        public sbyte                                    M_WriteMask                             { get; set; }
        public sbyte                                    M_SourceColorBlendMode                  { get; set; }
        public sbyte                                    M_DestinationColorBlendMode             { get; set; }
        public sbyte                                    M_SourceAlphaBlendMode                  { get; set; }
        public sbyte                                    M_DestinationAlphaBlendMode             { get; set; }
        public sbyte                                    M_ColorBlendOperation                   { get; set; }
        public sbyte                                    M_AlphaBlendOperation                   { get; set; }
        public sbyte                                    M_Padding                               { get; set; }

        public static RenderTargetBlendState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTargetBlendState() { Pointer= p0 };

            value.M_WriteMask                               = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_WriteMask                 ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_SourceColorBlendMode                    = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_SourceColorBlendMode      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_DestinationColorBlendMode               = GetSByte(new IntPtr(p + 0x012)); // 0x12 M_DestinationColorBlendMode ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_SourceAlphaBlendMode                    = GetSByte(new IntPtr(p + 0x013)); // 0x13 M_SourceAlphaBlendMode      ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_DestinationAlphaBlendMode               = GetSByte(new IntPtr(p + 0x014)); // 0x14 M_DestinationAlphaBlendMode ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ColorBlendOperation                     = GetSByte(new IntPtr(p + 0x015)); // 0x15 M_ColorBlendOperation       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_AlphaBlendOperation                     = GetSByte(new IntPtr(p + 0x016)); // 0x16 M_AlphaBlendOperation       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_Padding                                 = GetSByte(new IntPtr(p + 0x017)); // 0x17 M_Padding                   ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
