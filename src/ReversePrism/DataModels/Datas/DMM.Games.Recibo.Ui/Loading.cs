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
    // 020 Rt                                       ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 Rot                                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 008 _instance                                Loading IL2CPP_TYPE_CLASS
    // 038 Logo                                     ModelClassType Image Image Image Pointer
    public partial class Loading : DataModel
    {
        public RectTransform?                           Rt                                      { get; set; }
        public Vector3                                  Rot                                     { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static Loading? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Loading() { Pointer= p0 };

            value.Rt                                        = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Rt                          ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.Rot                                       = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 Rot                         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 Logo                        ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
