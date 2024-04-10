using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Values                                   000185CB9068 ModelClassListType Value[] Value[] List<Value> Pointer
    // 050 PinnedElementIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ValueTuple : DataModel
    {
        public List<Value>?                             Values                                  { get; set; }
        public int                                      PinnedElementIndex                      { get; set; }

        public static ValueTuple? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueTuple() { Pointer= p0 };

            value.Values                                    = GetObjectList<Value>(new IntPtr(p + 0x048), ReversePrism.DataModels.Value.FromPointer); // 0246691DC680 0x48 Values                      ( 000185CB9068 ModelClassListType Value[] Value[] List<Value> Pointer )
            value.PinnedElementIndex                        = GetInt32(new IntPtr(p + 0x050)); // 0246691DC6A0 0x50 PinnedElementIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
