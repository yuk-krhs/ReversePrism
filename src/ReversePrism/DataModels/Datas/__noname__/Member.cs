using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _Member                                  ModelClassType DataMember DataMember DataMember Pointer
    // 018 Ns                                       ModelPrimitiveType string string string String
    // 020 BaseTypeIndex                            ModelPrimitiveType int int int Int32
    public partial class Member : DataModel
    {
        public DataMember?                              _Member                                 { get; set; }
        public string                                   Ns                                      { get; set; }
        public int                                      BaseTypeIndex                           { get; set; }

        public static Member? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Member() { Pointer= p0 };

            value._Member                                   = GetObject<DataMember>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataMember.FromPointer); // 0x10 _Member                     ( ModelClassType DataMember DataMember DataMember Pointer )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 0x18 Ns                          ( ModelPrimitiveType string string string String )
            value.BaseTypeIndex                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 BaseTypeIndex               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
