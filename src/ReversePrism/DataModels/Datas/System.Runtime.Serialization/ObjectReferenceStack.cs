using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaximumArraySize                         int IL2CPP_TYPE_I4
    // 000 InitialArraySize                         int IL2CPP_TYPE_I4
    // 010 Count                                    ModelPrimitiveType int int int Int32
    // 018 objectArray                              <object>[] IL2CPP_TYPE_SZARRAY
    // 020 IsReferenceArray                         ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 028 objectDictionary                         Dictionary`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    public partial class ObjectReferenceStack : DataModel
    {
        public int                                      Count                                   { get; set; }
        public List<bool>?                              IsReferenceArray                        { get; set; }

        public static ObjectReferenceStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectReferenceStack() { Pointer= p0 };

            value.Count                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Count                       ( ModelPrimitiveType int int int Int32 )
            value.IsReferenceArray                          = GetBoolList(new IntPtr(p + 0x020)); // 0x20 IsReferenceArray            ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
