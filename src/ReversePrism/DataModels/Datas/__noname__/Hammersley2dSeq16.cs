using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _Hammersley2dSeq16                       ModelEnumType <hammersley2dSeq16>e__FixedBuffer <hammersley2dSeq16>e__FixedBuffer <hammersley2dSeq16>e__FixedBuffer Int32
    public partial class Hammersley2dSeq16 : DataModel
    {
        public <hammersley2dSeq16>e__FixedBuffer        _Hammersley2dSeq16                      { get; set; }

        public static Hammersley2dSeq16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Hammersley2dSeq16() { Pointer= p0 };

            value._Hammersley2dSeq16                        = (<hammersley2dSeq16>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0x10 _Hammersley2dSeq16          ( ModelEnumType <hammersley2dSeq16>e__FixedBuffer <hammersley2dSeq16>e__FixedBuffer <hammersley2dSeq16>e__FixedBuffer Int32 )

            return value;
        }
    }
}
