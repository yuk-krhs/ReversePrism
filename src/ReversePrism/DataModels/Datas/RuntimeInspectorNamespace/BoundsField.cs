using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 InputCenter                              ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 088 InputExtents                             ModelClassType Vector3Field Vector3Field Vector3Field Pointer
    // 090 CenterVariable                           ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 098 ExtentsVariable                          ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 0A0 IntCenterVariable                        ModelClassType MemberInfo MemberInfo MemberInfo Pointer
    // 0A8 IntSizeVariable                          ModelClassType MemberInfo MemberInfo MemberInfo Pointer
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

            value.InputCenter                               = GetObject<Vector3Field>(new IntPtr(p + 0x080), ReversePrism.DataModels.Vector3Field.FromPointer); // 0x80 InputCenter                 ( ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.InputExtents                              = GetObject<Vector3Field>(new IntPtr(p + 0x088), ReversePrism.DataModels.Vector3Field.FromPointer); // 0x88 InputExtents                ( ModelClassType Vector3Field Vector3Field Vector3Field Pointer )
            value.CenterVariable                            = GetObject<MemberInfo>(new IntPtr(p + 0x090), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x90 CenterVariable              ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.ExtentsVariable                           = GetObject<MemberInfo>(new IntPtr(p + 0x098), ReversePrism.DataModels.MemberInfo.FromPointer); // 0x98 ExtentsVariable             ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.IntCenterVariable                         = GetObject<MemberInfo>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.MemberInfo.FromPointer); // 0xA0 IntCenterVariable           ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )
            value.IntSizeVariable                           = GetObject<MemberInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.MemberInfo.FromPointer); // 0xA8 IntSizeVariable             ( ModelClassType MemberInfo MemberInfo MemberInfo Pointer )

            return value;
        }
    }
}
