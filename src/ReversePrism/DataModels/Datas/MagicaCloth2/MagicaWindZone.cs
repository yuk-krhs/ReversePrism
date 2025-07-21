using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Mode                                     ModelEnumType Mode Mode Mode Int32
    // 024 Size                                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 Radius                                   ModelPrimitiveType float float float Single
    // 034 Main                                     ModelPrimitiveType float float float Single
    // 038 Turbulence                               ModelPrimitiveType float float float Single
    // 03C DirectionAngleX                          ModelPrimitiveType float float float Single
    // 040 DirectionAngleY                          ModelPrimitiveType float float float Single
    // 048 Attenuation                              ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 050 IsAddition                               ModelPrimitiveType bool bool bool Bool
    // 054 WindId                                   ModelPrimitiveType int int int Int32
    public partial class MagicaWindZone : DataModel
    {
        public Mode                                     Mode                                    { get; set; }
        public Vector3                                  Size                                    { get; set; }
        public float                                    Radius                                  { get; set; }
        public float                                    Main                                    { get; set; }
        public float                                    Turbulence                              { get; set; }
        public float                                    DirectionAngleX                         { get; set; }
        public float                                    DirectionAngleY                         { get; set; }
        public AnimationCurve?                          Attenuation                             { get; set; }
        public bool                                     IsAddition                              { get; set; }
        public int                                      WindId                                  { get; set; }

        public static MagicaWindZone? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaWindZone() { Pointer= p0 };

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x020)); // 0x20 Mode                        ( ModelEnumType Mode Mode Mode Int32 )
            value.Size                                      = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 Size                        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x030)); // 0x30 Radius                      ( ModelPrimitiveType float float float Single )
            value.Main                                      = GetSingle(new IntPtr(p + 0x034)); // 0x34 Main                        ( ModelPrimitiveType float float float Single )
            value.Turbulence                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 Turbulence                  ( ModelPrimitiveType float float float Single )
            value.DirectionAngleX                           = GetSingle(new IntPtr(p + 0x03C)); // 0x3C DirectionAngleX             ( ModelPrimitiveType float float float Single )
            value.DirectionAngleY                           = GetSingle(new IntPtr(p + 0x040)); // 0x40 DirectionAngleY             ( ModelPrimitiveType float float float Single )
            value.Attenuation                               = GetObject<AnimationCurve>(new IntPtr(p + 0x048), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x48 Attenuation                 ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.IsAddition                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsAddition                  ( ModelPrimitiveType bool bool bool Bool )
            value.WindId                                    = GetInt32(new IntPtr(p + 0x054)); // 0x54 WindId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
