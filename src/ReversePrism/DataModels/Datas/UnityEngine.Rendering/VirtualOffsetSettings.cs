using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseVirtualOffset                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 OutOfGeoOffset                           000186666050 ModelPrimitiveType float float float Single
    // 018 SearchMultiplier                         000186666050 ModelPrimitiveType float float float Single
    // 01C RayOriginBias                            000186666050 ModelPrimitiveType float float float Single
    // 020 MaxHitsPerRay                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 CollisionMask                            00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32
    public partial class VirtualOffsetSettings
    {
        public bool                                     UseVirtualOffset                        { get; set; }
        public float                                    OutOfGeoOffset                          { get; set; }
        public float                                    SearchMultiplier                        { get; set; }
        public float                                    RayOriginBias                           { get; set; }
        public int                                      MaxHitsPerRay                           { get; set; }
        public LayerMask                                CollisionMask                           { get; set; }

        public static VirtualOffsetSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualOffsetSettings();

            value.UseVirtualOffset                          = GetBool(new IntPtr(p + 0x010)); // 0270D91BB020 0x10 UseVirtualOffset            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OutOfGeoOffset                            = GetSingle(new IntPtr(p + 0x014)); // 0270D91BB040 0x14 OutOfGeoOffset              ( 000186666050 ModelPrimitiveType float float float Single )
            value.SearchMultiplier                          = GetSingle(new IntPtr(p + 0x018)); // 0270D91BB060 0x18 SearchMultiplier            ( 000186666050 ModelPrimitiveType float float float Single )
            value.RayOriginBias                             = GetSingle(new IntPtr(p + 0x01C)); // 0270D91BB080 0x1C RayOriginBias               ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxHitsPerRay                             = GetInt32(new IntPtr(p + 0x020)); // 0270D91BB0A0 0x20 MaxHitsPerRay               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CollisionMask                             = (LayerMask)GetInt32(new IntPtr(p + 0x024)); // 0270D91BB0C0 0x24 CollisionMask               ( 00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32 )

            return value;
        }
    }
}
