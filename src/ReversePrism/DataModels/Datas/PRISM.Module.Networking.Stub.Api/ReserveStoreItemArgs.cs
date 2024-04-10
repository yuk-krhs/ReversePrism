using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReserveStoreItemArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStoreItemIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstStoreItemId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReserveStoreItemArgs : DataModel
    {
        public int                                      MstStoreItemId                          { get; set; }

        public static ReserveStoreItemArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReserveStoreItemArgs() { Pointer= p0 };

            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x018)); // 024660B38E20 0x18 MstStoreItemId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
