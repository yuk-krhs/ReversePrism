using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterIconImage                       000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 Text                                     0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 ActivePositionX                          0001866656B0 ModelPrimitiveType float float float Single
    // 034 InactivePositionX                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 InOutAnimationSeconds                    0001866656B0 ModelPrimitiveType float float float Single
    // 03C KeepSeconds                              0001866656B0 ModelPrimitiveType float float float Single
    // 040 IsHorizontalMoving                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 TargetVerticalPosition                   0001866656B0 ModelPrimitiveType float float float Single
    // 048 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 Sequence                                 0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    public partial class LiveSkillView : DataModel
    {
        public RawImage?                                CharacterIconImage                      { get; set; }
        public TextMeshProUGUI?                         Text                                    { get; set; }
        public float                                    ActivePositionX                         { get; set; }
        public float                                    InactivePositionX                       { get; set; }
        public float                                    InOutAnimationSeconds                   { get; set; }
        public float                                    KeepSeconds                             { get; set; }
        public bool                                     IsHorizontalMoving                      { get; set; }
        public float                                    TargetVerticalPosition                  { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public Tween?                                   Sequence                                { get; set; }

        public static LiveSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillView() { Pointer= p0 };

            value.CharacterIconImage                        = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0246650B9670 0x20 CharacterIconImage          ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.Text                                      = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0246650B9690 0x28 Text                        ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ActivePositionX                           = GetSingle(new IntPtr(p + 0x030)); // 0246650B96B0 0x30 ActivePositionX             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InactivePositionX                         = GetSingle(new IntPtr(p + 0x034)); // 0246650B96D0 0x34 InactivePositionX           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InOutAnimationSeconds                     = GetSingle(new IntPtr(p + 0x038)); // 0246650B96F0 0x38 InOutAnimationSeconds       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.KeepSeconds                               = GetSingle(new IntPtr(p + 0x03C)); // 0246650B9710 0x3C KeepSeconds                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsHorizontalMoving                        = GetBool(new IntPtr(p + 0x040)); // 0246650B9730 0x40 IsHorizontalMoving          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetVerticalPosition                    = GetSingle(new IntPtr(p + 0x044)); // 0246650B9750 0x44 TargetVerticalPosition      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 0246650B9770 0x48 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Sequence                                  = GetObject<Tween>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tween.FromPointer); // 0246650B9790 0x50 Sequence                    ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
