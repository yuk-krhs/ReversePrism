using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderingLayerMask                       ModelPrimitiveType uint uint uint UInt32
    // 014 Layer                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_motionMode                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 016 M_shadowMode                             ModelPrimitiveType sbyte sbyte sbyte SByte
    // 017 M_receiveShadows                         ModelPrimitiveType sbyte sbyte sbyte SByte
    // 018 M_staticShadowCaster                     ModelPrimitiveType sbyte sbyte sbyte SByte
    // 019 M_allDepthSorted                         ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class BatchFilterSettings : DataModel
    {
        public uint                                     RenderingLayerMask                      { get; set; }
        public sbyte                                    Layer                                   { get; set; }
        public sbyte                                    M_motionMode                            { get; set; }
        public sbyte                                    M_shadowMode                            { get; set; }
        public sbyte                                    M_receiveShadows                        { get; set; }
        public sbyte                                    M_staticShadowCaster                    { get; set; }
        public sbyte                                    M_allDepthSorted                        { get; set; }

        public static BatchFilterSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchFilterSettings() { Pointer= p0 };

            value.RenderingLayerMask                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 RenderingLayerMask          ( ModelPrimitiveType uint uint uint UInt32 )
            value.Layer                                     = GetSByte(new IntPtr(p + 0x014)); // 0x14 Layer                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_motionMode                              = GetSByte(new IntPtr(p + 0x015)); // 0x15 M_motionMode                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_shadowMode                              = GetSByte(new IntPtr(p + 0x016)); // 0x16 M_shadowMode                ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_receiveShadows                          = GetSByte(new IntPtr(p + 0x017)); // 0x17 M_receiveShadows            ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_staticShadowCaster                      = GetSByte(new IntPtr(p + 0x018)); // 0x18 M_staticShadowCaster        ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_allDepthSorted                          = GetSByte(new IntPtr(p + 0x019)); // 0x19 M_allDepthSorted            ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
