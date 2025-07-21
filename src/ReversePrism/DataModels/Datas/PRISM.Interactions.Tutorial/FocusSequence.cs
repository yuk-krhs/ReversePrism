using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubSequence                              ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 018 UnmaskSprite                             ModelClassType Sprite Sprite Sprite Pointer
    // 020 ArrowPosition                            ModelEnumType ArrowPosition ArrowPosition ArrowPosition Int32
    // 024 ArrowType                                ModelEnumType ArrowType ArrowType ArrowType Int32
    // 028 ArrowOffsetPosition                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 AnnotationPosition                       ModelEnumType AnnotationPosition AnnotationPosition AnnotationPosition Int32
    // 038 AnnotationMessage                        ModelPrimitiveType string string string String
    public partial class FocusSequence : DataModel
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
            var value   = new FocusSequence() { Pointer= p0 };

            value.SubSequence                               = GetObject<ITutorialSequence>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x10 SubSequence                 ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.UnmaskSprite                              = GetObject<Sprite>(new IntPtr(p + 0x018), ReversePrism.DataModels.Sprite.FromPointer); // 0x18 UnmaskSprite                ( ModelClassType Sprite Sprite Sprite Pointer )
            value.ArrowPosition                             = (ArrowPosition)GetInt32(new IntPtr(p + 0x020)); // 0x20 ArrowPosition               ( ModelEnumType ArrowPosition ArrowPosition ArrowPosition Int32 )
            value.ArrowType                                 = (ArrowType)GetInt32(new IntPtr(p + 0x024)); // 0x24 ArrowType                   ( ModelEnumType ArrowType ArrowType ArrowType Int32 )
            value.ArrowOffsetPosition                       = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 ArrowOffsetPosition         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AnnotationPosition                        = (AnnotationPosition)GetInt32(new IntPtr(p + 0x030)); // 0x30 AnnotationPosition          ( ModelEnumType AnnotationPosition AnnotationPosition AnnotationPosition Int32 )
            value.AnnotationMessage                         = GetString(new IntPtr(p + 0x038)); // 0x38 AnnotationMessage           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
