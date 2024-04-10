using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 LiveCellViewParent                       0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 LiveCellViewPrefab                       0001866F47E0 ModelClassType OurStreamLiveDetailCellView OurStreamLiveDetailCellView OurStreamLiveDetailCellView Pointer
    // 038 ArchiveHeaderTabGroup                    0001866F1700 ModelClassType OurStreamArchiveListHeaderTabGroup OurStreamArchiveListHeaderTabGroup OurStreamArchiveListHeaderTabGroup Pointer
    // 040 ArchiveViewArea                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 ArchiveCellViewParent                    0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 ArchiveCellViewPrefab                    0001866EF1C0 ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer
    // 058 ArchiveListEmptyView                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 070 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 078 DisposableCellView                       0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 onClickLiveDetailSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 onClickLiveViewingSubject                Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 090 onClickArchiveSelectSubject              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 098 onClickFavoriteToggleSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 0A0 onRefreshSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A8 LiveCellViewList                         000185CF72E8 ModelClassListType List`1<OurStreamLiveDetailCellView> List`1<OurStreamLiveDetailCellView> List<OurStreamLiveDetailCellView> Pointer
    // 0B0 ArchiveCellList                          000185CF70A8 ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer
    // 0B8 liveCellViewPool                         ObjectPool`1<OurStreamLiveDetailCellView> IL2CPP_TYPE_GENERICINST
    // 0C0 archiveCellViewPool                      ObjectPool`1<OurStreamArchiveCellView> IL2CPP_TYPE_GENERICINST
    // 0C8 ArchiveScrollRect                        0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    public partial class OurStreamTopScreenView : DataModel
    {
        public UIButton?                                FavoriteButton                          { get; set; }
        public Transform?                               LiveCellViewParent                      { get; set; }
        public OurStreamLiveDetailCellView?             LiveCellViewPrefab                      { get; set; }
        public OurStreamArchiveListHeaderTabGroup?      ArchiveHeaderTabGroup                   { get; set; }
        public GameObject?                              ArchiveViewArea                         { get; set; }
        public Transform?                               ArchiveCellViewParent                   { get; set; }
        public OurStreamArchiveCellView?                ArchiveCellViewPrefab                   { get; set; }
        public GameObject?                              ArchiveListEmptyView                    { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CompositeDisposable?                     DisposableCellView                      { get; set; }
        public List<OurStreamLiveDetailCellView>?       LiveCellViewList                        { get; set; }
        public List<OurStreamArchiveCellView>?          ArchiveCellList                         { get; set; }
        public ScrollRect?                              ArchiveScrollRect                       { get; set; }

        public static OurStreamTopScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamTopScreenView() { Pointer= p0 };

            value.FavoriteButton                            = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466B1B6A60 0x20 FavoriteButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveCellViewParent                        = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466B1B6A80 0x28 LiveCellViewParent          ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.LiveCellViewPrefab                        = GetObject<OurStreamLiveDetailCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.OurStreamLiveDetailCellView.FromPointer); // 02466B1B6AA0 0x30 LiveCellViewPrefab          ( 0001866F47E0 ModelClassType OurStreamLiveDetailCellView OurStreamLiveDetailCellView OurStreamLiveDetailCellView Pointer )
            value.ArchiveHeaderTabGroup                     = GetObject<OurStreamArchiveListHeaderTabGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.OurStreamArchiveListHeaderTabGroup.FromPointer); // 02466B1B6AC0 0x38 ArchiveHeaderTabGroup       ( 0001866F1700 ModelClassType OurStreamArchiveListHeaderTabGroup OurStreamArchiveListHeaderTabGroup OurStreamArchiveListHeaderTabGroup Pointer )
            value.ArchiveViewArea                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1B6AE0 0x40 ArchiveViewArea             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ArchiveCellViewParent                     = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466B1B6B00 0x48 ArchiveCellViewParent       ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ArchiveCellViewPrefab                     = GetObject<OurStreamArchiveCellView>(new IntPtr(p + 0x050), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 02466B1B6B20 0x50 ArchiveCellViewPrefab       ( 0001866EF1C0 ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer )
            value.ArchiveListEmptyView                      = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1B6B40 0x58 ArchiveListEmptyView        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1B6B60 0x60 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x068), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 02466B1B6B80 0x68 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B1B6BA0 0x70 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.DisposableCellView                        = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466B1B6BC0 0x78 DisposableCellView          ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.LiveCellViewList                          = GetObjectList<OurStreamLiveDetailCellView>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.OurStreamLiveDetailCellView.FromPointer); // 02466B1B6C80 0xA8 LiveCellViewList            ( 000185CF72E8 ModelClassListType List`1<OurStreamLiveDetailCellView> List`1<OurStreamLiveDetailCellView> List<OurStreamLiveDetailCellView> Pointer )
            value.ArchiveCellList                           = GetObjectList<OurStreamArchiveCellView>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 02466B1B6CA0 0xB0 ArchiveCellList             ( 000185CF70A8 ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer )
            value.ArchiveScrollRect                         = GetObject<ScrollRect>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B1B6D00 0xC8 ArchiveScrollRect           ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )

            return value;
        }
    }
}
