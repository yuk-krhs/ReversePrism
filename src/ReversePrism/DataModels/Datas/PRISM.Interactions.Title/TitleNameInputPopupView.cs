using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameInputPopupContent                    0001867544C0 ModelClassType PlayerNameInputContent PlayerNameInputContent PlayerNameInputContent Pointer
    // 028 NameInputConfirmContent                  000186754000 ModelClassType PlayerNameConfirmContent PlayerNameConfirmContent PlayerNameConfirmContent Pointer
    public partial class TitleNameInputPopupView : DataModel
    {
        public PlayerNameInputContent?                  NameInputPopupContent                   { get; set; }
        public PlayerNameConfirmContent?                NameInputConfirmContent                 { get; set; }

        public static TitleNameInputPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleNameInputPopupView() { Pointer= p0 };

            value.NameInputPopupContent                     = GetObject<PlayerNameInputContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayerNameInputContent.FromPointer); // 0245A43FBC40 0x20 NameInputPopupContent       ( 0001867544C0 ModelClassType PlayerNameInputContent PlayerNameInputContent PlayerNameInputContent Pointer )
            value.NameInputConfirmContent                   = GetObject<PlayerNameConfirmContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.PlayerNameConfirmContent.FromPointer); // 0245A43FBC60 0x28 NameInputConfirmContent     ( 000186754000 ModelClassType PlayerNameConfirmContent PlayerNameConfirmContent PlayerNameConfirmContent Pointer )

            return value;
        }
    }
}
