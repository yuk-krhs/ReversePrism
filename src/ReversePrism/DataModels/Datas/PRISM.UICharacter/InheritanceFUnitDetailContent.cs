using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FUnitInfoPresenter                       0001865487E0 ModelClassType FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter Pointer
    // 068 SupportPresenter                         00018654B8E0 ModelClassType FUnitDetailSupportPresenter FUnitDetailSupportPresenter FUnitDetailSupportPresenter Pointer
    // 070 Fu                                       000186509E50 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer
    // 078 DetectTouchDisposable                    0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.FUnitInfoPresenter                        = GetObject<FUnitDetailFUnitInfoPresenter>(new IntPtr(p + 0x060), ReversePrism.DataModels.FUnitDetailFUnitInfoPresenter.FromPointer); // 024665E1E090 0x60 FUnitInfoPresenter          ( 0001865487E0 ModelClassType FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter FUnitDetailFUnitInfoPresenter Pointer )
            value.SupportPresenter                          = GetObject<FUnitDetailSupportPresenter>(new IntPtr(p + 0x068), ReversePrism.DataModels.FUnitDetailSupportPresenter.FromPointer); // 024665E1E0B0 0x68 SupportPresenter            ( 00018654B8E0 ModelClassType FUnitDetailSupportPresenter FUnitDetailSupportPresenter FUnitDetailSupportPresenter Pointer )
            value.Fu                                        = GetObject<IFesUnitStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.IFesUnitStatus.FromPointer); // 024665E1E0D0 0x70 Fu                          ( 000186509E50 ModelClassType IFesUnitStatus IFesUnitStatus IFesUnitStatus Pointer )
            value.DetectTouchDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDisposable.FromPointer); // 024665E1E0F0 0x78 DetectTouchDisposable       ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
