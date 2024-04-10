using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MouseSensitivityMultiplier             float IL2CPP_TYPE_R4
    // 020 M_LookSpeedController                    000186666050 ModelPrimitiveType float float float Single
    // 024 M_LookSpeedMouse                         000186666050 ModelPrimitiveType float float float Single
    // 028 M_MoveSpeed                              000186666050 ModelPrimitiveType float float float Single
    // 02C M_MoveSpeedIncrement                     000186666050 ModelPrimitiveType float float float Single
    // 030 M_Turbo                                  000186666050 ModelPrimitiveType float float float Single
    // 038 LookAction                               0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 040 MoveAction                               0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 048 SpeedAction                              0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 050 YMoveAction                              0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 058 InputRotateAxisX                         0001866656B0 ModelPrimitiveType float float float Single
    // 05C InputRotateAxisY                         0001866656B0 ModelPrimitiveType float float float Single
    // 060 InputChangeSpeed                         0001866656B0 ModelPrimitiveType float float float Single
    // 064 InputVertical                            0001866656B0 ModelPrimitiveType float float float Single
    // 068 InputHorizontal                          0001866656B0 ModelPrimitiveType float float float Single
    // 06C InputYAxis                               0001866656B0 ModelPrimitiveType float float float Single
    // 070 LeftShiftBoost                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 LeftShift                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 072 Fire1                                    000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.M_LookSpeedController                     = GetSingle(new IntPtr(p + 0x020)); // 02466915B148 0x20 M_LookSpeedController       ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_LookSpeedMouse                          = GetSingle(new IntPtr(p + 0x024)); // 02466915B168 0x24 M_LookSpeedMouse            ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_MoveSpeed                               = GetSingle(new IntPtr(p + 0x028)); // 02466915B188 0x28 M_MoveSpeed                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_MoveSpeedIncrement                      = GetSingle(new IntPtr(p + 0x02C)); // 02466915B1A8 0x2C M_MoveSpeedIncrement        ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_Turbo                                   = GetSingle(new IntPtr(p + 0x030)); // 02466915B1C8 0x30 M_Turbo                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.LookAction                                = GetObject<InputAction>(new IntPtr(p + 0x038), ReversePrism.DataModels.InputAction.FromPointer); // 02466915B1E8 0x38 LookAction                  ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.MoveAction                                = GetObject<InputAction>(new IntPtr(p + 0x040), ReversePrism.DataModels.InputAction.FromPointer); // 02466915B208 0x40 MoveAction                  ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.SpeedAction                               = GetObject<InputAction>(new IntPtr(p + 0x048), ReversePrism.DataModels.InputAction.FromPointer); // 02466915B228 0x48 SpeedAction                 ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.YMoveAction                               = GetObject<InputAction>(new IntPtr(p + 0x050), ReversePrism.DataModels.InputAction.FromPointer); // 02466915B248 0x50 YMoveAction                 ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.InputRotateAxisX                          = GetSingle(new IntPtr(p + 0x058)); // 02466915B268 0x58 InputRotateAxisX            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputRotateAxisY                          = GetSingle(new IntPtr(p + 0x05C)); // 02466915B288 0x5C InputRotateAxisY            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputChangeSpeed                          = GetSingle(new IntPtr(p + 0x060)); // 02466915B2A8 0x60 InputChangeSpeed            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputVertical                             = GetSingle(new IntPtr(p + 0x064)); // 02466915B2C8 0x64 InputVertical               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputHorizontal                           = GetSingle(new IntPtr(p + 0x068)); // 02466915B2E8 0x68 InputHorizontal             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InputYAxis                                = GetSingle(new IntPtr(p + 0x06C)); // 02466915B308 0x6C InputYAxis                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LeftShiftBoost                            = GetBool(new IntPtr(p + 0x070)); // 02466915B328 0x70 LeftShiftBoost              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LeftShift                                 = GetBool(new IntPtr(p + 0x071)); // 02466915B348 0x71 LeftShift                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Fire1                                     = GetBool(new IntPtr(p + 0x072)); // 02466915B368 0x72 Fire1                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
