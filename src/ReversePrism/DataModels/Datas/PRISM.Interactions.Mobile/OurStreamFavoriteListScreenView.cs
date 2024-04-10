using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 ArchiveCellViewParent                    0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 ArchiveCellViewPrefab                    0001866EF1C0 ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer
    // 038 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EmptyText2                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 058 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 060 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 onClickArchiveSelectSubject              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onClickFavoriteToggleSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 078 ArchiveCellList                          000185CF70A8 ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer
    public partial class OurStreamFavoriteListScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public Transform?                               ArchiveCellViewParent                   { get; set; }
        public OurStreamArchiveCellView?                ArchiveCellViewPrefab                   { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText2                              { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public List<OurStreamArchiveCellView>?          ArchiveCellList                         { get; set; }

        public static OurStreamFavoriteListScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 02466B198C80 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.ArchiveCellViewParent                     = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B198CA0 0x28 ArchiveCellViewParent       ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ArchiveCellViewPrefab                     = GetObject<OurStreamArchiveCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 02466B198CC0 0x30 ArchiveCellViewPrefab       ( 0001866EF1C0 ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466B198CE0 0x38 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B198D00 0x40 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EmptyText2                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B198D20 0x48 EmptyText2                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B198D40 0x50 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B198D60 0x58 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466B198D80 0x60 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ArchiveCellList                           = GetObjectList<OurStreamArchiveCellView>(new IntPtr(p + 0x078), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 02466B198DE0 0x78 ArchiveCellList             ( 000185CF70A8 ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer )

            return value;
        }
    }
}
