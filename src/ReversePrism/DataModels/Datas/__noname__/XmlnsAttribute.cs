using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrefixOffset                             ModelPrimitiveType int int int Int32
    // 014 PrefixLength                             ModelPrimitiveType int int int Int32
    // 018 NsOffset                                 ModelPrimitiveType int int int Int32
    // 01C NsLength                                 ModelPrimitiveType int int int Int32
    // 020 Referred                                 ModelPrimitiveType bool bool bool Bool
    public partial class XmlnsAttribute : DataModel
    {
        public int                                      PrefixOffset                            { get; set; }
        public int                                      PrefixLength                            { get; set; }
        public int                                      NsOffset                                { get; set; }
        public int                                      NsLength                                { get; set; }
        public bool                                     Referred                                { get; set; }

        public static XmlnsAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlnsAttribute() { Pointer= p0 };

            value.PrefixOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 PrefixOffset                ( ModelPrimitiveType int int int Int32 )
            value.PrefixLength                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 PrefixLength                ( ModelPrimitiveType int int int Int32 )
            value.NsOffset                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 NsOffset                    ( ModelPrimitiveType int int int Int32 )
            value.NsLength                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NsLength                    ( ModelPrimitiveType int int int Int32 )
            value.Referred                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 Referred                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
