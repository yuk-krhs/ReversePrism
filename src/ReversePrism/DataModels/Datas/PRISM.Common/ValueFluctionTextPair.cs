using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BeforeValueText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 AfterValueText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DigitNum                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 IncreaseColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 044 DecreaseColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
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

            value.BeforeValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665570AA0 0x20 BeforeValueText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665570AC0 0x28 AfterValueText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DigitNum                                  = GetInt32(new IntPtr(p + 0x030)); // 024665570AE0 0x30 DigitNum                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x034)); // 024665570B00 0x34 IncreaseColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.DecreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x044)); // 024665570B20 0x44 DecreaseColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
