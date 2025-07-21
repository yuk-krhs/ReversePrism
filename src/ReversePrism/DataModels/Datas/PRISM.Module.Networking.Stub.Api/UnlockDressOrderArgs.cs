using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UnlockDressOrderArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 018 MstCostumeId                             ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstIdolId                                ModelPrimitiveType int int int Int32
    public partial class UnlockDressOrderArgs : DataModel
    {
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static UnlockDressOrderArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnlockDressOrderArgs() { Pointer= p0 };

            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstIdolId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
