using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_currentCount                           ModelPrimitiveType int int int Int32
    // 018 M_ids                                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 m_objs                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 028 M_isWrapped                              ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 000 primes                                   int[] IL2CPP_TYPE_SZARRAY
    public partial class ObjectToIdCache : DataModel
    {
        public int                                      M_currentCount                          { get; set; }
        public List<int>?                               M_ids                                   { get; set; }
        public List<bool>?                              M_isWrapped                             { get; set; }

        public static ObjectToIdCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectToIdCache() { Pointer= p0 };

            value.M_currentCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_currentCount              ( ModelPrimitiveType int int int Int32 )
            value.M_ids                                     = GetInt32List(new IntPtr(p + 0x018)); // 0x18 M_ids                       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_isWrapped                               = GetBoolList(new IntPtr(p + 0x028)); // 0x28 M_isWrapped                 ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
