using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 108 Clamp                                    0001866EAB90 ModelEnumType Clamp Clamp Clamp Int32
    // 10C ClampMin                                 000186666050 ModelPrimitiveType float float float Single
    // 110 ClampMax                                 000186666050 ModelPrimitiveType float float float Single
    // 114 ClampConstant                            000186666050 ModelPrimitiveType float float float Single
    // 118 Invert                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 119 Normalize                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 11C NormalizeMin                             000186666050 ModelPrimitiveType float float float Single
    // 120 NormalizeMax                             000186666050 ModelPrimitiveType float float float Single
    // 124 NormalizeZero                            000186666050 ModelPrimitiveType float float float Single
    // 128 Scale                                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 12C ScaleFactor                              000186666050 ModelPrimitiveType float float float Single
    public partial class AxisControl : DataModel
    {
        public Clamp                                    Clamp                                   { get; set; }
        public float                                    ClampMin                                { get; set; }
        public float                                    ClampMax                                { get; set; }
        public float                                    ClampConstant                           { get; set; }
        public bool                                     Invert                                  { get; set; }
        public bool                                     Normalize                               { get; set; }
        public float                                    NormalizeMin                            { get; set; }
        public float                                    NormalizeMax                            { get; set; }
        public float                                    NormalizeZero                           { get; set; }
        public bool                                     Scale                                   { get; set; }
        public float                                    ScaleFactor                             { get; set; }

        public static AxisControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisControl() { Pointer= p0 };

            value.Clamp                                     = (Clamp)GetInt32(new IntPtr(p + 0x108)); // 0245A3365300 0x108 Clamp                       ( 0001866EAB90 ModelEnumType Clamp Clamp Clamp Int32 )
            value.ClampMin                                  = GetSingle(new IntPtr(p + 0x10C)); // 0245A3365320 0x10C ClampMin                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.ClampMax                                  = GetSingle(new IntPtr(p + 0x110)); // 0245A3365340 0x110 ClampMax                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.ClampConstant                             = GetSingle(new IntPtr(p + 0x114)); // 0245A3365360 0x114 ClampConstant               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Invert                                    = GetBool(new IntPtr(p + 0x118)); // 0245A3365380 0x118 Invert                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x119)); // 0245A33653A0 0x119 Normalize                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NormalizeMin                              = GetSingle(new IntPtr(p + 0x11C)); // 0245A33653C0 0x11C NormalizeMin                ( 000186666050 ModelPrimitiveType float float float Single )
            value.NormalizeMax                              = GetSingle(new IntPtr(p + 0x120)); // 0245A33653E0 0x120 NormalizeMax                ( 000186666050 ModelPrimitiveType float float float Single )
            value.NormalizeZero                             = GetSingle(new IntPtr(p + 0x124)); // 0245A3365400 0x124 NormalizeZero               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Scale                                     = GetBool(new IntPtr(p + 0x128)); // 0245A3365420 0x128 Scale                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ScaleFactor                               = GetSingle(new IntPtr(p + 0x12C)); // 0245A3365440 0x12C ScaleFactor                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
