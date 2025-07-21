using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 klass                                    <int> IL2CPP_TYPE_I
    // 018 Fhandle                                  ModelEnumType RuntimeFieldHandle RuntimeFieldHandle RuntimeFieldHandle Int32
    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 Type                                     ModelClassType Type Type Type Pointer
    // 030 Attrs                                    ModelEnumType FieldAttributes FieldAttributes FieldAttributes Int32
    public partial class RuntimeFieldInfo : DataModel
    {
        public RuntimeFieldHandle                       Fhandle                                 { get; set; }
        public string                                   Name                                    { get; set; }
        public Type?                                    Type                                    { get; set; }
        public FieldAttributes                          Attrs                                   { get; set; }

        public static RuntimeFieldInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeFieldInfo() { Pointer= p0 };

            value.Fhandle                                   = (RuntimeFieldHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 Fhandle                     ( ModelEnumType RuntimeFieldHandle RuntimeFieldHandle RuntimeFieldHandle Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 Type                        ( ModelClassType Type Type Type Pointer )
            value.Attrs                                     = (FieldAttributes)GetInt32(new IntPtr(p + 0x030)); // 0x30 Attrs                       ( ModelEnumType FieldAttributes FieldAttributes FieldAttributes Int32 )

            return value;
        }
    }
}
