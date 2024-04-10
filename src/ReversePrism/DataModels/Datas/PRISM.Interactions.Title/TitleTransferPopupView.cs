using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GameStartContent                         0001865EE310 ModelClassType GameStartContent GameStartContent GameStartContent Pointer
    // 028 TransferAccount                          0001866A2500 ModelClassType TransferAccount TransferAccount TransferAccount Pointer
    public partial class TitleTransferPopupView : DataModel
    {
        public GameStartContent?                        GameStartContent                        { get; set; }
        public TransferAccount?                         TransferAccount                         { get; set; }

        public static TitleTransferPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleTransferPopupView() { Pointer= p0 };

            value.GameStartContent                          = GetObject<GameStartContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameStartContent.FromPointer); // 0245A43FBE98 0x20 GameStartContent            ( 0001865EE310 ModelClassType GameStartContent GameStartContent GameStartContent Pointer )
            value.TransferAccount                           = GetObject<TransferAccount>(new IntPtr(p + 0x028), ReversePrism.DataModels.TransferAccount.FromPointer); // 0245A43FBEB8 0x28 TransferAccount             ( 0001866A2500 ModelClassType TransferAccount TransferAccount TransferAccount Pointer )

            return value;
        }
    }
}
