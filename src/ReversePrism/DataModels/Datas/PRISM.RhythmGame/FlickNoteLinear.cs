using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 ArrowSpriteRenderer                      000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer
    // 030 ArrowContainer                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 ArrowOffsetToEdge                        0001866656B0 ModelPrimitiveType float float float Single
    // 03C ArrowSpace                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 ArrowFadeDuration                        0001866656B0 ModelPrimitiveType float float float Single
    // 048 ArrowSpriteRenderers                     000185D0C138 ModelClassListType List`1<SpriteRenderer> List`1<SpriteRenderer> List<SpriteRenderer> Pointer
    public partial class FlickNoteLinear
    {
        public SpriteRenderer?                          ArrowSpriteRenderer                     { get; set; }
        public Transform?                               ArrowContainer                          { get; set; }
        public float                                    ArrowOffsetToEdge                       { get; set; }
        public float                                    ArrowSpace                              { get; set; }
        public float                                    ArrowFadeDuration                       { get; set; }
        public List<SpriteRenderer>?                    ArrowSpriteRenderers                    { get; set; }

        public static FlickNoteLinear? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FlickNoteLinear();

            value.ArrowSpriteRenderer                       = GetObject<SpriteRenderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4FA20A0 0x28 ArrowSpriteRenderer         ( 000186552100 ModelClassType SpriteRenderer SpriteRenderer SpriteRenderer Pointer )
            value.ArrowContainer                            = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270D4FA20C0 0x30 ArrowContainer              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ArrowOffsetToEdge                         = GetSingle(new IntPtr(p + 0x038)); // 0270D4FA20E0 0x38 ArrowOffsetToEdge           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ArrowSpace                                = GetSingle(new IntPtr(p + 0x03C)); // 0270D4FA2100 0x3C ArrowSpace                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ArrowFadeDuration                         = GetSingle(new IntPtr(p + 0x040)); // 0270D4FA2120 0x40 ArrowFadeDuration           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ArrowSpriteRenderers                      = GetObjectList<SpriteRenderer>(new IntPtr(p + 0x048), ReversePrism.DataModels.SpriteRenderer.FromPointer); // 0270D4FA2140 0x48 ArrowSpriteRenderers        ( 000185D0C138 ModelClassListType List`1<SpriteRenderer> List`1<SpriteRenderer> List<SpriteRenderer> Pointer )

            return value;
        }
    }
}
