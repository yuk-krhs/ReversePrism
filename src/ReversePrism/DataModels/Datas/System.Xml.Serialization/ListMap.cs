using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemInfo                                 0001865CFBB0 ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer
    // 018 ChoiceMember                             000186671910 ModelPrimitiveType string string string String
    public partial class ListMap
    {
        public XmlTypeMapElementInfoList?               ItemInfo                                { get; set; }
        public string                                   ChoiceMember                            { get; set; }

        public static ListMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListMap();

            value.ItemInfo                                  = GetObject<XmlTypeMapElementInfoList>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlTypeMapElementInfoList.FromPointer); // 0270D74D1340 0x10 ItemInfo                    ( 0001865CFBB0 ModelClassType XmlTypeMapElementInfoList XmlTypeMapElementInfoList XmlTypeMapElementInfoList Pointer )
            value.ChoiceMember                              = GetString(new IntPtr(p + 0x018)); // 0270D74D1360 0x18 ChoiceMember                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
