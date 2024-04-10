using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 InputCenter                              000186777850 ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 088 InputExtents                             000186777850 ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 090 CenterVariable                           0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 098 ExtentsVariable                          0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 0A0 IntCenterVariable                        0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 0A8 IntSizeVariable                          0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    public partial class BoundsField : DataModel
    {
        public Vector3Field?                            InputCenter                             { get; set; }
        public Vector3Field?                            InputExtents                            { get; set; }
        public MemberInfo?                              CenterVariable                          { get; set; }
        public MemberInfo?                              ExtentsVariable                         { get; set; }
        public MemberInfo?                              IntCenterVariable                       { get; set; }
        public MemberInfo?                              IntSizeVariable                         { get; set; }

        public static BoundsField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundsField() { Pointer= p0 };

            value.InputCenter                               = GetObject<Vector3Field>(new IntPtr(p + 0x080), ReversePrism.DataModels.Vector3Field.FromPointer); // 02466B236AB8 0x80 InputCenter                 ( 000186777850 ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.InputExtents                              = GetObject<Vector3Field>(new IntPtr(p + 0x088), ReversePrism.DataModels.Vector3Field.FromPointer); // 02466B236AD8 0x88 InputExtents                ( 000186777850 ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.CenterVariable                            = GetObject<MemberInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MemberInfo.FromPointer); // 02466B236AF8 0x90 CenterVariable              ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.ExtentsVariable                           = GetObject<MemberInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.MemberInfo.FromPointer); // 02466B236B18 0x98 ExtentsVariable             ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.IntCenterVariable                         = GetObject<MemberInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MemberInfo.FromPointer); // 02466B236B38 0xA0 IntCenterVariable           ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.IntSizeVariable                           = GetObject<MemberInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MemberInfo.FromPointer); // 02466B236B58 0xA8 IntSizeVariable             ( 0001865F1B00 ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
