using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BtnConversion                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 Check                                    000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 TxtSelectedCount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SelectedLimitCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 onCheck                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 onConversionSubject                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class PieceArchiveBottomView
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
            var value   = new PieceArchiveBottomView();

            value.BtnConversion                             = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA290AC8 0x20 BtnConversion               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Check                                     = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA290AE8 0x28 Check                       ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.TxtSelectedCount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA290B08 0x30 TxtSelectedCount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedLimitCount                        = GetInt32(new IntPtr(p + 0x038)); // 0270DA290B28 0x38 SelectedLimitCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
