using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 IdolIconView                             0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 038 CursorObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 SettingsObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProfileSupportCharaSelectGridViewCell
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
            var value   = new ProfileSupportCharaSelectGridViewCell();

            value.IdolIconView                              = GetObject<SCharaIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0270DB742780 0x30 IdolIconView                ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.CursorObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB7427A0 0x38 CursorObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SettingsObject                            = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB7427C0 0x40 SettingsObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DB7427E0 0x48 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
