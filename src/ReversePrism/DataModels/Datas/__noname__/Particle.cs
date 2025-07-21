using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Position                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_Velocity                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_AnimatedVelocity                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_InitialVelocity                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 M_AxisOfRotation                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C M_Rotation                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 M_AngularVelocity                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 064 M_StartSize                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 M_StartColor                             ModelEnumType Color32 Color32 Color32 Int32
    // 074 M_RandomSeed                             ModelPrimitiveType uint uint uint UInt32
    // 078 M_ParentRandomSeed                       ModelPrimitiveType uint uint uint UInt32
    // 07C M_Lifetime                               ModelPrimitiveType float float float Single
    // 080 M_StartLifetime                          ModelPrimitiveType float float float Single
    // 084 M_MeshIndex                              ModelPrimitiveType int int int Int32
    // 088 M_EmitAccumulator0                       ModelPrimitiveType float float float Single
    // 08C M_EmitAccumulator1                       ModelPrimitiveType float float float Single
    // 090 M_Flags                                  ModelPrimitiveType uint uint uint UInt32
    public partial class Particle : DataModel
    {
        public Vector3                                  M_Position                              { get; set; }
        public Vector3                                  M_Velocity                              { get; set; }
        public Vector3                                  M_AnimatedVelocity                      { get; set; }
        public Vector3                                  M_InitialVelocity                       { get; set; }
        public Vector3                                  M_AxisOfRotation                        { get; set; }
        public Vector3                                  M_Rotation                              { get; set; }
        public Vector3                                  M_AngularVelocity                       { get; set; }
        public Vector3                                  M_StartSize                             { get; set; }
        public Color32                                  M_StartColor                            { get; set; }
        public uint                                     M_RandomSeed                            { get; set; }
        public uint                                     M_ParentRandomSeed                      { get; set; }
        public float                                    M_Lifetime                              { get; set; }
        public float                                    M_StartLifetime                         { get; set; }
        public int                                      M_MeshIndex                             { get; set; }
        public float                                    M_EmitAccumulator0                      { get; set; }
        public float                                    M_EmitAccumulator1                      { get; set; }
        public uint                                     M_Flags                                 { get; set; }

        public static Particle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Particle() { Pointer= p0 };

            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Position                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Velocity                                = (Vector3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Velocity                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AnimatedVelocity                        = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_AnimatedVelocity          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InitialVelocity                         = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_InitialVelocity           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AxisOfRotation                          = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_AxisOfRotation            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Rotation                                = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_Rotation                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AngularVelocity                         = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_AngularVelocity           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_StartSize                               = (Vector3)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_StartSize                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_StartColor                              = (Color32)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_StartColor                ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.M_RandomSeed                              = GetUInt32(new IntPtr(p + 0x074)); // 0x74 M_RandomSeed                ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_ParentRandomSeed                        = GetUInt32(new IntPtr(p + 0x078)); // 0x78 M_ParentRandomSeed          ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_Lifetime                                = GetSingle(new IntPtr(p + 0x07C)); // 0x7C M_Lifetime                  ( ModelPrimitiveType float float float Single )
            value.M_StartLifetime                           = GetSingle(new IntPtr(p + 0x080)); // 0x80 M_StartLifetime             ( ModelPrimitiveType float float float Single )
            value.M_MeshIndex                               = GetInt32(new IntPtr(p + 0x084)); // 0x84 M_MeshIndex                 ( ModelPrimitiveType int int int Int32 )
            value.M_EmitAccumulator0                        = GetSingle(new IntPtr(p + 0x088)); // 0x88 M_EmitAccumulator0          ( ModelPrimitiveType float float float Single )
            value.M_EmitAccumulator1                        = GetSingle(new IntPtr(p + 0x08C)); // 0x8C M_EmitAccumulator1          ( ModelPrimitiveType float float float Single )
            value.M_Flags                                   = GetUInt32(new IntPtr(p + 0x090)); // 0x90 M_Flags                     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
