using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterIconImage                       ModelClassType RawImage RawImage RawImage Pointer
    // 028 Text                                     ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 ActivePositionX                          ModelPrimitiveType float float float Single
    // 034 InactivePositionX                        ModelPrimitiveType float float float Single
    // 038 InOutAnimationSeconds                    ModelPrimitiveType float float float Single
    // 03C KeepSeconds                              ModelPrimitiveType float float float Single
    // 040 IsHorizontalMoving                       ModelPrimitiveType bool bool bool Bool
    // 044 TargetVerticalPosition                   ModelPrimitiveType float float float Single
    // 048 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 Sequence                                 ModelClassType Tween Tween Tween Pointer
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

            value.CharacterIconImage                        = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 CharacterIconImage          ( ModelClassType RawImage RawImage RawImage Pointer )
            value.Text                                      = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x28 Text                        ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.ActivePositionX                           = GetSingle(new IntPtr(p + 0x030)); // 0x30 ActivePositionX             ( ModelPrimitiveType float float float Single )
            value.InactivePositionX                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 InactivePositionX           ( ModelPrimitiveType float float float Single )
            value.InOutAnimationSeconds                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 InOutAnimationSeconds       ( ModelPrimitiveType float float float Single )
            value.KeepSeconds                               = GetSingle(new IntPtr(p + 0x03C)); // 0x3C KeepSeconds                 ( ModelPrimitiveType float float float Single )
            value.IsHorizontalMoving                        = GetBool(new IntPtr(p + 0x040)); // 0x40 IsHorizontalMoving          ( ModelPrimitiveType bool bool bool Bool )
            value.TargetVerticalPosition                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 TargetVerticalPosition      ( ModelPrimitiveType float float float Single )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 0x48 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Sequence                                  = GetObject<Tween>(new IntPtr(p + 0x050), ReversePrism.DataModels.Tween.FromPointer); // 0x50 Sequence                    ( ModelClassType Tween Tween Tween Pointer )

            return value;
        }
    }
}
