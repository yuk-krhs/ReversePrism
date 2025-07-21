using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _finish                                  Action IL2CPP_TYPE_CLASS
    // 020 Image                                    ModelClassType Image Image Image Pointer
    // 028 Amount                                   ModelPrimitiveType float float float Single
    // 010 Instance                                 ModelClassType Complete Complete Complete Pointer
    // 030 Logo                                     ModelClassType Image Image Image Pointer
    public partial class Complete : DataModel
    {
        public Image?                                   Image                                   { get; set; }
        public float                                    Amount                                  { get; set; }
        public Complete?                                Instance                                { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static Complete? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Complete() { Pointer= p0 };

            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 Image                       ( ModelClassType Image Image Image Pointer )
            value.Amount                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 Amount                      ( ModelPrimitiveType float float float Single )
            value.Instance                                  = GetObject<Complete>(new IntPtr(p + 0x010), ReversePrism.DataModels.Complete.FromPointer); // 0x10 Instance                    ( ModelClassType Complete Complete Complete Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 Logo                        ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
