using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FcStack                                  000185D00D58 ModelClassListType List`1<RegexFC> List`1<RegexFC> List<RegexFC> Pointer
    // 018 _intStack                                ValueListBuilder`1<int> IL2CPP_TYPE_GENERICINST
    // 038 SkipAllChildren                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 Skipchild                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A Failed                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RegexFCD
    {
        public List<RegexFC>?                           FcStack                                 { get; set; }
        public bool                                     SkipAllChildren                         { get; set; }
        public bool                                     Skipchild                               { get; set; }
        public bool                                     Failed                                  { get; set; }

        public static RegexFCD? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexFCD();

            value.FcStack                                   = GetObjectList<RegexFC>(new IntPtr(p + 0x010), ReversePrism.DataModels.RegexFC.FromPointer); // 0270D79A11F8 0x10 FcStack                     ( 000185D00D58 ModelClassListType List`1<RegexFC> List`1<RegexFC> List<RegexFC> Pointer )
            value.SkipAllChildren                           = GetBool(new IntPtr(p + 0x038)); // 0270D79A1238 0x38 SkipAllChildren             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Skipchild                                 = GetBool(new IntPtr(p + 0x039)); // 0270D79A1258 0x39 Skipchild                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Failed                                    = GetBool(new IntPtr(p + 0x03A)); // 0270D79A1278 0x3A Failed                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
