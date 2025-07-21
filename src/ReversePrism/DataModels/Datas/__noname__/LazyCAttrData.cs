using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Assembly                                 ModelClassType Assembly Assembly Assembly Pointer
    // 018 data                                     <int> IL2CPP_TYPE_I
    // 020 Data_length                              ModelPrimitiveType uint uint uint UInt32
    public partial class LazyCAttrData : DataModel
    {
        public Assembly?                                Assembly                                { get; set; }
        public uint                                     Data_length                             { get; set; }

        public static LazyCAttrData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LazyCAttrData() { Pointer= p0 };

            value.Assembly                                  = GetObject<Assembly>(new IntPtr(p + 0x010), ReversePrism.DataModels.Assembly.FromPointer); // 0x10 Assembly                    ( ModelClassType Assembly Assembly Assembly Pointer )
            value.Data_length                               = GetUInt32(new IntPtr(p + 0x020)); // 0x20 Data_length                 ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
