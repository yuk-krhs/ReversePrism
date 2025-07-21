using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AnchorInertia                            ModelPrimitiveType float float float Single
    // 014 WorldInertia                             ModelPrimitiveType float float float Single
    // 018 MovementInertiaSmoothing                 ModelPrimitiveType float float float Single
    // 01C MovementSpeedLimit                       ModelPrimitiveType float float float Single
    // 020 RotationSpeedLimit                       ModelPrimitiveType float float float Single
    // 024 LocalInertia                             ModelPrimitiveType float float float Single
    // 028 LocalMovementSpeedLimit                  ModelPrimitiveType float float float Single
    // 02C LocalRotationSpeedLimit                  ModelPrimitiveType float float float Single
    // 030 DepthInertia                             ModelPrimitiveType float float float Single
    // 034 CentrifualAcceleration                   ModelPrimitiveType float float float Single
    // 038 ParticleSpeedLimit                       ModelPrimitiveType float float float Single
    // 03C TeleportMode                             ModelEnumType TeleportMode TeleportMode TeleportMode Int32
    // 040 TeleportDistance                         ModelPrimitiveType float float float Single
    // 044 TeleportRotation                         ModelPrimitiveType float float float Single
    public partial class InertiaConstraintParams : DataModel
    {
        public float                                    AnchorInertia                           { get; set; }
        public float                                    WorldInertia                            { get; set; }
        public float                                    MovementInertiaSmoothing                { get; set; }
        public float                                    MovementSpeedLimit                      { get; set; }
        public float                                    RotationSpeedLimit                      { get; set; }
        public float                                    LocalInertia                            { get; set; }
        public float                                    LocalMovementSpeedLimit                 { get; set; }
        public float                                    LocalRotationSpeedLimit                 { get; set; }
        public float                                    DepthInertia                            { get; set; }
        public float                                    CentrifualAcceleration                  { get; set; }
        public float                                    ParticleSpeedLimit                      { get; set; }
        public TeleportMode                             TeleportMode                            { get; set; }
        public float                                    TeleportDistance                        { get; set; }
        public float                                    TeleportRotation                        { get; set; }

        public static InertiaConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InertiaConstraintParams() { Pointer= p0 };

            value.AnchorInertia                             = GetSingle(new IntPtr(p + 0x010)); // 0x10 AnchorInertia               ( ModelPrimitiveType float float float Single )
            value.WorldInertia                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 WorldInertia                ( ModelPrimitiveType float float float Single )
            value.MovementInertiaSmoothing                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 MovementInertiaSmoothing    ( ModelPrimitiveType float float float Single )
            value.MovementSpeedLimit                        = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MovementSpeedLimit          ( ModelPrimitiveType float float float Single )
            value.RotationSpeedLimit                        = GetSingle(new IntPtr(p + 0x020)); // 0x20 RotationSpeedLimit          ( ModelPrimitiveType float float float Single )
            value.LocalInertia                              = GetSingle(new IntPtr(p + 0x024)); // 0x24 LocalInertia                ( ModelPrimitiveType float float float Single )
            value.LocalMovementSpeedLimit                   = GetSingle(new IntPtr(p + 0x028)); // 0x28 LocalMovementSpeedLimit     ( ModelPrimitiveType float float float Single )
            value.LocalRotationSpeedLimit                   = GetSingle(new IntPtr(p + 0x02C)); // 0x2C LocalRotationSpeedLimit     ( ModelPrimitiveType float float float Single )
            value.DepthInertia                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 DepthInertia                ( ModelPrimitiveType float float float Single )
            value.CentrifualAcceleration                    = GetSingle(new IntPtr(p + 0x034)); // 0x34 CentrifualAcceleration      ( ModelPrimitiveType float float float Single )
            value.ParticleSpeedLimit                        = GetSingle(new IntPtr(p + 0x038)); // 0x38 ParticleSpeedLimit          ( ModelPrimitiveType float float float Single )
            value.TeleportMode                              = (TeleportMode)GetInt32(new IntPtr(p + 0x03C)); // 0x3C TeleportMode                ( ModelEnumType TeleportMode TeleportMode TeleportMode Int32 )
            value.TeleportDistance                          = GetSingle(new IntPtr(p + 0x040)); // 0x40 TeleportDistance            ( ModelPrimitiveType float float float Single )
            value.TeleportRotation                          = GetSingle(new IntPtr(p + 0x044)); // 0x44 TeleportRotation            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
