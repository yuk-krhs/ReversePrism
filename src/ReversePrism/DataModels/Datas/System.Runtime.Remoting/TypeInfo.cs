using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServerType                               000186671910 ModelPrimitiveType string string string String
    // 018 ServerHierarchy                          000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 InterfacesImplemented                    000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class TypeInfo
    {
        public string                                   ServerType                              { get; set; }
        public List<string>?                            ServerHierarchy                         { get; set; }
        public List<string>?                            InterfacesImplemented                   { get; set; }

        public static TypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInfo();

            value.ServerType                                = GetString(new IntPtr(p + 0x010)); // 0270D6BB9D18 0x10 ServerType                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ServerHierarchy                           = GetStringList(new IntPtr(p + 0x018)); // 0270D6BB9D38 0x18 ServerHierarchy             ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.InterfacesImplemented                     = GetStringList(new IntPtr(p + 0x020)); // 0270D6BB9D58 0x20 InterfacesImplemented       ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
