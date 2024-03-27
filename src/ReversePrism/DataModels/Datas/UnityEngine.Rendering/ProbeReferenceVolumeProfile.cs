using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Version                                  0001865B7BC0 ModelEnumType Version Version Version Int32
    // 01C FreezePlacement                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 020 SimplificationLevels                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 MinDistanceBetweenProbes                 000186666050 ModelPrimitiveType float float float Single
    // 028 RenderersLayerMask                       00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 02C MinRendererVolumeSize                    000186666050 ModelPrimitiveType float float float Single
    public partial class ProbeReferenceVolumeProfile
    {
        public Version                                  Version                                 { get; set; }
        public bool                                     FreezePlacement                         { get; set; }
        public int                                      SimplificationLevels                    { get; set; }
        public float                                    MinDistanceBetweenProbes                { get; set; }
        public LayerMask                                RenderersLayerMask                      { get; set; }
        public float                                    MinRendererVolumeSize                   { get; set; }

        public static ProbeReferenceVolumeProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeReferenceVolumeProfile();

            value.Version                                   = (Version)GetInt32(new IntPtr(p + 0x018)); // 0270D92201E0 0x18 Version                     ( 0001865B7BC0 ModelEnumType Version Version Version Int32 )
            value.FreezePlacement                           = GetBool(new IntPtr(p + 0x01C)); // 0270D9220200 0x1C FreezePlacement             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.SimplificationLevels                      = GetInt32(new IntPtr(p + 0x020)); // 0270D9220220 0x20 SimplificationLevels        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MinDistanceBetweenProbes                  = GetSingle(new IntPtr(p + 0x024)); // 0270D9220240 0x24 MinDistanceBetweenProbes    ( 000186666050 ModelPrimitiveType float float float Single )
            value.RenderersLayerMask                        = (LayerMask)GetInt32(new IntPtr(p + 0x028)); // 0270D9220260 0x28 RenderersLayerMask          ( 00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.MinRendererVolumeSize                     = GetSingle(new IntPtr(p + 0x02C)); // 0270D9220280 0x2C MinRendererVolumeSize       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
