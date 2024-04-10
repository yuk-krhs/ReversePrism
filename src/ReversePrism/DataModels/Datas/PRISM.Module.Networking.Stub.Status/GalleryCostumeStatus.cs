using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 018 CostumeType                              000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 000 PartsTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 01C PartsType                                000186727940 ModelEnumType PartsType PartsType PartsType Int32
    // 000 MstIdFieldNumber                         int IL2CPP_TYPE_I4
    // 020 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 024 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryCostumeStatus : DataModel
    {
        public CostumeType                              CostumeType                             { get; set; }
        public PartsType                                PartsType                               { get; set; }
        public int                                      MstId                                   { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryCostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryCostumeStatus() { Pointer= p0 };

            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x018)); // 02466151D030 0x18 CostumeType                 ( 000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.PartsType                                 = (PartsType)GetInt32(new IntPtr(p + 0x01C)); // 02466151D070 0x1C PartsType                   ( 000186727940 ModelEnumType PartsType PartsType PartsType Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x020)); // 02466151D0B0 0x20 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x024)); // 02466151D0F0 0x24 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
