using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 NormalText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SelectedText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 NewBadgeObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class FriendCategoryListViewCell
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
            var value   = new FriendCategoryListViewCell();

            value.NormalText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5D98 0x40 NormalText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SelectedText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBDE5DB8 0x48 SelectedText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NewBadgeObject                            = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBDE5DD8 0x50 NewBadgeObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DBDE5DF8 0x58 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
