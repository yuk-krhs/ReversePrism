using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018651B0D0 ModelClassType IFriendOverlayView IFriendOverlayView IFriendOverlayView Pointer
    // 018 ViewModel                                0001865CD230 ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer
    // 020 permanentData                            SavableJsonObject`1<FriendListSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 OverlayManager                           0001866FE7B0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 048 CategoryType                             0001866CDC80 ModelEnumType CategoryType CategoryType CategoryType Int32
    // 04C SortCategory                             0001866CE810 ModelEnumType SortCategory SortCategory SortCategory Int32
    // 050 SortOrder                                0001866CEF50 ModelEnumType SortOrder SortOrder SortOrder Int32
    public partial class FriendOverlayPresenter
    {
        public IFriendOverlayView?                      View                                    { get; set; }
        public FriendViewModel?                         ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CategoryType                             CategoryType                            { get; set; }
        public SortCategory                             SortCategory                            { get; set; }
        public SortOrder                                SortOrder                               { get; set; }

        public static FriendOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendOverlayPresenter();

            value.View                                      = GetObject<IFriendOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendOverlayView.FromPointer); // 0270D63217B0 0x10 View                        ( 00018651B0D0 ModelClassType IFriendOverlayView IFriendOverlayView IFriendOverlayView Pointer )
            value.ViewModel                                 = GetObject<FriendViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendViewModel.FromPointer); // 0270D63217D0 0x18 ViewModel                   ( 0001865CD230 ModelClassType FriendViewModel FriendViewModel FriendViewModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6321830 0x30 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6321850 0x38 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x040), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D6321870 0x40 OverlayManager              ( 0001866FE7B0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.CategoryType                              = (CategoryType)GetInt32(new IntPtr(p + 0x048)); // 0270D6321890 0x48 CategoryType                ( 0001866CDC80 ModelEnumType CategoryType CategoryType CategoryType Int32 )
            value.SortCategory                              = (SortCategory)GetInt32(new IntPtr(p + 0x04C)); // 0270D63218B0 0x4C SortCategory                ( 0001866CE810 ModelEnumType SortCategory SortCategory SortCategory Int32 )
            value.SortOrder                                 = (SortOrder)GetInt32(new IntPtr(p + 0x050)); // 0270D63218D0 0x50 SortOrder                   ( 0001866CEF50 ModelEnumType SortOrder SortOrder SortOrder Int32 )

            return value;
        }
    }
}
