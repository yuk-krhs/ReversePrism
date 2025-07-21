using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BadgeLists                               ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 028 CurrentIndex                             ModelPrimitiveType int int int Int32
    // 02C CurrentDuration                          ModelPrimitiveType float float float Single
    // 030 IsStartRotation                          ModelPrimitiveType bool bool bool Bool
    // 038 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 Duration                                 ModelPrimitiveType float float float Single
    public partial class BadgeRotation : DataModel
    {
        public List<GameObject>?                        BadgeLists                              { get; set; }
        public int                                      CurrentIndex                            { get; set; }
        public float                                    CurrentDuration                         { get; set; }
        public bool                                     IsStartRotation                         { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    Duration                                { get; set; }

        public static BadgeRotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeRotation() { Pointer= p0 };

            value.BadgeLists                                = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BadgeLists                  ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 CurrentIndex                ( ModelPrimitiveType int int int Int32 )
            value.CurrentDuration                           = GetSingle(new IntPtr(p + 0x02C)); // 0x2C CurrentDuration             ( ModelPrimitiveType float float float Single )
            value.IsStartRotation                           = GetBool(new IntPtr(p + 0x030)); // 0x30 IsStartRotation             ( ModelPrimitiveType bool bool bool Bool )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 Duration                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
