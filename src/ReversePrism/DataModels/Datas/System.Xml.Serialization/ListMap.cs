using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemInfo                                 ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer
    // 018 ChoiceMember                             ModelPrimitiveType string string string String
    public partial class ListMap : DataModel
    {
        public XmlTypeMapElementInfoList?               ItemInfo                                { get; set; }
        public string                                   ChoiceMember                            { get; set; }

        public static ListMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListMap() { Pointer= p0 };

            value.ItemInfo                                  = GetObject<XmlTypeMapElementInfoList>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlTypeMapElementInfoList.FromPointer); // 0x10 ItemInfo                    ( ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer )
            value.ChoiceMember                              = GetString(new IntPtr(p + 0x018)); // 0x18 ChoiceMember                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
