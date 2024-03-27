using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Compatible>k__BackingField              EnumerationOptions IL2CPP_TYPE_CLASS
    // 008 <CompatibleRecursive>k__BackingField     EnumerationOptions IL2CPP_TYPE_CLASS
    // 010 Default                                  00018673F670 ModelClassType EnumerationOptions EnumerationOptions EnumerationOptions Pointer
    // 010 RecurseSubdirectories                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IgnoreInaccessible                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 BufferSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 AttributesToSkip                         0001865784A0 ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 01C MatchType                                0001865DFB10 ModelEnumType MatchType MatchType MatchType Int32
    // 020 MatchCasing                              0001865DD0D0 ModelEnumType MatchCasing MatchCasing MatchCasing Int32
    // 024 ReturnSpecialDirectories                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EnumerationOptions
    {
        public EnumerationOptions?                      Default                                 { get; set; }
        public bool                                     RecurseSubdirectories                   { get; set; }
        public bool                                     IgnoreInaccessible                      { get; set; }
        public int                                      BufferSize                              { get; set; }
        public FileAttributes                           AttributesToSkip                        { get; set; }
        public MatchType                                MatchType                               { get; set; }
        public MatchCasing                              MatchCasing                             { get; set; }
        public bool                                     ReturnSpecialDirectories                { get; set; }

        public static EnumerationOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumerationOptions();

            value.Default                                   = GetObject<EnumerationOptions>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnumerationOptions.FromPointer); // 0270D6E3A0A8 0x10 Default                     ( 00018673F670 ModelClassType EnumerationOptions EnumerationOptions EnumerationOptions Pointer )
            value.RecurseSubdirectories                     = GetBool(new IntPtr(p + 0x010)); // 0270D6E3A0C8 0x10 RecurseSubdirectories       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreInaccessible                        = GetBool(new IntPtr(p + 0x011)); // 0270D6E3A0E8 0x11 IgnoreInaccessible          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x014)); // 0270D6E3A108 0x14 BufferSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributesToSkip                          = (FileAttributes)GetInt32(new IntPtr(p + 0x018)); // 0270D6E3A128 0x18 AttributesToSkip            ( 0001865784A0 ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.MatchType                                 = (MatchType)GetInt32(new IntPtr(p + 0x01C)); // 0270D6E3A148 0x1C MatchType                   ( 0001865DFB10 ModelEnumType MatchType MatchType MatchType Int32 )
            value.MatchCasing                               = (MatchCasing)GetInt32(new IntPtr(p + 0x020)); // 0270D6E3A168 0x20 MatchCasing                 ( 0001865DD0D0 ModelEnumType MatchCasing MatchCasing MatchCasing Int32 )
            value.ReturnSpecialDirectories                  = GetBool(new IntPtr(p + 0x024)); // 0270D6E3A188 0x24 ReturnSpecialDirectories    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
