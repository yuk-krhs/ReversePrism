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
    // 040 PIdolDuplicatedObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceSupportCharaSelectGridViewCell
    {
        public SCharaIconRectView?                      IdolIconView                            { get; set; }
        public GameObject?                              CursorObject                            { get; set; }
        public GameObject?                              PIdolDuplicatedObject                   { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ProduceSupportCharaSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectGridViewCell();

            value.IdolIconView                              = GetObject<SCharaIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0270DA118F70 0x30 IdolIconView                ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.CursorObject                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA118F90 0x38 CursorObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDuplicatedObject                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA118FB0 0x40 PIdolDuplicatedObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA118FD0 0x48 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
