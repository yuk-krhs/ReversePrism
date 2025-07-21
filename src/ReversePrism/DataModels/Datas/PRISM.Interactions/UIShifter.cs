using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentCell                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 SubCell                                  ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 Indicator                                ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 038 ShiftSeconds                             ModelPrimitiveType float float float Single
    // 03C AutoShiftSeconds                         ModelPrimitiveType float float float Single
    // 040 MoveSize                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 Count                                    ModelPrimitiveType int int int Int32
    // 04C CurrentIndex                             ModelPrimitiveType int int int Int32
    // 050 PrevShiftTime                            ModelPrimitiveType float float float Single
    // 058 onUpdateCell                             Subject`1<ValueTuple`2<RectTransform, int>> IL2CPP_TYPE_GENERICINST
    public partial class UIShifter : DataModel
    {
        public RectTransform?                           CurrentCell                             { get; set; }
        public RectTransform?                           SubCell                                 { get; set; }
        public CarouselIndicator?                       Indicator                               { get; set; }
        public float                                    ShiftSeconds                            { get; set; }
        public float                                    AutoShiftSeconds                        { get; set; }
        public Vector2                                  MoveSize                                { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public float                                    PrevShiftTime                           { get; set; }

        public static UIShifter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIShifter() { Pointer= p0 };

            value.CurrentCell                               = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 CurrentCell                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SubCell                                   = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 SubCell                     ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Indicator                                 = GetObject<CarouselIndicator>(new IntPtr(p + 0x030), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 0x30 Indicator                   ( ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )
            value.ShiftSeconds                              = GetSingle(new IntPtr(p + 0x038)); // 0x38 ShiftSeconds                ( ModelPrimitiveType float float float Single )
            value.AutoShiftSeconds                          = GetSingle(new IntPtr(p + 0x03C)); // 0x3C AutoShiftSeconds            ( ModelPrimitiveType float float float Single )
            value.MoveSize                                  = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 MoveSize                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 Count                       ( ModelPrimitiveType int int int Int32 )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x04C)); // 0x4C CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.PrevShiftTime                             = GetSingle(new IntPtr(p + 0x050)); // 0x50 PrevShiftTime               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
