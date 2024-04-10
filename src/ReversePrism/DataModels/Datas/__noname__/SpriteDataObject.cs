using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Frames                                   000185D2E3B8 ModelEnumListType List`1<Frame> List`1<Frame> List<Frame> Pointer
    // 018 Meta                                     0001865FD640 ModelEnumType Meta Meta Meta Int32
    public partial class SpriteDataObject : DataModel
    {
        public List<Frame>?                             Frames                                  { get; set; }
        public Meta                                     Meta                                    { get; set; }

        public static SpriteDataObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteDataObject() { Pointer= p0 };

            value.Frames                                    = GetEnumList<Frame>(new IntPtr(p + 0x010)); // 02466A6CB528 0x10 Frames                      ( 000185D2E3B8 ModelEnumListType List`1<Frame> List`1<Frame> List<Frame> Pointer )
            value.Meta                                      = (Meta)GetInt32(new IntPtr(p + 0x018)); // 02466A6CB548 0x18 Meta                        ( 0001865FD640 ModelEnumType Meta Meta Meta Int32 )

            return value;
        }
    }
}
