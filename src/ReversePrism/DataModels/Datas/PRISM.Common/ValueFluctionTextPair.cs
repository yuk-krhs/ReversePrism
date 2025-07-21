using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeValueText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AfterValueText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DigitNum                                 ModelPrimitiveType int int int Int32
    // 034 IncreaseColor                            ModelEnumType Color Color Color Int32
    // 044 DecreaseColor                            ModelEnumType Color Color Color Int32
    public partial class ValueFluctionTextPair : DataModel
    {
        public UITextMeshProUGUI?                       BeforeValueText                         { get; set; }
        public UITextMeshProUGUI?                       AfterValueText                          { get; set; }
        public int                                      DigitNum                                { get; set; }
        public Color                                    IncreaseColor                           { get; set; }
        public Color                                    DecreaseColor                           { get; set; }

        public static ValueFluctionTextPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueFluctionTextPair() { Pointer= p0 };

            value.BeforeValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 BeforeValueText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 AfterValueText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DigitNum                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 DigitNum                    ( ModelPrimitiveType int int int Int32 )
            value.IncreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 IncreaseColor               ( ModelEnumType Color Color Color Int32 )
            value.DecreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x044)); // 0x44 DecreaseColor               ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
