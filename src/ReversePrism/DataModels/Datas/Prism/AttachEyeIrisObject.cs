using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AttachObjectLeft                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 AttachObjectRight                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 MoveRate                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 OnTriggerName                            000186671910 ModelPrimitiveType string string string String
    // 050 OffTriggerName                           000186671910 ModelPrimitiveType string string string String
    // 058 AttachFlag                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 EyeL                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 068 EyeR                                     0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    public partial class AttachEyeIrisObject
    {
        public GameObject?                              AttachObjectLeft                        { get; set; }
        public GameObject?                              AttachObjectRight                       { get; set; }
        public Vector2                                  MoveRate                                { get; set; }
        public string                                   OnTriggerName                           { get; set; }
        public string                                   OffTriggerName                          { get; set; }
        public bool                                     AttachFlag                              { get; set; }
        public EyeController?                           EyeL                                    { get; set; }
        public EyeController?                           EyeR                                    { get; set; }

        public static AttachEyeIrisObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachEyeIrisObject();

            value.AttachObjectLeft                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D66F18 0x30 AttachObjectLeft            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AttachObjectRight                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D66F38 0x38 AttachObjectRight           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MoveRate                                  = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0270D4D66F58 0x40 MoveRate                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OnTriggerName                             = GetString(new IntPtr(p + 0x048)); // 0270D4D66F78 0x48 OnTriggerName               ( 000186671910 ModelPrimitiveType string string string String )
            value.OffTriggerName                            = GetString(new IntPtr(p + 0x050)); // 0270D4D66F98 0x50 OffTriggerName              ( 000186671910 ModelPrimitiveType string string string String )
            value.AttachFlag                                = GetBool(new IntPtr(p + 0x058)); // 0270D4D66FB8 0x58 AttachFlag                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x060), ReversePrism.DataModels.EyeController.FromPointer); // 0270D4D66FD8 0x60 EyeL                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x068), ReversePrism.DataModels.EyeController.FromPointer); // 0270D4D66FF8 0x68 EyeR                        ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )

            return value;
        }
    }
}
