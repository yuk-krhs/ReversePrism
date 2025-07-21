using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 receivedData                             ConcurrentQueue`1<Queue`1<sbyte[]>> IL2CPP_TYPE_GENERICINST
    // 018 ReadData                                 ModelClassType ReadData ReadData ReadData Pointer
    public partial class PrismStream : DataModel
    {
        public ReadData?                                ReadData                                { get; set; }

        public static PrismStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismStream() { Pointer= p0 };

            value.ReadData                                  = GetObject<ReadData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ReadData.FromPointer); // 0x18 ReadData                    ( ModelClassType ReadData ReadData ReadData Pointer )

            return value;
        }
    }
}
