using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 sig                                      <int> IL2CPP_TYPE_I
    // 018 args                                     <int> IL2CPP_TYPE_I
    // 020 Next_arg                                 ModelPrimitiveType int int int Int32
    // 024 Num_args                                 ModelPrimitiveType int int int Int32
    public partial class ArgIterator : DataModel
    {
        public int                                      Next_arg                                { get; set; }
        public int                                      Num_args                                { get; set; }

        public static ArgIterator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArgIterator() { Pointer= p0 };

            value.Next_arg                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 Next_arg                    ( ModelPrimitiveType int int int Int32 )
            value.Num_args                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 Num_args                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
