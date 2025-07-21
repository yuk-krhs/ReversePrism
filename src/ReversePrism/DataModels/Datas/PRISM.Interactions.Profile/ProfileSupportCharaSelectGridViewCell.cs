using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 IdolIconView                             ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 038 CursorObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 040 SettingsObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 048 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileSupportCharaSelectGridViewCell : DataModel
    {
        public SCharaIconRectView?                      IdolIconView                            { get; set; }
        public GameObject?                              CursorObject                            { get; set; }
        public GameObject?                              SettingsObject                          { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ProfileSupportCharaSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectGridViewCell() { Pointer= p0 };

            value.IdolIconView                              = GetObject<SCharaIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x30 IdolIconView                ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.CursorObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 CursorObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SettingsObject                            = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 SettingsObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
