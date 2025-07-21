using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseVirtualOffset                         ModelPrimitiveType bool bool bool Bool
    // 014 OutOfGeoOffset                           ModelPrimitiveType float float float Single
    // 018 SearchMultiplier                         ModelPrimitiveType float float float Single
    // 01C RayOriginBias                            ModelPrimitiveType float float float Single
    // 020 MaxHitsPerRay                            ModelPrimitiveType int int int Int32
    // 024 CollisionMask                            ModelEnumType LayerMask LayerMask LayerMask Int32
    public partial class VirtualOffsetSettings : DataModel
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
            var value   = new VirtualOffsetSettings() { Pointer= p0 };

            value.UseVirtualOffset                          = GetBool(new IntPtr(p + 0x010)); // 0x10 UseVirtualOffset            ( ModelPrimitiveType bool bool bool Bool )
            value.OutOfGeoOffset                            = GetSingle(new IntPtr(p + 0x014)); // 0x14 OutOfGeoOffset              ( ModelPrimitiveType float float float Single )
            value.SearchMultiplier                          = GetSingle(new IntPtr(p + 0x018)); // 0x18 SearchMultiplier            ( ModelPrimitiveType float float float Single )
            value.RayOriginBias                             = GetSingle(new IntPtr(p + 0x01C)); // 0x1C RayOriginBias               ( ModelPrimitiveType float float float Single )
            value.MaxHitsPerRay                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxHitsPerRay               ( ModelPrimitiveType int int int Int32 )
            value.CollisionMask                             = (LayerMask)GetInt32(new IntPtr(p + 0x024)); // 0x24 CollisionMask               ( ModelEnumType LayerMask LayerMask LayerMask Int32 )

            return value;
        }
    }
}
