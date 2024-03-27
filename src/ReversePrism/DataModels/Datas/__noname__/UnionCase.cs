using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 020 Fields                                   000185C9F578 ModelClassListType PropertyInfo[] PropertyInfo[] List<PropertyInfo> Pointer
    // 028 FieldReader                              000186546B60 ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer
    // 030 Constructor                              000186546B60 ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer
    public partial class UnionCase
    {
        public int                                      Tag                                     { get; set; }
        public string                                   Name                                    { get; set; }
        public List<PropertyInfo>?                      Fields                                  { get; set; }
        public FSharpFunction?                          FieldReader                             { get; set; }
        public FSharpFunction?                          Constructor                             { get; set; }

        public static UnionCase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnionCase();

            value.Tag                                       = GetInt32(new IntPtr(p + 0x010)); // 0270D8867218 0x10 Tag                         ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270D8867238 0x18 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Fields                                    = GetObjectList<PropertyInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D8867258 0x20 Fields                      ( 000185C9F578 ModelClassListType PropertyInfo[] PropertyInfo[] List<PropertyInfo> Pointer )
            value.FieldReader                               = GetObject<FSharpFunction>(new IntPtr(p + 0x028), ReversePrism.DataModels.FSharpFunction.FromPointer); // 0270D8867278 0x28 FieldReader                 ( 000186546B60 ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer )
            value.Constructor                               = GetObject<FSharpFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.FSharpFunction.FromPointer); // 0270D8867298 0x30 Constructor                 ( 000186546B60 ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer )

            return value;
        }
    }
}
