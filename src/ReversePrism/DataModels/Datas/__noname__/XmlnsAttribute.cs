using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrefixOffset                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 PrefixLength                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 NsOffset                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C NsLength                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Referred                                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class XmlnsAttribute
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
            var value   = new XmlnsAttribute();

            value.PrefixOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0270D7C61098 0x10 PrefixOffset                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PrefixLength                              = GetInt32(new IntPtr(p + 0x014)); // 0270D7C610B8 0x14 PrefixLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NsOffset                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D7C610D8 0x18 NsOffset                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NsLength                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270D7C610F8 0x1C NsLength                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Referred                                  = GetBool(new IntPtr(p + 0x020)); // 0270D7C61118 0x20 Referred                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
