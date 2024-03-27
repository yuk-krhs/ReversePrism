using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubSequence                              0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 018 UnmaskSprite                             00018666B610 ModelClassType Sprite Sprite Sprite Pointer
    // 020 ArrowPosition                            0001866DA530 ModelEnumType ArrowPosition ArrowPosition ArrowPosition Int32
    // 024 ArrowType                                0001866DAF10 ModelEnumType ArrowType ArrowType ArrowType Int32
    // 028 ArrowOffsetPosition                      0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 AnnotationPosition                       0001866BC590 ModelEnumType AnnotationPosition AnnotationPosition AnnotationPosition Int32
    // 038 AnnotationMessage                        000186671910 ModelPrimitiveType string string string String
    public partial class FocusSequence
    {
        public ITutorialSequence?                       SubSequence                             { get; set; }
        public Sprite?                                  UnmaskSprite                            { get; set; }
        public ArrowPosition                            ArrowPosition                           { get; set; }
        public ArrowType                                ArrowType                               { get; set; }
        public Vector2                                  ArrowOffsetPosition                     { get; set; }
        public AnnotationPosition                       AnnotationPosition                      { get; set; }
        public string                                   AnnotationMessage                       { get; set; }

        public static FocusSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusSequence();

            value.SubSequence                               = GetObject<ITutorialSequence>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 027005AB1920 0x10 SubSequence                 ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.UnmaskSprite                              = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 027005AB1940 0x18 UnmaskSprite                ( 00018666B610 ModelClassType Sprite Sprite Sprite Pointer )
            value.ArrowPosition                             = (ArrowPosition)GetInt32(new IntPtr(p + 0x020)); // 027005AB1960 0x20 ArrowPosition               ( 0001866DA530 ModelEnumType ArrowPosition ArrowPosition ArrowPosition Int32 )
            value.ArrowType                                 = (ArrowType)GetInt32(new IntPtr(p + 0x024)); // 027005AB1980 0x24 ArrowType                   ( 0001866DAF10 ModelEnumType ArrowType ArrowType ArrowType Int32 )
            value.ArrowOffsetPosition                       = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 027005AB19A0 0x28 ArrowOffsetPosition         ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AnnotationPosition                        = (AnnotationPosition)GetInt32(new IntPtr(p + 0x030)); // 027005AB19C0 0x30 AnnotationPosition          ( 0001866BC590 ModelEnumType AnnotationPosition AnnotationPosition AnnotationPosition Int32 )
            value.AnnotationMessage                         = GetString(new IntPtr(p + 0x038)); // 027005AB19E0 0x38 AnnotationMessage           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
