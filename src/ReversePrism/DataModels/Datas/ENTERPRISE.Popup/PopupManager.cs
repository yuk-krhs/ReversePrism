using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultContentKeys                       string[] IL2CPP_TYPE_SZARRAY
    // 020 _cacheObjects                            Dictionary`2<string, ValueTuple`2<string, GameObject>> IL2CPP_TYPE_GENERICINST
    // 028 _templateButtons                         Dictionary`2<MessagePopupButtonType, List`1<ButtonInformation>> IL2CPP_TYPE_GENERICINST
    // 030 AttachedSystem                           ModelClassType PopupSystem PopupSystem PopupSystem Pointer
    public partial class PopupManager : DataModel
    {
        public PopupSystem?                             AttachedSystem                          { get; set; }

        public static PopupManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupManager() { Pointer= p0 };

            value.AttachedSystem                            = GetObject<PopupSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.PopupSystem.FromPointer); // 0x30 AttachedSystem              ( ModelClassType PopupSystem PopupSystem PopupSystem Pointer )

            return value;
        }
    }
}
