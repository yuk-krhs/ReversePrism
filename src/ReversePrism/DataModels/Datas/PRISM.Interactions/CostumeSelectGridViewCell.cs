using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 CostumeIconView                          00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer
    public partial class CostumeSelectGridViewCell
    {
        public CostumeIconView?                         CostumeIconView                         { get; set; }

        public static CostumeSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSelectGridViewCell();

            value.CostumeIconView                           = GetObject<CostumeIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0270DA2A71E8 0x30 CostumeIconView             ( 00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer )

            return value;
        }
    }
}
