using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001867406A0 ModelEnumType QName QName QName Int32
    // 028 Val                                      0001866722E0 ModelPrimitiveType string string string String
    // 030 ContentPos                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 HashCode                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 PrevHash                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AttrInfo
    {
        public QName                                    Name                                    { get; set; }
        public string                                   Val                                     { get; set; }
        public int                                      ContentPos                              { get; set; }
        public int                                      HashCode                                { get; set; }
        public int                                      PrevHash                                { get; set; }

        public static AttrInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttrInfo();

            value.Name                                      = (QName)GetInt32(new IntPtr(p + 0x010)); // 0270D734EC08 0x10 Name                        ( 0001867406A0 ModelEnumType QName QName QName Int32 )
            value.Val                                       = GetString(new IntPtr(p + 0x028)); // 0270D734EC28 0x28 Val                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ContentPos                                = GetInt32(new IntPtr(p + 0x030)); // 0270D734EC48 0x30 ContentPos                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x034)); // 0270D734EC68 0x34 HashCode                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PrevHash                                  = GetInt32(new IntPtr(p + 0x038)); // 0270D734EC88 0x38 PrevHash                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
