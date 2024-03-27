using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseTriggers                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 UseLayerMask                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 UseDepth                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 UseOutsideDepth                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 UseNormalAngle                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 015 UseOutsideNormalAngle                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 LayerMask                                00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 01C MinDepth                                 000186666050 ModelPrimitiveType float float float Single
    // 020 MaxDepth                                 000186666050 ModelPrimitiveType float float float Single
    // 024 MinNormalAngle                           000186666050 ModelPrimitiveType float float float Single
    // 028 MaxNormalAngle                           000186666050 ModelPrimitiveType float float float Single
    public partial class ContactFilter2D
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
            var value   = new ContactFilter2D();

            value.UseTriggers                               = GetBool(new IntPtr(p + 0x010)); // 027002291C28 0x10 UseTriggers                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseLayerMask                              = GetBool(new IntPtr(p + 0x011)); // 027002291C48 0x11 UseLayerMask                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseDepth                                  = GetBool(new IntPtr(p + 0x012)); // 027002291C68 0x12 UseDepth                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseOutsideDepth                           = GetBool(new IntPtr(p + 0x013)); // 027002291C88 0x13 UseOutsideDepth             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseNormalAngle                            = GetBool(new IntPtr(p + 0x014)); // 027002291CA8 0x14 UseNormalAngle              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UseOutsideNormalAngle                     = GetBool(new IntPtr(p + 0x015)); // 027002291CC8 0x15 UseOutsideNormalAngle       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LayerMask                                 = (LayerMask)GetInt32(new IntPtr(p + 0x018)); // 027002291CE8 0x18 LayerMask                   ( 00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.MinDepth                                  = GetSingle(new IntPtr(p + 0x01C)); // 027002291D08 0x1C MinDepth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxDepth                                  = GetSingle(new IntPtr(p + 0x020)); // 027002291D28 0x20 MaxDepth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.MinNormalAngle                            = GetSingle(new IntPtr(p + 0x024)); // 027002291D48 0x24 MinNormalAngle              ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxNormalAngle                            = GetSingle(new IntPtr(p + 0x028)); // 027002291D68 0x28 MaxNormalAngle              ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
