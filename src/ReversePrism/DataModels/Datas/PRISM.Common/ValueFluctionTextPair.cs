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
    public partial class ValueFluctionTextPair
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
            var value   = new ValueFluctionTextPair();

            value.BeforeValueText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5507408 0x20 BeforeValueText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AfterValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5507428 0x28 AfterValueText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DigitNum                                  = GetInt32(new IntPtr(p + 0x030)); // 0270D5507448 0x30 DigitNum                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x034)); // 0270D5507468 0x34 IncreaseColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.DecreaseColor                             = (Color)GetInt32(new IntPtr(p + 0x044)); // 0270D5507488 0x44 DecreaseColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
