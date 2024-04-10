using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 viewFactory                              IPopupViewFactory`1<IMoviePopupView> IL2CPP_TYPE_GENERICINST
    // 018 Vm                                       00018665B8E0 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer
    // 020 PIdolDetailPopupViewFactory              0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer
    // 028 SCharaDetailPopupViewFactory             000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer
    // 030 onPlay                                   Subject`1<MoviePlayerModel> IL2CPP_TYPE_GENERICINST
    // 038 ProduceAdvStatusList                     000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer
    public partial class MoviePopupSequencer : DataModel
    {
        public MoviePopupViewModel?                     Vm                                      { get; set; }
        public IPIdolDetailPopupViewFactory?            PIdolDetailPopupViewFactory             { get; set; }
        public ISCharaDetailPopupViewFactory?           SCharaDetailPopupViewFactory            { get; set; }
        public List<IProduceAdvStatus>?                 ProduceAdvStatusList                    { get; set; }

        public static MoviePopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MoviePopupSequencer() { Pointer= p0 };

            value.Vm                                        = GetObject<MoviePopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MoviePopupViewModel.FromPointer); // 024665EF40F0 0x18 Vm                          ( 00018665B8E0 ModelClassType MoviePopupViewModel MoviePopupViewModel MoviePopupViewModel Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<IPIdolDetailPopupViewFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPIdolDetailPopupViewFactory.FromPointer); // 024665EF4110 0x20 PIdolDetailPopupViewFactory ( 0001865D0010 ModelClassType IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory IPIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<ISCharaDetailPopupViewFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISCharaDetailPopupViewFactory.FromPointer); // 024665EF4130 0x28 SCharaDetailPopupViewFactory ( 000186622C10 ModelClassType ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory ISCharaDetailPopupViewFactory Pointer )
            value.ProduceAdvStatusList                      = GetObjectList<IProduceAdvStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProduceAdvStatus.FromPointer); // 024665EF4170 0x38 ProduceAdvStatusList        ( 000185D05518 ModelClassListType IReadOnlyList`1<IProduceAdvStatus> IReadOnlyList`1<IProduceAdvStatus> List<IProduceAdvStatus> Pointer )

            return value;
        }
    }
}
