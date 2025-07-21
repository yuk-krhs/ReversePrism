using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtEpisodeTitle                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtCreateDate                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtSkip                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnSkipInfo                              ModelClassType UIButton UIButton UIButton Pointer
    // 048 Strategies                               ModelClassListType ProduceStrategyContentView[] ProduceStrategyContentView[] List<ProduceStrategyContentView> Pointer
    public partial class FUnitDetailProduceInfoView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtEpisodeTitle                         { get; set; }
        public UITextMeshProUGUI?                       TxtCreateDate                           { get; set; }
        public UITextMeshProUGUI?                       TxtSkip                                 { get; set; }
        public UIButton?                                BtnSkipInfo                             { get; set; }
        public List<ProduceStrategyContentView>?        Strategies                              { get; set; }

        public static FUnitDetailProduceInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailProduceInfoView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtEpisodeTitle                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtEpisodeTitle             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCreateDate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtCreateDate               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkip                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtSkip                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnSkipInfo                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnSkipInfo                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Strategies                                = GetObjectList<ProduceStrategyContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceStrategyContentView.FromPointer); // 0x48 Strategies                  ( ModelClassListType ProduceStrategyContentView[] ProduceStrategyContentView[] List<ProduceStrategyContentView> Pointer )

            return value;
        }
    }
}
