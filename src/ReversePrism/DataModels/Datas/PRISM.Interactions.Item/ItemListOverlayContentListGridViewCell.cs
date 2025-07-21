using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 038 ExpireLabel                              ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer
    // 040 SelectedCursorObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 048 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 050 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ItemListOverlayContentListGridViewCell : DataModel
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public ItemExpireLabel?                         ExpireLabel                             { get; set; }
        public GameObject?                              SelectedCursorObject                    { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ItemListOverlayContentListGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemListOverlayContentListGridViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x30 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ExpireLabel                               = GetObject<ItemExpireLabel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ItemExpireLabel.FromPointer); // 0x38 ExpireLabel                 ( ModelClassType ItemExpireLabel ItemExpireLabel ItemExpireLabel Pointer )
            value.SelectedCursorObject                      = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 SelectedCursorObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x048)); // 0x48 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
