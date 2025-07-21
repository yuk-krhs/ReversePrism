using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType OurStreamFavoriteListModel OurStreamFavoriteListModel OurStreamFavoriteListModel Pointer
    // 018 View                                     ModelClassType IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView Pointer
    // 020 Parameter                                ModelClassType OurStreamFavoriteListParameter OurStreamFavoriteListParameter OurStreamFavoriteListParameter Pointer
    // 028 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class OurStreamFavoriteListPresenter : DataModel
    {
        public OurStreamFavoriteListModel?              Model                                   { get; set; }
        public IOurStreamFavoriteListScreenView?        View                                    { get; set; }
        public OurStreamFavoriteListParameter?          Parameter                               { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static OurStreamFavoriteListPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<OurStreamFavoriteListModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamFavoriteListModel.FromPointer); // 0x10 Model                       ( ModelClassType OurStreamFavoriteListModel OurStreamFavoriteListModel OurStreamFavoriteListModel Pointer )
            value.View                                      = GetObject<IOurStreamFavoriteListScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamFavoriteListScreenView.FromPointer); // 0x18 View                        ( ModelClassType IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamFavoriteListParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamFavoriteListParameter.FromPointer); // 0x20 Parameter                   ( ModelClassType OurStreamFavoriteListParameter OurStreamFavoriteListParameter OurStreamFavoriteListParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x28 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
