using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MouseSensitivityMultiplier             float IL2CPP_TYPE_R4
    // 020 M_LookSpeedController                    ModelPrimitiveType float float float Single
    // 024 M_LookSpeedMouse                         ModelPrimitiveType float float float Single
    // 028 M_MoveSpeed                              ModelPrimitiveType float float float Single
    // 02C M_MoveSpeedIncrement                     ModelPrimitiveType float float float Single
    // 030 M_Turbo                                  ModelPrimitiveType float float float Single
    // 038 LookAction                               ModelClassType InputAction InputAction InputAction Pointer
    // 040 MoveAction                               ModelClassType InputAction InputAction InputAction Pointer
    // 048 SpeedAction                              ModelClassType InputAction InputAction InputAction Pointer
    // 050 YMoveAction                              ModelClassType InputAction InputAction InputAction Pointer
    // 058 InputRotateAxisX                         ModelPrimitiveType float float float Single
    // 05C InputRotateAxisY                         ModelPrimitiveType float float float Single
    // 060 InputChangeSpeed                         ModelPrimitiveType float float float Single
    // 064 InputVertical                            ModelPrimitiveType float float float Single
    // 068 InputHorizontal                          ModelPrimitiveType float float float Single
    // 06C InputYAxis                               ModelPrimitiveType float float float Single
    // 070 LeftShiftBoost                           ModelPrimitiveType bool bool bool Bool
    // 071 LeftShift                                ModelPrimitiveType bool bool bool Bool
    // 072 Fire1                                    ModelPrimitiveType bool bool bool Bool
    public partial class FreeCamera : DataModel
    {
        public float                                    M_LookSpeedController                   { get; set; }
        public float                                    M_LookSpeedMouse                        { get; set; }
        public float                                    M_MoveSpeed                             { get; set; }
        public float                                    M_MoveSpeedIncrement                    { get; set; }
        public float                                    M_Turbo                                 { get; set; }
        public InputAction?                             LookAction                              { get; set; }
        public InputAction?                             MoveAction                              { get; set; }
        public InputAction?                             SpeedAction                             { get; set; }
        public InputAction?                             YMoveAction                             { get; set; }
        public float                                    InputRotateAxisX                        { get; set; }
        public float                                    InputRotateAxisY                        { get; set; }
        public float                                    InputChangeSpeed                        { get; set; }
        public float                                    InputVertical                           { get; set; }
        public float                                    InputHorizontal                         { get; set; }
        public float                                    InputYAxis                              { get; set; }
        public bool                                     LeftShiftBoost                          { get; set; }
        public bool                                     LeftShift                               { get; set; }
        public bool                                     Fire1                                   { get; set; }

        public static FreeCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FreeCamera() { Pointer= p0 };

            value.M_LookSpeedController                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_LookSpeedController       ( ModelPrimitiveType float float float Single )
            value.M_LookSpeedMouse                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_LookSpeedMouse            ( ModelPrimitiveType float float float Single )
            value.M_MoveSpeed                               = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_MoveSpeed                 ( ModelPrimitiveType float float float Single )
            value.M_MoveSpeedIncrement                      = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_MoveSpeedIncrement        ( ModelPrimitiveType float float float Single )
            value.M_Turbo                                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Turbo                     ( ModelPrimitiveType float float float Single )
            value.LookAction                                = GetObject<InputAction>(new IntPtr(p + 0x038), ReversePrism.DataModels.InputAction.FromPointer); // 0x38 LookAction                  ( ModelClassType InputAction InputAction InputAction Pointer )
            value.MoveAction                                = GetObject<InputAction>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputAction.FromPointer); // 0x40 MoveAction                  ( ModelClassType InputAction InputAction InputAction Pointer )
            value.SpeedAction                               = GetObject<InputAction>(new IntPtr(p + 0x048), ReversePrism.DataModels.InputAction.FromPointer); // 0x48 SpeedAction                 ( ModelClassType InputAction InputAction InputAction Pointer )
            value.YMoveAction                               = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 0x50 YMoveAction                 ( ModelClassType InputAction InputAction InputAction Pointer )
            value.InputRotateAxisX                          = GetSingle(new IntPtr(p + 0x058)); // 0x58 InputRotateAxisX            ( ModelPrimitiveType float float float Single )
            value.InputRotateAxisY                          = GetSingle(new IntPtr(p + 0x05C)); // 0x5C InputRotateAxisY            ( ModelPrimitiveType float float float Single )
            value.InputChangeSpeed                          = GetSingle(new IntPtr(p + 0x060)); // 0x60 InputChangeSpeed            ( ModelPrimitiveType float float float Single )
            value.InputVertical                             = GetSingle(new IntPtr(p + 0x064)); // 0x64 InputVertical               ( ModelPrimitiveType float float float Single )
            value.InputHorizontal                           = GetSingle(new IntPtr(p + 0x068)); // 0x68 InputHorizontal             ( ModelPrimitiveType float float float Single )
            value.InputYAxis                                = GetSingle(new IntPtr(p + 0x06C)); // 0x6C InputYAxis                  ( ModelPrimitiveType float float float Single )
            value.LeftShiftBoost                            = GetBool(new IntPtr(p + 0x070)); // 0x70 LeftShiftBoost              ( ModelPrimitiveType bool bool bool Bool )
            value.LeftShift                                 = GetBool(new IntPtr(p + 0x071)); // 0x71 LeftShift                   ( ModelPrimitiveType bool bool bool Bool )
            value.Fire1                                     = GetBool(new IntPtr(p + 0x072)); // 0x72 Fire1                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
