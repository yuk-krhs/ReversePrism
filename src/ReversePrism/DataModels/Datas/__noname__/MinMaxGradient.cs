using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Mode                                   ModelEnumType ParticleSystemGradientMode ParticleSystemGradientMode ParticleSystemGradientMode Int32
    // 018 M_GradientMin                            ModelClassType Gradient Gradient Gradient Pointer
    // 020 M_GradientMax                            ModelClassType Gradient Gradient Gradient Pointer
    // 028 M_ColorMin                               ModelEnumType Color Color Color Int32
    // 038 M_ColorMax                               ModelEnumType Color Color Color Int32
    public partial class MinMaxGradient : DataModel
    {
        public ParticleSystemGradientMode               M_Mode                                  { get; set; }
        public Gradient?                                M_GradientMin                           { get; set; }
        public Gradient?                                M_GradientMax                           { get; set; }
        public Color                                    M_ColorMin                              { get; set; }
        public Color                                    M_ColorMax                              { get; set; }

        public static MinMaxGradient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinMaxGradient() { Pointer= p0 };

            value.M_Mode                                    = (ParticleSystemGradientMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Mode                      ( ModelEnumType ParticleSystemGradientMode ParticleSystemGradientMode ParticleSystemGradientMode Int32 )
            value.M_GradientMin                             = GetObject<Gradient>(new IntPtr(p + 0x018), ReversePrism.DataModels.Gradient.FromPointer); // 0x18 M_GradientMin               ( ModelClassType Gradient Gradient Gradient Pointer )
            value.M_GradientMax                             = GetObject<Gradient>(new IntPtr(p + 0x020), ReversePrism.DataModels.Gradient.FromPointer); // 0x20 M_GradientMax               ( ModelClassType Gradient Gradient Gradient Pointer )
            value.M_ColorMin                                = (Color)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_ColorMin                  ( ModelEnumType Color Color Color Int32 )
            value.M_ColorMax                                = (Color)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_ColorMax                  ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
