using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BadgeLists                               000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 028 CurrentIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C CurrentDuration                          0001866656B0 ModelPrimitiveType float float float Single
    // 030 IsStartRotation                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 Duration                                 0001866656B0 ModelPrimitiveType float float float Single
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

            value.BadgeLists                                = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024664C21710 0x20 BadgeLists                  ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.CurrentIndex                              = GetInt32(new IntPtr(p + 0x028)); // 024664C21730 0x28 CurrentIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentDuration                           = GetSingle(new IntPtr(p + 0x02C)); // 024664C21750 0x2C CurrentDuration             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsStartRotation                           = GetBool(new IntPtr(p + 0x030)); // 024664C21770 0x30 IsStartRotation             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 024664C21790 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x040)); // 024664C217B0 0x40 Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
