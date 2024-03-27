using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 nameInputTextKey                         string IL2CPP_TYPE_STRING
    // 060 ProducerName                             0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 068 ProducerNameCount                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ProducerNameLabelText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NameInputEmptyText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 InfoText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 Model                                    000186754BB0 ModelClassType PlayerNameInputModel PlayerNameInputModel PlayerNameInputModel Pointer
    public partial class PlayerNameInputPopupBase
    {
        public CommonInputFieldTMP?                     ProducerName                            { get; set; }
        public UITextMeshProUGUI?                       ProducerNameCount                       { get; set; }
        public UITextMeshProUGUI?                       ProducerNameLabelText                   { get; set; }
        public UITextMeshProUGUI?                       NameInputEmptyText                      { get; set; }
        public UITextMeshProUGUI?                       InfoText                                { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public PlayerNameInputModel?                    Model                                   { get; set; }

        public static PlayerNameInputPopupBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerNameInputPopupBase();

            value.ProducerName                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270043957F8 0x60 ProducerName                ( 0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ProducerNameCount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395818 0x68 ProducerNameCount           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducerNameLabelText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395838 0x70 ProducerNameLabelText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NameInputEmptyText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395858 0x78 NameInputEmptyText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InfoText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395878 0x80 InfoText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004395898 0x88 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Model                                     = GetObject<PlayerNameInputModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.PlayerNameInputModel.FromPointer); // 0270043958B8 0x90 Model                       ( 000186754BB0 ModelClassType PlayerNameInputModel PlayerNameInputModel PlayerNameInputModel Pointer )

            return value;
        }
    }
}
