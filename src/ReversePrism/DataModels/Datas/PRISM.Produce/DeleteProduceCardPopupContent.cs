using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 SelectablePCardGridView                  ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer
    // 068 DeleteCountText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 DeckCountWarningText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 HavingCardAmount                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 DeleteProduceCardAmount                  ModelPrimitiveType int int int Int32
    // 088 selectablePCardViewModels                IList`1<SelectablePCardViewModel> IL2CPP_TYPE_GENERICINST
    // 090 SelectCards                              ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 OptionData                               ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    public partial class DeleteProduceCardPopupContent : DataModel
    {
        public SelectablePCardGridView?                 SelectablePCardGridView                 { get; set; }
        public UITextMeshProUGUI?                       DeleteCountText                         { get; set; }
        public UITextMeshProUGUI?                       DeckCountWarningText                    { get; set; }
        public UITextMeshProUGUI?                       HavingCardAmount                        { get; set; }
        public int                                      DeleteProduceCardAmount                 { get; set; }
        public List<IProduceCardStatus>?                SelectCards                             { get; set; }
        public ProduceOptionSaveData?                   OptionData                              { get; set; }

        public static DeleteProduceCardPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteProduceCardPopupContent() { Pointer= p0 };

            value.SelectablePCardGridView                   = GetObject<SelectablePCardGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SelectablePCardGridView.FromPointer); // 0x60 SelectablePCardGridView     ( ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer )
            value.DeleteCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 DeleteCountText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeckCountWarningText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 DeckCountWarningText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HavingCardAmount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 HavingCardAmount            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeleteProduceCardAmount                   = GetInt32(new IntPtr(p + 0x080)); // 0x80 DeleteProduceCardAmount     ( ModelPrimitiveType int int int Int32 )
            value.SelectCards                               = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x90 SelectCards                 ( ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.OptionData                                = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0x98 OptionData                  ( ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
