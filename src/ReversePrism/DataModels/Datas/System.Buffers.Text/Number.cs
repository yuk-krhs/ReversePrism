using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_rgval64Power10                         ulong[] IL2CPP_TYPE_SZARRAY
    // 008 s_rgexp64Power10                         sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 S_rgval64Power10By16                     000185B84A20 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 018 S_rgexp64Power10By16                     000185B8D910 ModelPrimitiveListType short[] short[] List<short> Pointer
    public partial class Number : DataModel
    {
        public List<ulong>?                             S_rgval64Power10By16                    { get; set; }
        public List<short>?                             S_rgexp64Power10By16                    { get; set; }

        public static Number? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Number() { Pointer= p0 };

            value.S_rgval64Power10By16                      = GetUInt64List(new IntPtr(p + 0x010)); // 024666E89E38 0x10 S_rgval64Power10By16        ( 000185B84A20 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.S_rgexp64Power10By16                      = GetInt16List(new IntPtr(p + 0x018)); // 024666E89E58 0x18 S_rgexp64Power10By16        ( 000185B8D910 ModelPrimitiveListType short[] short[] List<short> Pointer )

            return value;
        }
    }
}
