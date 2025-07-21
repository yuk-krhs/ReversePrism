using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              ModelPrimitiveType int int int Int32
    // 014 IsBeingSet                               ModelPrimitiveType bool bool bool Bool
    // 015 IsInSameUnit                             ModelPrimitiveType bool bool bool Bool
    // 016 IsLimitedVocalSeparate                   ModelPrimitiveType bool bool bool Bool
    public partial class CharacterIconDescriptor : DataModel
    {
        public int                                      CharacterId                             { get; set; }
        public bool                                     IsBeingSet                              { get; set; }
        public bool                                     IsInSameUnit                            { get; set; }
        public bool                                     IsLimitedVocalSeparate                  { get; set; }

        public static CharacterIconDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterIconDescriptor() { Pointer= p0 };

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.IsBeingSet                                = GetBool(new IntPtr(p + 0x014)); // 0x14 IsBeingSet                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsInSameUnit                              = GetBool(new IntPtr(p + 0x015)); // 0x15 IsInSameUnit                ( ModelPrimitiveType bool bool bool Bool )
            value.IsLimitedVocalSeparate                    = GetBool(new IntPtr(p + 0x016)); // 0x16 IsLimitedVocalSeparate      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
