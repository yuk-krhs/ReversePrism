using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Extend                                   ModelPrimitiveType string string string String
    // 020 ExtendMultiple                           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Device                                   ModelEnumType MatcherJson MatcherJson MatcherJson Int32
    public partial class LayoutJsonNameAndDescriptorOnly : DataModel
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
            var value   = new LayoutJsonNameAndDescriptorOnly() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Extend                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Extend                      ( ModelPrimitiveType string string string String )
            value.ExtendMultiple                            = GetStringList(new IntPtr(p + 0x020)); // 0x20 ExtendMultiple              ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Device                                    = (MatcherJson)GetInt32(new IntPtr(p + 0x028)); // 0x28 Device                      ( ModelEnumType MatcherJson MatcherJson MatcherJson Int32 )

            return value;
        }
    }
}
