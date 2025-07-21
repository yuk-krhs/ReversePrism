using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   ModelEnumType XmlNodeChangedAction XmlNodeChangedAction XmlNodeChangedAction Int32
    // 018 Node                                     ModelClassType XmlNode XmlNode XmlNode Pointer
    // 020 OldParent                                ModelClassType XmlNode XmlNode XmlNode Pointer
    // 028 NewParent                                ModelClassType XmlNode XmlNode XmlNode Pointer
    // 030 OldValue                                 ModelPrimitiveType string string string String
    // 038 NewValue                                 ModelPrimitiveType string string string String
    public partial class XmlNodeChangedEventArgs : DataModel
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
            var value   = new XmlNodeChangedEventArgs() { Pointer= p0 };

            value.Action                                    = (XmlNodeChangedAction)GetInt32(new IntPtr(p + 0x010)); // 0x10 Action                      ( ModelEnumType XmlNodeChangedAction XmlNodeChangedAction XmlNodeChangedAction Int32 )
            value.Node                                      = GetObject<XmlNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNode.FromPointer); // 0x18 Node                        ( ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.OldParent                                 = GetObject<XmlNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlNode.FromPointer); // 0x20 OldParent                   ( ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.NewParent                                 = GetObject<XmlNode>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNode.FromPointer); // 0x28 NewParent                   ( ModelClassType XmlNode XmlNode XmlNode Pointer )
            value.OldValue                                  = GetString(new IntPtr(p + 0x030)); // 0x30 OldValue                    ( ModelPrimitiveType string string string String )
            value.NewValue                                  = GetString(new IntPtr(p + 0x038)); // 0x38 NewValue                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
