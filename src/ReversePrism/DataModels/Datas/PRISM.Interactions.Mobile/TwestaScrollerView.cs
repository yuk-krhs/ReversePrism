using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 ArticleCellPrefab                        0001866C44C0 ModelClassType TwestaArticleCell TwestaArticleCell TwestaArticleCell Pointer
    // 030 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 thumbnailPopupViewFactory                PopupViewFactory`1<IThumbnailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 onClickArticle                           Subject`1<ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 048 onClickIcon                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onClickFavoriteToggle                    Subject`1<ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 058 onClickThumbnail                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 CellDataWithDisposablesList              000185D2EFF8 ModelClassListType List`1<TwestaArticleCellDataWithDisposables> List`1<TwestaArticleCellDataWithDisposables> List<TwestaArticleCellDataWithDisposables> Pointer
    // 068 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class TwestaScrollerView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public TwestaArticleCell?                       ArticleCellPrefab                       { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public List<TwestaArticleCellDataWithDisposables>? CellDataWithDisposablesList             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static TwestaScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaScrollerView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 02466B1CE0E0 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.ArticleCellPrefab                         = GetObject<TwestaArticleCell>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaArticleCell.FromPointer); // 02466B1CE100 0x28 ArticleCellPrefab           ( 0001866C44C0 ModelClassType TwestaArticleCell TwestaArticleCell TwestaArticleCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B1CE120 0x30 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CellDataWithDisposablesList               = GetObjectList<TwestaArticleCellDataWithDisposables>(new IntPtr(p + 0x060), ReversePrism.DataModels.TwestaArticleCellDataWithDisposables.FromPointer); // 02466B1CE1E0 0x60 CellDataWithDisposablesList ( 000185D2EFF8 ModelClassListType List`1<TwestaArticleCellDataWithDisposables> List`1<TwestaArticleCellDataWithDisposables> List<TwestaArticleCellDataWithDisposables> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B1CE200 0x68 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
