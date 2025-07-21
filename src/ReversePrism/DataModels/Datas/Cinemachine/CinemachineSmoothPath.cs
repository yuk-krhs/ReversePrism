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
    // 060 M_ControlPoints1                         ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer
    // 068 M_ControlPoints2                         ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer
    // 070 M_IsLoopedCache                          ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineSmoothPath : DataModel
    {
        public bool                                     M_Looped                                { get; set; }
        public List<Waypoint>?                          M_Waypoints                             { get; set; }
        public List<Waypoint>?                          M_ControlPoints1                        { get; set; }
        public List<Waypoint>?                          M_ControlPoints2                        { get; set; }
        public bool                                     M_IsLoopedCache                         { get; set; }

        public static CinemachineSmoothPath? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineSmoothPath() { Pointer= p0 };

            value.M_Looped                                  = GetBool(new IntPtr(p + 0x050)); // 0x50 M_Looped                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_Waypoints                               = GetEnumList<Waypoint>(new IntPtr(p + 0x058)); // 0x58 M_Waypoints                 ( ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer )
            value.M_ControlPoints1                          = GetEnumList<Waypoint>(new IntPtr(p + 0x060)); // 0x60 M_ControlPoints1            ( ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer )
            value.M_ControlPoints2                          = GetEnumList<Waypoint>(new IntPtr(p + 0x068)); // 0x68 M_ControlPoints2            ( ModelEnumListType Waypoint[] Waypoint[] List<Waypoint> Pointer )
            value.M_IsLoopedCache                           = GetBool(new IntPtr(p + 0x070)); // 0x70 M_IsLoopedCache             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
