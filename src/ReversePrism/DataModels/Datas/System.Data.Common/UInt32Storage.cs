using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_defaultValue                           uint IL2CPP_TYPE_U4
    // 050 Values                                   000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class UInt32Storage : DataModel
    {
        public List<uint>?                              Values                                  { get; set; }

        public static UInt32Storage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UInt32Storage() { Pointer= p0 };

            value.Values                                    = GetUInt32List(new IntPtr(p + 0x050)); // 024668A60EB8 0x50 Values                      ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
