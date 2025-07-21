using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GuidSize                                 int IL2CPP_TYPE_I4
    // 010 _ReadData                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 ReadDataIndex                            ModelPrimitiveType int int int Int32
    public partial class ReadData : DataModel
    {
        public List<sbyte>?                             _ReadData                               { get; set; }
        public int                                      ReadDataIndex                           { get; set; }

        public static ReadData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadData() { Pointer= p0 };

            value._ReadData                                 = GetSByteList(new IntPtr(p + 0x010)); // 0x10 _ReadData                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ReadDataIndex                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ReadDataIndex               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
