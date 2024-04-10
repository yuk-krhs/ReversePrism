using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CountText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PieceIcon                                00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 PieceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 SelectBG                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class PieceExchangeRateCell : DataModel
    {
        public UITextMeshProUGUI?                       CountText                               { get; set; }
        public RewardItem?                              PieceIcon                               { get; set; }
        public UITextMeshProUGUI?                       PieceText                               { get; set; }
        public GameObject?                              SelectBG                                { get; set; }

        public static PieceExchangeRateCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PieceExchangeRateCell() { Pointer= p0 };

            value.CountText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665564088 0x20 CountText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceIcon                                 = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0246655640A8 0x28 PieceIcon                   ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655640C8 0x30 PieceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectBG                                  = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246655640E8 0x38 SelectBG                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
