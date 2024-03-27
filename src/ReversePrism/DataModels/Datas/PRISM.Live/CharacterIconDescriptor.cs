using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 014 IsBeingSet                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 015 IsInSameUnit                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class CharacterIconDescriptor
    {
        public int                                      CharacterId                             { get; set; }
        public bool                                     IsBeingSet                              { get; set; }
        public bool                                     IsInSameUnit                            { get; set; }

        public static CharacterIconDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterIconDescriptor();

            value.CharacterId                               = GetInt32(new IntPtr(p + 0x010)); // 0270D51B5810 0x10 CharacterId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsBeingSet                                = GetBool(new IntPtr(p + 0x014)); // 0270D51B5830 0x14 IsBeingSet                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsInSameUnit                              = GetBool(new IntPtr(p + 0x015)); // 0270D51B5850 0x15 IsInSameUnit                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
