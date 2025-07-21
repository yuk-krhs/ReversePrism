using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseTriggers                              ModelPrimitiveType bool bool bool Bool
    // 011 UseLayerMask                             ModelPrimitiveType bool bool bool Bool
    // 012 UseDepth                                 ModelPrimitiveType bool bool bool Bool
    // 013 UseOutsideDepth                          ModelPrimitiveType bool bool bool Bool
    // 014 UseNormalAngle                           ModelPrimitiveType bool bool bool Bool
    // 015 UseOutsideNormalAngle                    ModelPrimitiveType bool bool bool Bool
    // 018 LayerMask                                ModelEnumType LayerMask LayerMask LayerMask Int32
    // 01C MinDepth                                 ModelPrimitiveType float float float Single
    // 020 MaxDepth                                 ModelPrimitiveType float float float Single
    // 024 MinNormalAngle                           ModelPrimitiveType float float float Single
    // 028 MaxNormalAngle                           ModelPrimitiveType float float float Single
    public partial class ContactFilter2D : DataModel
    {
        public bool                                     UseTriggers                             { get; set; }
        public bool                                     UseLayerMask                            { get; set; }
        public bool                                     UseDepth                                { get; set; }
        public bool                                     UseOutsideDepth                         { get; set; }
        public bool                                     UseNormalAngle                          { get; set; }
        public bool                                     UseOutsideNormalAngle                   { get; set; }
        public LayerMask                                LayerMask                               { get; set; }
        public float                                    MinDepth                                { get; set; }
        public float                                    MaxDepth                                { get; set; }
        public float                                    MinNormalAngle                          { get; set; }
        public float                                    MaxNormalAngle                          { get; set; }

        public static ContactFilter2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContactFilter2D() { Pointer= p0 };

            value.UseTriggers                               = GetBool(new IntPtr(p + 0x010)); // 0x10 UseTriggers                 ( ModelPrimitiveType bool bool bool Bool )
            value.UseLayerMask                              = GetBool(new IntPtr(p + 0x011)); // 0x11 UseLayerMask                ( ModelPrimitiveType bool bool bool Bool )
            value.UseDepth                                  = GetBool(new IntPtr(p + 0x012)); // 0x12 UseDepth                    ( ModelPrimitiveType bool bool bool Bool )
            value.UseOutsideDepth                           = GetBool(new IntPtr(p + 0x013)); // 0x13 UseOutsideDepth             ( ModelPrimitiveType bool bool bool Bool )
            value.UseNormalAngle                            = GetBool(new IntPtr(p + 0x014)); // 0x14 UseNormalAngle              ( ModelPrimitiveType bool bool bool Bool )
            value.UseOutsideNormalAngle                     = GetBool(new IntPtr(p + 0x015)); // 0x15 UseOutsideNormalAngle       ( ModelPrimitiveType bool bool bool Bool )
            value.LayerMask                                 = (LayerMask)GetInt32(new IntPtr(p + 0x018)); // 0x18 LayerMask                   ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.MinDepth                                  = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MinDepth                    ( ModelPrimitiveType float float float Single )
            value.MaxDepth                                  = GetSingle(new IntPtr(p + 0x020)); // 0x20 MaxDepth                    ( ModelPrimitiveType float float float Single )
            value.MinNormalAngle                            = GetSingle(new IntPtr(p + 0x024)); // 0x24 MinNormalAngle              ( ModelPrimitiveType float float float Single )
            value.MaxNormalAngle                            = GetSingle(new IntPtr(p + 0x028)); // 0x28 MaxNormalAngle              ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
