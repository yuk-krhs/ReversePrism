using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType OurStreamArchiveDetailModel OurStreamArchiveDetailModel OurStreamArchiveDetailModel Pointer
    // 018 View                                     ModelClassType IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView Pointer
    // 020 Parameter                                ModelClassType OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 ArchiveData                              ModelClassType IArchiveStreamProgramStatus IArchiveStreamProgramStatus IArchiveStreamProgramStatus Pointer
    public partial class OurStreamArchiveDetailPresenter : DataModel
    {
        public OurStreamArchiveDetailModel?             Model                                   { get; set; }
        public IOurStreamArchiveDetailScreenView?       View                                    { get; set; }
        public OurStreamArchiveDetailParameter?         Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IArchiveStreamProgramStatus?             ArchiveData                             { get; set; }

        public static OurStreamArchiveDetailPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<OurStreamArchiveDetailModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamArchiveDetailModel.FromPointer); // 0x10 Model                       ( ModelClassType OurStreamArchiveDetailModel OurStreamArchiveDetailModel OurStreamArchiveDetailModel Pointer )
            value.View                                      = GetObject<IOurStreamArchiveDetailScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamArchiveDetailScreenView.FromPointer); // 0x18 View                        ( ModelClassType IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView IOurStreamArchiveDetailScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamArchiveDetailParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamArchiveDetailParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter OurStreamArchiveDetailParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.ArchiveData                               = GetObject<IArchiveStreamProgramStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IArchiveStreamProgramStatus.FromPointer); // 0x40 ArchiveData                 ( ModelClassType IArchiveStreamProgramStatus IArchiveStreamProgramStatus IArchiveStreamProgramStatus Pointer )

            return value;
        }
    }
}
