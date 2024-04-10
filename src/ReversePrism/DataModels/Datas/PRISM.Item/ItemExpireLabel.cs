using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ExpireLabel                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ExpireText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IntervalDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ItemExpireLabel : DataModel
    {
        public GameObject?                              ExpireLabel                             { get; set; }
        public UITextMeshProUGUI?                       ExpireText                              { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }

        public static ItemExpireLabel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemExpireLabel() { Pointer= p0 };

            value.ExpireLabel                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466534D1F0 0x20 ExpireLabel                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExpireText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466534D210 0x28 ExpireText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 02466534D230 0x30 IntervalDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
