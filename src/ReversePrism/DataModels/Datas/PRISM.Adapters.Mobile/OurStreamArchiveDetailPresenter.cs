using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866F0030 ModelClassType OurStreamArchiveDetailModel OurStreamArchiveDetailModel OurStreamArchiveDetailModel Pointer
    // 018 View                                     0001865CA0E0 ModelClassType IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView Pointer
    // 020 Parameter                                0001866F0550 ModelClassType OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 detailPopupViewFactory                   IPopupViewFactory`1<IOurStreamLiveContentDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 ArchiveData                              0001866D2A40 ModelClassType ArchiveStreamProgram ArchiveStreamProgram ArchiveStreamProgram Pointer
    public partial class OurStreamArchiveDetailPresenter : DataModel
    {
        public OurStreamArchiveDetailModel?             Model                                   { get; set; }
        public IOurStreamArchiveDetailScreenView?       View                                    { get; set; }
        public OurStreamArchiveDetailParameter?         Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public ArchiveStreamProgram?                    ArchiveData                             { get; set; }

        public static OurStreamArchiveDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<OurStreamArchiveDetailModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamArchiveDetailModel.FromPointer); // 0246668FF580 0x10 Model                       ( 0001866F0030 ModelClassType OurStreamArchiveDetailModel OurStreamArchiveDetailModel OurStreamArchiveDetailModel Pointer )
            value.View                                      = GetObject<IOurStreamArchiveDetailScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamArchiveDetailScreenView.FromPointer); // 0246668FF5A0 0x18 View                        ( 0001865CA0E0 ModelClassType IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamArchiveDetailParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamArchiveDetailParameter.FromPointer); // 0246668FF5C0 0x20 Parameter                   ( 0001866F0550 ModelClassType OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0246668FF5E0 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246668FF620 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ArchiveData                               = GetObject<ArchiveStreamProgram>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArchiveStreamProgram.FromPointer); // 0246668FF640 0x40 ArchiveData                 ( 0001866D2A40 ModelClassType ArchiveStreamProgram ArchiveStreamProgram ArchiveStreamProgram Pointer )

            return value;
        }
    }
}
