using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Fonts                                    ModelClassListType TMP_FontAsset[] TMP_FontAsset[] List<TMP_FontAsset> Pointer
    // 000 disableCounter                           int IL2CPP_TYPE_I4
    public partial class FontCleaner : DataModel
    {
        public List<TMP_FontAsset>?                     Fonts                                   { get; set; }

        public static FontCleaner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontCleaner() { Pointer= p0 };

            value.Fonts                                     = GetObjectList<TMP_FontAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_FontAsset.FromPointer); // 0x20 Fonts                       ( ModelClassListType TMP_FontAsset[] TMP_FontAsset[] List<TMP_FontAsset> Pointer )

            return value;
        }
    }
}
