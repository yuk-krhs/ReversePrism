using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 GoCostumeContent                         ModelClassType GashaDetailCostumeCell GashaDetailCostumeCell GashaDetailCostumeCell Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 CostumeViewModels                        ModelClassListType List`1<GashaDetailCostumeViewModel> List`1<GashaDetailCostumeViewModel> List<GashaDetailCostumeViewModel> Pointer
    // 040 Context                                  ModelClassType GashaDetailCostumeViewContext GashaDetailCostumeViewContext GashaDetailCostumeViewContext Pointer
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GashaCostumePopupView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public GashaDetailCostumeCell?                  GoCostumeContent                        { get; set; }
        public List<GashaDetailCostumeViewModel>?       CostumeViewModels                       { get; set; }
        public GashaDetailCostumeViewContext?           Context                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GashaCostumePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaCostumePopupView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.GoCostumeContent                          = GetObject<GashaDetailCostumeCell>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaDetailCostumeCell.FromPointer); // 0x28 GoCostumeContent            ( ModelClassType GashaDetailCostumeCell GashaDetailCostumeCell GashaDetailCostumeCell Pointer )
            value.CostumeViewModels                         = GetObjectList<GashaDetailCostumeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaDetailCostumeViewModel.FromPointer); // 0x38 CostumeViewModels           ( ModelClassListType List`1<GashaDetailCostumeViewModel> List`1<GashaDetailCostumeViewModel> List<GashaDetailCostumeViewModel> Pointer )
            value.Context                                   = GetObject<GashaDetailCostumeViewContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.GashaDetailCostumeViewContext.FromPointer); // 0x40 Context                     ( ModelClassType GashaDetailCostumeViewContext GashaDetailCostumeViewContext GashaDetailCostumeViewContext Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
