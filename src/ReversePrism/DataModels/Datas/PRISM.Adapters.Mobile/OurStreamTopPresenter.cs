using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866F8FA0 ModelClassType OurStreamTopModel OurStreamTopModel OurStreamTopModel Pointer
    // 018 View                                     0001865CC280 ModelClassType IOurStreamTopScreenView IOurStreamTopScreenView IOurStreamTopScreenView Pointer
    // 020 Parameter                                0001866F94A0 ModelClassType OurStreamTopParameter OurStreamTopParameter OurStreamTopParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 detailPopupViewFactory                   IPopupViewFactory`1<IOurStreamLiveContentDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 038 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 TabLiveList                              000185CE5CB8 ModelClassListType List`1<ILiveStreamProgramStatus> List`1<ILiveStreamProgramStatus> List<ILiveStreamProgramStatus> Pointer
    // 048 TabArchiveList                           000185CCD0E8 ModelClassListType List`1<ArchiveStreamProgram> List`1<ArchiveStreamProgram> List<ArchiveStreamProgram> Pointer
    // 050 IsSortDown                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamTopPresenter : DataModel
    {
        public OurStreamTopModel?                       Model                                   { get; set; }
        public IOurStreamTopScreenView?                 View                                    { get; set; }
        public OurStreamTopParameter?                   Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public List<ILiveStreamProgramStatus>?          TabLiveList                             { get; set; }
        public List<ArchiveStreamProgram>?              TabArchiveList                          { get; set; }
        public bool                                     IsSortDown                              { get; set; }

        public static OurStreamTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<OurStreamTopModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamTopModel.FromPointer); // 02466692F6E8 0x10 Model                       ( 0001866F8FA0 ModelClassType OurStreamTopModel OurStreamTopModel OurStreamTopModel Pointer )
            value.View                                      = GetObject<IOurStreamTopScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamTopScreenView.FromPointer); // 02466692F708 0x18 View                        ( 0001865CC280 ModelClassType IOurStreamTopScreenView IOurStreamTopScreenView IOurStreamTopScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamTopParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamTopParameter.FromPointer); // 02466692F728 0x20 Parameter                   ( 0001866F94A0 ModelClassType OurStreamTopParameter OurStreamTopParameter OurStreamTopParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 02466692F748 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466692F788 0x38 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TabLiveList                               = GetObjectList<ILiveStreamProgramStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ILiveStreamProgramStatus.FromPointer); // 02466692F7A8 0x40 TabLiveList                 ( 000185CE5CB8 ModelClassListType List`1<ILiveStreamProgramStatus> List`1<ILiveStreamProgramStatus> List<ILiveStreamProgramStatus> Pointer )
            value.TabArchiveList                            = GetObjectList<ArchiveStreamProgram>(new IntPtr(p + 0x048), ReversePrism.DataModels.ArchiveStreamProgram.FromPointer); // 02466692F7C8 0x48 TabArchiveList              ( 000185CCD0E8 ModelClassListType List`1<ArchiveStreamProgram> List`1<ArchiveStreamProgram> List<ArchiveStreamProgram> Pointer )
            value.IsSortDown                                = GetBool(new IntPtr(p + 0x050)); // 02466692F7E8 0x50 IsSortDown                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
