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
    // 010 Default                                  ModelClassType EnumerationOptions EnumerationOptions EnumerationOptions Pointer
    // 010 RecurseSubdirectories                    ModelPrimitiveType bool bool bool Bool
    // 011 IgnoreInaccessible                       ModelPrimitiveType bool bool bool Bool
    // 014 BufferSize                               ModelPrimitiveType int int int Int32
    // 018 AttributesToSkip                         ModelEnumType FileAttributes FileAttributes FileAttributes Int32
    // 01C MatchType                                ModelEnumType MatchType MatchType MatchType Int32
    // 020 MatchCasing                              ModelEnumType MatchCasing MatchCasing MatchCasing Int32
    // 024 ReturnSpecialDirectories                 ModelPrimitiveType bool bool bool Bool
    public partial class EnumerationOptions : DataModel
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
            var value   = new EnumerationOptions() { Pointer= p0 };

            value.Default                                   = GetObject<EnumerationOptions>(new IntPtr(p + 0x010), ReversePrism.DataModels.EnumerationOptions.FromPointer); // 0x10 Default                     ( ModelClassType EnumerationOptions EnumerationOptions EnumerationOptions Pointer )
            value.RecurseSubdirectories                     = GetBool(new IntPtr(p + 0x010)); // 0x10 RecurseSubdirectories       ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreInaccessible                        = GetBool(new IntPtr(p + 0x011)); // 0x11 IgnoreInaccessible          ( ModelPrimitiveType bool bool bool Bool )
            value.BufferSize                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 BufferSize                  ( ModelPrimitiveType int int int Int32 )
            value.AttributesToSkip                          = (FileAttributes)GetInt32(new IntPtr(p + 0x018)); // 0x18 AttributesToSkip            ( ModelEnumType FileAttributes FileAttributes FileAttributes Int32 )
            value.MatchType                                 = (MatchType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C MatchType                   ( ModelEnumType MatchType MatchType MatchType Int32 )
            value.MatchCasing                               = (MatchCasing)GetInt32(new IntPtr(p + 0x020)); // 0x20 MatchCasing                 ( ModelEnumType MatchCasing MatchCasing MatchCasing Int32 )
            value.ReturnSpecialDirectories                  = GetBool(new IntPtr(p + 0x024)); // 0x24 ReturnSpecialDirectories    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
