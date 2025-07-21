using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IVoicePopupView IVoicePopupView IVoicePopupView Pointer
    // 018 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 020 Vm                                       ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer
    // 028 PIdolDetailPopupViewFactory              ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 030 SCharaDetailPopupViewFactory             ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 038 onPlayListCategory                       Subject`1<ValueTuple`2<IdolVoicePlayListCategory, int>> IL2CPP_TYPE_GENERICINST
    // 040 ProduceAdvStatusList                     ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class VoicePopupPresenter : DataModel
    {
        public IVoicePopupView?                         View                                    { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public VoicePopupViewModel?                     Vm                                      { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static VoicePopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IVoicePopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IVoicePopupView.FromPointer); // 0x10 View                        ( ModelClassType IVoicePopupView IVoicePopupView IVoicePopupView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x18 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Vm                                        = GetObject<VoicePopupViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.VoicePopupViewModel.FromPointer); // 0x20 Vm                          ( ModelClassType VoicePopupViewModel VoicePopupViewModel VoicePopupViewModel Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 0x28 PIdolDetailPopupViewFactory ( ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 0x30 SCharaDetailPopupViewFactory ( ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 0x40 ProduceAdvStatusList        ( ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
