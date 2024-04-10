using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WorldToCameraMatrix                    00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 M_CameraPosition                         0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 05C M_CustomAxis                             0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 M_Criteria                               000186533DF0 ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32
    // 06C M_DistanceMetric                         0001866DF440 ModelEnumType DistanceMetric DistanceMetric DistanceMetric Int32
    public partial class SortingSettings : DataModel
    {
        public Matrix4x4                                M_WorldToCameraMatrix                   { get; set; }
        public Vector3                                  M_CameraPosition                        { get; set; }
        public Vector3                                  M_CustomAxis                            { get; set; }
        public SortingCriteria                          M_Criteria                              { get; set; }
        public DistanceMetric                           M_DistanceMetric                        { get; set; }

        public static SortingSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortingSettings() { Pointer= p0 };

            value.M_WorldToCameraMatrix                     = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 024660F370B8 0x10 M_WorldToCameraMatrix       ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_CameraPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 024660F370D8 0x50 M_CameraPosition            ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CustomAxis                              = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 024660F370F8 0x5C M_CustomAxis                ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Criteria                                = (SortingCriteria)GetInt32(new IntPtr(p + 0x068)); // 024660F37118 0x68 M_Criteria                  ( 000186533DF0 ModelEnumType SortingCriteria SortingCriteria SortingCriteria Int32 )
            value.M_DistanceMetric                          = (DistanceMetric)GetInt32(new IntPtr(p + 0x06C)); // 024660F37138 0x6C M_DistanceMetric            ( 0001866DF440 ModelEnumType DistanceMetric DistanceMetric DistanceMetric Int32 )

            return value;
        }
    }
}
