using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelEnumType QName QName QName Int32
    // 028 Val                                      ModelPrimitiveType string string string String
    // 030 ContentPos                               ModelPrimitiveType int int int Int32
    // 034 HashCode                                 ModelPrimitiveType int int int Int32
    // 038 PrevHash                                 ModelPrimitiveType int int int Int32
    public partial class AttrInfo : DataModel
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
            var value   = new AttrInfo() { Pointer= p0 };

            value.Name                                      = (QName)GetInt32(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelEnumType QName QName QName Int32 )
            value.Val                                       = GetString(new IntPtr(p + 0x028)); // 0x28 Val                         ( ModelPrimitiveType string string string String )
            value.ContentPos                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 ContentPos                  ( ModelPrimitiveType int int int Int32 )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 HashCode                    ( ModelPrimitiveType int int int Int32 )
            value.PrevHash                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 PrevHash                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
