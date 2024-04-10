using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CurrentCell                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 SubCell                                  000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 Indicator                                000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 038 ShiftSeconds                             0001866656B0 ModelPrimitiveType float float float Single
    // 03C AutoShiftSeconds                         0001866656B0 ModelPrimitiveType float float float Single
    // 040 MoveSize                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 PrevShiftTime                            0001866656B0 ModelPrimitiveType float float float Single
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

            value.CurrentCell                               = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A4F68FB0 0x20 CurrentCell                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SubCell                                   = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A4F68FD0 0x28 SubCell                     ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Indicator                                 = GetObject<CarouselIndicator>(new IntPtr(p + 0x030), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 0245A4F68FF0 0x30 Indicator                   ( 000186547E60 ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )
            value.ShiftSeconds                              = GetSingle(new IntPtr(p + 0x038)); // 0245A4F69010 0x38 ShiftSeconds                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AutoShiftSeconds                          = GetSingle(new IntPtr(p + 0x03C)); // 0245A4F69030 0x3C AutoShiftSeconds            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MoveSize                                  = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0245A4F69050 0x40 MoveSize                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x048)); // 0245A4F69070 0x48 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x04C)); // 0245A4F69090 0x4C CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PrevShiftTime                             = GetSingle(new IntPtr(p + 0x050)); // 0245A4F690B0 0x50 PrevShiftTime               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
