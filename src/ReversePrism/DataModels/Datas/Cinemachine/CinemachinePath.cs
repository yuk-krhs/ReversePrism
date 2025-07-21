using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 M_Looped                                 ModelPrimitiveType bool bool bool Bool
    // 058 M_Waypoints                              ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer
    public partial class CinemachinePath : DataModel
    {
        public bool                                     M_Looped                                { get; set; }
        public List<Waypoint>?                          M_Waypoints                             { get; set; }

        public static CinemachinePath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachinePath() { Pointer= p0 };

            value.M_Looped                                  = GetBool(new IntPtr(p + 0x050)); // 0x50 M_Looped                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_Waypoints                               = GetEnumList<Waypoint>(new IntPtr(p + 0x058)); // 0x58 M_Waypoints                 ( ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer )

            return value;
        }
    }
}
