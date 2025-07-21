using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NormalText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SelectedText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 NewBadgeObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 058 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendCategoryListViewCell : DataModel
    {
        public UITextMeshProUGUI?                       NormalText                              { get; set; }
        public UITextMeshProUGUI?                       SelectedText                            { get; set; }
        public GameObject?                              NewBadgeObject                          { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static FriendCategoryListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendCategoryListViewCell() { Pointer= p0 };

            value.NormalText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 NormalText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 SelectedText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewBadgeObject                            = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 NewBadgeObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
