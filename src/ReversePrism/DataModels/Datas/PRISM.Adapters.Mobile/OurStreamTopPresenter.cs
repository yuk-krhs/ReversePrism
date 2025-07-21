using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType OurStreamTopModel OurStreamTopModel OurStreamTopModel Pointer
    // 018 View                                     ModelClassType IOurStreamTopScreenView IOurStreamTopScreenView IOurStreamTopScreenView Pointer
    // 020 Parameter                                ModelClassType OurStreamTopParameter OurStreamTopParameter OurStreamTopParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 TabLiveList                              ModelClassListType List`1<ILiveStreamProgramStatus> List`1<ILiveStreamProgramStatus> List<ILiveStreamProgramStatus> Pointer
    // 048 TabArchiveList                           ModelClassListType List`1<IArchiveStreamProgramStatus> List`1<IArchiveStreamProgramStatus> List<IArchiveStreamProgramStatus> Pointer
    // 050 IsSortDown                               ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamTopPresenter : DataModel
    {
        public OurStreamTopModel?                       Model                                   { get; set; }
        public IOurStreamTopScreenView?                 View                                    { get; set; }
        public OurStreamTopParameter?                   Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public List<ILiveStreamProgramStatus>?          TabLiveList                             { get; set; }
        public List<IArchiveStreamProgramStatus>?       TabArchiveList                          { get; set; }
        public bool                                     IsSortDown                              { get; set; }

        public static OurStreamTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<OurStreamTopModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamTopModel.FromPointer); // 0x10 Model                       ( ModelClassType OurStreamTopModel OurStreamTopModel OurStreamTopModel Pointer )
            value.View                                      = GetObject<IOurStreamTopScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamTopScreenView.FromPointer); // 0x18 View                        ( ModelClassType IOurStreamTopScreenView IOurStreamTopScreenView IOurStreamTopScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamTopParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType OurStreamTopParameter OurStreamTopParameter OurStreamTopParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.TabLiveList                               = GetObjectList<ILiveStreamProgramStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ILiveStreamProgramStatus.FromPointer); // 0x40 TabLiveList                 ( ModelClassListType List`1<ILiveStreamProgramStatus> List`1<ILiveStreamProgramStatus> List<ILiveStreamProgramStatus> Pointer )
            value.TabArchiveList                            = GetObjectList<IArchiveStreamProgramStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IArchiveStreamProgramStatus.FromPointer); // 0x48 TabArchiveList              ( ModelClassListType List`1<IArchiveStreamProgramStatus> List`1<IArchiveStreamProgramStatus> List<IArchiveStreamProgramStatus> Pointer )
            value.IsSortDown                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsSortDown                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
