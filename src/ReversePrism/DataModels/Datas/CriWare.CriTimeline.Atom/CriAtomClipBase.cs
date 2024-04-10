using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 StopWithoutRelease                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 Muted                                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 01A IgnoreBlend                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 01B LoopWithinClip                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C StopAtClipEnd                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 OffsetTime                               0001865C2E50 ModelPrimitiveType double double double Double
    // 028 TemplateBehaviour                        000186641650 ModelClassType CriAtomBehaviour CriAtomBehaviour CriAtomBehaviour Pointer
    // 030 ClipDuration                             0001865C2950 ModelPrimitiveType double double double Double
    public partial class CriAtomClipBase : DataModel
    {
        public bool                                     StopWithoutRelease                      { get; set; }
        public bool                                     Muted                                   { get; set; }
        public bool                                     IgnoreBlend                             { get; set; }
        public bool                                     LoopWithinClip                          { get; set; }
        public bool                                     StopAtClipEnd                           { get; set; }
        public double                                   OffsetTime                              { get; set; }
        public CriAtomBehaviour?                        TemplateBehaviour                       { get; set; }
        public double                                   ClipDuration                            { get; set; }

        public static CriAtomClipBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomClipBase() { Pointer= p0 };

            value.StopWithoutRelease                        = GetBool(new IntPtr(p + 0x018)); // 024664E15B80 0x18 StopWithoutRelease          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Muted                                     = GetBool(new IntPtr(p + 0x019)); // 024664E15BA0 0x19 Muted                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreBlend                               = GetBool(new IntPtr(p + 0x01A)); // 024664E15BC0 0x1A IgnoreBlend                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LoopWithinClip                            = GetBool(new IntPtr(p + 0x01B)); // 024664E15BE0 0x1B LoopWithinClip              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StopAtClipEnd                             = GetBool(new IntPtr(p + 0x01C)); // 024664E15C00 0x1C StopAtClipEnd               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OffsetTime                                = GetDouble(new IntPtr(p + 0x020)); // 024664E15C20 0x20 OffsetTime                  ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.TemplateBehaviour                         = GetObject<CriAtomBehaviour>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomBehaviour.FromPointer); // 024664E15C40 0x28 TemplateBehaviour           ( 000186641650 ModelClassType CriAtomBehaviour CriAtomBehaviour CriAtomBehaviour Pointer )
            value.ClipDuration                              = GetDouble(new IntPtr(p + 0x030)); // 024664E15C60 0x30 ClipDuration                ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
