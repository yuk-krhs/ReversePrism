using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 NameLabel                                ModelClassType Text Text Text Pointer
    // 068 ValueLabel                               ModelClassType Text Text Text Pointer
    // 070 ProgressBarRect                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 078 M_Value                                  ModelClassType ProgressBarValue ProgressBarValue ProgressBarValue Pointer
    // 080 M_Timer                                  ModelPrimitiveType float float float Single
    public partial class DebugUIHandlerProgressBar : DataModel
    {
        public Text?                                    NameLabel                               { get; set; }
        public Text?                                    ValueLabel                              { get; set; }
        public RectTransform?                           ProgressBarRect                         { get; set; }
        public ProgressBarValue?                        M_Value                                 { get; set; }
        public float                                    M_Timer                                 { get; set; }

        public static DebugUIHandlerProgressBar? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerProgressBar() { Pointer= p0 };

            value.NameLabel                                 = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 NameLabel                   ( ModelClassType Text Text Text Pointer )
            value.ValueLabel                                = GetObject<Text>(new IntPtr(p + 0x068), ReversePrism.DataModels.Text.FromPointer); // 0x68 ValueLabel                  ( ModelClassType Text Text Text Pointer )
            value.ProgressBarRect                           = GetObject<RectTransform>(new IntPtr(p + 0x070), ReversePrism.DataModels.RectTransform.FromPointer); // 0x70 ProgressBarRect             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Value                                   = GetObject<ProgressBarValue>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProgressBarValue.FromPointer); // 0x78 M_Value                     ( ModelClassType ProgressBarValue ProgressBarValue ProgressBarValue Pointer )
            value.M_Timer                                   = GetSingle(new IntPtr(p + 0x080)); // 0x80 M_Timer                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
