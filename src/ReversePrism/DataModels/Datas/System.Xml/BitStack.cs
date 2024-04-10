using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _BitStack                                000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 StackPos                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Curr                                     000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class BitStack : DataModel
    {
        public List<uint>?                              _BitStack                               { get; set; }
        public int                                      StackPos                                { get; set; }
        public uint                                     Curr                                    { get; set; }

        public static BitStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitStack() { Pointer= p0 };

            value._BitStack                                 = GetUInt32List(new IntPtr(p + 0x010)); // 0246673B8028 0x10 _BitStack                   ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.StackPos                                  = GetInt32(new IntPtr(p + 0x018)); // 0246673B8048 0x18 StackPos                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Curr                                      = GetUInt32(new IntPtr(p + 0x01C)); // 0246673B8068 0x1C Curr                        ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
