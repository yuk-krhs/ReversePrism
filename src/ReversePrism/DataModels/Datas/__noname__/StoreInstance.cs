using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreName                                000186672F10 ModelPrimitiveType string string string String
    // 018 Instance                                 0001866587B0 ModelClassType IStore IStore IStore Pointer
    public partial class StoreInstance
    {
        public string                                   StoreName                               { get; set; }
        public IStore?                                  Instance                                { get; set; }

        public static StoreInstance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreInstance();

            value.StoreName                                 = GetString(new IntPtr(p + 0x010)); // 02700691C150 0x10 StoreName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.Instance                                  = GetObject<IStore>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStore.FromPointer); // 02700691C170 0x18 Instance                    ( 0001866587B0 ModelClassType IStore IStore IStore Pointer )

            return value;
        }
    }
}
