using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ns                                       ModelClassType XNamespace XNamespace XNamespace Pointer
    // 018 LocalName                                ModelPrimitiveType string string string String
    // 020 HashCode                                 ModelPrimitiveType int int int Int32
    public partial class XName : DataModel
    {
        public XNamespace?                              Ns                                      { get; set; }
        public string                                   LocalName                               { get; set; }
        public int                                      HashCode                                { get; set; }

        public static XName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XName() { Pointer= p0 };

            value.Ns                                        = GetObject<XNamespace>(new IntPtr(p + 0x010), ReversePrism.DataModels.XNamespace.FromPointer); // 0x10 Ns                          ( ModelClassType XNamespace XNamespace XNamespace Pointer )
            value.LocalName                                 = GetString(new IntPtr(p + 0x018)); // 0x18 LocalName                   ( ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 HashCode                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
