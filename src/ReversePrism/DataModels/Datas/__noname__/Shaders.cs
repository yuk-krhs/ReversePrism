using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bloom                                    ModelClassType Shader Shader Shader Pointer
    // 018 SoftOverlay                              ModelClassType Shader Shader Shader Pointer
    // 020 RadialBlur                               ModelClassType Shader Shader Shader Pointer
    // 028 Copy                                     ModelClassType Shader Shader Shader Pointer
    // 030 CopyStd                                  ModelClassType Shader Shader Shader Pointer
    // 038 CopyStdFromTexArray                      ModelClassType Shader Shader Shader Pointer
    // 040 CopyStdFromDoubleWide                    ModelClassType Shader Shader Shader Pointer
    // 048 DiscardAlpha                             ModelClassType Shader Shader Shader Pointer
    // 050 DepthOfField                             ModelClassType Shader Shader Shader Pointer
    // 058 FinalPass                                ModelClassType Shader Shader Shader Pointer
    // 060 GrainBaker                               ModelClassType Shader Shader Shader Pointer
    // 068 Texture2dLerp                            ModelClassType Shader Shader Shader Pointer
    // 070 Uber                                     ModelClassType Shader Shader Shader Pointer
    // 078 Lut2DBaker                               ModelClassType Shader Shader Shader Pointer
    public partial class Shaders : DataModel
    {
        public Shader?                                  Bloom                                   { get; set; }
        public Shader?                                  SoftOverlay                             { get; set; }
        public Shader?                                  RadialBlur                              { get; set; }
        public Shader?                                  Copy                                    { get; set; }
        public Shader?                                  CopyStd                                 { get; set; }
        public Shader?                                  CopyStdFromTexArray                     { get; set; }
        public Shader?                                  CopyStdFromDoubleWide                   { get; set; }
        public Shader?                                  DiscardAlpha                            { get; set; }
        public Shader?                                  DepthOfField                            { get; set; }
        public Shader?                                  FinalPass                               { get; set; }
        public Shader?                                  GrainBaker                              { get; set; }
        public Shader?                                  Texture2dLerp                           { get; set; }
        public Shader?                                  Uber                                    { get; set; }
        public Shader?                                  Lut2DBaker                              { get; set; }

        public static Shaders? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Shaders() { Pointer= p0 };

            value.Bloom                                     = GetObject<Shader>(new IntPtr(p + 0x010), ReversePrism.DataModels.Shader.FromPointer); // 0x10 Bloom                       ( ModelClassType Shader Shader Shader Pointer )
            value.SoftOverlay                               = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 0x18 SoftOverlay                 ( ModelClassType Shader Shader Shader Pointer )
            value.RadialBlur                                = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0x20 RadialBlur                  ( ModelClassType Shader Shader Shader Pointer )
            value.Copy                                      = GetObject<Shader>(new IntPtr(p + 0x028), ReversePrism.DataModels.Shader.FromPointer); // 0x28 Copy                        ( ModelClassType Shader Shader Shader Pointer )
            value.CopyStd                                   = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 CopyStd                     ( ModelClassType Shader Shader Shader Pointer )
            value.CopyStdFromTexArray                       = GetObject<Shader>(new IntPtr(p + 0x038), ReversePrism.DataModels.Shader.FromPointer); // 0x38 CopyStdFromTexArray         ( ModelClassType Shader Shader Shader Pointer )
            value.CopyStdFromDoubleWide                     = GetObject<Shader>(new IntPtr(p + 0x040), ReversePrism.DataModels.Shader.FromPointer); // 0x40 CopyStdFromDoubleWide       ( ModelClassType Shader Shader Shader Pointer )
            value.DiscardAlpha                              = GetObject<Shader>(new IntPtr(p + 0x048), ReversePrism.DataModels.Shader.FromPointer); // 0x48 DiscardAlpha                ( ModelClassType Shader Shader Shader Pointer )
            value.DepthOfField                              = GetObject<Shader>(new IntPtr(p + 0x050), ReversePrism.DataModels.Shader.FromPointer); // 0x50 DepthOfField                ( ModelClassType Shader Shader Shader Pointer )
            value.FinalPass                                 = GetObject<Shader>(new IntPtr(p + 0x058), ReversePrism.DataModels.Shader.FromPointer); // 0x58 FinalPass                   ( ModelClassType Shader Shader Shader Pointer )
            value.GrainBaker                                = GetObject<Shader>(new IntPtr(p + 0x060), ReversePrism.DataModels.Shader.FromPointer); // 0x60 GrainBaker                  ( ModelClassType Shader Shader Shader Pointer )
            value.Texture2dLerp                             = GetObject<Shader>(new IntPtr(p + 0x068), ReversePrism.DataModels.Shader.FromPointer); // 0x68 Texture2dLerp               ( ModelClassType Shader Shader Shader Pointer )
            value.Uber                                      = GetObject<Shader>(new IntPtr(p + 0x070), ReversePrism.DataModels.Shader.FromPointer); // 0x70 Uber                        ( ModelClassType Shader Shader Shader Pointer )
            value.Lut2DBaker                                = GetObject<Shader>(new IntPtr(p + 0x078), ReversePrism.DataModels.Shader.FromPointer); // 0x78 Lut2DBaker                  ( ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
