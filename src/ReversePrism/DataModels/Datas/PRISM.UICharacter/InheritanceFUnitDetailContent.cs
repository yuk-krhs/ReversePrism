using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FUnitInfoPresenter                       ModelClassType FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter Pointer
    // 068 SupportPresenter                         ModelClassType FUnitDetailSupportPresenter FUnitDetailSupportPresenter FUnitDetailSupportPresenter Pointer
    // 070 Fu                                       ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 078 DetectTouchDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class InheritanceFUnitDetailContent : DataModel
    {
        public FUnitDetailFUnitInfoPresenter?           FUnitInfoPresenter                      { get; set; }
        public FUnitDetailSupportPresenter?             SupportPresenter                        { get; set; }
        public IFesUnitStatus?                          Fu                                      { get; set; }
        public IDisposable?                             DetectTouchDisposable                   { get; set; }

        public static InheritanceFUnitDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFUnitDetailContent() { Pointer= p0 };

            value.FUnitInfoPresenter                        = GetObject<FUnitDetailFUnitInfoPresenter>(new IntPtr(p + 0x060), ReversePrism.DataModels.FUnitDetailFUnitInfoPresenter.FromPointer); // 0x60 FUnitInfoPresenter          ( ModelClassType FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter Pointer )
            value.SupportPresenter                          = GetObject<FUnitDetailSupportPresenter>(new IntPtr(p + 0x068), ReversePrism.DataModels.FUnitDetailSupportPresenter.FromPointer); // 0x68 SupportPresenter            ( ModelClassType FUnitDetailSupportPresenter FUnitDetailSupportPresenter FUnitDetailSupportPresenter Pointer )
            value.Fu                                        = GetObject<IFesUnitStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 0x70 Fu                          ( ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.DetectTouchDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 0x78 DetectTouchDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
