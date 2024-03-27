using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 00018658F230 ModelClassType StorageLocationProvider StorageLocationProvider StorageLocationProvider Pointer
    public partial class ScrumbleProcessor
    {
        public StorageLocationProvider?                 Provider                                { get; set; }

        public static ScrumbleProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrumbleProcessor();

            value.Provider                                  = GetObject<StorageLocationProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.StorageLocationProvider.FromPointer); // 02700442E1B8 0x10 Provider                    ( 00018658F230 ModelClassType StorageLocationProvider StorageLocationProvider StorageLocationProvider Pointer )

            return value;
        }
    }
}
