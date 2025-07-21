using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnConversion                            ModelClassType UIButton UIButton UIButton Pointer
    // 028 Check                                    ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 TxtSelectedCount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SelectedLimitCount                       ModelPrimitiveType int int int Int32
    // 040 onCheck                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 onConversionSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class PieceArchiveBottomView : DataModel
    {
        public UIButton?                                BtnConversion                           { get; set; }
        public ToggleButton?                            Check                                   { get; set; }
        public UITextMeshProUGUI?                       TxtSelectedCount                        { get; set; }
        public int                                      SelectedLimitCount                      { get; set; }

        public static PieceArchiveBottomView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceArchiveBottomView() { Pointer= p0 };

            value.BtnConversion                             = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 BtnConversion               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Check                                     = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 Check                       ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.TxtSelectedCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtSelectedCount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedLimitCount                        = GetInt32(new IntPtr(p + 0x038)); // 0x38 SelectedLimitCount          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
