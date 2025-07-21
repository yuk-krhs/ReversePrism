using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Characters                               ModelClassListType Character[] Character[] List<Character> Pointer
    // 028 YAxis                                    ModelPrimitiveType bool bool bool Bool
    // 029 XzPlane                                  ModelPrimitiveType bool bool bool Bool
    // 030 MixData                                  ModelClassListType MixData[] MixData[] List<MixData> Pointer
    // 038 WhichMin                                 ModelPrimitiveType bool bool bool Bool
    // 039 WhichMax                                 ModelPrimitiveType bool bool bool Bool
    // 03C ScaleMin                                 ModelPrimitiveType float float float Single
    // 040 ScaleMax                                 ModelPrimitiveType float float float Single
    public partial class AdaptiveScale : DataModel
    {
        public List<Character>?                         Characters                              { get; set; }
        public bool                                     YAxis                                   { get; set; }
        public bool                                     XzPlane                                 { get; set; }
        public List<MixData>?                           MixData                                 { get; set; }
        public bool                                     WhichMin                                { get; set; }
        public bool                                     WhichMax                                { get; set; }
        public float                                    ScaleMin                                { get; set; }
        public float                                    ScaleMax                                { get; set; }

        public static AdaptiveScale? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveScale() { Pointer= p0 };

            value.Characters                                = GetObjectList<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Characters                  ( ModelClassListType Character[] Character[] List<Character> Pointer )
            value.YAxis                                     = GetBool(new IntPtr(p + 0x028)); // 0x28 YAxis                       ( ModelPrimitiveType bool bool bool Bool )
            value.XzPlane                                   = GetBool(new IntPtr(p + 0x029)); // 0x29 XzPlane                     ( ModelPrimitiveType bool bool bool Bool )
            value.MixData                                   = GetObjectList<MixData>(new IntPtr(p + 0x030), ReversePrism.DataModels.MixData.FromPointer); // 0x30 MixData                     ( ModelClassListType MixData[] MixData[] List<MixData> Pointer )
            value.WhichMin                                  = GetBool(new IntPtr(p + 0x038)); // 0x38 WhichMin                    ( ModelPrimitiveType bool bool bool Bool )
            value.WhichMax                                  = GetBool(new IntPtr(p + 0x039)); // 0x39 WhichMax                    ( ModelPrimitiveType bool bool bool Bool )
            value.ScaleMin                                  = GetSingle(new IntPtr(p + 0x03C)); // 0x3C ScaleMin                    ( ModelPrimitiveType float float float Single )
            value.ScaleMax                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 ScaleMax                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
