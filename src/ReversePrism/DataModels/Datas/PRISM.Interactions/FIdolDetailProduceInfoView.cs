using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtEpisodeTitle                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtCreateDate                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtSkip                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnSkipInfo                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 Strategies                               000185B9DA40 ModelClassListType ProduceStrategyContentView[] ProduceStrategyContentView[] List<ProduceStrategyContentView> Pointer
    public partial class FIdolDetailProduceInfoView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtEpisodeTitle                         { get; set; }
        public UITextMeshProUGUI?                       TxtCreateDate                           { get; set; }
        public UITextMeshProUGUI?                       TxtSkip                                 { get; set; }
        public UIButton?                                BtnSkipInfo                             { get; set; }
        public List<ProduceStrategyContentView>?        Strategies                              { get; set; }

        public static FIdolDetailProduceInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailProduceInfoView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A301800 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtEpisodeTitle                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A301820 0x28 TxtEpisodeTitle             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCreateDate                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A301840 0x30 TxtCreateDate               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkip                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A301860 0x38 TxtSkip                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnSkipInfo                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A301880 0x40 BtnSkipInfo                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Strategies                                = GetObjectList<ProduceStrategyContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceStrategyContentView.FromPointer); // 02466A3018A0 0x48 Strategies                  ( 000185B9DA40 ModelClassListType ProduceStrategyContentView[] ProduceStrategyContentView[] List<ProduceStrategyContentView> Pointer )

            return value;
        }
    }
}
