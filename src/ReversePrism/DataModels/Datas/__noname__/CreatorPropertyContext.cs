using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 018 Property                                 000186602EA0 ModelClassType JsonProperty JsonProperty JsonProperty Pointer
    // 020 ConstructorProperty                      000186602EA0 ModelClassType JsonProperty JsonProperty JsonProperty Pointer
    // 028 Presence                                 Nullable`1<PropertyPresence> IL2CPP_TYPE_GENERICINST
    // 030 Value                                    <object> IL2CPP_TYPE_OBJECT
    // 038 Used                                     000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CreatorPropertyContext : DataModel
    {
        public string                                   Name                                    { get; set; }
        public JsonProperty?                            Property                                { get; set; }
        public JsonProperty?                            ConstructorProperty                     { get; set; }
        public bool                                     Used                                    { get; set; }

        public static CreatorPropertyContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreatorPropertyContext() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0246687E5D90 0x10 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Property                                  = GetObject<JsonProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.JsonProperty.FromPointer); // 0246687E5DB0 0x18 Property                    ( 000186602EA0 ModelClassType JsonProperty JsonProperty JsonProperty Pointer )
            value.ConstructorProperty                       = GetObject<JsonProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.JsonProperty.FromPointer); // 0246687E5DD0 0x20 ConstructorProperty         ( 000186602EA0 ModelClassType JsonProperty JsonProperty JsonProperty Pointer )
            value.Used                                      = GetBool(new IntPtr(p + 0x038)); // 0246687E5E30 0x38 Used                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
