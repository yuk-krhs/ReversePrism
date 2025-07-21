using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 ArticleCellPrefab                        ModelClassType TwestaArticleCell TwestaArticleCell TwestaArticleCell Pointer
    // 030 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 onClickArticle                           Subject`1<ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 040 onClickIcon                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 onClickFavoriteToggle                    Subject`1<ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 050 onClickThumbnail                         Subject`1<ITwestaArticleCellData> IL2CPP_TYPE_GENERICINST
    // 058 CellDataWithDisposablesList              ModelClassListType List`1<TwestaArticleCellDataWithDisposables> List`1<TwestaArticleCellDataWithDisposables> List<TwestaArticleCellDataWithDisposables> Pointer
    // 060 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class TwestaScrollerView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public TwestaArticleCell?                       ArticleCellPrefab                       { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public List<TwestaArticleCellDataWithDisposables>? CellDataWithDisposablesList             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static TwestaScrollerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TwestaScrollerView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.ArticleCellPrefab                         = GetObject<TwestaArticleCell>(new IntPtr(p + 0x028), ReversePrism.DataModels.TwestaArticleCell.FromPointer); // 0x28 ArticleCellPrefab           ( ModelClassType TwestaArticleCell TwestaArticleCell TwestaArticleCell Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CellDataWithDisposablesList               = GetObjectList<TwestaArticleCellDataWithDisposables>(new IntPtr(p + 0x058), ReversePrism.DataModels.TwestaArticleCellDataWithDisposables.FromPointer); // 0x58 CellDataWithDisposablesList ( ModelClassListType List`1<TwestaArticleCellDataWithDisposables> List`1<TwestaArticleCellDataWithDisposables> List<TwestaArticleCellDataWithDisposables> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x60 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
