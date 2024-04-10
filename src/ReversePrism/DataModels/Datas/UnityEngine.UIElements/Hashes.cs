using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSize                                    int IL2CPP_TYPE_I4
    // 010 _Hashes                                  000186533650 ModelEnumType <hashes>e__FixedBuffer <hashes>e__FixedBuffer <hashes>e__FixedBuffer Int32
    public partial class Hashes : DataModel
    {
        public <hashes>e__FixedBuffer                   _Hashes                                 { get; set; }

        public static Hashes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hashes() { Pointer= p0 };

            value._Hashes                                   = (<hashes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0245A6802FB8 0x10 _Hashes                     ( 000186533650 ModelEnumType <hashes>e__FixedBuffer <hashes>e__FixedBuffer <hashes>e__FixedBuffer Int32 )

            return value;
        }
    }
}
