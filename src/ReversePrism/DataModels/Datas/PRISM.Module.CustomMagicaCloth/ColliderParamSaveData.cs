using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelPrimitiveType string string string String
    // 018 ColliderParams                           ModelClassListType List`1<AMagicaColliderParam> List`1<AMagicaColliderParam> List<AMagicaColliderParam> Pointer
    public partial class ColliderParamSaveData : DataModel
    {
        public string                                   Category                                { get; set; }
        public List<AMagicaColliderParam>?              ColliderParams                          { get; set; }

        public static ColliderParamSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColliderParamSaveData() { Pointer= p0 };

            value.Category                                  = GetString(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelPrimitiveType string string string String )
            value.ColliderParams                            = GetObjectList<AMagicaColliderParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.AMagicaColliderParam.FromPointer); // 0x18 ColliderParams              ( ModelClassListType List`1<AMagicaColliderParam> List`1<AMagicaColliderParam> List<AMagicaColliderParam> Pointer )

            return value;
        }
    }
}
