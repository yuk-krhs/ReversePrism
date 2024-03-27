using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Extend                                   0001866722E0 ModelPrimitiveType string string string String
    // 020 ExtendMultiple                           000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Device                                   00018662CF60 ModelEnumType MatcherJson MatcherJson MatcherJson Int32
    public partial class LayoutJsonNameAndDescriptorOnly
    {
        public string                                   Name                                    { get; set; }
        public string                                   Extend                                  { get; set; }
        public List<string>?                            ExtendMultiple                          { get; set; }
        public MatcherJson                              Device                                  { get; set; }

        public static LayoutJsonNameAndDescriptorOnly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LayoutJsonNameAndDescriptorOnly();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270033CA218 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Extend                                    = GetString(new IntPtr(p + 0x018)); // 0270033CA238 0x18 Extend                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExtendMultiple                            = GetStringList(new IntPtr(p + 0x020)); // 0270033CA258 0x20 ExtendMultiple              ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Device                                    = (MatcherJson)GetInt32(new IntPtr(p + 0x028)); // 0270033CA278 0x28 Device                      ( 00018662CF60 ModelEnumType MatcherJson MatcherJson MatcherJson Int32 )

            return value;
        }
    }
}
