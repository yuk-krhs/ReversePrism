using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 SelectablePCardGridView                  00018671F870 ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer
    // 068 DeleteCountText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 DeckCountWarningText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 HavingCardAmount                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 DeleteProduceCardAmount                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 selectablePCardViewModels                IList`1<SelectablePCardViewModel> IL2CPP_TYPE_GENERICINST
    // 090 SelectCards                              000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 OptionData                               000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
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

            value.SelectablePCardGridView                   = GetObject<SelectablePCardGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.SelectablePCardGridView.FromPointer); // 024665D1CBE8 0x60 SelectablePCardGridView     ( 00018671F870 ModelClassType SelectablePCardGridView SelectablePCardGridView SelectablePCardGridView Pointer )
            value.DeleteCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D1CC08 0x68 DeleteCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeckCountWarningText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D1CC28 0x70 DeckCountWarningText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HavingCardAmount                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665D1CC48 0x78 HavingCardAmount            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DeleteProduceCardAmount                   = GetInt32(new IntPtr(p + 0x080)); // 024665D1CC68 0x80 DeleteProduceCardAmount     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectCards                               = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 024665D1CCA8 0x90 SelectCards                 ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.OptionData                                = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 024665D1CCC8 0x98 OptionData                  ( 000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
