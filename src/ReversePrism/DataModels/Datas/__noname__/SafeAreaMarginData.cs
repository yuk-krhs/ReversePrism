using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 EditorDeviceName                         ModelPrimitiveType string string string String
    // 020 EditorModelName                          ModelPrimitiveType string string string String
    // 028 IsNotchLeft                              ModelPrimitiveType bool bool bool Bool
    // 030 Datas                                    ModelClassListType List`1<MarginData> List`1<MarginData> List<MarginData> Pointer
    public partial class SafeAreaMarginData : DataModel
    {
        public string                                   EditorDeviceName                        { get; set; }
        public string                                   EditorModelName                         { get; set; }
        public bool                                     IsNotchLeft                             { get; set; }
        public List<MarginData>?                        Datas                                   { get; set; }

        public static SafeAreaMarginData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SafeAreaMarginData() { Pointer= p0 };

            value.EditorDeviceName                          = GetString(new IntPtr(p + 0x018)); // 0x18 EditorDeviceName            ( ModelPrimitiveType string string string String )
            value.EditorModelName                           = GetString(new IntPtr(p + 0x020)); // 0x20 EditorModelName             ( ModelPrimitiveType string string string String )
            value.IsNotchLeft                               = GetBool(new IntPtr(p + 0x028)); // 0x28 IsNotchLeft                 ( ModelPrimitiveType bool bool bool Bool )
            value.Datas                                     = GetObjectList<MarginData>(new IntPtr(p + 0x030), ReversePrism.DataModels.MarginData.FromPointer); // 0x30 Datas                       ( ModelClassListType List`1<MarginData> List`1<MarginData> List<MarginData> Pointer )

            return value;
        }
    }
}
