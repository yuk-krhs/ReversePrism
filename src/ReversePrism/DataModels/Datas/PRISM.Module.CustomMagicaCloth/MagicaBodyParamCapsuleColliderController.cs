using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CapsuleCollider                          ModelClassType MagicaCapsuleCollider MagicaCapsuleCollider MagicaCapsuleCollider Pointer
    // 048 Length                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 050 StartRadius                              ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    // 058 EndRadius                                ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    public partial class MagicaBodyParamCapsuleColliderController : DataModel
    {
        public MagicaCapsuleCollider?                   CapsuleCollider                         { get; set; }
        public BodyParamFloatProperty?                  Length                                  { get; set; }
        public BodyParamFloatProperty?                  StartRadius                             { get; set; }
        public BodyParamFloatProperty?                  EndRadius                               { get; set; }

        public static MagicaBodyParamCapsuleColliderController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaBodyParamCapsuleColliderController() { Pointer= p0 };

            value.CapsuleCollider                           = GetObject<MagicaCapsuleCollider>(new IntPtr(p + 0x040), ReversePrism.DataModels.MagicaCapsuleCollider.FromPointer); // 0x40 CapsuleCollider             ( ModelClassType MagicaCapsuleCollider MagicaCapsuleCollider MagicaCapsuleCollider Pointer )
            value.Length                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x48 Length                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.StartRadius                               = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x50 StartRadius                 ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )
            value.EndRadius                                 = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x58 EndRadius                   ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )

            return value;
        }
    }
}
