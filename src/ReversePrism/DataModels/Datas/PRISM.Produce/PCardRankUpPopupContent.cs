using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GridView                                 000186702130 ModelClassType PCardRankUpGridView PCardRankUpGridView PCardRankUpGridView Pointer
    // 068 RankUpCountText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 HavingCardAmountText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 RankUpCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 RankUpModels                             000185B99920 ModelClassListType PCardRankUpModel[] PCardRankUpModel[] List<PCardRankUpModel> Pointer
    // 088 RankUpViewModels                         000185B99AF0 ModelClassListType PCardRankUpViewModel[] PCardRankUpViewModel[] List<PCardRankUpViewModel> Pointer
    // 090 RankUpPCards                             000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer
    // 098 OptionData                               000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    public partial class PCardRankUpPopupContent
    {
        public PCardRankUpGridView?                     GridView                                { get; set; }
        public UITextMeshProUGUI?                       RankUpCountText                         { get; set; }
        public UITextMeshProUGUI?                       HavingCardAmountText                    { get; set; }
        public int                                      RankUpCount                             { get; set; }
        public List<PCardRankUpModel>?                  RankUpModels                            { get; set; }
        public List<PCardRankUpViewModel>?              RankUpViewModels                        { get; set; }
        public List<IProduceCardStatus>?                RankUpPCards                            { get; set; }
        public ProduceOptionSaveData?                   OptionData                              { get; set; }

        public static PCardRankUpPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpPopupContent();

            value.GridView                                  = GetObject<PCardRankUpGridView>(new IntPtr(p + 0x060), ReversePrism.DataModels.PCardRankUpGridView.FromPointer); // 0270D5CEC9F0 0x60 GridView                    ( 000186702130 ModelClassType PCardRankUpGridView PCardRankUpGridView PCardRankUpGridView Pointer )
            value.RankUpCountText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CECA10 0x68 RankUpCountText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HavingCardAmountText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CECA30 0x70 HavingCardAmountText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankUpCount                               = GetInt32(new IntPtr(p + 0x078)); // 0270D5CECA50 0x78 RankUpCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RankUpModels                              = GetObjectList<PCardRankUpModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.PCardRankUpModel.FromPointer); // 0270D5CECA70 0x80 RankUpModels                ( 000185B99920 ModelClassListType PCardRankUpModel[] PCardRankUpModel[] List<PCardRankUpModel> Pointer )
            value.RankUpViewModels                          = GetObjectList<PCardRankUpViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.PCardRankUpViewModel.FromPointer); // 0270D5CECA90 0x88 RankUpViewModels            ( 000185B99AF0 ModelClassListType PCardRankUpViewModel[] PCardRankUpViewModel[] List<PCardRankUpViewModel> Pointer )
            value.RankUpPCards                              = GetObjectList<IProduceCardStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CECAB0 0x90 RankUpPCards                ( 000185CE7148 ModelClassListType List`1<IProduceCardStatus> List`1<IProduceCardStatus> List<IProduceCardStatus> Pointer )
            value.OptionData                                = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0270D5CECAD0 0x98 OptionData                  ( 000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
