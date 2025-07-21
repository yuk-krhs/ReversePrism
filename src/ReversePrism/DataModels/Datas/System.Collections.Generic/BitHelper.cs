using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Length                                   ModelPrimitiveType int int int Int32
    // 018 _arrayPtr                                IntPtr IL2CPP_TYPE_PTR
    // 020 Array                                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 UseStackAlloc                            ModelPrimitiveType bool bool bool Bool
    public partial class BitHelper : DataModel
    {
        public int                                      Length                                  { get; set; }
        public List<int>?                               Array                                   { get; set; }
        public bool                                     UseStackAlloc                           { get; set; }

        public static BitHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitHelper() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Array                                     = GetInt32List(new IntPtr(p + 0x020)); // 0x20 Array                       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UseStackAlloc                             = GetBool(new IntPtr(p + 0x028)); // 0x28 UseStackAlloc               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
