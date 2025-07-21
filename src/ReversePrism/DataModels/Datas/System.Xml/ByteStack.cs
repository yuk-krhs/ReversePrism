using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 GrowthRate                               ModelPrimitiveType int int int Int32
    // 01C Top                                      ModelPrimitiveType int int int Int32
    // 020 Size                                     ModelPrimitiveType int int int Int32
    public partial class ByteStack : DataModel
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
            var value   = new ByteStack() { Pointer= p0 };

            value.Stack                                     = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Stack                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.GrowthRate                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 GrowthRate                  ( ModelPrimitiveType int int int Int32 )
            value.Top                                       = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Top                         ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Size                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
