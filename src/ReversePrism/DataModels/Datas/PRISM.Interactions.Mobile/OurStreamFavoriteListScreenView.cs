using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 ArchiveCellViewParent                    ModelClassType Transform Transform Transform Pointer
    // 030 ArchiveCellViewPrefab                    ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer
    // 038 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 040 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 EmptyText2                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 058 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 060 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 onClickArchiveSelectSubject              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onClickFavoriteToggleSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 078 ArchiveCellList                          ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer
    public partial class OurStreamFavoriteListScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public Transform?                               ArchiveCellViewParent                   { get; set; }
        public OurStreamArchiveCellView?                ArchiveCellViewPrefab                   { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UITextMeshProUGUI?                       EmptyText2                              { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public List<OurStreamArchiveCellView>?          ArchiveCellList                         { get; set; }

        public static OurStreamFavoriteListScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamFavoriteListScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x20 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.ArchiveCellViewParent                     = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ArchiveCellViewParent       ( ModelClassType Transform Transform Transform Pointer )
            value.ArchiveCellViewPrefab                     = GetObject<OurStreamArchiveCellView>(new IntPtr(p + 0x030), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 0x30 ArchiveCellViewPrefab       ( ModelClassType OurStreamArchiveCellView OurStreamArchiveCellView OurStreamArchiveCellView Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EmptyText2                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 EmptyText2                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x50 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x58 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ArchiveCellList                           = GetObjectList<OurStreamArchiveCellView>(new IntPtr(p + 0x078), ReversePrism.DataModels.OurStreamArchiveCellView.FromPointer); // 0x78 ArchiveCellList             ( ModelClassListType List`1<OurStreamArchiveCellView> List`1<OurStreamArchiveCellView> List<OurStreamArchiveCellView> Pointer )

            return value;
        }
    }
}
