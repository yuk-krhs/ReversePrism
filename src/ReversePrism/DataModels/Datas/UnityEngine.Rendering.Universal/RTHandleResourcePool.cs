using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_ResourcePool                           Dictionary`2<int, SortedList`2<int, ValueTuple`2<RTHandle, int>>> IL2CPP_TYPE_GENERICINST
    // 018 M_RemoveList                             ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 000 s_CurrentStaleResourceCount              int IL2CPP_TYPE_I4
    // 004 s_StaleResourceLifetime                  int IL2CPP_TYPE_I4
    // 008 s_StaleResourceMaxCapacity               int IL2CPP_TYPE_I4
    public partial class RTHandleResourcePool : DataModel
    {
        public List<int>?                               M_RemoveList                            { get; set; }

        public static RTHandleResourcePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RTHandleResourcePool() { Pointer= p0 };

            value.M_RemoveList                              = GetInt32List(new IntPtr(p + 0x018)); // 0x18 M_RemoveList                ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
