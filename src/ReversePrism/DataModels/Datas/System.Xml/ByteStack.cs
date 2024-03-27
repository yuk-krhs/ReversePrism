using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 GrowthRate                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Top                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ByteStack
    {
        public List<sbyte>?                             Stack                                   { get; set; }
        public int                                      GrowthRate                              { get; set; }
        public int                                      Top                                     { get; set; }
        public int                                      Size                                    { get; set; }

        public static ByteStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteStack();

            value.Stack                                     = GetSByteList(new IntPtr(p + 0x010)); // 0270D73684A0 0x10 Stack                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GrowthRate                                = GetInt32(new IntPtr(p + 0x018)); // 0270D73684C0 0x18 GrowthRate                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Top                                       = GetInt32(new IntPtr(p + 0x01C)); // 0270D73684E0 0x1C Top                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D7368500 0x20 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
