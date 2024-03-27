using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Converters                               000185CB5048 ModelClassListType XmlValueConverter[] XmlValueConverter[] List<XmlValueConverter> Pointer
    // 030 HasAtomicMember                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 HasListMember                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlUnionConverter
    {
        public List<XmlValueConverter>?                 Converters                              { get; set; }
        public bool                                     HasAtomicMember                         { get; set; }
        public bool                                     HasListMember                           { get; set; }

        public static XmlUnionConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUnionConverter();

            value.Converters                                = GetObjectList<XmlValueConverter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlValueConverter.FromPointer); // 0270D75EBFA8 0x28 Converters                  ( 000185CB5048 ModelClassListType XmlValueConverter[] XmlValueConverter[] List<XmlValueConverter> Pointer )
            value.HasAtomicMember                           = GetBool(new IntPtr(p + 0x030)); // 0270D75EBFC8 0x30 HasAtomicMember             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasListMember                             = GetBool(new IntPtr(p + 0x031)); // 0270D75EBFE8 0x31 HasListMember               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
