using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tag                                      ModelPrimitiveType int int int Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 Fields                                   ModelClassListType PropertyInfo[] PropertyInfo[] List<PropertyInfo> Pointer
    // 028 FieldReader                              ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer
    // 030 Constructor                              ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer
    public partial class UnionCase : DataModel
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
            var value   = new UnionCase() { Pointer= p0 };

            value.Tag                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Tag                         ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Fields                                    = GetObjectList<PropertyInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x20 Fields                      ( ModelClassListType PropertyInfo[] PropertyInfo[] List<PropertyInfo> Pointer )
            value.FieldReader                               = GetObject<FSharpFunction>(new IntPtr(p + 0x028), ReversePrism.DataModels.FSharpFunction.FromPointer); // 0x28 FieldReader                 ( ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer )
            value.Constructor                               = GetObject<FSharpFunction>(new IntPtr(p + 0x030), ReversePrism.DataModels.FSharpFunction.FromPointer); // 0x30 Constructor                 ( ModelClassType FSharpFunction FSharpFunction FSharpFunction Pointer )

            return value;
        }
    }
}
