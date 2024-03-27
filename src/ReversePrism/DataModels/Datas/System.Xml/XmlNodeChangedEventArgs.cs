using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   0001865A1A20 ModelEnumType XmlNodeChangedAction XmlNodeChangedAction XmlNodeChangedAction Int32
    // 018 Node                                     0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 OldParent                                0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 028 NewParent                                0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 030 OldValue                                 000186671910 ModelPrimitiveType string string string String
    // 038 NewValue                                 000186671910 ModelPrimitiveType string string string String
    public partial class XmlNodeChangedEventArgs
    {
        public XmlNodeChangedAction                     Action                                  { get; set; }
        public XmlNode?                                 Node                                    { get; set; }
        public XmlNode?                                 OldParent                               { get; set; }
        public XmlNode?                                 NewParent                               { get; set; }
        public string                                   OldValue                                { get; set; }
        public string                                   NewValue                                { get; set; }

        public static XmlNodeChangedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeChangedEventArgs();

            value.Action                                    = (XmlNodeChangedAction)GetInt32(new IntPtr(p + 0x010)); // 0270D74531C0 0x10 Action                      ( 0001865A1A20 ModelEnumType XmlNodeChangedAction XmlNodeChangedAction XmlNodeChangedAction Int32 )
            value.Node                                      = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 0270D74531E0 0x18 Node                        ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.OldParent                                 = GetObject<XmlNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNode.FromPointer); // 0270D7453200 0x20 OldParent                   ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.NewParent                                 = GetObject<XmlNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNode.FromPointer); // 0270D7453220 0x28 NewParent                   ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.OldValue                                  = GetString(new IntPtr(p + 0x030)); // 0270D7453240 0x30 OldValue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.NewValue                                  = GetString(new IntPtr(p + 0x038)); // 0270D7453260 0x38 NewValue                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
