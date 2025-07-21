using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_JsonCache                              ModelPrimitiveType string string string String
    // 018 m_ConfigValues                           IReadOnlyDictionary`2<string, ConfigurationEntry> IL2CPP_TYPE_GENERICINST
    // 020 Serializer                               ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer
    public partial class ProjectConfiguration : DataModel
    {
        public string                                   M_JsonCache                             { get; set; }
        public IJsonSerializer?                         Serializer                              { get; set; }

        public static ProjectConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProjectConfiguration() { Pointer= p0 };

            value.M_JsonCache                               = GetString(new IntPtr(p + 0x010)); // 0x10 M_JsonCache                 ( ModelPrimitiveType string string string String )
            value.Serializer                                = GetObject<IJsonSerializer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IJsonSerializer.FromPointer); // 0x20 Serializer                  ( ModelClassType IJsonSerializer IJsonSerializer IJsonSerializer Pointer )

            return value;
        }
    }
}
