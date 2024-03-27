using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GuidSize                                 int IL2CPP_TYPE_I4
    // 010 _ReadData                                000185CD0A78 ModelPrimitiveListType List`1<sbyte> List`1<sbyte> List<sbyte> Pointer
    // 018 ReadDataIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ReadBuffer                               0001865174D0 ModelClassType PrismStreamReadBuffer PrismStreamReadBuffer PrismStreamReadBuffer Pointer
    public partial class ReadData
    {
        public List<sbyte>?                             _ReadData                               { get; set; }
        public int                                      ReadDataIndex                           { get; set; }
        public PrismStreamReadBuffer?                   ReadBuffer                              { get; set; }

        public static ReadData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadData();

            value._ReadData                                 = GetSByteList(new IntPtr(p + 0x010)); // 0270D4F11A70 0x10 _ReadData                   ( 000185CD0A78 ModelPrimitiveListType List`1<sbyte> List`1<sbyte> List<sbyte> Pointer )
            value.ReadDataIndex                             = GetInt32(new IntPtr(p + 0x018)); // 0270D4F11A90 0x18 ReadDataIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadBuffer                                = GetObject<PrismStreamReadBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismStreamReadBuffer.FromPointer); // 0270D4F11AB0 0x20 ReadBuffer                  ( 0001865174D0 ModelClassType PrismStreamReadBuffer PrismStreamReadBuffer PrismStreamReadBuffer Pointer )

            return value;
        }
    }
}
