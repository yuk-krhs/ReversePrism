using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 StopWithoutRelease                       ModelPrimitiveType bool bool bool Bool
    // 019 Muted                                    ModelPrimitiveType bool bool bool Bool
    // 01A IgnoreBlend                              ModelPrimitiveType bool bool bool Bool
    // 01B LoopWithinClip                           ModelPrimitiveType bool bool bool Bool
    // 01C StopAtClipEnd                            ModelPrimitiveType bool bool bool Bool
    // 020 OffsetTime                               ModelPrimitiveType double double double Double
    // 028 TemplateBehaviour                        ModelClassType CriAtomBehaviour CriAtomBehaviour CriAtomBehaviour Pointer
    // 030 ClipDuration                             ModelPrimitiveType double double double Double
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

            value.StopWithoutRelease                        = GetBool(new IntPtr(p + 0x018)); // 0x18 StopWithoutRelease          ( ModelPrimitiveType bool bool bool Bool )
            value.Muted                                     = GetBool(new IntPtr(p + 0x019)); // 0x19 Muted                       ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreBlend                               = GetBool(new IntPtr(p + 0x01A)); // 0x1A IgnoreBlend                 ( ModelPrimitiveType bool bool bool Bool )
            value.LoopWithinClip                            = GetBool(new IntPtr(p + 0x01B)); // 0x1B LoopWithinClip              ( ModelPrimitiveType bool bool bool Bool )
            value.StopAtClipEnd                             = GetBool(new IntPtr(p + 0x01C)); // 0x1C StopAtClipEnd               ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetTime                                = GetDouble(new IntPtr(p + 0x020)); // 0x20 OffsetTime                  ( ModelPrimitiveType double double double Double )
            value.TemplateBehaviour                         = GetObject<CriAtomBehaviour>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtomBehaviour.FromPointer); // 0x28 TemplateBehaviour           ( ModelClassType CriAtomBehaviour CriAtomBehaviour CriAtomBehaviour Pointer )
            value.ClipDuration                              = GetDouble(new IntPtr(p + 0x030)); // 0x30 ClipDuration                ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
