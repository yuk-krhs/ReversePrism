using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 o                                        <object> IL2CPP_TYPE_OBJECT
    // 018 XmlNode                                  0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 LineNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 LinePosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlNodeEventArgs : DataModel
    {
        public XmlNode?                                 XmlNode                                 { get; set; }
        public int                                      LineNumber                              { get; set; }
        public int                                      LinePosition                            { get; set; }

        public static XmlNodeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlNodeEventArgs() { Pointer= p0 };

            value.XmlNode                                   = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 024667506D48 0x18 XmlNode                     ( 0001866BB0D0 ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.LineNumber                                = GetInt32(new IntPtr(p + 0x020)); // 024667506D68 0x20 LineNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePosition                              = GetInt32(new IntPtr(p + 0x024)); // 024667506D88 0x24 LinePosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
