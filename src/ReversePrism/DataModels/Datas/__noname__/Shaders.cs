using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bloom                                    00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 018 SoftOverlay                              00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 020 RadialBlur                               00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 028 Copy                                     00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 030 CopyStd                                  00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 038 CopyStdFromTexArray                      00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 040 CopyStdFromDoubleWide                    00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 048 DiscardAlpha                             00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 050 DepthOfField                             00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 058 FinalPass                                00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 060 GrainBaker                               00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 068 Texture2dLerp                            00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 070 Uber                                     00018674CC40 ModelClassType Shader Shader Shader Pointer
    // 078 Lut2DBaker                               00018674CC40 ModelClassType Shader Shader Shader Pointer
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

            value.Bloom                                     = GetObject<Shader>(new IntPtr(p + 0x010), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB308 0x10 Bloom                       ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.SoftOverlay                               = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB328 0x18 SoftOverlay                 ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.RadialBlur                                = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB348 0x20 RadialBlur                  ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.Copy                                      = GetObject<Shader>(new IntPtr(p + 0x028), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB368 0x28 Copy                        ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.CopyStd                                   = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB388 0x30 CopyStd                     ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.CopyStdFromTexArray                       = GetObject<Shader>(new IntPtr(p + 0x038), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB3A8 0x38 CopyStdFromTexArray         ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.CopyStdFromDoubleWide                     = GetObject<Shader>(new IntPtr(p + 0x040), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB3C8 0x40 CopyStdFromDoubleWide       ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.DiscardAlpha                              = GetObject<Shader>(new IntPtr(p + 0x048), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB3E8 0x48 DiscardAlpha                ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.DepthOfField                              = GetObject<Shader>(new IntPtr(p + 0x050), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB408 0x50 DepthOfField                ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.FinalPass                                 = GetObject<Shader>(new IntPtr(p + 0x058), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB428 0x58 FinalPass                   ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.GrainBaker                                = GetObject<Shader>(new IntPtr(p + 0x060), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB448 0x60 GrainBaker                  ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.Texture2dLerp                             = GetObject<Shader>(new IntPtr(p + 0x068), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB468 0x68 Texture2dLerp               ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.Uber                                      = GetObject<Shader>(new IntPtr(p + 0x070), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB488 0x70 Uber                        ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )
            value.Lut2DBaker                                = GetObject<Shader>(new IntPtr(p + 0x078), ReversePrism.DataModels.Shader.FromPointer); // 0245A60DB4A8 0x78 Lut2DBaker                  ( 00018674CC40 ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
