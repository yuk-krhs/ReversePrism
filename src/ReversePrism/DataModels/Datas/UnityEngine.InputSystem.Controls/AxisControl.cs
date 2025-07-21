using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 108 Clamp                                    ModelEnumType Clamp Clamp Clamp Int32
    // 10C ClampMin                                 ModelPrimitiveType float float float Single
    // 110 ClampMax                                 ModelPrimitiveType float float float Single
    // 114 ClampConstant                            ModelPrimitiveType float float float Single
    // 118 Invert                                   ModelPrimitiveType bool bool bool Bool
    // 119 Normalize                                ModelPrimitiveType bool bool bool Bool
    // 11C NormalizeMin                             ModelPrimitiveType float float float Single
    // 120 NormalizeMax                             ModelPrimitiveType float float float Single
    // 124 NormalizeZero                            ModelPrimitiveType float float float Single
    // 128 Scale                                    ModelPrimitiveType bool bool bool Bool
    // 12C ScaleFactor                              ModelPrimitiveType float float float Single
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

            value.Clamp                                     = (Clamp)GetInt32(new IntPtr(p + 0x108)); // 0x108 Clamp                       ( ModelEnumType Clamp Clamp Clamp Int32 )
            value.ClampMin                                  = GetSingle(new IntPtr(p + 0x10C)); // 0x10C ClampMin                    ( ModelPrimitiveType float float float Single )
            value.ClampMax                                  = GetSingle(new IntPtr(p + 0x110)); // 0x110 ClampMax                    ( ModelPrimitiveType float float float Single )
            value.ClampConstant                             = GetSingle(new IntPtr(p + 0x114)); // 0x114 ClampConstant               ( ModelPrimitiveType float float float Single )
            value.Invert                                    = GetBool(new IntPtr(p + 0x118)); // 0x118 Invert                      ( ModelPrimitiveType bool bool bool Bool )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x119)); // 0x119 Normalize                   ( ModelPrimitiveType bool bool bool Bool )
            value.NormalizeMin                              = GetSingle(new IntPtr(p + 0x11C)); // 0x11C NormalizeMin                ( ModelPrimitiveType float float float Single )
            value.NormalizeMax                              = GetSingle(new IntPtr(p + 0x120)); // 0x120 NormalizeMax                ( ModelPrimitiveType float float float Single )
            value.NormalizeZero                             = GetSingle(new IntPtr(p + 0x124)); // 0x124 NormalizeZero               ( ModelPrimitiveType float float float Single )
            value.Scale                                     = GetBool(new IntPtr(p + 0x128)); // 0x128 Scale                       ( ModelPrimitiveType bool bool bool Bool )
            value.ScaleFactor                               = GetSingle(new IntPtr(p + 0x12C)); // 0x12C ScaleFactor                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
