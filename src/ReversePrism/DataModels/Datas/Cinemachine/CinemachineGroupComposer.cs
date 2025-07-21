using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 M_GroupFramingSize                       ModelPrimitiveType float float float Single
    // 104 M_FramingMode                            ModelEnumType FramingMode FramingMode FramingMode Int32
    // 108 M_FrameDamping                           ModelPrimitiveType float float float Single
    // 10C M_AdjustmentMode                         ModelEnumType AdjustmentMode AdjustmentMode AdjustmentMode Int32
    // 110 M_MaxDollyIn                             ModelPrimitiveType float float float Single
    // 114 M_MaxDollyOut                            ModelPrimitiveType float float float Single
    // 118 M_MinimumDistance                        ModelPrimitiveType float float float Single
    // 11C M_MaximumDistance                        ModelPrimitiveType float float float Single
    // 120 M_MinimumFOV                             ModelPrimitiveType float float float Single
    // 124 M_MaximumFOV                             ModelPrimitiveType float float float Single
    // 128 M_MinimumOrthoSize                       ModelPrimitiveType float float float Single
    // 12C M_MaximumOrthoSize                       ModelPrimitiveType float float float Single
    // 130 M_prevFramingDistance                    ModelPrimitiveType float float float Single
    // 134 M_prevFOV                                ModelPrimitiveType float float float Single
    // 138 LastBounds                               ModelEnumType Bounds Bounds Bounds Int32
    // 150 LastBoundsMatrix                         ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class CinemachineGroupComposer : DataModel
    {
        public float                                    M_GroupFramingSize                      { get; set; }
        public FramingMode                              M_FramingMode                           { get; set; }
        public float                                    M_FrameDamping                          { get; set; }
        public AdjustmentMode                           M_AdjustmentMode                        { get; set; }
        public float                                    M_MaxDollyIn                            { get; set; }
        public float                                    M_MaxDollyOut                           { get; set; }
        public float                                    M_MinimumDistance                       { get; set; }
        public float                                    M_MaximumDistance                       { get; set; }
        public float                                    M_MinimumFOV                            { get; set; }
        public float                                    M_MaximumFOV                            { get; set; }
        public float                                    M_MinimumOrthoSize                      { get; set; }
        public float                                    M_MaximumOrthoSize                      { get; set; }
        public float                                    M_prevFramingDistance                   { get; set; }
        public float                                    M_prevFOV                               { get; set; }
        public Bounds                                   LastBounds                              { get; set; }
        public Matrix4x4                                LastBoundsMatrix                        { get; set; }

        public static CinemachineGroupComposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineGroupComposer() { Pointer= p0 };

            value.M_GroupFramingSize                        = GetSingle(new IntPtr(p + 0x100)); // 0x100 M_GroupFramingSize          ( ModelPrimitiveType float float float Single )
            value.M_FramingMode                             = (FramingMode)GetInt32(new IntPtr(p + 0x104)); // 0x104 M_FramingMode               ( ModelEnumType FramingMode FramingMode FramingMode Int32 )
            value.M_FrameDamping                            = GetSingle(new IntPtr(p + 0x108)); // 0x108 M_FrameDamping              ( ModelPrimitiveType float float float Single )
            value.M_AdjustmentMode                          = (AdjustmentMode)GetInt32(new IntPtr(p + 0x10C)); // 0x10C M_AdjustmentMode            ( ModelEnumType AdjustmentMode AdjustmentMode AdjustmentMode Int32 )
            value.M_MaxDollyIn                              = GetSingle(new IntPtr(p + 0x110)); // 0x110 M_MaxDollyIn                ( ModelPrimitiveType float float float Single )
            value.M_MaxDollyOut                             = GetSingle(new IntPtr(p + 0x114)); // 0x114 M_MaxDollyOut               ( ModelPrimitiveType float float float Single )
            value.M_MinimumDistance                         = GetSingle(new IntPtr(p + 0x118)); // 0x118 M_MinimumDistance           ( ModelPrimitiveType float float float Single )
            value.M_MaximumDistance                         = GetSingle(new IntPtr(p + 0x11C)); // 0x11C M_MaximumDistance           ( ModelPrimitiveType float float float Single )
            value.M_MinimumFOV                              = GetSingle(new IntPtr(p + 0x120)); // 0x120 M_MinimumFOV                ( ModelPrimitiveType float float float Single )
            value.M_MaximumFOV                              = GetSingle(new IntPtr(p + 0x124)); // 0x124 M_MaximumFOV                ( ModelPrimitiveType float float float Single )
            value.M_MinimumOrthoSize                        = GetSingle(new IntPtr(p + 0x128)); // 0x128 M_MinimumOrthoSize          ( ModelPrimitiveType float float float Single )
            value.M_MaximumOrthoSize                        = GetSingle(new IntPtr(p + 0x12C)); // 0x12C M_MaximumOrthoSize          ( ModelPrimitiveType float float float Single )
            value.M_prevFramingDistance                     = GetSingle(new IntPtr(p + 0x130)); // 0x130 M_prevFramingDistance       ( ModelPrimitiveType float float float Single )
            value.M_prevFOV                                 = GetSingle(new IntPtr(p + 0x134)); // 0x134 M_prevFOV                   ( ModelPrimitiveType float float float Single )
            value.LastBounds                                = (Bounds)GetInt32(new IntPtr(p + 0x138)); // 0x138 LastBounds                  ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.LastBoundsMatrix                          = (Matrix4x4)GetInt32(new IntPtr(p + 0x150)); // 0x150 LastBoundsMatrix            ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
