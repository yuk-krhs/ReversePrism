using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AttachObjectLeft                         ModelClassType GameObject GameObject GameObject Pointer
    // 038 AttachObjectRight                        ModelClassType GameObject GameObject GameObject Pointer
    // 040 MoveRate                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 OnTriggerName                            ModelPrimitiveType string string string String
    // 050 OffTriggerName                           ModelPrimitiveType string string string String
    // 058 RemoveHighLight                          ModelPrimitiveType bool bool bool Bool
    // 059 RemoveEyeIris                            ModelPrimitiveType bool bool bool Bool
    // 05A AttachFlag                               ModelPrimitiveType bool bool bool Bool
    // 060 EyeL                                     ModelClassType EyeController EyeController EyeController Pointer
    // 068 EyeR                                     ModelClassType EyeController EyeController EyeController Pointer
    public partial class AttachEyeIrisObject : DataModel
    {
        public GameObject?                              AttachObjectLeft                        { get; set; }
        public GameObject?                              AttachObjectRight                       { get; set; }
        public Vector2                                  MoveRate                                { get; set; }
        public string                                   OnTriggerName                           { get; set; }
        public string                                   OffTriggerName                          { get; set; }
        public bool                                     RemoveHighLight                         { get; set; }
        public bool                                     RemoveEyeIris                           { get; set; }
        public bool                                     AttachFlag                              { get; set; }
        public EyeController?                           EyeL                                    { get; set; }
        public EyeController?                           EyeR                                    { get; set; }

        public static AttachEyeIrisObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachEyeIrisObject() { Pointer= p0 };

            value.AttachObjectLeft                          = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 AttachObjectLeft            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AttachObjectRight                         = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 AttachObjectRight           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MoveRate                                  = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 MoveRate                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OnTriggerName                             = GetString(new IntPtr(p + 0x048)); // 0x48 OnTriggerName               ( ModelPrimitiveType string string string String )
            value.OffTriggerName                            = GetString(new IntPtr(p + 0x050)); // 0x50 OffTriggerName              ( ModelPrimitiveType string string string String )
            value.RemoveHighLight                           = GetBool(new IntPtr(p + 0x058)); // 0x58 RemoveHighLight             ( ModelPrimitiveType bool bool bool Bool )
            value.RemoveEyeIris                             = GetBool(new IntPtr(p + 0x059)); // 0x59 RemoveEyeIris               ( ModelPrimitiveType bool bool bool Bool )
            value.AttachFlag                                = GetBool(new IntPtr(p + 0x05A)); // 0x5A AttachFlag                  ( ModelPrimitiveType bool bool bool Bool )
            value.EyeL                                      = GetObject<EyeController>(new IntPtr(p + 0x060), ReversePrism.DataModels.EyeController.FromPointer); // 0x60 EyeL                        ( ModelClassType EyeController EyeController EyeController Pointer )
            value.EyeR                                      = GetObject<EyeController>(new IntPtr(p + 0x068), ReversePrism.DataModels.EyeController.FromPointer); // 0x68 EyeR                        ( ModelClassType EyeController EyeController EyeController Pointer )

            return value;
        }
    }
}
