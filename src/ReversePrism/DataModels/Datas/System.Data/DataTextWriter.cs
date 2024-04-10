using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 XmltextWriter                            0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    public partial class DataTextWriter : DataModel
    {
        public XmlWriter?                               XmltextWriter                           { get; set; }

        public static DataTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTextWriter() { Pointer= p0 };

            value.XmltextWriter                             = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0246689E6780 0x18 XmltextWriter               ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )

            return value;
        }
    }
}
