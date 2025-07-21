using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 nameInputTextKey                         string IL2CPP_TYPE_STRING
    // 060 ProducerName                             ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 068 ProducerNameCount                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ProducerNameLabelText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 NameInputEmptyText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 InfoText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 Model                                    ModelClassType PlayerNameInputModel PlayerNameInputModel PlayerNameInputModel Pointer
    public partial class PlayerNameInputPopupBase : DataModel
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
            var value   = new PlayerNameInputPopupBase() { Pointer= p0 };

            value.ProducerName                              = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x60 ProducerName                ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ProducerNameCount                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 ProducerNameCount           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ProducerNameLabelText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ProducerNameLabelText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NameInputEmptyText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 NameInputEmptyText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InfoText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 InfoText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Model                                     = GetObject<PlayerNameInputModel>(new IntPtr(p + 0x090), ReversePrism.DataModels.PlayerNameInputModel.FromPointer); // 0x90 Model                       ( ModelClassType PlayerNameInputModel PlayerNameInputModel PlayerNameInputModel Pointer )

            return value;
        }
    }
}
