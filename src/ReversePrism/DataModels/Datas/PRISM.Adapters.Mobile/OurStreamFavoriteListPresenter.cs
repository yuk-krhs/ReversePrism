using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866F2850 ModelClassType OurStreamFavoriteListModel OurStreamFavoriteListModel OurStreamFavoriteListModel Pointer
    // 018 View                                     0001865CA5A0 ModelClassType IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView Pointer
    // 020 Parameter                                0001866F2CE0 ModelClassType OurStreamFavoriteListParameter OurStreamFavoriteListParameter OurStreamFavoriteListParameter Pointer
    // 028 Container                                0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 030 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.Model                                     = GetObject<OurStreamFavoriteListModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurStreamFavoriteListModel.FromPointer); // 024666900A20 0x10 Model                       ( 0001866F2850 ModelClassType OurStreamFavoriteListModel OurStreamFavoriteListModel OurStreamFavoriteListModel Pointer )
            value.View                                      = GetObject<IOurStreamFavoriteListScreenView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamFavoriteListScreenView.FromPointer); // 024666900A40 0x18 View                        ( 0001865CA5A0 ModelClassType IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView IOurStreamFavoriteListScreenView Pointer )
            value.Parameter                                 = GetObject<OurStreamFavoriteListParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.OurStreamFavoriteListParameter.FromPointer); // 024666900A60 0x20 Parameter                   ( 0001866F2CE0 ModelClassType OurStreamFavoriteListParameter OurStreamFavoriteListParameter OurStreamFavoriteListParameter Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 024666900A80 0x28 Container                   ( 0001865B76B0 ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666900AA0 0x30 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
