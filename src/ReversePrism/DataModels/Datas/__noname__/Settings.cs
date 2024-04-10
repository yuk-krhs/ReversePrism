using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Default>k__BackingField                 Settings IL2CPP_TYPE_CLASS
    // 010 RecursionLimit                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 TypeRegistry                             0001866DC650 ModelClassType TypeRegistry TypeRegistry TypeRegistry Pointer
    // 020 IgnoreUnknownFields                      0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class Settings : DataModel
    {
        public int                                      RecursionLimit                          { get; set; }
        public TypeRegistry?                            TypeRegistry                            { get; set; }
        public bool                                     IgnoreUnknownFields                     { get; set; }

        public static Settings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Settings() { Pointer= p0 };

            value.RecursionLimit                            = GetInt32(new IntPtr(p + 0x010)); // 02466A476148 0x10 RecursionLimit              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TypeRegistry                              = GetObject<TypeRegistry>(new IntPtr(p + 0x018), ReversePrism.DataModels.TypeRegistry.FromPointer); // 02466A476168 0x18 TypeRegistry                ( 0001866DC650 ModelClassType TypeRegistry TypeRegistry TypeRegistry Pointer )
            value.IgnoreUnknownFields                       = GetBool(new IntPtr(p + 0x020)); // 02466A476188 0x20 IgnoreUnknownFields         ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
